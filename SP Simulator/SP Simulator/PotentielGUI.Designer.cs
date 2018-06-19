namespace SP_Simulator
{
    partial class PotentielGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PotentielGUI));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.AttaqueLabel = new System.Windows.Forms.Label();
            this.DefenseLabel = new System.Windows.Forms.Label();
            this.ElementLabel = new System.Windows.Forms.Label();
            this.HpLabel = new System.Windows.Forms.Label();
            this.ResFeuLabel = new System.Windows.Forms.Label();
            this.ResEauLabel = new System.Windows.Forms.Label();
            this.ResLumLabel = new System.Windows.Forms.Label();
            this.ResObsLabel = new System.Windows.Forms.Label();
            this.SPNameLabel = new System.Windows.Forms.Label();
            this.BonusLabel = new System.Windows.Forms.Label();
            this.BonusAttaqueLabel = new System.Windows.Forms.Label();
            this.BonusPrecisionLabel = new System.Windows.Forms.Label();
            this.BonusElementLabel = new System.Windows.Forms.Label();
            this.BonusEsquiveLabel = new System.Windows.Forms.Label();
            this.BonusHpLabel = new System.Windows.Forms.Label();
            this.BonusMpLabel = new System.Windows.Forms.Label();
            this.BonusChanceCCLabel = new System.Windows.Forms.Label();
            this.BonusDegatsCCLabel = new System.Windows.Forms.Label();
            this.BonusAllDefLabel = new System.Windows.Forms.Label();
            this.BonusDimChCCLabel = new System.Windows.Forms.Label();
            this.BonusDimDegatCCLabel = new System.Windows.Forms.Label();
            this.BonusToutElement = new System.Windows.Forms.Label();
            this.BonusDimDegatsMagiques = new System.Windows.Forms.Label();
            this.BonusFéeLabel = new System.Windows.Forms.Label();
            this.PotentielLabel = new System.Windows.Forms.Label();
            this.ConseilsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.TitleLabel.Location = new System.Drawing.Point(35, 32);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(210, 20);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Aperçu du potentiel de la SP";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Location = new System.Drawing.Point(266, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(21, 20);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AttaqueLabel
            // 
            this.AttaqueLabel.AutoSize = true;
            this.AttaqueLabel.BackColor = System.Drawing.Color.Transparent;
            this.AttaqueLabel.ForeColor = System.Drawing.Color.Red;
            this.AttaqueLabel.Location = new System.Drawing.Point(23, 95);
            this.AttaqueLabel.Name = "AttaqueLabel";
            this.AttaqueLabel.Size = new System.Drawing.Size(50, 13);
            this.AttaqueLabel.TabIndex = 2;
            this.AttaqueLabel.Text = "Attaque: ";
            // 
            // DefenseLabel
            // 
            this.DefenseLabel.AutoSize = true;
            this.DefenseLabel.BackColor = System.Drawing.Color.Transparent;
            this.DefenseLabel.ForeColor = System.Drawing.Color.Red;
            this.DefenseLabel.Location = new System.Drawing.Point(23, 120);
            this.DefenseLabel.Name = "DefenseLabel";
            this.DefenseLabel.Size = new System.Drawing.Size(53, 13);
            this.DefenseLabel.TabIndex = 3;
            this.DefenseLabel.Text = "Défense: ";
            // 
            // ElementLabel
            // 
            this.ElementLabel.AutoSize = true;
            this.ElementLabel.BackColor = System.Drawing.Color.Transparent;
            this.ElementLabel.ForeColor = System.Drawing.Color.Red;
            this.ElementLabel.Location = new System.Drawing.Point(23, 147);
            this.ElementLabel.Name = "ElementLabel";
            this.ElementLabel.Size = new System.Drawing.Size(51, 13);
            this.ElementLabel.TabIndex = 4;
            this.ElementLabel.Text = "Elément: ";
            // 
            // HpLabel
            // 
            this.HpLabel.AutoSize = true;
            this.HpLabel.BackColor = System.Drawing.Color.Transparent;
            this.HpLabel.ForeColor = System.Drawing.Color.Red;
            this.HpLabel.Location = new System.Drawing.Point(23, 176);
            this.HpLabel.Name = "HpLabel";
            this.HpLabel.Size = new System.Drawing.Size(49, 13);
            this.HpLabel.TabIndex = 5;
            this.HpLabel.Text = "HP/MP: ";
            // 
            // ResFeuLabel
            // 
            this.ResFeuLabel.AutoSize = true;
            this.ResFeuLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResFeuLabel.ForeColor = System.Drawing.Color.Red;
            this.ResFeuLabel.Location = new System.Drawing.Point(23, 206);
            this.ResFeuLabel.Name = "ResFeuLabel";
            this.ResFeuLabel.Size = new System.Drawing.Size(87, 13);
            this.ResFeuLabel.TabIndex = 6;
            this.ResFeuLabel.Text = "Résistance Feu: ";
            // 
            // ResEauLabel
            // 
            this.ResEauLabel.AutoSize = true;
            this.ResEauLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResEauLabel.ForeColor = System.Drawing.Color.Red;
            this.ResEauLabel.Location = new System.Drawing.Point(23, 233);
            this.ResEauLabel.Name = "ResEauLabel";
            this.ResEauLabel.Size = new System.Drawing.Size(88, 13);
            this.ResEauLabel.TabIndex = 7;
            this.ResEauLabel.Text = "Résistance Eau: ";
            // 
            // ResLumLabel
            // 
            this.ResLumLabel.AutoSize = true;
            this.ResLumLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResLumLabel.ForeColor = System.Drawing.Color.Red;
            this.ResLumLabel.Location = new System.Drawing.Point(23, 261);
            this.ResLumLabel.Name = "ResLumLabel";
            this.ResLumLabel.Size = new System.Drawing.Size(106, 13);
            this.ResLumLabel.TabIndex = 8;
            this.ResLumLabel.Text = "Résistance Lumière: ";
            // 
            // ResObsLabel
            // 
            this.ResObsLabel.AutoSize = true;
            this.ResObsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResObsLabel.ForeColor = System.Drawing.Color.Red;
            this.ResObsLabel.Location = new System.Drawing.Point(23, 287);
            this.ResObsLabel.Name = "ResObsLabel";
            this.ResObsLabel.Size = new System.Drawing.Size(114, 13);
            this.ResObsLabel.TabIndex = 9;
            this.ResObsLabel.Text = "Résistance Obscurité: ";
            // 
            // SPNameLabel
            // 
            this.SPNameLabel.AutoSize = true;
            this.SPNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.SPNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPNameLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.SPNameLabel.Location = new System.Drawing.Point(72, 61);
            this.SPNameLabel.Name = "SPNameLabel";
            this.SPNameLabel.Size = new System.Drawing.Size(57, 15);
            this.SPNameLabel.TabIndex = 10;
            this.SPNameLabel.Text = "SPName";
            // 
            // BonusLabel
            // 
            this.BonusLabel.AutoSize = true;
            this.BonusLabel.BackColor = System.Drawing.Color.Transparent;
            this.BonusLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.BonusLabel.Location = new System.Drawing.Point(26, 324);
            this.BonusLabel.Name = "BonusLabel";
            this.BonusLabel.Size = new System.Drawing.Size(40, 13);
            this.BonusLabel.TabIndex = 11;
            this.BonusLabel.Text = "Bonus:";
            // 
            // BonusAttaqueLabel
            // 
            this.BonusAttaqueLabel.AutoSize = true;
            this.BonusAttaqueLabel.BackColor = System.Drawing.Color.Transparent;
            this.BonusAttaqueLabel.ForeColor = System.Drawing.Color.Lime;
            this.BonusAttaqueLabel.Location = new System.Drawing.Point(26, 354);
            this.BonusAttaqueLabel.Name = "BonusAttaqueLabel";
            this.BonusAttaqueLabel.Size = new System.Drawing.Size(50, 13);
            this.BonusAttaqueLabel.TabIndex = 12;
            this.BonusAttaqueLabel.Text = "Attaque: ";
            // 
            // BonusPrecisionLabel
            // 
            this.BonusPrecisionLabel.AutoSize = true;
            this.BonusPrecisionLabel.BackColor = System.Drawing.Color.Transparent;
            this.BonusPrecisionLabel.ForeColor = System.Drawing.Color.Lime;
            this.BonusPrecisionLabel.Location = new System.Drawing.Point(26, 379);
            this.BonusPrecisionLabel.Name = "BonusPrecisionLabel";
            this.BonusPrecisionLabel.Size = new System.Drawing.Size(56, 13);
            this.BonusPrecisionLabel.TabIndex = 13;
            this.BonusPrecisionLabel.Text = "Précision: ";
            // 
            // BonusElementLabel
            // 
            this.BonusElementLabel.AutoSize = true;
            this.BonusElementLabel.BackColor = System.Drawing.Color.Transparent;
            this.BonusElementLabel.ForeColor = System.Drawing.Color.Lime;
            this.BonusElementLabel.Location = new System.Drawing.Point(26, 430);
            this.BonusElementLabel.Name = "BonusElementLabel";
            this.BonusElementLabel.Size = new System.Drawing.Size(51, 13);
            this.BonusElementLabel.TabIndex = 14;
            this.BonusElementLabel.Text = "Elément: ";
            // 
            // BonusEsquiveLabel
            // 
            this.BonusEsquiveLabel.AutoSize = true;
            this.BonusEsquiveLabel.BackColor = System.Drawing.Color.Transparent;
            this.BonusEsquiveLabel.ForeColor = System.Drawing.Color.Lime;
            this.BonusEsquiveLabel.Location = new System.Drawing.Point(26, 404);
            this.BonusEsquiveLabel.Name = "BonusEsquiveLabel";
            this.BonusEsquiveLabel.Size = new System.Drawing.Size(51, 13);
            this.BonusEsquiveLabel.TabIndex = 15;
            this.BonusEsquiveLabel.Text = "Esquive: ";
            // 
            // BonusHpLabel
            // 
            this.BonusHpLabel.AutoSize = true;
            this.BonusHpLabel.BackColor = System.Drawing.Color.Transparent;
            this.BonusHpLabel.ForeColor = System.Drawing.Color.Lime;
            this.BonusHpLabel.Location = new System.Drawing.Point(26, 456);
            this.BonusHpLabel.Name = "BonusHpLabel";
            this.BonusHpLabel.Size = new System.Drawing.Size(28, 13);
            this.BonusHpLabel.TabIndex = 16;
            this.BonusHpLabel.Text = "HP: ";
            // 
            // BonusMpLabel
            // 
            this.BonusMpLabel.AutoSize = true;
            this.BonusMpLabel.BackColor = System.Drawing.Color.Transparent;
            this.BonusMpLabel.ForeColor = System.Drawing.Color.Lime;
            this.BonusMpLabel.Location = new System.Drawing.Point(26, 483);
            this.BonusMpLabel.Name = "BonusMpLabel";
            this.BonusMpLabel.Size = new System.Drawing.Size(29, 13);
            this.BonusMpLabel.TabIndex = 17;
            this.BonusMpLabel.Text = "MP: ";
            // 
            // BonusChanceCCLabel
            // 
            this.BonusChanceCCLabel.AutoSize = true;
            this.BonusChanceCCLabel.BackColor = System.Drawing.Color.Transparent;
            this.BonusChanceCCLabel.ForeColor = System.Drawing.Color.Lime;
            this.BonusChanceCCLabel.Location = new System.Drawing.Point(136, 354);
            this.BonusChanceCCLabel.Name = "BonusChanceCCLabel";
            this.BonusChanceCCLabel.Size = new System.Drawing.Size(88, 13);
            this.BonusChanceCCLabel.TabIndex = 18;
            this.BonusChanceCCLabel.Text = "Chance Critique: ";
            // 
            // BonusDegatsCCLabel
            // 
            this.BonusDegatsCCLabel.AutoSize = true;
            this.BonusDegatsCCLabel.BackColor = System.Drawing.Color.Transparent;
            this.BonusDegatsCCLabel.ForeColor = System.Drawing.Color.Lime;
            this.BonusDegatsCCLabel.Location = new System.Drawing.Point(136, 379);
            this.BonusDegatsCCLabel.Name = "BonusDegatsCCLabel";
            this.BonusDegatsCCLabel.Size = new System.Drawing.Size(85, 13);
            this.BonusDegatsCCLabel.TabIndex = 19;
            this.BonusDegatsCCLabel.Text = "Dégats Critique: ";
            // 
            // BonusAllDefLabel
            // 
            this.BonusAllDefLabel.AutoSize = true;
            this.BonusAllDefLabel.BackColor = System.Drawing.Color.Transparent;
            this.BonusAllDefLabel.ForeColor = System.Drawing.Color.Lime;
            this.BonusAllDefLabel.Location = new System.Drawing.Point(136, 404);
            this.BonusAllDefLabel.Name = "BonusAllDefLabel";
            this.BonusAllDefLabel.Size = new System.Drawing.Size(82, 13);
            this.BonusAllDefLabel.TabIndex = 20;
            this.BonusAllDefLabel.Text = "Toute défense: ";
            // 
            // BonusDimChCCLabel
            // 
            this.BonusDimChCCLabel.AutoSize = true;
            this.BonusDimChCCLabel.BackColor = System.Drawing.Color.Transparent;
            this.BonusDimChCCLabel.ForeColor = System.Drawing.Color.Lime;
            this.BonusDimChCCLabel.Location = new System.Drawing.Point(135, 430);
            this.BonusDimChCCLabel.Name = "BonusDimChCCLabel";
            this.BonusDimChCCLabel.Size = new System.Drawing.Size(98, 13);
            this.BonusDimChCCLabel.TabIndex = 21;
            this.BonusDimChCCLabel.Text = "Réd. Ch. Critiques: ";
            // 
            // BonusDimDegatCCLabel
            // 
            this.BonusDimDegatCCLabel.AutoSize = true;
            this.BonusDimDegatCCLabel.BackColor = System.Drawing.Color.Transparent;
            this.BonusDimDegatCCLabel.ForeColor = System.Drawing.Color.Lime;
            this.BonusDimDegatCCLabel.Location = new System.Drawing.Point(135, 456);
            this.BonusDimDegatCCLabel.Name = "BonusDimDegatCCLabel";
            this.BonusDimDegatCCLabel.Size = new System.Drawing.Size(74, 13);
            this.BonusDimDegatCCLabel.TabIndex = 22;
            this.BonusDimDegatCCLabel.Text = "Réd. Critique: ";
            // 
            // BonusToutElement
            // 
            this.BonusToutElement.AutoSize = true;
            this.BonusToutElement.BackColor = System.Drawing.Color.Transparent;
            this.BonusToutElement.ForeColor = System.Drawing.Color.Lime;
            this.BonusToutElement.Location = new System.Drawing.Point(135, 483);
            this.BonusToutElement.Name = "BonusToutElement";
            this.BonusToutElement.Size = new System.Drawing.Size(107, 13);
            this.BonusToutElement.TabIndex = 23;
            this.BonusToutElement.Text = "Toutes Résistances: ";
            // 
            // BonusDimDegatsMagiques
            // 
            this.BonusDimDegatsMagiques.AutoSize = true;
            this.BonusDimDegatsMagiques.BackColor = System.Drawing.Color.Transparent;
            this.BonusDimDegatsMagiques.ForeColor = System.Drawing.Color.Lime;
            this.BonusDimDegatsMagiques.Location = new System.Drawing.Point(26, 507);
            this.BonusDimDegatsMagiques.Name = "BonusDimDegatsMagiques";
            this.BonusDimDegatsMagiques.Size = new System.Drawing.Size(122, 13);
            this.BonusDimDegatsMagiques.TabIndex = 24;
            this.BonusDimDegatsMagiques.Text = "Réd. Dégats Magiques: ";
            // 
            // BonusFéeLabel
            // 
            this.BonusFéeLabel.AutoSize = true;
            this.BonusFéeLabel.BackColor = System.Drawing.Color.Transparent;
            this.BonusFéeLabel.ForeColor = System.Drawing.Color.Lime;
            this.BonusFéeLabel.Location = new System.Drawing.Point(26, 532);
            this.BonusFéeLabel.Name = "BonusFéeLabel";
            this.BonusFéeLabel.Size = new System.Drawing.Size(31, 13);
            this.BonusFéeLabel.TabIndex = 25;
            this.BonusFéeLabel.Text = "Fée: ";
            // 
            // PotentielLabel
            // 
            this.PotentielLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PotentielLabel.AutoSize = true;
            this.PotentielLabel.BackColor = System.Drawing.Color.Transparent;
            this.PotentielLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.PotentielLabel.Location = new System.Drawing.Point(26, 585);
            this.PotentielLabel.Name = "PotentielLabel";
            this.PotentielLabel.Size = new System.Drawing.Size(70, 13);
            this.PotentielLabel.TabIndex = 26;
            this.PotentielLabel.Text = "ConseilsBody";
            this.PotentielLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PotentielLabel.Click += new System.EventHandler(this.PotentielLabel_Click);
            // 
            // ConseilsLabel
            // 
            this.ConseilsLabel.AutoSize = true;
            this.ConseilsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConseilsLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ConseilsLabel.Location = new System.Drawing.Point(26, 562);
            this.ConseilsLabel.Name = "ConseilsLabel";
            this.ConseilsLabel.Size = new System.Drawing.Size(49, 13);
            this.ConseilsLabel.TabIndex = 27;
            this.ConseilsLabel.Text = "Conseils:";
            // 
            // PotentielGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(290, 740);
            this.Controls.Add(this.ConseilsLabel);
            this.Controls.Add(this.PotentielLabel);
            this.Controls.Add(this.BonusFéeLabel);
            this.Controls.Add(this.BonusDimDegatsMagiques);
            this.Controls.Add(this.BonusToutElement);
            this.Controls.Add(this.BonusDimDegatCCLabel);
            this.Controls.Add(this.BonusDimChCCLabel);
            this.Controls.Add(this.BonusAllDefLabel);
            this.Controls.Add(this.BonusDegatsCCLabel);
            this.Controls.Add(this.BonusChanceCCLabel);
            this.Controls.Add(this.BonusMpLabel);
            this.Controls.Add(this.BonusHpLabel);
            this.Controls.Add(this.BonusEsquiveLabel);
            this.Controls.Add(this.BonusElementLabel);
            this.Controls.Add(this.BonusPrecisionLabel);
            this.Controls.Add(this.BonusAttaqueLabel);
            this.Controls.Add(this.BonusLabel);
            this.Controls.Add(this.SPNameLabel);
            this.Controls.Add(this.ResObsLabel);
            this.Controls.Add(this.ResLumLabel);
            this.Controls.Add(this.ResEauLabel);
            this.Controls.Add(this.ResFeuLabel);
            this.Controls.Add(this.HpLabel);
            this.Controls.Add(this.ElementLabel);
            this.Controls.Add(this.DefenseLabel);
            this.Controls.Add(this.AttaqueLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PotentielGUI";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PotentielGUI";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PotentielGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Label AttaqueLabel;
        private System.Windows.Forms.Label DefenseLabel;
        private System.Windows.Forms.Label ElementLabel;
        private System.Windows.Forms.Label HpLabel;
        private System.Windows.Forms.Label ResFeuLabel;
        private System.Windows.Forms.Label ResEauLabel;
        private System.Windows.Forms.Label ResLumLabel;
        private System.Windows.Forms.Label ResObsLabel;
        private System.Windows.Forms.Label SPNameLabel;
        private System.Windows.Forms.Label BonusLabel;
        private System.Windows.Forms.Label BonusAttaqueLabel;
        private System.Windows.Forms.Label BonusPrecisionLabel;
        private System.Windows.Forms.Label BonusElementLabel;
        private System.Windows.Forms.Label BonusEsquiveLabel;
        private System.Windows.Forms.Label BonusHpLabel;
        private System.Windows.Forms.Label BonusMpLabel;
        private System.Windows.Forms.Label BonusChanceCCLabel;
        private System.Windows.Forms.Label BonusDegatsCCLabel;
        private System.Windows.Forms.Label BonusAllDefLabel;
        private System.Windows.Forms.Label BonusDimChCCLabel;
        private System.Windows.Forms.Label BonusDimDegatCCLabel;
        private System.Windows.Forms.Label BonusToutElement;
        private System.Windows.Forms.Label BonusDimDegatsMagiques;
        private System.Windows.Forms.Label BonusFéeLabel;
        private System.Windows.Forms.Label PotentielLabel;
        private System.Windows.Forms.Label ConseilsLabel;
    }
}