namespace Loop
{
    partial class Form1
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
            this.GameStarButton = new System.Windows.Forms.Button();
            this.NumberLabel0 = new System.Windows.Forms.Label();
            this.CheckNumberBox0 = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CheckBotton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameStarButton
            // 
            this.GameStarButton.Location = new System.Drawing.Point(52, 345);
            this.GameStarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GameStarButton.Name = "GameStarButton";
            this.GameStarButton.Size = new System.Drawing.Size(143, 72);
            this.GameStarButton.TabIndex = 0;
            this.GameStarButton.Text = "產生數字";
            this.GameStarButton.UseVisualStyleBackColor = true;
            this.GameStarButton.Click += new System.EventHandler(this.GameStarButton_Click);
            // 
            // NumberLabel0
            // 
            this.NumberLabel0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumberLabel0.Font = new System.Drawing.Font("新細明體", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumberLabel0.Location = new System.Drawing.Point(48, 43);
            this.NumberLabel0.Name = "NumberLabel0";
            this.NumberLabel0.Size = new System.Drawing.Size(284, 62);
            this.NumberLabel0.TabIndex = 1;
            this.NumberLabel0.Text = "0   0   0   0";
            this.NumberLabel0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckNumberBox0
            // 
            this.CheckNumberBox0.Font = new System.Drawing.Font("新細明體", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CheckNumberBox0.Location = new System.Drawing.Point(56, 123);
            this.CheckNumberBox0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckNumberBox0.Name = "CheckNumberBox0";
            this.CheckNumberBox0.Size = new System.Drawing.Size(276, 64);
            this.CheckNumberBox0.TabIndex = 5;
            this.CheckNumberBox0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StatusLabel.Location = new System.Drawing.Point(43, 229);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(125, 60);
            this.StatusLabel.TabIndex = 9;
            this.StatusLabel.Text = "????";
            // 
            // CheckBotton
            // 
            this.CheckBotton.Location = new System.Drawing.Point(285, 345);
            this.CheckBotton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBotton.Name = "CheckBotton";
            this.CheckBotton.Size = new System.Drawing.Size(143, 72);
            this.CheckBotton.TabIndex = 10;
            this.CheckBotton.Text = "確認";
            this.CheckBotton.UseVisualStyleBackColor = true;
            this.CheckBotton.Click += new System.EventHandler(this.CheckBotton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 511);
            this.Controls.Add(this.CheckBotton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.CheckNumberBox0);
            this.Controls.Add(this.NumberLabel0);
            this.Controls.Add(this.GameStarButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GameStarButton;
        private System.Windows.Forms.Label NumberLabel0;
        private System.Windows.Forms.TextBox CheckNumberBox0;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button CheckBotton;
    }
}

