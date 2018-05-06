namespace PokemonUi
{
    partial class PokemonUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokemonUi));
            this.PokemonPictureBox = new System.Windows.Forms.PictureBox();
            this.CpLabel = new System.Windows.Forms.Label();
            this.PowerUpButton = new System.Windows.Forms.Button();
            this.PokemonCpLabel = new System.Windows.Forms.Label();
            this.PokemonNameLabel = new System.Windows.Forms.Label();
            this.HpLlabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.PokemonHpLabel = new System.Windows.Forms.Label();
            this.PokemonMaxHpLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.PokemonWeightLabel = new System.Windows.Forms.Label();
            this.PokemonHeightLlabel = new System.Windows.Forms.Label();
            this.PlayerStardustLabel = new System.Windows.Forms.Label();
            this.CandyLabel = new System.Windows.Forms.Label();
            this.StardustLabel = new System.Windows.Forms.Label();
            this.PlayerCandyLabel = new System.Windows.Forms.Label();
            this.CandyPictureBox1 = new System.Windows.Forms.PictureBox();
            this.StardustPictureBox1 = new System.Windows.Forms.PictureBox();
            this.StardustPictureBox2 = new System.Windows.Forms.PictureBox();
            this.CandyPictureBox2 = new System.Windows.Forms.PictureBox();
            this.PokemonPowerUpCandyLabel = new System.Windows.Forms.Label();
            this.PokemonPowerUpStardustLabel = new System.Windows.Forms.Label();
            this.EvolveButton = new System.Windows.Forms.Button();
            this.EvolvePictureBox = new System.Windows.Forms.PictureBox();
            this.PokemonEvolveCandyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CandyPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StardustPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StardustPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CandyPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EvolvePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PokemonPictureBox
            // 
            this.PokemonPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PokemonPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PokemonPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PokemonPictureBox.Image")));
            this.PokemonPictureBox.Location = new System.Drawing.Point(125, 42);
            this.PokemonPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.PokemonPictureBox.Name = "PokemonPictureBox";
            this.PokemonPictureBox.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.PokemonPictureBox.Size = new System.Drawing.Size(173, 153);
            this.PokemonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PokemonPictureBox.TabIndex = 0;
            this.PokemonPictureBox.TabStop = false;
            // 
            // CpLabel
            // 
            this.CpLabel.AutoSize = true;
            this.CpLabel.Location = new System.Drawing.Point(162, 18);
            this.CpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CpLabel.Name = "CpLabel";
            this.CpLabel.Size = new System.Drawing.Size(30, 20);
            this.CpLabel.TabIndex = 1;
            this.CpLabel.Text = "CP";
            // 
            // PowerUpButton
            // 
            this.PowerUpButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PowerUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PowerUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PowerUpButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerUpButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PowerUpButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PowerUpButton.Location = new System.Drawing.Point(43, 411);
            this.PowerUpButton.Margin = new System.Windows.Forms.Padding(4);
            this.PowerUpButton.Name = "PowerUpButton";
            this.PowerUpButton.Size = new System.Drawing.Size(158, 60);
            this.PowerUpButton.TabIndex = 2;
            this.PowerUpButton.Text = "POWER UP";
            this.PowerUpButton.UseVisualStyleBackColor = false;
            this.PowerUpButton.Click += new System.EventHandler(this.PowerUpButton_Click);
            // 
            // PokemonCpLabel
            // 
            this.PokemonCpLabel.AutoSize = true;
            this.PokemonCpLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PokemonCpLabel.Location = new System.Drawing.Point(200, 8);
            this.PokemonCpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PokemonCpLabel.Name = "PokemonCpLabel";
            this.PokemonCpLabel.Size = new System.Drawing.Size(55, 30);
            this.PokemonCpLabel.TabIndex = 3;
            this.PokemonCpLabel.Text = "133";
            // 
            // PokemonNameLabel
            // 
            this.PokemonNameLabel.AutoSize = true;
            this.PokemonNameLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokemonNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PokemonNameLabel.Location = new System.Drawing.Point(176, 183);
            this.PokemonNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PokemonNameLabel.Name = "PokemonNameLabel";
            this.PokemonNameLabel.Size = new System.Drawing.Size(73, 24);
            this.PokemonNameLabel.TabIndex = 4;
            this.PokemonNameLabel.Text = "小火龍";
            // 
            // HpLlabel
            // 
            this.HpLlabel.AutoSize = true;
            this.HpLlabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HpLlabel.Location = new System.Drawing.Point(148, 207);
            this.HpLlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HpLlabel.Name = "HpLlabel";
            this.HpLlabel.Size = new System.Drawing.Size(39, 25);
            this.HpLlabel.TabIndex = 5;
            this.HpLlabel.Text = "HP";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(221, 207);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(20, 25);
            this.label.TabIndex = 6;
            this.label.Text = "/";
            // 
            // PokemonHpLabel
            // 
            this.PokemonHpLabel.AutoSize = true;
            this.PokemonHpLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokemonHpLabel.Location = new System.Drawing.Point(187, 207);
            this.PokemonHpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PokemonHpLabel.Name = "PokemonHpLabel";
            this.PokemonHpLabel.Size = new System.Drawing.Size(36, 25);
            this.PokemonHpLabel.TabIndex = 7;
            this.PokemonHpLabel.Text = "30";
            // 
            // PokemonMaxHpLabel
            // 
            this.PokemonMaxHpLabel.AutoSize = true;
            this.PokemonMaxHpLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokemonMaxHpLabel.Location = new System.Drawing.Point(242, 207);
            this.PokemonMaxHpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PokemonMaxHpLabel.Name = "PokemonMaxHpLabel";
            this.PokemonMaxHpLabel.Size = new System.Drawing.Size(36, 25);
            this.PokemonMaxHpLabel.TabIndex = 8;
            this.PokemonMaxHpLabel.Text = "80";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.WeightLabel.Location = new System.Drawing.Point(96, 280);
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
            this.HeightLabel.Location = new System.Drawing.Point(249, 280);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(71, 24);
            this.HeightLabel.TabIndex = 11;
            this.HeightLabel.Text = "Height";
            // 
            // PokemonWeightLabel
            // 
            this.PokemonWeightLabel.AutoSize = true;
            this.PokemonWeightLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokemonWeightLabel.Location = new System.Drawing.Point(111, 246);
            this.PokemonWeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PokemonWeightLabel.Name = "PokemonWeightLabel";
            this.PokemonWeightLabel.Size = new System.Drawing.Size(36, 25);
            this.PokemonWeightLabel.TabIndex = 13;
            this.PokemonWeightLabel.Text = "80";
            // 
            // PokemonHeightLlabel
            // 
            this.PokemonHeightLlabel.AutoSize = true;
            this.PokemonHeightLlabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokemonHeightLlabel.Location = new System.Drawing.Point(262, 246);
            this.PokemonHeightLlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PokemonHeightLlabel.Name = "PokemonHeightLlabel";
            this.PokemonHeightLlabel.Size = new System.Drawing.Size(36, 25);
            this.PokemonHeightLlabel.TabIndex = 14;
            this.PokemonHeightLlabel.Text = "90";
            // 
            // PlayerStardustLabel
            // 
            this.PlayerStardustLabel.AutoSize = true;
            this.PlayerStardustLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerStardustLabel.Location = new System.Drawing.Point(111, 329);
            this.PlayerStardustLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerStardustLabel.Name = "PlayerStardustLabel";
            this.PlayerStardustLabel.Size = new System.Drawing.Size(60, 25);
            this.PlayerStardustLabel.TabIndex = 15;
            this.PlayerStardustLabel.Text = "1000";
            // 
            // CandyLabel
            // 
            this.CandyLabel.AutoSize = true;
            this.CandyLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CandyLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.CandyLabel.Location = new System.Drawing.Point(243, 361);
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
            this.StardustLabel.Location = new System.Drawing.Point(79, 361);
            this.StardustLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StardustLabel.Name = "StardustLabel";
            this.StardustLabel.Size = new System.Drawing.Size(113, 24);
            this.StardustLabel.TabIndex = 17;
            this.StardustLabel.Text = "STARDUST";
            // 
            // PlayerCandyLabel
            // 
            this.PlayerCandyLabel.AutoSize = true;
            this.PlayerCandyLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerCandyLabel.Location = new System.Drawing.Point(274, 331);
            this.PlayerCandyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerCandyLabel.Name = "PlayerCandyLabel";
            this.PlayerCandyLabel.Size = new System.Drawing.Size(36, 25);
            this.PlayerCandyLabel.TabIndex = 18;
            this.PlayerCandyLabel.Text = "29";
            // 
            // CandyPictureBox1
            // 
            this.CandyPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.CandyPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CandyPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("CandyPictureBox1.Image")));
            this.CandyPictureBox1.Location = new System.Drawing.Point(239, 320);
            this.CandyPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.CandyPictureBox1.Name = "CandyPictureBox1";
            this.CandyPictureBox1.Size = new System.Drawing.Size(27, 31);
            this.CandyPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CandyPictureBox1.TabIndex = 19;
            this.CandyPictureBox1.TabStop = false;
            this.CandyPictureBox1.Click += new System.EventHandler(this.CandyPictureBox1_Click);
            // 
            // StardustPictureBox1
            // 
            this.StardustPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.StardustPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StardustPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("StardustPictureBox1.Image")));
            this.StardustPictureBox1.Location = new System.Drawing.Point(83, 320);
            this.StardustPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.StardustPictureBox1.Name = "StardustPictureBox1";
            this.StardustPictureBox1.Size = new System.Drawing.Size(20, 37);
            this.StardustPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StardustPictureBox1.TabIndex = 20;
            this.StardustPictureBox1.TabStop = false;
            this.StardustPictureBox1.Click += new System.EventHandler(this.StardustPictureBox1_Click);
            // 
            // StardustPictureBox2
            // 
            this.StardustPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.StardustPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StardustPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("StardustPictureBox2.Image")));
            this.StardustPictureBox2.Location = new System.Drawing.Point(214, 419);
            this.StardustPictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.StardustPictureBox2.Name = "StardustPictureBox2";
            this.StardustPictureBox2.Size = new System.Drawing.Size(20, 37);
            this.StardustPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StardustPictureBox2.TabIndex = 24;
            this.StardustPictureBox2.TabStop = false;
            // 
            // CandyPictureBox2
            // 
            this.CandyPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.CandyPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CandyPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("CandyPictureBox2.Image")));
            this.CandyPictureBox2.Location = new System.Drawing.Point(324, 422);
            this.CandyPictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.CandyPictureBox2.Name = "CandyPictureBox2";
            this.CandyPictureBox2.Size = new System.Drawing.Size(27, 34);
            this.CandyPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CandyPictureBox2.TabIndex = 23;
            this.CandyPictureBox2.TabStop = false;
            // 
            // PokemonPowerUpCandyLabel
            // 
            this.PokemonPowerUpCandyLabel.AutoSize = true;
            this.PokemonPowerUpCandyLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokemonPowerUpCandyLabel.Location = new System.Drawing.Point(359, 428);
            this.PokemonPowerUpCandyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PokemonPowerUpCandyLabel.Name = "PokemonPowerUpCandyLabel";
            this.PokemonPowerUpCandyLabel.Size = new System.Drawing.Size(24, 25);
            this.PokemonPowerUpCandyLabel.TabIndex = 22;
            this.PokemonPowerUpCandyLabel.Text = "3";
            // 
            // PokemonPowerUpStardustLabel
            // 
            this.PokemonPowerUpStardustLabel.AutoSize = true;
            this.PokemonPowerUpStardustLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokemonPowerUpStardustLabel.Location = new System.Drawing.Point(242, 428);
            this.PokemonPowerUpStardustLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PokemonPowerUpStardustLabel.Name = "PokemonPowerUpStardustLabel";
            this.PokemonPowerUpStardustLabel.Size = new System.Drawing.Size(48, 25);
            this.PokemonPowerUpStardustLabel.TabIndex = 21;
            this.PokemonPowerUpStardustLabel.Text = "100";
            // 
            // EvolveButton
            // 
            this.EvolveButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.EvolveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EvolveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EvolveButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvolveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EvolveButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EvolveButton.Location = new System.Drawing.Point(43, 488);
            this.EvolveButton.Margin = new System.Windows.Forms.Padding(4);
            this.EvolveButton.Name = "EvolveButton";
            this.EvolveButton.Size = new System.Drawing.Size(158, 60);
            this.EvolveButton.TabIndex = 25;
            this.EvolveButton.Text = "EVOLVE";
            this.EvolveButton.UseVisualStyleBackColor = false;
            this.EvolveButton.Click += new System.EventHandler(this.EvolveButton_Click);
            // 
            // EvolvePictureBox
            // 
            this.EvolvePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.EvolvePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EvolvePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("EvolvePictureBox.Image")));
            this.EvolvePictureBox.Location = new System.Drawing.Point(324, 499);
            this.EvolvePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.EvolvePictureBox.Name = "EvolvePictureBox";
            this.EvolvePictureBox.Size = new System.Drawing.Size(27, 34);
            this.EvolvePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EvolvePictureBox.TabIndex = 27;
            this.EvolvePictureBox.TabStop = false;
            // 
            // PokemonEvolveCandyLabel
            // 
            this.PokemonEvolveCandyLabel.AutoSize = true;
            this.PokemonEvolveCandyLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokemonEvolveCandyLabel.Location = new System.Drawing.Point(359, 505);
            this.PokemonEvolveCandyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PokemonEvolveCandyLabel.Name = "PokemonEvolveCandyLabel";
            this.PokemonEvolveCandyLabel.Size = new System.Drawing.Size(36, 25);
            this.PokemonEvolveCandyLabel.TabIndex = 26;
            this.PokemonEvolveCandyLabel.Text = "30";
            // 
            // PokemonUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(424, 579);
            this.Controls.Add(this.EvolvePictureBox);
            this.Controls.Add(this.PokemonEvolveCandyLabel);
            this.Controls.Add(this.EvolveButton);
            this.Controls.Add(this.StardustPictureBox2);
            this.Controls.Add(this.CandyPictureBox2);
            this.Controls.Add(this.PokemonPowerUpCandyLabel);
            this.Controls.Add(this.PokemonPowerUpStardustLabel);
            this.Controls.Add(this.StardustPictureBox1);
            this.Controls.Add(this.CandyPictureBox1);
            this.Controls.Add(this.PlayerCandyLabel);
            this.Controls.Add(this.StardustLabel);
            this.Controls.Add(this.CandyLabel);
            this.Controls.Add(this.PlayerStardustLabel);
            this.Controls.Add(this.PokemonHeightLlabel);
            this.Controls.Add(this.PokemonWeightLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.PokemonMaxHpLabel);
            this.Controls.Add(this.PokemonHpLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.HpLlabel);
            this.Controls.Add(this.PokemonNameLabel);
            this.Controls.Add(this.PokemonCpLabel);
            this.Controls.Add(this.PowerUpButton);
            this.Controls.Add(this.CpLabel);
            this.Controls.Add(this.PokemonPictureBox);
            this.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PokemonUi";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CandyPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StardustPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StardustPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CandyPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EvolvePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PokemonPictureBox;
        private System.Windows.Forms.Label CpLabel;
        private System.Windows.Forms.Button PowerUpButton;
        private System.Windows.Forms.Label PokemonCpLabel;
        private System.Windows.Forms.Label PokemonNameLabel;
        private System.Windows.Forms.Label HpLlabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label PokemonHpLabel;
        private System.Windows.Forms.Label PokemonMaxHpLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label PokemonWeightLabel;
        private System.Windows.Forms.Label PokemonHeightLlabel;
        private System.Windows.Forms.Label PlayerStardustLabel;
        private System.Windows.Forms.Label CandyLabel;
        private System.Windows.Forms.Label StardustLabel;
        private System.Windows.Forms.Label PlayerCandyLabel;
        private System.Windows.Forms.PictureBox CandyPictureBox1;
        private System.Windows.Forms.PictureBox StardustPictureBox1;
        private System.Windows.Forms.PictureBox StardustPictureBox2;
        private System.Windows.Forms.PictureBox CandyPictureBox2;
        private System.Windows.Forms.Label PokemonPowerUpCandyLabel;
        private System.Windows.Forms.Label PokemonPowerUpStardustLabel;
        private System.Windows.Forms.Button EvolveButton;
        private System.Windows.Forms.PictureBox EvolvePictureBox;
        private System.Windows.Forms.Label PokemonEvolveCandyLabel;
    }
}

