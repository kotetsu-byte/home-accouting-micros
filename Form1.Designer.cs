namespace Домашняя_бухгалтерия
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelWelcome = new Label();
            dataGridView1 = new DataGridView();
            buttonCreate = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            groupBox1 = new GroupBox();
            buttonPeriodFilter = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dateTimePickerFilterTo = new DateTimePicker();
            dateTimePickerFilterFrom = new DateTimePicker();
            buttonCategoryFilter = new Button();
            label2 = new Label();
            listBoxCategories = new ListBox();
            buttonClearFilter = new Button();
            buttonIOFilter = new Button();
            label1 = new Label();
            comboBoxIOFilter = new ComboBox();
            buttonCustomCategories = new Button();
            buttonClose = new Button();
            buttonDeleteUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 15F);
            labelWelcome.Location = new Point(73, 28);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(278, 28);
            labelWelcome.TabIndex = 1;
            labelWelcome.Text = "Добро пожаловать, <ИМЯ>!";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 275);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(761, 163);
            dataGridView1.TabIndex = 2;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(73, 236);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 3;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(154, 236);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(235, 236);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonPeriodFilter);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePickerFilterTo);
            groupBox1.Controls.Add(dateTimePickerFilterFrom);
            groupBox1.Controls.Add(buttonCategoryFilter);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(listBoxCategories);
            groupBox1.Controls.Add(buttonClearFilter);
            groupBox1.Controls.Add(buttonIOFilter);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxIOFilter);
            groupBox1.Location = new Point(370, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 192);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фильтры";
            // 
            // buttonPeriodFilter
            // 
            buttonPeriodFilter.Location = new Point(347, 106);
            buttonPeriodFilter.Name = "buttonPeriodFilter";
            buttonPeriodFilter.Size = new Size(75, 23);
            buttonPeriodFilter.TabIndex = 12;
            buttonPeriodFilter.Text = "OK";
            buttonPeriodFilter.UseVisualStyleBackColor = true;
            buttonPeriodFilter.Click += buttonPeriodFilter_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(138, 114);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 11;
            label5.Text = "От:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 143);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 10;
            label4.Text = "До:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 114);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 9;
            label3.Text = "По периоду:";
            // 
            // dateTimePickerFilterTo
            // 
            dateTimePickerFilterTo.Location = new Point(168, 137);
            dateTimePickerFilterTo.Name = "dateTimePickerFilterTo";
            dateTimePickerFilterTo.Size = new Size(172, 23);
            dateTimePickerFilterTo.TabIndex = 8;
            // 
            // dateTimePickerFilterFrom
            // 
            dateTimePickerFilterFrom.Location = new Point(168, 108);
            dateTimePickerFilterFrom.Name = "dateTimePickerFilterFrom";
            dateTimePickerFilterFrom.Size = new Size(172, 23);
            dateTimePickerFilterFrom.TabIndex = 7;
            // 
            // buttonCategoryFilter
            // 
            buttonCategoryFilter.Location = new Point(346, 53);
            buttonCategoryFilter.Name = "buttonCategoryFilter";
            buttonCategoryFilter.Size = new Size(75, 23);
            buttonCategoryFilter.TabIndex = 6;
            buttonCategoryFilter.Text = "OK";
            buttonCategoryFilter.UseVisualStyleBackColor = true;
            buttonCategoryFilter.Click += buttonCategoryFilter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 53);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 5;
            label2.Text = "По категориям:";
            // 
            // listBoxCategories
            // 
            listBoxCategories.FormattingEnabled = true;
            listBoxCategories.Location = new Point(138, 53);
            listBoxCategories.Name = "listBoxCategories";
            listBoxCategories.SelectionMode = SelectionMode.MultiSimple;
            listBoxCategories.Size = new Size(202, 49);
            listBoxCategories.TabIndex = 4;
            // 
            // buttonClearFilter
            // 
            buttonClearFilter.Location = new Point(16, 163);
            buttonClearFilter.Name = "buttonClearFilter";
            buttonClearFilter.Size = new Size(136, 23);
            buttonClearFilter.TabIndex = 3;
            buttonClearFilter.Text = "Очистить фильтры";
            buttonClearFilter.UseVisualStyleBackColor = true;
            buttonClearFilter.Click += buttonClearFilter_Click;
            // 
            // buttonIOFilter
            // 
            buttonIOFilter.Location = new Point(346, 22);
            buttonIOFilter.Name = "buttonIOFilter";
            buttonIOFilter.Size = new Size(75, 23);
            buttonIOFilter.TabIndex = 2;
            buttonIOFilter.Text = "OK";
            buttonIOFilter.UseVisualStyleBackColor = true;
            buttonIOFilter.Click += buttonIOFilter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 25);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 1;
            label1.Text = "По доходу/расходу:";
            // 
            // comboBoxIOFilter
            // 
            comboBoxIOFilter.FormattingEnabled = true;
            comboBoxIOFilter.Location = new Point(138, 22);
            comboBoxIOFilter.Name = "comboBoxIOFilter";
            comboBoxIOFilter.Size = new Size(202, 23);
            comboBoxIOFilter.TabIndex = 0;
            // 
            // buttonCustomCategories
            // 
            buttonCustomCategories.Location = new Point(73, 207);
            buttonCustomCategories.Name = "buttonCustomCategories";
            buttonCustomCategories.Size = new Size(186, 23);
            buttonCustomCategories.TabIndex = 8;
            buttonCustomCategories.Text = "Пользовательские категории";
            buttonCustomCategories.UseVisualStyleBackColor = true;
            buttonCustomCategories.Click += buttonCustomCategories_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(717, 35);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 9;
            buttonClose.Text = "Закрыть";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonDeleteUser
            // 
            buttonDeleteUser.Location = new Point(73, 77);
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.Size = new Size(156, 23);
            buttonDeleteUser.TabIndex = 13;
            buttonDeleteUser.Text = "Удалить учётную запись";
            buttonDeleteUser.UseVisualStyleBackColor = true;
            buttonDeleteUser.Click += buttonDeleteUser_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 635);
            Controls.Add(buttonDeleteUser);
            Controls.Add(buttonClose);
            Controls.Add(buttonCustomCategories);
            Controls.Add(groupBox1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonCreate);
            Controls.Add(dataGridView1);
            Controls.Add(labelWelcome);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelWelcome;
        private DataGridView dataGridView1;
        private Button buttonCreate;
        private Button buttonEdit;
        private Button buttonDelete;
        private GroupBox groupBox1;
        private ComboBox comboBoxIOFilter;
        private Button buttonIOFilter;
        private Label label1;
        private Button buttonClearFilter;
        private Button buttonCategoryFilter;
        private Label label2;
        private ListBox listBoxCategories;
        private DateTimePicker dateTimePickerFilterFrom;
        private Button buttonPeriodFilter;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePickerFilterTo;
        private Button buttonCustomCategories;
        private Button buttonClose;
        private Button buttonDeleteUser;
    }
}
