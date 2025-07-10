using System.Collections;
using System.Diagnostics;
using System.Xml.Linq;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using Домашняя_бухгалтерия.Interfaces;

namespace Домашняя_бухгалтерия
{
    public partial class Form1 : Form
    {
        private int? _userId;
        private readonly ITransactionRepository _transactionRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUserRepository _userRepository;

        public Form1(int? userId, ITransactionRepository transactionRepository, ICategoryRepository categoryRepository, IUserRepository userRepository)
        {
            InitializeComponent();
            _userId = userId;
            _transactionRepository = transactionRepository;
            _categoryRepository = categoryRepository;
            _userRepository = userRepository;
            IOFilterContent();
            CategoriesFilterContent();
            AddChart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var user = _userRepository.GetUserById((int)_userId);

            labelWelcome.Text = $"Добро пожаловать, {user.Name}!";

            var transactions = _transactionRepository.GetAllTransactions((int)_userId);

            var selectedFields = transactions.Select(t => new { t.Id, t.Type, t.CategoryName, t.Date, t.Amount, t.Comment }).ToList();

            dataGridView1.DataSource = selectedFields;
            dataGridView1.Columns["Id"].Visible = false;

            dataGridView1.CellFormatting += (s, e) =>
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Amount" && e.Value != null)
                {
                    if (decimal.TryParse(e.Value.ToString(), out var val))
                    {
                        e.Value = val.ToString("#,0", new System.Globalization.CultureInfo("ru-RU"));
                        e.FormattingApplied = true;
                    }
                }
            };
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreateTransaction create = new CreateTransaction(_userId, _transactionRepository, _categoryRepository, _userRepository);
            this.Hide();
            create.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.CurrentRow;

            int id = (int)selectedRow.Cells["Id"].Value;

            var transaction = _transactionRepository.GetTransactionById((int)_userId, id);

            EditTransaction edit = new EditTransaction(_categoryRepository, _transactionRepository, _userRepository, _userId, id);
            this.Hide();
            edit.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.CurrentRow;

            int id = (int)selectedRow.Cells["Id"].Value;

            _transactionRepository.Delete((int)_userId, id);

            dataGridView1.DataSource = null;

            var transactions = _transactionRepository.GetAllTransactions((int)_userId);

            var selectedFields = transactions.Select(t => new { t.Id, t.Type, t.CategoryName, t.Date, t.Amount, t.Comment }).ToList();

            dataGridView1.DataSource = selectedFields;
            dataGridView1.Columns["Id"].Visible = false;

            dataGridView1.CellFormatting += (s, e) =>
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Amount" && e.Value != null)
                {
                    if (decimal.TryParse(e.Value.ToString(), out var val))
                    {
                        e.Value = val.ToString("#,0", new System.Globalization.CultureInfo("ru-RU"));
                        e.FormattingApplied = true;
                    }
                }
            };


            var grouped = transactions.GroupBy(t => t.CategoryName).Select(g => new
            {
                CategoryName = g.Key,
                TotalAmount = g.Sum(x => x.Amount)
            }).ToList();

            var categoryNames = grouped.Select(x => x.CategoryName).ToList();
            var totalAmounts = grouped.Select(x => x.TotalAmount).ToList();

            var values = totalAmounts.Select(x => (double)x).ToArray();

            var cartesianChart = new CartesianChart()
            {
                Dock = DockStyle.Bottom,
                Height = 200,
                Series = new ISeries[]
                {
                    new ColumnSeries<double>
                    {
                        Values = values,
                        Name = "Транзакции"
                    }
                },

                XAxes = new[]
                {
                    new Axis
                    {
                        Labels = categoryNames,
                        Name = "Категории"
                    }
                },

                YAxes = new[]
                {
                    new Axis
                    {
                        Name = "Сумма",
                        MinLimit = 0
                    }
                }
            };

            this.Controls.Add(cartesianChart);
        }

        private void IOFilterContent()
        {
            var options = new List<string>() { "Доход", "Расход" };
            comboBoxIOFilter.DataSource = options;
        }

        private void buttonIOFilter_Click(object sender, EventArgs e)
        {
            var selectedIndex = comboBoxIOFilter.Text;

            var transactions = _transactionRepository.GetAllTransactions((int)_userId);

            var selectedFields = transactions.Select(t => new { t.Id, t.Type, t.CategoryName, t.Date, t.Amount, t.Comment }).ToList();

            switch (selectedIndex)
            {
                case "Доход":
                    {
                        var sourse = selectedFields.Where(t => t.Type == "Доход").ToList();
                        dataGridView1.DataSource = sourse;
                        dataGridView1.Columns["Id"].Visible = false;

                        dataGridView1.CellFormatting += (s, e) =>
                        {
                            if (dataGridView1.Columns[e.ColumnIndex].Name == "Amount" && e.Value != null)
                            {
                                if (decimal.TryParse(e.Value.ToString(), out var val))
                                {
                                    e.Value = val.ToString("#,0", new System.Globalization.CultureInfo("ru-RU"));
                                    e.FormattingApplied = true;
                                }
                            }
                        };

                        var incomes = transactions.Where(t => t.Type == "Доход").ToList();

                        var grouped = incomes.GroupBy(t => t.CategoryName).Select(g => new
                        {
                            CategoryName = g.Key,
                            TotalAmount = g.Sum(x => x.Amount)
                        }).ToList();

                        var categoryNames = grouped.Select(x => x.CategoryName).ToList();
                        var totalAmounts = grouped.Select(x => x.TotalAmount).ToList();

                        var values = totalAmounts.Select(x => (double)x).ToArray();

                        var cartesianChart = new CartesianChart()
                        {
                            Dock = DockStyle.Bottom,
                            Height = 200,
                            Series = new ISeries[]
                            {
                                new ColumnSeries<double>
                                {
                                    Values = values,
                                    Name = "Транзакции"
                                }
                                        },

                            XAxes = new[]
                                        {
                                new Axis
                                {
                                    Labels = categoryNames,
                                    Name = "Категории"
                                }
                            },

                            YAxes = new[]
                            {
                                new Axis
                                {
                                    Name = "Сумма",
                                    MinLimit = 0
                                }
                            }
                        };

                        this.Controls.Add(cartesianChart);

                        break;
                    }
                case "Расход":
                    {
                        var source = selectedFields.Where(t => t.Type == "Расход").ToList();
                        dataGridView1.DataSource = source;
                        dataGridView1.Columns["Id"].Visible = false;

                        dataGridView1.CellFormatting += (s, e) =>
                        {
                            if (dataGridView1.Columns[e.ColumnIndex].Name == "Amount" && e.Value != null)
                            {
                                if (decimal.TryParse(e.Value.ToString(), out var val))
                                {
                                    e.Value = val.ToString("#,0", new System.Globalization.CultureInfo("ru-RU"));
                                    e.FormattingApplied = true;
                                }
                            }
                        };
                        var outcomes = transactions.Where(t => t.Type == "Расход").ToList();

                        var grouped = outcomes.GroupBy(t => t.CategoryName).Select(g => new
                        {
                            CategoryName = g.Key,
                            TotalAmount = g.Sum(x => x.Amount)
                        }).ToList();

                        var categoryNames = grouped.Select(x => x.CategoryName).ToList();
                        var totalAmounts = grouped.Select(x => x.TotalAmount).ToList();

                        var values = totalAmounts.Select(x => (double)x).ToArray();

                        var cartesianChart = new CartesianChart()
                        {
                            Dock = DockStyle.Bottom,
                            Height = 200,
                            Series = new ISeries[]
                            {
                                new ColumnSeries<double>
                                {
                                    Values = values,
                                    Name = "Транзакции"
                                }
                                        },

                            XAxes = new[]
                                        {
                                new Axis
                                {
                                    Labels = categoryNames,
                                    Name = "Категории"
                                }
                            },

                            YAxes = new[]
                            {
                                new Axis
                                {
                                    Name = "Сумма",
                                    MinLimit = 0
                                }
                            }
                        };

                        this.Controls.Add(cartesianChart);

                        break;
                    }
            }
        }

        private void buttonClearFilter_Click(object sender, EventArgs e)
        {
            var transactions = _transactionRepository.GetAllTransactions((int)_userId);

            var selectedFields = transactions.Select(t => new { t.Id, t.Type, t.CategoryName, t.Date, t.Amount, t.Comment }).ToList();

            dataGridView1.DataSource = selectedFields;
            dataGridView1.Columns["Id"].Visible = false;

            dataGridView1.CellFormatting += (s, e) =>
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Amount" && e.Value != null)
                {
                    if (decimal.TryParse(e.Value.ToString(), out var val))
                    {
                        e.Value = val.ToString("#,0", new System.Globalization.CultureInfo("ru-RU"));
                        e.FormattingApplied = true;
                    }
                }
            };

            var grouped = transactions.GroupBy(t => t.CategoryName).Select(g => new
            {
                CategoryName = g.Key,
                TotalAmount = g.Sum(x => x.Amount)
            }).ToList();

            var categoryNames = grouped.Select(x => x.CategoryName).ToList();
            var totalAmounts = grouped.Select(x => x.TotalAmount).ToList();

            var values = totalAmounts.Select(x => (double)x).ToArray();

            var cartesianChart = new CartesianChart()
            {
                Dock = DockStyle.Bottom,
                Height = 200,
                Series = new ISeries[]
                {
                    new ColumnSeries<double>
                    {
                        Values = values,
                        Name = "Транзакции"
                    }
                },

                XAxes = new[]
                {
                    new Axis
                    {
                        Labels = categoryNames,
                        Name = "Категории"
                    }
                },

                YAxes = new[]
                {
                    new Axis
                    {
                        Name = "Сумма",
                        MinLimit = 0
                    }
                }
            };

            this.Controls.Add(cartesianChart);
        }

        private void CategoriesFilterContent()
        {
            var categories = _categoryRepository.GetAllCategories((int)_userId);
            listBoxCategories.DataSource = categories.Select(c => c.Name).ToList();
        }
        private void buttonCategoryFilter_Click(object sender, EventArgs e)
        {
            var selectedCategories = listBoxCategories.SelectedItems.Cast<string>().ToList();

            var transactions = _transactionRepository.GetAllTransactions((int)_userId);

            var display = transactions.Where(t => selectedCategories.Contains(t.CategoryName)).ToList();

            var selectedFields = display.Select(t => new { t.Id, t.Type, t.CategoryName, t.Date, t.Amount, t.Comment }).ToList();

            dataGridView1.DataSource = selectedFields;
            dataGridView1.Columns["Id"].Visible = false;

            dataGridView1.CellFormatting += (s, e) =>
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Amount" && e.Value != null)
                {
                    if (decimal.TryParse(e.Value.ToString(), out var val))
                    {
                        e.Value = val.ToString("#,0", new System.Globalization.CultureInfo("ru-RU"));
                        e.FormattingApplied = true;
                    }
                }
            };

            var grouped = display.GroupBy(t => t.CategoryName).Select(g => new
            {
                CategoryName = g.Key,
                TotalAmount = g.Sum(x => x.Amount)
            }).ToList();

            var categoryNames = grouped.Select(x => x.CategoryName).ToList();
            var totalAmounts = grouped.Select(x => x.TotalAmount).ToList();

            var values = totalAmounts.Select(x => (double)x).ToArray();

            var cartesianChart = new CartesianChart()
            {
                Dock = DockStyle.Bottom,
                Height = 200,
                Series = new ISeries[]
                {
                    new ColumnSeries<double>
                    {
                        Values = values,
                        Name = "Транзакции"
                    }
                },

                XAxes = new[]
                {
                    new Axis
                    {
                        Labels = categoryNames,
                        Name = "Категории"
                    }
                },

                YAxes = new[]
                {
                    new Axis
                    {
                        Name = "Сумма",
                        MinLimit = 0
                    }
                }
            };

            this.Controls.Add(cartesianChart);
        }

        private void buttonPeriodFilter_Click(object sender, EventArgs e)
        {
            var fromDate = DateOnly.FromDateTime(dateTimePickerFilterFrom.Value);
            var toDate = DateOnly.FromDateTime(dateTimePickerFilterTo.Value);

            var transactions = _transactionRepository.GetAllTransactions((int)_userId);

            var filtered = transactions.Where(t => t.Date >= fromDate && t.Date <= toDate).ToList();

            var selectedFields = filtered.Select(t => new { t.Id, t.Type, t.CategoryName, t.Date, t.Amount, t.Comment }).ToList();

            dataGridView1.DataSource = selectedFields;
            dataGridView1.Columns["Id"].Visible = false;

            dataGridView1.CellFormatting += (s, e) =>
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Amount" && e.Value != null)
                {
                    if (decimal.TryParse(e.Value.ToString(), out var val))
                    {
                        e.Value = val.ToString("#,0", new System.Globalization.CultureInfo("ru-RU"));
                        e.FormattingApplied = true;
                    }
                }
            };

            var grouped = filtered.GroupBy(t => t.CategoryName).Select(g => new
            {
                CategoryName = g.Key,
                TotalAmount = g.Sum(x => x.Amount)
            }).ToList();

            var categoryNames = grouped.Select(x => x.CategoryName).ToList();
            var totalAmounts = grouped.Select(x => x.TotalAmount).ToList();

            var values = totalAmounts.Select(x => (double)x).ToArray();

            var cartesianChart = new CartesianChart()
            {
                Dock = DockStyle.Bottom,
                Height = 200,
                Series = new ISeries[]
                {
                    new ColumnSeries<double>
                    {
                        Values = values,
                        Name = "Транзакции"
                    }
                },

                XAxes = new[]
                {
                    new Axis
                    {
                        Labels = categoryNames,
                        Name = "Категории"
                    }
                },

                YAxes = new[]
                {
                    new Axis
                    {
                        Name = "Сумма",
                        MinLimit = 0
                    }
                }
            };

            this.Controls.Add(cartesianChart);
        }

        private void buttonCustomCategories_Click(object sender, EventArgs e)
        {
            CustomCategories form = new CustomCategories(_userId, _categoryRepository, _transactionRepository, _userRepository);

            this.Hide();

            form.Show();
        }

        private void AddChart()
        {
            var transactions = _transactionRepository.GetAllTransactions((int)_userId);

            var grouped = transactions.GroupBy(t => t.CategoryName).Select(g => new
            {
                CategoryName = g.Key,
                TotalAmount = g.Sum(x => x.Amount)
            }).ToList();

            var categoryNames = grouped.Select(x => x.CategoryName).ToList();
            var totalAmounts = grouped.Select(x => x.TotalAmount).ToList();

            var values = totalAmounts.Select(x => (double)x).ToArray();

            var cartesianChart = new CartesianChart()
            {
                Dock = DockStyle.Bottom,
                Height = 200,
                Series = new ISeries[]
                {
                    new ColumnSeries<double>
                    {
                        Values = values,
                        Name = "Транзакции"
                    }
                },

                XAxes = new[]
                {
                    new Axis
                    {
                        Labels = categoryNames,
                        Name = "Категории"
                    }
                },

                YAxes = new[]
                {
                    new Axis
                    {
                        Name = "Сумма",
                        MinLimit = 0
                    }
                }
            };

            this.Controls.Add(cartesianChart);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login(_userRepository, _transactionRepository, _categoryRepository);

            login.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Login login = new Login(_userRepository, _transactionRepository, _categoryRepository);
            this.Hide();
            login.Show();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            _userRepository.Delete((int)_userId);

            Login login = new Login(_userRepository, _transactionRepository, _categoryRepository);
            this.Hide();
            login.Show();
        }
    }
}
