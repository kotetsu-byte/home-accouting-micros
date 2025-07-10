namespace Домашняя_бухгалтерия
{
    partial class CustomCategories
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
            label1 = new Label();
            listBoxCustomCategoriesIncome = new ListBox();
            buttonCreate = new Button();
            buttonEditIncome = new Button();
            buttonDeleteIncome = new Button();
            listBoxCustomCategoriesOutcome = new ListBox();
            label2 = new Label();
            label3 = new Label();
            buttonDeleteOutcome = new Button();
            buttonEditOutcome = new Button();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(114, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 21);
            label1.TabIndex = 0;
            label1.Text = "Пользовательские категории";
            // 
            // listBoxCustomCategoriesIncome
            // 
            listBoxCustomCategoriesIncome.FormattingEnabled = true;
            listBoxCustomCategoriesIncome.Location = new Point(129, 58);
            listBoxCustomCategoriesIncome.Name = "listBoxCustomCategoriesIncome";
            listBoxCustomCategoriesIncome.Size = new Size(192, 169);
            listBoxCustomCategoriesIncome.TabIndex = 1;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(129, 408);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 2;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonEditIncome
            // 
            buttonEditIncome.Location = new Point(339, 58);
            buttonEditIncome.Name = "buttonEditIncome";
            buttonEditIncome.Size = new Size(75, 23);
            buttonEditIncome.TabIndex = 3;
            buttonEditIncome.Text = "Изменить";
            buttonEditIncome.UseVisualStyleBackColor = true;
            buttonEditIncome.Click += buttonEditIncome_Click;
            // 
            // buttonDeleteIncome
            // 
            buttonDeleteIncome.Location = new Point(339, 87);
            buttonDeleteIncome.Name = "buttonDeleteIncome";
            buttonDeleteIncome.Size = new Size(75, 23);
            buttonDeleteIncome.TabIndex = 4;
            buttonDeleteIncome.Text = "Удалить";
            buttonDeleteIncome.UseVisualStyleBackColor = true;
            buttonDeleteIncome.Click += buttonDeleteIncome_Click;
            // 
            // listBoxCustomCategoriesOutcome
            // 
            listBoxCustomCategoriesOutcome.FormattingEnabled = true;
            listBoxCustomCategoriesOutcome.Location = new Point(129, 233);
            listBoxCustomCategoriesOutcome.Name = "listBoxCustomCategoriesOutcome";
            listBoxCustomCategoriesOutcome.Size = new Size(192, 169);
            listBoxCustomCategoriesOutcome.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 7;
            label2.Text = "Доходы:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 233);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 8;
            label3.Text = "Расходы:";
            // 
            // buttonDeleteOutcome
            // 
            buttonDeleteOutcome.Location = new Point(339, 258);
            buttonDeleteOutcome.Name = "buttonDeleteOutcome";
            buttonDeleteOutcome.Size = new Size(75, 23);
            buttonDeleteOutcome.TabIndex = 10;
            buttonDeleteOutcome.Text = "Удалить";
            buttonDeleteOutcome.UseVisualStyleBackColor = true;
            buttonDeleteOutcome.Click += buttonDeleteOutcome_Click;
            // 
            // buttonEditOutcome
            // 
            buttonEditOutcome.Location = new Point(339, 229);
            buttonEditOutcome.Name = "buttonEditOutcome";
            buttonEditOutcome.Size = new Size(75, 23);
            buttonEditOutcome.TabIndex = 9;
            buttonEditOutcome.Text = "Изменить";
            buttonEditOutcome.UseVisualStyleBackColor = true;
            buttonEditOutcome.Click += buttonEditOutcome_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(246, 408);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 11;
            buttonClose.Text = "Закрыть";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // CustomCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 450);
            Controls.Add(buttonClose);
            Controls.Add(buttonDeleteOutcome);
            Controls.Add(buttonEditOutcome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBoxCustomCategoriesOutcome);
            Controls.Add(buttonDeleteIncome);
            Controls.Add(buttonEditIncome);
            Controls.Add(buttonCreate);
            Controls.Add(listBoxCustomCategoriesIncome);
            Controls.Add(label1);
            Name = "CustomCategories";
            Text = "CustomCategories";
            FormClosed += CustomCategories_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxCustomCategoriesIncome;
        private Button buttonCreate;
        private Button buttonEditIncome;
        private Button buttonDeleteIncome;
        private Button buttonClose;
        private ListBox listBoxCustomCategoriesOutcome;
        private Label label2;
        private Label label3;
        private Button buttonDeleteOutcome;
        private Button buttonEditOutcome;
    }
}