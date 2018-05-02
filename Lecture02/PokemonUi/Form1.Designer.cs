namespace PokemonUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CpLabel = new System.Windows.Forms.Label();
            this.PowerUpButton = new System.Windows.Forms.Button();
            this.PokemonCpLabel = new System.Windows.Forms.Label();
            this.PokemonName = new System.Windows.Forms.Label();
            this.HpLlabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.PokemonHpLabel = new System.Windows.Forms.Label();
            this.PokemonMaxHpLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.PokemonType = new System.Windows.Forms.Label();
            this.PokemonWeightLabel = new System.Windows.Forms.Label();
            this.PokemonHeightLlabel = new System.Windows.Forms.Label();
            this.PlayerStardustLabel = new System.Windows.Forms.Label();
            this.CandyLabel = new System.Windows.Forms.Label();
            this.StardustLabel = new System.Windows.Forms.Label();
            this.PlayerCandyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(152, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CpLabel
            // 
            this.CpLabel.AutoSize = true;
            this.CpLabel.Location = new System.Drawing.Point(171, 16);
            this.CpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CpLabel.Name = "CpLabel";
            this.CpLabel.Size = new System.Drawing.Size(30, 20);
            this.CpLabel.TabIndex = 1;
            this.CpLabel.Text = "CP";
            // 
            // PowerUpButton
            // 
            this.PowerUpButton.BackColor = System.Drawing.Color.LightGreen;
            this.PowerUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PowerUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PowerUpButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerUpButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.PowerUpButton.Location = new System.Drawing.Point(42, 429);
            this.PowerUpButton.Margin = new System.Windows.Forms.Padding(4);
            this.PowerUpButton.Name = "PowerUpButton";
            this.PowerUpButton.Size = new System.Drawing.Size(181, 68);
            this.PowerUpButton.TabIndex = 2;
            this.PowerUpButton.Text = "POWER UP";
            this.PowerUpButton.UseVisualStyleBackColor = false;
            this.PowerUpButton.Click += new System.EventHandler(this.PowerUpButton_Click);
            // 
            // PokemonCpLabel
            // 
            this.PokemonCpLabel.AutoSize = true;
            this.PokemonCpLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PokemonCpLabel.Location = new System.Drawing.Point(209, 16);
            this.PokemonCpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PokemonCpLabel.Name = "PokemonCpLabel";
            this.PokemonCpLabel.Size = new System.Drawing.Size(36, 20);
            this.PokemonCpLabel.TabIndex = 3;
            this.PokemonCpLabel.Text = "133";
            // 
            // PokemonName
            // 
            this.PokemonName.AutoSize = true;
            this.PokemonName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokemonName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PokemonName.Location = new System.Drawing.Point(191, 181);
            this.PokemonName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PokemonName.Name = "PokemonName";
            this.PokemonName.Size = new System.Drawing.Size(73, 24);
            this.PokemonName.TabIndex = 4;
            this.PokemonName.Text = "小火龍";
            // 
            // HpLlabel
            // 
            this.HpLlabel.AutoSize = true;
            this.HpLlabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HpLlabel.Location = new System.Drawing.Point(168, 205);
            this.HpLlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HpLlabel.Name = "HpLlabel";
            this.HpLlabel.Size = new System.Drawing.Size(33, 20);
            this.HpLlabel.TabIndex = 5;
            this.HpLlabel.Text = "HP";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(241, 205);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(17, 20);
            this.label.TabIndex = 6;
            this.label.Text = "/";
            // 
            // PokemonHpLabel
            // 
            this.PokemonHpLabel.AutoSize = true;
            this.PokemonHpLabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokemonHpLabel.Location = new System.Drawing.Point(207, 205);
            this.PokemonHpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PokemonHpLabel.Name = "PokemonHpLabel";
            this.PokemonHpLabel.Size = new System.Drawing.Size(28, 20);
            this.PokemonHpLabel.TabIndex = 7;
            this.PokemonHpLabel.Text = "30";
            // 
            // PokemonMaxHpLabel
            // 
            this.PokemonMaxHpLabel.AutoSize = true;
            this.PokemonMaxHpLabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokemonMaxHpLabel.Location = new System.Drawing.Point(262, 205);
            this.PokemonMaxHpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PokemonMaxHpLabel.Name = "PokemonMaxHpLabel";
            this.PokemonMaxHpLabel.Size = new System.Drawing.Size(29, 20);
            this.PokemonMaxHpLabel.TabIndex = 8;
            this.PokemonMaxHpLabel.Text = "80";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TypeLabel.Location = new System.Drawing.Point(76, 293);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(53, 24);
            this.TypeLabel.TabIndex = 9;
            this.TypeLabel.Text = "Type";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.WeightLabel.Location = new System.Drawing.Point(219, 293);
            this.WeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(75, 24);
            this.WeightLabel.TabIndex = 10;
            this.WeightLabel.Text = "Weight";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.HeightLabel.Location = new System.Drawing.Point(340, 293);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(71, 24);
            this.HeightLabel.TabIndex = 11;
            this.HeightLabel.Text = "Height";
            // 
            // PokemonType
            // 
            this.PokemonType.AutoSize = true;
            this.PokemonType.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokemonType.Location = new System.Drawing.Point(58, 248);
            this.PokemonType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PokemonType.Name = "PokemonType";
            this.PokemonType.Size = new System.Drawing.Size(116, 20);
            this.PokemonType.TabIndex = 12;
            this.PokemonType.Text = "PokemonType";
            // 
            // PokemonWeightLabel
            // 
            this.PokemonWeightLabel.AutoSize = true;
            this.PokemonWeightLabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokemonWeightLabel.Location = new System.Drawing.Point(244, 248);
            this.PokemonWeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PokemonWeightLabel.Name = "PokemonWeightLabel";
            this.PokemonWeightLabel.Size = new System.Drawing.Size(29, 20);
            this.PokemonWeightLabel.TabIndex = 13;
            this.PokemonWeightLabel.Text = "80";
            // 
            // PokemonHeightLlabel
            // 
            this.PokemonHeightLlabel.AutoSize = true;
            this.PokemonHeightLlabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokemonHeightLlabel.Location = new System.Drawing.Point(357, 248);
            this.PokemonHeightLlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PokemonHeightLlabel.Name = "PokemonHeightLlabel";
            this.PokemonHeightLlabel.Size = new System.Drawing.Size(29, 20);
            this.PokemonHeightLlabel.TabIndex = 14;
            this.PokemonHeightLlabel.Text = "90";
            // 
            // PlayerStardustLabel
            // 
            this.PlayerStardustLabel.AutoSize = true;
            this.PlayerStardustLabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerStardustLabel.Location = new System.Drawing.Point(139, 336);
            this.PlayerStardustLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerStardustLabel.Name = "PlayerStardustLabel";
            this.PlayerStardustLabel.Size = new System.Drawing.Size(46, 20);
            this.PlayerStardustLabel.TabIndex = 15;
            this.PlayerStardustLabel.Text = "1000";
            // 
            // CandyLabel
            // 
            this.CandyLabel.AutoSize = true;
            this.CandyLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CandyLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.CandyLabel.Location = new System.Drawing.Point(333, 368);
            this.CandyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CandyLabel.Name = "CandyLabel";
            this.CandyLabel.Size = new System.Drawing.Size(78, 24);
            this.CandyLabel.TabIndex = 16;
            this.CandyLabel.Text = "CANDY";
            // 
            // StardustLabel
            // 
            this.StardustLabel.AutoSize = true;
            this.StardustLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StardustLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.StardustLabel.Location = new System.Drawing.Point(107, 368);
            this.StardustLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StardustLabel.Name = "StardustLabel";
            this.StardustLabel.Size = new System.Drawing.Size(113, 24);
            this.StardustLabel.TabIndex = 17;
            this.StardustLabel.Text = "STARDUST";
            // 
            // PlayerCandyLabel
            // 
            this.PlayerCandyLabel.AutoSize = true;
            this.PlayerCandyLabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerCandyLabel.Location = new System.Drawing.Point(359, 336);
            this.PlayerCandyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerCandyLabel.Name = "PlayerCandyLabel";
            this.PlayerCandyLabel.Size = new System.Drawing.Size(28, 20);
            this.PlayerCandyLabel.TabIndex = 18;
            this.PlayerCandyLabel.Text = "50";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 579);
            this.Controls.Add(this.PlayerCandyLabel);
            this.Controls.Add(this.StardustLabel);
            this.Controls.Add(this.CandyLabel);
            this.Controls.Add(this.PlayerStardustLabel);
            this.Controls.Add(this.PokemonHeightLlabel);
            this.Controls.Add(this.PokemonWeightLabel);
            this.Controls.Add(this.PokemonType);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.PokemonMaxHpLabel);
            this.Controls.Add(this.PokemonHpLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.HpLlabel);
            this.Controls.Add(this.PokemonName);
            this.Controls.Add(this.PokemonCpLabel);
            this.Controls.Add(this.PowerUpButton);
            this.Controls.Add(this.CpLabel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CpLabel;
        private System.Windows.Forms.Button PowerUpButton;
        private System.Windows.Forms.Label PokemonCpLabel;
        private System.Windows.Forms.Label PokemonName;
        private System.Windows.Forms.Label HpLlabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label PokemonHpLabel;
        private System.Windows.Forms.Label PokemonMaxHpLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label PokemonType;
        private System.Windows.Forms.Label PokemonWeightLabel;
        private System.Windows.Forms.Label PokemonHeightLlabel;
        private System.Windows.Forms.Label PlayerStardustLabel;
        private System.Windows.Forms.Label CandyLabel;
        private System.Windows.Forms.Label StardustLabel;
        private System.Windows.Forms.Label PlayerCandyLabel;
    }
}

