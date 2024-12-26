namespace tkpo_lab5
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
            this.buttonEndCall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.buttonCall = new System.Windows.Forms.Button();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonRecharge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEndCall
            // 
            this.buttonEndCall.Location = new System.Drawing.Point(174, 193);
            this.buttonEndCall.Name = "buttonEndCall";
            this.buttonEndCall.Size = new System.Drawing.Size(137, 44);
            this.buttonEndCall.TabIndex = 0;
            this.buttonEndCall.Text = "завершить разговор";
            this.buttonEndCall.UseVisualStyleBackColor = true;
            this.buttonEndCall.Click += new System.EventHandler(this.buttonEndCall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Баланс:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(80, 25);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(14, 16);
            this.labelBalance.TabIndex = 2;
            this.labelBalance.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Состояние:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(103, 48);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(11, 16);
            this.labelState.TabIndex = 4;
            this.labelState.Text = "-";
            // 
            // buttonCall
            // 
            this.buttonCall.Location = new System.Drawing.Point(174, 104);
            this.buttonCall.Name = "buttonCall";
            this.buttonCall.Size = new System.Drawing.Size(137, 32);
            this.buttonCall.TabIndex = 0;
            this.buttonCall.Text = "позвонить";
            this.buttonCall.UseVisualStyleBackColor = true;
            this.buttonCall.Click += new System.EventHandler(this.buttonCall_Click);
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Location = new System.Drawing.Point(174, 142);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(137, 45);
            this.buttonAnswer.TabIndex = 0;
            this.buttonAnswer.Text = "ответить на звонок";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 22);
            this.textBox1.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(19, 341);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(422, 196);
            this.listBox1.TabIndex = 6;
            // 
            // buttonRecharge
            // 
            this.buttonRecharge.Location = new System.Drawing.Point(174, 289);
            this.buttonRecharge.Name = "buttonRecharge";
            this.buttonRecharge.Size = new System.Drawing.Size(137, 32);
            this.buttonRecharge.TabIndex = 7;
            this.buttonRecharge.Text = "пополнить баланс";
            this.buttonRecharge.UseVisualStyleBackColor = true;
            this.buttonRecharge.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 562);
            this.Controls.Add(this.buttonRecharge);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCall);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.buttonEndCall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "телефон";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEndCall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Button buttonCall;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonRecharge;
    }
}

