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
    public partial class CustomCategoriesCreate : Form
    {
        private int? _userId;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUserRepository _userRepository;
        private readonly ITransactionRepository _transactionRepository;
        public CustomCategoriesCreate(int? userId, ICategoryRepository categoryRepository, ITransactionRepository transactionRepository, IUserRepository userRepository)
        {
            InitializeComponent();
            _userId = userId;
            _categoryRepository = categoryRepository;
            TypeContent();
            _transactionRepository = transactionRepository;
            _userRepository = userRepository;
        }

        private void TypeContent()
        {
            var types = new List<string>() { "Доход", "Расход" };
            comboBoxType.DataSource = types;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string type = comboBoxType.Text;
            string name = textBoxCategoryName.Text;

            var category = new Category
            {
                Type = type,
                Name = name,
                UserId = _userId,
            };

            _categoryRepository.Create(category);

            this.Hide();

            CustomCategories form = new CustomCategories(_userId, _categoryRepository, _transactionRepository, _userRepository);
            form.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CustomCategories form = new CustomCategories(_userId, _categoryRepository, _transactionRepository, _userRepository);
            this.Hide();
            form.Show();
        }

        private void CustomCategoriesCreate_FormClosed(object sender, FormClosedEventArgs e)
        {
            CustomCategories form = new CustomCategories(_userId, _categoryRepository, _transactionRepository, _userRepository);
            form.Show();
        }
    }
}
