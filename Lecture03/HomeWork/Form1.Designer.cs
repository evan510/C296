namespace HomeWork
{
    partial class homeWork
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MailLlabel = new System.Windows.Forms.Label();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.CheckMailButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MailLlabel
            // 
            this.MailLlabel.AutoSize = true;
            this.MailLlabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MailLlabel.Location = new System.Drawing.Point(24, 38);
            this.MailLlabel.Name = "MailLlabel";
            this.MailLlabel.Size = new System.Drawing.Size(106, 16);
            this.MailLlabel.TabIndex = 0;
            this.MailLlabel.Text = "請輸入email：";
            // 
            // MailTextBox
            // 
            this.MailTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MailTextBox.Location = new System.Drawing.Point(136, 27);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(213, 27);
            this.MailTextBox.TabIndex = 1;
            // 
            // CheckMailButton
            // 
            this.CheckMailButton.Location = new System.Drawing.Point(27, 73);
            this.CheckMailButton.Name = "CheckMailButton";
            this.CheckMailButton.Size = new System.Drawing.Size(322, 46);
            this.CheckMailButton.TabIndex = 2;
            this.CheckMailButton.Text = "檢查mail";
            this.CheckMailButton.UseVisualStyleBackColor = true;
            this.CheckMailButton.Click += new System.EventHandler(this.CheckMailButton_Click);
            // 
            // homeWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 450);
            this.Controls.Add(this.CheckMailButton);
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.MailLlabel);
            this.Name = "homeWork";
            this.Text = "HomeWork";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MailLlabel;
        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.Button CheckMailButton;
    }
}

