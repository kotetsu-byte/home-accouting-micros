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
using Домашняя_бухгалтерия.Repositories;

namespace Домашняя_бухгалтерия
{
    public partial class Login : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly ITransactionRepository _transactionRepository;
        private readonly ICategoryRepository _categoryRepository;
        public Login(IUserRepository userRepository, ITransactionRepository transactionRepository, ICategoryRepository categoryRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _transactionRepository = transactionRepository;
            _categoryRepository = categoryRepository;
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelLogin.Visible = false;
            panelRegister.Visible = true;
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            var id = _userRepository.UserExists(username, password);

            if (id != 0)
            {
                var user = _userRepository.GetUserById((int)id);
                Form1 form1 = new Form1(id, _transactionRepository, _categoryRepository, _userRepository);

                this.Hide();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelRegister.Visible = false;
            panelLogin.Visible = true;
        }

        private void buttonRegister_Click_1(object sender, EventArgs e)
        {
            string name = textBoxRName.Text;
            string username = textBoxRUsername.Text;
            string password = textBoxRPassword.Text;
            string confirmPassword = textBoxRConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Имя пользователя и пароль являются обязательными полями");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают!");
                return;
            }

            var user = new User
            {
                Name = name,
                Username = username,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(password),
            };

            _userRepository.Create(user);

            MessageBox.Show("Регистрация прошла успешно!");
            panelRegister.Visible = false;
            panelLogin.Visible = true;
        }
    }
}
