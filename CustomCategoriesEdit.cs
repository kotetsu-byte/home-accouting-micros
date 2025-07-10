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
    public partial class CustomCategoriesEdit : Form
    {
        private int? _userId;
        private int? _id;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUserRepository _userRepository;
        private readonly ITransactionRepository _transactionRepository;
        public CustomCategoriesEdit(int? userId, int? id, IUserRepository userRepository, ITransactionRepository transactionRepository, ICategoryRepository categoryRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _transactionRepository = transactionRepository;
            _categoryRepository = categoryRepository;
            _userId = userId;
            _id = id;
            TypeContent();
            LoadValues();
        }

        private void TypeContent()
        {
            var types = new List<string>() { "Доход", "Расход" };
            comboBoxType.DataSource = types;
        }

        private void LoadValues()
        {
            var category = _categoryRepository.GetCategoryById((int)_id);

            comboBoxType.SelectedItem = category.Type;
            textBoxCategoryName.Text = category.Name;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string type = comboBoxType.Text;
            string name = textBoxCategoryName.Text;

            var category = new Category
            {
                Id = _id,
                Type = type,
                Name = name,
                UserId = _userId,
            };

            _categoryRepository.Update(category);

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

        private void CustomCategoriesEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            CustomCategories form = new CustomCategories(_userId, _categoryRepository, _transactionRepository, _userRepository);
            form.Show();
        }
    }
}
