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

namespace Домашняя_бухгалтерия
{
    public partial class CustomCategories : Form
    {
        private int? _userId;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ITransactionRepository _transactionRepository;
        private readonly IUserRepository _userRepository;
        public CustomCategories(int? userId, ICategoryRepository categoryRepository, ITransactionRepository transactionRepository, IUserRepository userRepository)
        {
            InitializeComponent();
            _userId = userId;
            _categoryRepository = categoryRepository;
            _transactionRepository = transactionRepository;
            _userRepository = userRepository;

            CustomCategoriesContent();
        }

        private void CustomCategoriesContent()
        {
            var categories = _categoryRepository.GetAllCategories((int)_userId);

            var customCategories = categories.Where(c => c.UserId == _userId).ToList();

            var customCategoriesIncome = customCategories.Where(c => c.Type == "Доход").Select(c => new { c.Name, c.Id }).ToList();
            var customCategoriesOutcome = customCategories.Where(c => c.Type == "Расход").Select(c => new { c.Name, c.Id }).ToList();

            listBoxCustomCategoriesIncome.DataSource = customCategoriesIncome;
            listBoxCustomCategoriesIncome.DisplayMember = "Name";
            listBoxCustomCategoriesIncome.ValueMember = "Id";
            listBoxCustomCategoriesOutcome.DataSource = customCategoriesOutcome;
            listBoxCustomCategoriesOutcome.DisplayMember = "Name";
            listBoxCustomCategoriesOutcome.ValueMember = "Id";
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CustomCategoriesCreate form = new CustomCategoriesCreate(_userId, _categoryRepository, _transactionRepository, _userRepository);

            this.Hide();

            form.Show();
        }


        private void buttonEditIncome_Click(object sender, EventArgs e)
        {
            if (listBoxCustomCategoriesIncome.Items.Count == 0) return;
            int selectedId = (int)listBoxCustomCategoriesIncome.SelectedValue;
            CustomCategoriesEdit form = new CustomCategoriesEdit(_userId, selectedId, _userRepository, _transactionRepository, _categoryRepository);

            this.Hide();
            form.Show();
        }

        private void buttonEditOutcome_Click(object sender, EventArgs e)
        {
            if (listBoxCustomCategoriesOutcome.Items.Count == 0) return;
            int selectedId = (int)listBoxCustomCategoriesOutcome.SelectedValue;
            CustomCategoriesEdit form = new CustomCategoriesEdit(_userId, selectedId, _userRepository, _transactionRepository, _categoryRepository);

            this.Hide();
            form.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(_userId, _transactionRepository, _categoryRepository, _userRepository);

            this.Hide();

            form.Show();
        }

        private void buttonDeleteIncome_Click(object sender, EventArgs e)
        {
            if (listBoxCustomCategoriesIncome.Items.Count == 0) return;
            int selectedId = (int)listBoxCustomCategoriesIncome.SelectedValue;
            _categoryRepository.Delete(selectedId);
            listBoxCustomCategoriesIncome.DataSource = null;
            var categories = _categoryRepository.GetAllCategories((int)_userId);

            var customCategories = categories.Where(c => c.UserId == _userId).ToList();

            var customCategoriesIncome = customCategories.Where(c => c.Type == "Доход").Select(c => new { c.Name, c.Id }).ToList();

            listBoxCustomCategoriesIncome.DataSource = customCategoriesIncome;
            listBoxCustomCategoriesIncome.DisplayMember = "Name";
            listBoxCustomCategoriesIncome.ValueMember = "Id";
        }

        private void buttonDeleteOutcome_Click(object sender, EventArgs e)
        {
            if (listBoxCustomCategoriesOutcome.Items.Count == 0) return;
            int selectedId = (int)listBoxCustomCategoriesOutcome.SelectedValue;
            _categoryRepository.Delete(selectedId);

            listBoxCustomCategoriesOutcome.DataSource = null;

            var categories = _categoryRepository.GetAllCategories((int)_userId);

            var customCategories = categories.Where(c => c.UserId == _userId).ToList();

            var customCategoriesOutcome = customCategories.Where(c => c.Type == "Расход").Select(c => new { c.Name, c.Id }).ToList();

            listBoxCustomCategoriesOutcome.DataSource = customCategoriesOutcome;
            listBoxCustomCategoriesOutcome.DisplayMember = "Name";
            listBoxCustomCategoriesOutcome.ValueMember = "Id";
        }

        private void CustomCategories_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = new Form1(_userId, _transactionRepository, _categoryRepository, _userRepository);
            form.Show();
        }
    }
}
