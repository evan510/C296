namespace GuessNumber
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
            this.guessNumberLabel = new System.Windows.Forms.Label();
            this.chuckNumberButton = new System.Windows.Forms.Button();
            this.AnswerButton = new System.Windows.Forms.Button();
            this.inputNumberTextBox = new System.Windows.Forms.TextBox();
            this.RestarButton = new System.Windows.Forms.Button();
            this.guessListLabel = new System.Windows.Forms.Label();
            this.howToPlayLabel = new System.Windows.Forms.Label();
            this.howToPlayLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guessNumberLabel
            // 
            this.guessNumberLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.guessNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.guessNumberLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.guessNumberLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guessNumberLabel.Location = new System.Drawing.Point(28, 61);
            this.guessNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.guessNumberLabel.Name = "guessNumberLabel";
            this.guessNumberLabel.Size = new System.Drawing.Size(204, 35);
            this.guessNumberLabel.TabIndex = 0;
            this.guessNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chuckNumberButton
            // 
            this.chuckNumberButton.BackColor = System.Drawing.Color.Teal;
            this.chuckNumberButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chuckNumberButton.FlatAppearance.BorderSize = 3;
            this.chuckNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chuckNumberButton.ForeColor = System.Drawing.Color.Transparent;
            this.chuckNumberButton.Location = new System.Drawing.Point(258, 120);
            this.chuckNumberButton.Name = "chuckNumberButton";
            this.chuckNumberButton.Size = new System.Drawing.Size(188, 83);
            this.chuckNumberButton.TabIndex = 1;
            this.chuckNumberButton.Text = "猜數字";
            this.chuckNumberButton.UseVisualStyleBackColor = false;
            this.chuckNumberButton.Click += new System.EventHandler(this.chuckNumberButton_Click);
            // 
            // AnswerButton
            // 
            this.AnswerButton.BackColor = System.Drawing.Color.Teal;
            this.AnswerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AnswerButton.FlatAppearance.BorderSize = 3;
            this.AnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerButton.ForeColor = System.Drawing.Color.Transparent;
            this.AnswerButton.Location = new System.Drawing.Point(258, 232);
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.Size = new System.Drawing.Size(188, 83);
            this.AnswerButton.TabIndex = 2;
            this.AnswerButton.Text = "看答案";
            this.AnswerButton.UseVisualStyleBackColor = false;
            this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // inputNumberTextBox
            // 
            this.inputNumberTextBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.inputNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputNumberTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.inputNumberTextBox.Location = new System.Drawing.Point(258, 61);
            this.inputNumberTextBox.Multiline = true;
            this.inputNumberTextBox.Name = "inputNumberTextBox";
            this.inputNumberTextBox.Size = new System.Drawing.Size(188, 35);
            this.inputNumberTextBox.TabIndex = 3;
            this.inputNumberTextBox.Tag = "請輸入一位數字";
            this.inputNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputNumberBox_KeyDown);
            // 
            // RestarButton
            // 
            this.RestarButton.BackColor = System.Drawing.Color.Teal;
            this.RestarButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RestarButton.FlatAppearance.BorderSize = 3;
            this.RestarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestarButton.ForeColor = System.Drawing.Color.Transparent;
            this.RestarButton.Location = new System.Drawing.Point(258, 346);
            this.RestarButton.Name = "RestarButton";
            this.RestarButton.Size = new System.Drawing.Size(188, 83);
            this.RestarButton.TabIndex = 4;
            this.RestarButton.Text = "重新開始";
            this.RestarButton.UseVisualStyleBackColor = false;
            this.RestarButton.Click += new System.EventHandler(this.RestarButton_Click);
            // 
            // guessListLabel
            // 
            this.guessListLabel.BackColor = System.Drawing.Color.CadetBlue;
            this.guessListLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guessListLabel.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.guessListLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guessListLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guessListLabel.Location = new System.Drawing.Point(28, 120);
            this.guessListLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.guessListLabel.Name = "guessListLabel";
            this.guessListLabel.Size = new System.Drawing.Size(204, 309);
            this.guessListLabel.TabIndex = 5;
            this.guessListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // howToPlayLabel
            // 
            this.howToPlayLabel.AutoSize = true;
            this.howToPlayLabel.Location = new System.Drawing.Point(258, 21);
            this.howToPlayLabel.Name = "howToPlayLabel";
            this.howToPlayLabel.Size = new System.Drawing.Size(155, 35);
            this.howToPlayLabel.TabIndex = 6;
            this.howToPlayLabel.Text = "請輸入數字";
            // 
            // howToPlayLabel2
            // 
            this.howToPlayLabel2.AutoSize = true;
            this.howToPlayLabel2.Location = new System.Drawing.Point(22, 21);
            this.howToPlayLabel2.Name = "howToPlayLabel2";
            this.howToPlayLabel2.Size = new System.Drawing.Size(99, 35);
            this.howToPlayLabel2.TabIndex = 7;
            this.howToPlayLabel2.Text = "正解：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(475, 462);
            this.Controls.Add(this.howToPlayLabel2);
            this.Controls.Add(this.howToPlayLabel);
            this.Controls.Add(this.guessListLabel);
            this.Controls.Add(this.RestarButton);
            this.Controls.Add(this.inputNumberTextBox);
            this.Controls.Add(this.AnswerButton);
            this.Controls.Add(this.chuckNumberButton);
            this.Controls.Add(this.guessNumberLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label guessNumberLabel;
        private System.Windows.Forms.Button chuckNumberButton;
        private System.Windows.Forms.Button AnswerButton;
        private System.Windows.Forms.TextBox inputNumberTextBox;
        private System.Windows.Forms.Button RestarButton;
        private System.Windows.Forms.Label guessListLabel;
        private System.Windows.Forms.Label howToPlayLabel;
        private System.Windows.Forms.Label howToPlayLabel2;
    }
}

