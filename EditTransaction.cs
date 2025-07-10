using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Домашняя_бухгалтерия.Interfaces;
using Домашняя_бухгалтерия.Models;

namespace Домашняя_бухгалтерия
{
    public partial class EditTransaction : Form
    {
        private int? _userId;
        private int? _id;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ITransactionRepository _transactionRepository;
        private readonly IUserRepository _userRepository;

        public EditTransaction(ICategoryRepository categoryRepository, ITransactionRepository transactionRepository, IUserRepository userRepository, int? userId, int? id)
        {
            InitializeComponent();
            _categoryRepository = categoryRepository;
            _transactionRepository = transactionRepository;
            _userRepository = userRepository;
            _userId = userId;
            _id = id;
            IOContent();
            LoadValues();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DateOnly? date = DateOnly.FromDateTime(dateTimePicker.Value);
            string type = comboBoxIO.Text;
            string category = comboBoxCategory.Text;
            double amount = double.Parse(textBoxAmount.Text);
            string comment = richTextBoxComment.Text;

            var transaction = new Transaction
            {
                Id = _id,
                Date = date,
                Type = type,
                CategoryName = category,
                Amount = amount,
                Comment = comment,
                UserId = _userId
            };

            _transactionRepository.Update(transaction);

            this.Hide();

            Form1 form1 = new Form1(_userId, _transactionRepository, _categoryRepository, _userRepository);
            form1.Show();
        }

        private void LoadValues()
        {
            var transaction = _transactionRepository.GetTransactionById((int)_userId, (int)_id);
            dateTimePicker.Value = transaction.Date.Value.ToDateTime(TimeOnly.MinValue);
            comboBoxIO.SelectedItem = transaction.Type;
            comboBoxCategory.SelectedItem = transaction.CategoryName;
            textBoxAmount.Text = transaction.Amount.ToString();
            richTextBoxComment.Text = transaction.Comment;
        }

        private void IOContent()
        {
            var ios = new List<string>() { "Доход", "Расход" };
            comboBoxIO.DataSource = ios;
        }

        private void comboBoxIO_SelectedIndexChanged(object sender, EventArgs e)
        {
            var categories = _categoryRepository.GetAllCategories((int)_userId);
            if (comboBoxIO.SelectedIndex == 0)
            {
                var incomes = categories.Where(c => c.Type == "Доход").Select(c => c.Name).ToList();
                comboBoxCategory.DataSource = incomes;
            }
            else if (comboBoxIO.SelectedIndex == 1)
            {
                var outcomes = categories.Where(c => c.Type == "Расход").Select(c => c.Name).ToList();
                comboBoxCategory.DataSource = outcomes;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(_userId, _transactionRepository, _categoryRepository, _userRepository);
            this.Hide();
            form.Show();
        }

        private void EditTransaction_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = new Form1(_userId, _transactionRepository, _categoryRepository, _userRepository);
            form.Show();
        }
    }
}
