namespace Comands
{
    partial class Editor
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CtrlCButton = new System.Windows.Forms.Button();
            this.CtrlVButton = new System.Windows.Forms.Button();
            this.CtrlXButton = new System.Windows.Forms.Button();
            this.CtrlZButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(419, 202);
            this.textBox1.TabIndex = 0;
            // 
            // CtrlCButton
            // 
            this.CtrlCButton.Location = new System.Drawing.Point(219, 221);
            this.CtrlCButton.Name = "CtrlCButton";
            this.CtrlCButton.Size = new System.Drawing.Size(75, 23);
            this.CtrlCButton.TabIndex = 1;
            this.CtrlCButton.Text = "Ctrl+C";
            this.CtrlCButton.UseVisualStyleBackColor = true;
            this.CtrlCButton.Click += new System.EventHandler(this.CtrlCButton_Click);
            // 
            // CtrlVButton
            // 
            this.CtrlVButton.Location = new System.Drawing.Point(300, 221);
            this.CtrlVButton.Name = "CtrlVButton";
            this.CtrlVButton.Size = new System.Drawing.Size(75, 23);
            this.CtrlVButton.TabIndex = 2;
            this.CtrlVButton.Text = "Ctrl+V";
            this.CtrlVButton.UseVisualStyleBackColor = true;
            this.CtrlVButton.Click += new System.EventHandler(this.CtrlVButton_Click);
            // 
            // CtrlXButton
            // 
            this.CtrlXButton.Location = new System.Drawing.Point(138, 221);
            this.CtrlXButton.Name = "CtrlXButton";
            this.CtrlXButton.Size = new System.Drawing.Size(75, 23);
            this.CtrlXButton.TabIndex = 3;
            this.CtrlXButton.Text = "Ctrl+X";
            this.CtrlXButton.UseVisualStyleBackColor = true;
            this.CtrlXButton.Click += new System.EventHandler(this.CtrlXButton_Click);
            // 
            // CtrlZButton
            // 
            this.CtrlZButton.Location = new System.Drawing.Point(57, 221);
            this.CtrlZButton.Name = "CtrlZButton";
            this.CtrlZButton.Size = new System.Drawing.Size(75, 23);
            this.CtrlZButton.TabIndex = 4;
            this.CtrlZButton.Text = "Ctrl+Z";
            this.CtrlZButton.UseVisualStyleBackColor = true;
            this.CtrlZButton.Click += new System.EventHandler(this.CtrlZButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 252);
            this.Controls.Add(this.CtrlZButton);
            this.Controls.Add(this.CtrlXButton);
            this.Controls.Add(this.CtrlVButton);
            this.Controls.Add(this.CtrlCButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CtrlCButton;
        private System.Windows.Forms.Button CtrlVButton;
        private System.Windows.Forms.Button CtrlXButton;
        private System.Windows.Forms.Button CtrlZButton;
    }
}

