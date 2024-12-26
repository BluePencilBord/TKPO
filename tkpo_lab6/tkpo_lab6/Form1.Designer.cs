namespace tkpo_lab6
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
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.labelCourseName = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.buttonAddGrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.ItemHeight = 16;
            this.listBoxInfo.Location = new System.Drawing.Point(129, 83);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(424, 228);
            this.listBoxInfo.TabIndex = 0;
            this.listBoxInfo.SelectedIndexChanged += new System.EventHandler(this.listBoxInfo_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(262, 375);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(179, 30);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "добавить студента";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(166, 347);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(364, 22);
            this.textBoxStudentName.TabIndex = 2;
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCourseName.Location = new System.Drawing.Point(257, 45);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(186, 29);
            this.labelCourseName.TabIndex = 3;
            this.labelCourseName.Text = "название курса";
            this.labelCourseName.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(262, 442);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(179, 46);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "удалить выделенного студента";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Оценка:";
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(191, 318);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(14, 16);
            this.labelGrade.TabIndex = 6;
            this.labelGrade.Text = "0";
            this.labelGrade.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonAddGrade
            // 
            this.buttonAddGrade.Location = new System.Drawing.Point(262, 406);
            this.buttonAddGrade.Name = "buttonAddGrade";
            this.buttonAddGrade.Size = new System.Drawing.Size(179, 30);
            this.buttonAddGrade.TabIndex = 7;
            this.buttonAddGrade.Text = "поставить оценку";
            this.buttonAddGrade.UseVisualStyleBackColor = true;
            this.buttonAddGrade.Click += new System.EventHandler(this.buttonAddGrade_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 520);
            this.Controls.Add(this.buttonAddGrade);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelCourseName);
            this.Controls.Add(this.textBoxStudentName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Курсы (6 лабораторная)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.Button buttonAddGrade;
    }
}

