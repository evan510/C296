namespace BMICakulatorEx
{
    partial class BMI
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
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.BMIbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(38, 32);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 12);
            this.heightLabel.TabIndex = 0;
            this.heightLabel.Text = "身高：";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(106, 22);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(135, 22);
            this.heightTextBox.TabIndex = 1;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(106, 79);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(135, 22);
            this.WeightTextBox.TabIndex = 3;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(38, 89);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(41, 12);
            this.WeightLabel.TabIndex = 2;
            this.WeightLabel.Text = "體重：";
            // 
            // BMIbutton
            // 
            this.BMIbutton.Location = new System.Drawing.Point(106, 143);
            this.BMIbutton.Name = "BMIbutton";
            this.BMIbutton.Size = new System.Drawing.Size(109, 38);
            this.BMIbutton.TabIndex = 4;
            this.BMIbutton.Text = "計算";
            this.BMIbutton.UseVisualStyleBackColor = true;
            this.BMIbutton.Click += new System.EventHandler(this.BMIbutton_Click);
            // 
            // BMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 203);
            this.Controls.Add(this.BMIbutton);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.heightLabel);
            this.Name = "BMI";
            this.Text = "BMI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Button BMIbutton;
    }
}

