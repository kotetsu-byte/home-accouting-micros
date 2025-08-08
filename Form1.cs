using System.Collections;
using System.Diagnostics;
using System.Xml.Linq;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using Домашняя_бухгалтерия.Interfaces;
using Домашняя_бухгалтерия.Models;

namespace Домашняя_бухгалтерия
{
    public partial class Form1 : Form
    {
        private int? _userId;
        private readonly ITransactionRepository _transactionRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUserRepository _userRepository;
        private CartesianChart cartesianChart;
        private List<double> values;
        private List<string> categoryNames;
        private ColumnSeries<double> columnSeries;
        private Axis xAxis;

        public Form1(int? userId, ITransactionRepository transactionRepository, ICategoryRepository categoryRepository, IUserRepository userRepository)
        {
            InitializeComponent();
            _userId = userId;
            _transactionRepository = transactionRepository;
            _categoryRepository = categoryRepository;
            _userRepository = userRepository;
            IOFilterContent();
            CategoriesFilterContent();

            columnSeries = new ColumnSeries<double>
            {
                Values = values,
                Name = "Транзакции"
            };

            xAxis = new Axis
            {
                Labels = categoryNames,
                Name = "Категории"
            };

            cartesianChart = new CartesianChart
            {
                Dock = DockStyle.Bottom,
                Height = 200,
                Series = new ISeries[]
                {
                    columnSeries      
                },
                XAxes = new[]
                {
                    xAxis
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
            UpdateChart(_transactionRepository.GetAllTransactions((int)_userId));
            Controls.Add(cartesianChart);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var user = _userRepository.GetUserById((int)_userId);

            labelWelcome.Text = $"Добро пожаловать, {user.Name}!";

            var transactions = _transactionRepository.GetAllTransactions((int)_userId);

            var selectedFields = _transactionRepository.GetFieldsFromTransactions(transactions);

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

            var selectedFields = _transactionRepository.GetFieldsFromTransactions(transactions);

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

            UpdateChart(transactions);
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

            var incomes = transactions.Where(t => t.Type == "Доход").ToList();

            var outcomes = transactions.Where(t => t.Type == "Расход").ToList();

            switch (selectedIndex)
            {
                case "Доход":
                    {
                        var sourse = _transactionRepository.GetFieldsFromTransactions(incomes);
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

                        UpdateChart(incomes);
                        break;
                    }
                case "Расход":
                    {
                        var source = _transactionRepository.GetFieldsFromTransactions(outcomes);
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

                        UpdateChart(outcomes);
                        break;
                    }
            }
        }

        private void buttonClearFilter_Click(object sender, EventArgs e)
        {
            var transactions = _transactionRepository.GetAllTransactions((int)_userId);

            var selectedFields = _transactionRepository.GetFieldsFromTransactions(transactions);

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

            UpdateChart(transactions);
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

            var selectedFields = _transactionRepository.GetFieldsFromTransactions(display);

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

            UpdateChart(display);
        }

        private void buttonPeriodFilter_Click(object sender, EventArgs e)
        {
            var fromDate = DateOnly.FromDateTime(dateTimePickerFilterFrom.Value);
            var toDate = DateOnly.FromDateTime(dateTimePickerFilterTo.Value);

            var transactions = _transactionRepository.GetAllTransactions((int)_userId);

            var filtered = transactions.Where(t => t.Date >= fromDate && t.Date <= toDate).ToList();

            var selectedFields = _transactionRepository.GetFieldsFromTransactions(filtered);

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

            UpdateChart(filtered);
        }

        private void buttonCustomCategories_Click(object sender, EventArgs e)
        {
            CustomCategories form = new CustomCategories(_userId, _categoryRepository, _transactionRepository, _userRepository);

            this.Hide();

            form.Show();
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
            DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить свою учётную запись?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if(result == DialogResult.Yes)
            {
                _userRepository.Delete((int)_userId);

                Login login = new Login(_userRepository, _transactionRepository, _categoryRepository);
                this.Hide();
                login.Show();
            } else
            {
                return;
            }
            return;
        }

        private void UpdateChart(ICollection<Transaction> transactions)
        {
            var grouped = transactions.GroupBy(t => t.CategoryName).Select(g => new
            {
                CategoryName = g.Key,
                TotalAmount = g.Sum(x => x.Amount)
            }).ToList();

            var cns = grouped.Select(x => x.CategoryName).ToList();
            var vals = grouped.Select(x => (double)x.TotalAmount).ToList();

            values = vals;
            columnSeries.Values = values.ToArray();
            categoryNames = cns;
            xAxis.Labels = categoryNames;

            cartesianChart.Update();
        }
    }
}
