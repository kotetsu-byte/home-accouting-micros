namespace Домашняя_бухгалтерия
{
    partial class CreateTransaction
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker = new DateTimePicker();
            comboBoxIO = new ComboBox();
            comboBoxCategory = new ComboBox();
            textBoxAmount = new TextBox();
            richTextBoxComment = new RichTextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 108);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Дата добавления";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 141);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 141);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 2;
            label3.Text = "Доход/Расход";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(201, 177);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Категория";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(201, 213);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 4;
            label5.Text = "Сумма";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(201, 251);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 5;
            label6.Text = "Комментарий";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(307, 102);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 6;
            // 
            // comboBoxIO
            // 
            comboBoxIO.FormattingEnabled = true;
            comboBoxIO.Location = new Point(307, 138);
            comboBoxIO.Name = "comboBoxIO";
            comboBoxIO.Size = new Size(200, 23);
            comboBoxIO.TabIndex = 7;
            comboBoxIO.SelectedIndexChanged += comboBoxIO_SelectedIndexChanged;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(307, 177);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(200, 23);
            comboBoxCategory.TabIndex = 8;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(307, 210);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(200, 23);
            textBoxAmount.TabIndex = 9;
            // 
            // richTextBoxComment
            // 
            richTextBoxComment.Location = new Point(307, 251);
            richTextBoxComment.Name = "richTextBoxComment";
            richTextBoxComment.Size = new Size(200, 96);
            richTextBoxComment.TabIndex = 10;
            richTextBoxComment.Text = "";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(307, 375);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(432, 375);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // CreateTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(richTextBoxComment);
            Controls.Add(textBoxAmount);
            Controls.Add(comboBoxCategory);
            Controls.Add(comboBoxIO);
            Controls.Add(dateTimePicker);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateTransaction";
            Text = "CreateTransaction";
            FormClosed += CreateTransaction_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker;
        private ComboBox comboBoxIO;
        private ComboBox comboBoxCategory;
        private TextBox textBoxAmount;
        private RichTextBox richTextBoxComment;
        private Button buttonSave;
        private Button buttonCancel;
    }
}