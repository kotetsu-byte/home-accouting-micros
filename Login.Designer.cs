namespace Домашняя_бухгалтерия
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelLogin = new Panel();
            panelRegister = new Panel();
            linkLabelLogin = new LinkLabel();
            buttonRegister = new Button();
            textBoxRConfirmPassword = new TextBox();
            textBoxRPassword = new TextBox();
            textBoxRName = new TextBox();
            textBoxRUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            linkLabelRegister = new LinkLabel();
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            labelPassword = new Label();
            labelUsername = new Label();
            panelLogin.SuspendLayout();
            panelRegister.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(linkLabelRegister);
            panelLogin.Controls.Add(buttonLogin);
            panelLogin.Controls.Add(textBoxPassword);
            panelLogin.Controls.Add(textBoxUsername);
            panelLogin.Controls.Add(labelPassword);
            panelLogin.Controls.Add(labelUsername);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(0, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(800, 450);
            panelLogin.TabIndex = 0;
            // 
            // panelRegister
            // 
            panelRegister.Controls.Add(linkLabelLogin);
            panelRegister.Controls.Add(buttonRegister);
            panelRegister.Controls.Add(textBoxRConfirmPassword);
            panelRegister.Controls.Add(textBoxRPassword);
            panelRegister.Controls.Add(textBoxRName);
            panelRegister.Controls.Add(textBoxRUsername);
            panelRegister.Controls.Add(label4);
            panelRegister.Controls.Add(label3);
            panelRegister.Controls.Add(label2);
            panelRegister.Controls.Add(label1);
            panelRegister.Dock = DockStyle.Fill;
            panelRegister.Location = new Point(0, 0);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(800, 450);
            panelRegister.TabIndex = 1;
            panelRegister.Visible = false;
            // 
            // linkLabelLogin
            // 
            linkLabelLogin.AutoSize = true;
            linkLabelLogin.Location = new Point(372, 322);
            linkLabelLogin.Name = "linkLabelLogin";
            linkLabelLogin.Size = new Size(33, 15);
            linkLabelLogin.TabIndex = 19;
            linkLabelLogin.TabStop = true;
            linkLabelLogin.Text = "Вход";
            linkLabelLogin.LinkClicked += linkLabelLogin_LinkClicked;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(372, 281);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(134, 23);
            buttonRegister.TabIndex = 18;
            buttonRegister.Text = "Зарегистрироваться";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click_1;
            // 
            // textBoxRConfirmPassword
            // 
            textBoxRConfirmPassword.Location = new Point(372, 231);
            textBoxRConfirmPassword.Name = "textBoxRConfirmPassword";
            textBoxRConfirmPassword.Size = new Size(171, 23);
            textBoxRConfirmPassword.TabIndex = 17;
            textBoxRConfirmPassword.UseSystemPasswordChar = true;
            // 
            // textBoxRPassword
            // 
            textBoxRPassword.Location = new Point(372, 191);
            textBoxRPassword.Name = "textBoxRPassword";
            textBoxRPassword.Size = new Size(171, 23);
            textBoxRPassword.TabIndex = 16;
            textBoxRPassword.UseSystemPasswordChar = true;
            // 
            // textBoxRName
            // 
            textBoxRName.Location = new Point(372, 113);
            textBoxRName.Name = "textBoxRName";
            textBoxRName.Size = new Size(171, 23);
            textBoxRName.TabIndex = 15;
            // 
            // textBoxRUsername
            // 
            textBoxRUsername.Location = new Point(372, 153);
            textBoxRUsername.Name = "textBoxRUsername";
            textBoxRUsername.Size = new Size(171, 23);
            textBoxRUsername.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 234);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 13;
            label4.Text = "Повторить пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 194);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 12;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 156);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 11;
            label2.Text = "Имя пользователя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 121);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 10;
            label1.Text = "ФИО";
            // 
            // linkLabelRegister
            // 
            linkLabelRegister.AutoSize = true;
            linkLabelRegister.Location = new Point(358, 241);
            linkLabelRegister.Name = "linkLabelRegister";
            linkLabelRegister.Size = new Size(76, 15);
            linkLabelRegister.TabIndex = 5;
            linkLabelRegister.TabStop = true;
            linkLabelRegister.Text = "Регистрация";
            linkLabelRegister.LinkClicked += linkLabelRegister_LinkClicked;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(358, 201);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(358, 155);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(159, 23);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(358, 120);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(159, 23);
            textBoxUsername.TabIndex = 2;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(303, 158);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(49, 15);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Пароль";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(243, 123);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(109, 15);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Имя пользователя";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelRegister);
            Controls.Add(panelLogin);
            Name = "Login";
            Text = "Login";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private LinkLabel linkLabelRegister;
        private Button buttonLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Label labelPassword;
        private Label labelUsername;
        private Panel panelRegister;
        private LinkLabel linkLabelLogin;
        private Button buttonRegister;
        private TextBox textBoxRPassword;
        private TextBox textBoxRName;
        private TextBox textBoxRUsername;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxRConfirmPassword;
    }
}