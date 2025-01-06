namespace SavasOyun
{
    partial class KartTutucu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblDayaniklilik = new System.Windows.Forms.Label();
            this.lblVurus = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblHavaAvantaji = new System.Windows.Forms.Label();
            this.lblDenizAvantaji = new System.Windows.Forms.Label();
            this.lblKaraAvantaji = new System.Windows.Forms.Label();
            this.lblKartAdi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.TextLevel = new System.Windows.Forms.TextBox();
            this.lblDurability = new System.Windows.Forms.Label();
            this.TextDurability = new System.Windows.Forms.TextBox();
            this.lblTotalDmg = new System.Windows.Forms.Label();
            this.TextDmg = new System.Windows.Forms.TextBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.lblDayaniklilik);
            this.panel5.Controls.Add(this.lblVurus);
            this.panel5.Controls.Add(this.lblTur);
            this.panel5.Controls.Add(this.lblHavaAvantaji);
            this.panel5.Controls.Add(this.lblDenizAvantaji);
            this.panel5.Controls.Add(this.lblKaraAvantaji);
            this.panel5.Location = new System.Drawing.Point(0, 191);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 69);
            this.panel5.TabIndex = 16;
            // 
            // lblDayaniklilik
            // 
            this.lblDayaniklilik.AutoSize = true;
            this.lblDayaniklilik.Location = new System.Drawing.Point(5, 5);
            this.lblDayaniklilik.Name = "lblDayaniklilik";
            this.lblDayaniklilik.Size = new System.Drawing.Size(37, 16);
            this.lblDayaniklilik.TabIndex = 0;
            this.lblDayaniklilik.Text = "D: 10";
            // 
            // lblVurus
            // 
            this.lblVurus.AutoSize = true;
            this.lblVurus.Location = new System.Drawing.Point(5, 27);
            this.lblVurus.Name = "lblVurus";
            this.lblVurus.Size = new System.Drawing.Size(36, 16);
            this.lblVurus.TabIndex = 0;
            this.lblVurus.Text = "V: 10";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(5, 48);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(55, 16);
            this.lblTur.TabIndex = 7;
            this.lblTur.Text = "T: Hava";
            // 
            // lblHavaAvantaji
            // 
            this.lblHavaAvantaji.Location = new System.Drawing.Point(117, 47);
            this.lblHavaAvantaji.Name = "lblHavaAvantaji";
            this.lblHavaAvantaji.Size = new System.Drawing.Size(79, 17);
            this.lblHavaAvantaji.TabIndex = 10;
            this.lblHavaAvantaji.Text = "HA: 10";
            this.lblHavaAvantaji.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDenizAvantaji
            // 
            this.lblDenizAvantaji.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDenizAvantaji.Location = new System.Drawing.Point(116, 25);
            this.lblDenizAvantaji.Name = "lblDenizAvantaji";
            this.lblDenizAvantaji.Size = new System.Drawing.Size(81, 21);
            this.lblDenizAvantaji.TabIndex = 9;
            this.lblDenizAvantaji.Text = "DA: 10";
            this.lblDenizAvantaji.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKaraAvantaji
            // 
            this.lblKaraAvantaji.Location = new System.Drawing.Point(118, 5);
            this.lblKaraAvantaji.Name = "lblKaraAvantaji";
            this.lblKaraAvantaji.Size = new System.Drawing.Size(78, 21);
            this.lblKaraAvantaji.TabIndex = 8;
            this.lblKaraAvantaji.Text = "KA: 10";
            this.lblKaraAvantaji.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKartAdi
            // 
            this.lblKartAdi.AutoSize = true;
            this.lblKartAdi.Location = new System.Drawing.Point(5, 5);
            this.lblKartAdi.Name = "lblKartAdi";
            this.lblKartAdi.Size = new System.Drawing.Size(34, 16);
            this.lblKartAdi.TabIndex = 15;
            this.lblKartAdi.Text = "Siha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Bisque;
            this.pictureBox1.Image = global::SavasOyun.Properties.Resources.plane;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(225, 18);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(40, 16);
            this.lblLevel.TabIndex = 18;
            this.lblLevel.Text = "Level";
            // 
            // TextLevel
            // 
            this.TextLevel.Location = new System.Drawing.Point(212, 47);
            this.TextLevel.Name = "TextLevel";
            this.TextLevel.Size = new System.Drawing.Size(68, 22);
            this.TextLevel.TabIndex = 19;
            // 
            // lblDurability
            // 
            this.lblDurability.AutoSize = true;
            this.lblDurability.Location = new System.Drawing.Point(213, 98);
            this.lblDurability.Name = "lblDurability";
            this.lblDurability.Size = new System.Drawing.Size(63, 16);
            this.lblDurability.TabIndex = 20;
            this.lblDurability.Text = "Durability";
            // 
            // TextDurability
            // 
            this.TextDurability.Location = new System.Drawing.Point(212, 134);
            this.TextDurability.Name = "TextDurability";
            this.TextDurability.Size = new System.Drawing.Size(68, 22);
            this.TextDurability.TabIndex = 21;
            // 
            // lblTotalDmg
            // 
            this.lblTotalDmg.AutoSize = true;
            this.lblTotalDmg.Location = new System.Drawing.Point(211, 175);
            this.lblTotalDmg.Name = "lblTotalDmg";
            this.lblTotalDmg.Size = new System.Drawing.Size(70, 16);
            this.lblTotalDmg.TabIndex = 22;
            this.lblTotalDmg.Text = "Total Dmg";
            // 
            // TextDmg
            // 
            this.TextDmg.Location = new System.Drawing.Point(212, 212);
            this.TextDmg.Name = "TextDmg";
            this.TextDmg.Size = new System.Drawing.Size(69, 22);
            this.TextDmg.TabIndex = 23;
            // 
            // KartTutucu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.TextDmg);
            this.Controls.Add(this.lblTotalDmg);
            this.Controls.Add(this.TextDurability);
            this.Controls.Add(this.lblDurability);
            this.Controls.Add(this.TextLevel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblKartAdi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KartTutucu";
            this.Size = new System.Drawing.Size(298, 261);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblDenizAvantaji;
        private System.Windows.Forms.Label lblKaraAvantaji;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblDayaniklilik;
        private System.Windows.Forms.Label lblKartAdi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHavaAvantaji;
        private System.Windows.Forms.Label lblVurus;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.TextBox TextLevel;
        private System.Windows.Forms.Label lblDurability;
        private System.Windows.Forms.TextBox TextDurability;
        private System.Windows.Forms.Label lblTotalDmg;
        private System.Windows.Forms.TextBox TextDmg;
    }
}
