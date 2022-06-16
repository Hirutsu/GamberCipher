namespace GambetCipherWinform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.keyInutTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.codeTB = new System.Windows.Forms.TextBox();
            this.codeBtn = new System.Windows.Forms.Button();
            this.unCodeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ключ";
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(15, 25);
            this.inputTB.Multiline = true;
            this.inputTB.Name = "inputTB";
            this.inputTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTB.Size = new System.Drawing.Size(282, 321);
            this.inputTB.TabIndex = 2;
            // 
            // keyInutTB
            // 
            this.keyInutTB.Location = new System.Drawing.Point(15, 377);
            this.keyInutTB.Name = "keyInutTB";
            this.keyInutTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.keyInutTB.Size = new System.Drawing.Size(282, 20);
            this.keyInutTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Закодированный текст";
            // 
            // codeTB
            // 
            this.codeTB.Location = new System.Drawing.Point(341, 25);
            this.codeTB.Multiline = true;
            this.codeTB.Name = "codeTB";
            this.codeTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.codeTB.Size = new System.Drawing.Size(282, 321);
            this.codeTB.TabIndex = 5;
            // 
            // codeBtn
            // 
            this.codeBtn.Location = new System.Drawing.Point(511, 374);
            this.codeBtn.Name = "codeBtn";
            this.codeBtn.Size = new System.Drawing.Size(112, 23);
            this.codeBtn.TabIndex = 6;
            this.codeBtn.Text = "Закодировать";
            this.codeBtn.UseVisualStyleBackColor = true;
            this.codeBtn.Click += new System.EventHandler(this.codeBtn_Click);
            // 
            // unCodeBtn
            // 
            this.unCodeBtn.Location = new System.Drawing.Point(341, 374);
            this.unCodeBtn.Name = "unCodeBtn";
            this.unCodeBtn.Size = new System.Drawing.Size(112, 23);
            this.unCodeBtn.TabIndex = 7;
            this.unCodeBtn.Text = "Раскодировать";
            this.unCodeBtn.UseVisualStyleBackColor = true;
            this.unCodeBtn.Click += new System.EventHandler(this.unCodeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 406);
            this.Controls.Add(this.unCodeBtn);
            this.Controls.Add(this.codeBtn);
            this.Controls.Add(this.codeTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.keyInutTB);
            this.Controls.Add(this.inputTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Gambet Cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.TextBox keyInutTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codeTB;
        private System.Windows.Forms.Button codeBtn;
        private System.Windows.Forms.Button unCodeBtn;
    }
}

