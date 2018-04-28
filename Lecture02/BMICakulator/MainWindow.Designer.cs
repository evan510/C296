namespace BMICakulator
{
    partial class MainWindow
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
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CalculateBMIButton.Location = new System.Drawing.Point(67, 178);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(192, 42);
            this.CalculateBMIButton.TabIndex = 0;
            this.CalculateBMIButton.Text = "計算BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(65, 45);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(51, 12);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "身高(cm)";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(122, 35);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(137, 22);
            this.HeightTextBox.TabIndex = 2;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(122, 84);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(137, 22);
            this.WeightTextBox.TabIndex = 4;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(65, 94);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(49, 12);
            this.WeightLabel.TabIndex = 3;
            this.WeightLabel.Text = "體重(kg)";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 257);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.CalculateBMIButton);
            this.Name = "MainWindow";
            this.Text = "簡易BMI計算機";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label WeightLabel;
    }
}

