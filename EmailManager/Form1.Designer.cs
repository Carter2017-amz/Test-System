namespace EmailManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ToField = new System.Windows.Forms.TextBox();
            this.SubjectField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MessageField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ContactsList = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CopiesList = new System.Windows.Forms.ListBox();
            this.SelectList = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SelectButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Менеджер почтовых рассылок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(747, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Программа для отправки почтовых сообщений клиентам";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кому:";
            // 
            // ToField
            // 
            this.ToField.Location = new System.Drawing.Point(90, 359);
            this.ToField.Name = "ToField";
            this.ToField.Size = new System.Drawing.Size(273, 33);
            this.ToField.TabIndex = 4;
            // 
            // SubjectField
            // 
            this.SubjectField.Location = new System.Drawing.Point(90, 465);
            this.SubjectField.Name = "SubjectField";
            this.SubjectField.Size = new System.Drawing.Size(273, 33);
            this.SubjectField.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Тема:";
            // 
            // MessageField
            // 
            this.MessageField.Location = new System.Drawing.Point(90, 569);
            this.MessageField.Multiline = true;
            this.MessageField.Name = "MessageField";
            this.MessageField.Size = new System.Drawing.Size(527, 316);
            this.MessageField.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Сообщение:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(686, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Список контактов:";
            // 
            // ContactsList
            // 
            this.ContactsList.FormattingEnabled = true;
            this.ContactsList.Location = new System.Drawing.Point(691, 359);
            this.ContactsList.Name = "ContactsList";
            this.ContactsList.Size = new System.Drawing.Size(271, 34);
            this.ContactsList.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(686, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "Копии:";
            // 
            // CopiesList
            // 
            this.CopiesList.FormattingEnabled = true;
            this.CopiesList.ItemHeight = 26;
            this.CopiesList.Location = new System.Drawing.Point(691, 465);
            this.CopiesList.Name = "CopiesList";
            this.CopiesList.Size = new System.Drawing.Size(295, 420);
            this.CopiesList.TabIndex = 13;
            // 
            // SelectList
            // 
            this.SelectList.FormattingEnabled = true;
            this.SelectList.ItemHeight = 26;
            this.SelectList.Location = new System.Drawing.Point(1098, 109);
            this.SelectList.Name = "SelectList";
            this.SelectList.Size = new System.Drawing.Size(295, 238);
            this.SelectList.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1093, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "Файлы:";
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(1083, 393);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(121, 52);
            this.SelectButton.TabIndex = 16;
            this.SelectButton.Text = "Выбрать";
            this.SelectButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(1265, 393);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 52);
            this.AddButton.TabIndex = 17;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(1250, 770);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(128, 52);
            this.ClearButton.TabIndex = 20;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(1068, 770);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(144, 52);
            this.SendButton.TabIndex = 19;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 26;
            this.listBox3.Location = new System.Drawing.Point(1083, 486);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(295, 238);
            this.listBox3.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 897);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.SelectList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CopiesList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ContactsList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MessageField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SubjectField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ToField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Менеджер почтовых рассылок";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ToField;
        private System.Windows.Forms.TextBox SubjectField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MessageField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ContactsList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox CopiesList;
        private System.Windows.Forms.ListBox SelectList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.ListBox listBox3;
    }
}

