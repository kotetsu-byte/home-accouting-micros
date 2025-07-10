namespace Домашняя_бухгалтерия
{
    partial class EditTransaction
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
            buttonSave = new Button();
            richTextBoxComment = new RichTextBox();
            textBoxAmount = new TextBox();
            comboBoxCategory = new ComboBox();
            comboBoxIO = new ComboBox();
            dateTimePicker = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(353, 350);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 23;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // richTextBoxComment
            // 
            richTextBoxComment.Location = new Point(353, 226);
            richTextBoxComment.Name = "richTextBoxComment";
            richTextBoxComment.Size = new Size(200, 96);
            richTextBoxComment.TabIndex = 22;
            richTextBoxComment.Text = "";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(353, 185);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(200, 23);
            textBoxAmount.TabIndex = 21;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(353, 152);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(200, 23);
            comboBoxCategory.TabIndex = 20;
            // 
            // comboBoxIO
            // 
            comboBoxIO.FormattingEnabled = true;
            comboBoxIO.Location = new Point(353, 113);
            comboBoxIO.Name = "comboBoxIO";
            comboBoxIO.Size = new Size(200, 23);
            comboBoxIO.TabIndex = 19;
            comboBoxIO.SelectedIndexChanged += comboBoxIO_SelectedIndexChanged;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(353, 77);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(247, 226);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 17;
            label6.Text = "Комментарий";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(247, 188);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 16;
            label5.Text = "Сумма";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(247, 152);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 15;
            label4.Text = "Категория";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 116);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 14;
            label3.Text = "Доход/Расход";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 116);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 83);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 12;
            label1.Text = "Дата добавления";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(478, 350);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 24;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // EditTransaction
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
            Name = "EditTransaction";
            Text = "EditTransaction";
            FormClosed += EditTransaction_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private RichTextBox richTextBoxComment;
        private TextBox textBoxAmount;
        private ComboBox comboBoxCategory;
        private ComboBox comboBoxIO;
        private DateTimePicker dateTimePicker;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonCancel;
    }
}