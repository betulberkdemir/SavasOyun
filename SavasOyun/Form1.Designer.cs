namespace SavasOyun
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CompScore = new System.Windows.Forms.TextBox();
            this.UserScore = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.FightBtn = new System.Windows.Forms.Button();
            this.arena1 = new System.Windows.Forms.Button();
            this.arena2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtMaxTur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTur = new System.Windows.Forms.TextBox();
            this.LblTur = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.kartTutucu6 = new SavasOyun.KartTutucu();
            this.kartTutucu5 = new SavasOyun.KartTutucu();
            this.kartTutucu4 = new SavasOyun.KartTutucu();
            this.kartTutucu3 = new SavasOyun.KartTutucu();
            this.kartTutucu2 = new SavasOyun.KartTutucu();
            this.kartTutucu1 = new SavasOyun.KartTutucu();
            this.arena6 = new System.Windows.Forms.Button();
            this.arena5 = new System.Windows.Forms.Button();
            this.arena4 = new System.Windows.Forms.Button();
            this.arena3 = new System.Windows.Forms.Button();
            this.kartTutucuKucuk6 = new SavasOyun.KartTutucuKucuk();
            this.kartTutucuKucuk5 = new SavasOyun.KartTutucuKucuk();
            this.kartTutucuKucuk4 = new SavasOyun.KartTutucuKucuk();
            this.kartTutucuKucuk3 = new SavasOyun.KartTutucuKucuk();
            this.kartTutucuKucuk2 = new SavasOyun.KartTutucuKucuk();
            this.kartTutucuKucuk1 = new SavasOyun.KartTutucuKucuk();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(970, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Computer\'s Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(979, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "User\'s Score";
            // 
            // CompScore
            // 
            this.CompScore.Location = new System.Drawing.Point(982, 153);
            this.CompScore.Name = "CompScore";
            this.CompScore.ReadOnly = true;
            this.CompScore.Size = new System.Drawing.Size(73, 22);
            this.CompScore.TabIndex = 20;
            // 
            // UserScore
            // 
            this.UserScore.Location = new System.Drawing.Point(982, 220);
            this.UserScore.Name = "UserScore";
            this.UserScore.ReadOnly = true;
            this.UserScore.Size = new System.Drawing.Size(73, 22);
            this.UserScore.TabIndex = 21;
            // 
            // StartBtn
            // 
            this.StartBtn.Enabled = false;
            this.StartBtn.Location = new System.Drawing.Point(974, 343);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(105, 49);
            this.StartBtn.TabIndex = 22;
            this.StartBtn.Text = "START";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.Start_Click);
            // 
            // FightBtn
            // 
            this.FightBtn.Location = new System.Drawing.Point(974, 424);
            this.FightBtn.Name = "FightBtn";
            this.FightBtn.Size = new System.Drawing.Size(105, 49);
            this.FightBtn.TabIndex = 23;
            this.FightBtn.Text = "FİGHT";
            this.FightBtn.UseVisualStyleBackColor = true;
            this.FightBtn.Click += new System.EventHandler(this.Fight_Click);
            // 
            // arena1
            // 
            this.arena1.Location = new System.Drawing.Point(19, 885);
            this.arena1.Name = "arena1";
            this.arena1.Size = new System.Drawing.Size(152, 30);
            this.arena1.TabIndex = 25;
            this.arena1.Tag = "0";
            this.arena1.Text = "Arena";
            this.arena1.UseVisualStyleBackColor = true;
            this.arena1.Click += new System.EventHandler(this.arena_Click);
            // 
            // arena2
            // 
            this.arena2.Location = new System.Drawing.Point(177, 885);
            this.arena2.Name = "arena2";
            this.arena2.Size = new System.Drawing.Size(152, 30);
            this.arena2.TabIndex = 26;
            this.arena2.Tag = "1";
            this.arena2.Text = "Arena";
            this.arena2.UseVisualStyleBackColor = true;
            this.arena2.Click += new System.EventHandler(this.arena_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtMaxTur);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtTur);
            this.panel1.Controls.Add(this.LblTur);
            this.panel1.Controls.Add(this.button17);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.kartTutucu6);
            this.panel1.Controls.Add(this.kartTutucu5);
            this.panel1.Controls.Add(this.kartTutucu4);
            this.panel1.Controls.Add(this.kartTutucu3);
            this.panel1.Controls.Add(this.kartTutucu2);
            this.panel1.Controls.Add(this.kartTutucu1);
            this.panel1.Controls.Add(this.arena6);
            this.panel1.Controls.Add(this.arena5);
            this.panel1.Controls.Add(this.arena4);
            this.panel1.Controls.Add(this.arena3);
            this.panel1.Controls.Add(this.arena2);
            this.panel1.Controls.Add(this.arena1);
            this.panel1.Controls.Add(this.FightBtn);
            this.panel1.Controls.Add(this.StartBtn);
            this.panel1.Controls.Add(this.UserScore);
            this.panel1.Controls.Add(this.CompScore);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.kartTutucuKucuk6);
            this.panel1.Controls.Add(this.kartTutucuKucuk5);
            this.panel1.Controls.Add(this.kartTutucuKucuk4);
            this.panel1.Controls.Add(this.kartTutucuKucuk3);
            this.panel1.Controls.Add(this.kartTutucuKucuk2);
            this.panel1.Controls.Add(this.kartTutucuKucuk1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 943);
            this.panel1.TabIndex = 0;
            // 
            // TxtMaxTur
            // 
            this.TxtMaxTur.Location = new System.Drawing.Point(973, 40);
            this.TxtMaxTur.Name = "TxtMaxTur";
            this.TxtMaxTur.Size = new System.Drawing.Size(87, 22);
            this.TxtMaxTur.TabIndex = 0;
            this.TxtMaxTur.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtMaxTur_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(991, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "MaxTur";
            // 
            // TxtTur
            // 
            this.TxtTur.Location = new System.Drawing.Point(974, 91);
            this.TxtTur.Name = "TxtTur";
            this.TxtTur.ReadOnly = true;
            this.TxtTur.Size = new System.Drawing.Size(87, 22);
            this.TxtTur.TabIndex = 2;
            // 
            // LblTur
            // 
            this.LblTur.AutoSize = true;
            this.LblTur.Location = new System.Drawing.Point(1004, 72);
            this.LblTur.Name = "LblTur";
            this.LblTur.Size = new System.Drawing.Size(27, 16);
            this.LblTur.TabIndex = 1;
            this.LblTur.Text = "Tur";
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button17.Location = new System.Drawing.Point(21, 329);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(112, 23);
            this.button17.TabIndex = 35;
            this.button17.Text = "OYUNCU";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button13.Location = new System.Drawing.Point(21, 40);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(112, 23);
            this.button13.TabIndex = 34;
            this.button13.Text = "BİLGİSAYAR";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button12.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(18, 624);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(946, 33);
            this.button12.TabIndex = 33;
            this.button12.Text = "OYUNCU KARTLARI";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button11.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.Location = new System.Drawing.Point(19, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(946, 33);
            this.button11.TabIndex = 32;
            this.button11.Text = "ARENA";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // kartTutucu6
            // 
            this.kartTutucu6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.kartTutucu6.Location = new System.Drawing.Point(662, 358);
            this.kartTutucu6.Name = "kartTutucu6";
            this.kartTutucu6.SavasKarti = null;
            this.kartTutucu6.Size = new System.Drawing.Size(298, 261);
            this.kartTutucu6.TabIndex = 31;
            // 
            // kartTutucu5
            // 
            this.kartTutucu5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.kartTutucu5.Location = new System.Drawing.Point(358, 358);
            this.kartTutucu5.Name = "kartTutucu5";
            this.kartTutucu5.SavasKarti = null;
            this.kartTutucu5.Size = new System.Drawing.Size(298, 261);
            this.kartTutucu5.TabIndex = 31;
            // 
            // kartTutucu4
            // 
            this.kartTutucu4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.kartTutucu4.Location = new System.Drawing.Point(21, 358);
            this.kartTutucu4.Name = "kartTutucu4";
            this.kartTutucu4.SavasKarti = null;
            this.kartTutucu4.Size = new System.Drawing.Size(307, 261);
            this.kartTutucu4.TabIndex = 31;
            // 
            // kartTutucu3
            // 
            this.kartTutucu3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.kartTutucu3.Location = new System.Drawing.Point(659, 65);
            this.kartTutucu3.Name = "kartTutucu3";
            this.kartTutucu3.SavasKarti = null;
            this.kartTutucu3.Size = new System.Drawing.Size(298, 261);
            this.kartTutucu3.TabIndex = 31;
            // 
            // kartTutucu2
            // 
            this.kartTutucu2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.kartTutucu2.Location = new System.Drawing.Point(355, 65);
            this.kartTutucu2.Name = "kartTutucu2";
            this.kartTutucu2.SavasKarti = null;
            this.kartTutucu2.Size = new System.Drawing.Size(298, 261);
            this.kartTutucu2.TabIndex = 31;
            // 
            // kartTutucu1
            // 
            this.kartTutucu1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.kartTutucu1.Location = new System.Drawing.Point(18, 65);
            this.kartTutucu1.Name = "kartTutucu1";
            this.kartTutucu1.SavasKarti = null;
            this.kartTutucu1.Size = new System.Drawing.Size(307, 261);
            this.kartTutucu1.TabIndex = 31;
            // 
            // arena6
            // 
            this.arena6.Location = new System.Drawing.Point(813, 885);
            this.arena6.Name = "arena6";
            this.arena6.Size = new System.Drawing.Size(152, 30);
            this.arena6.TabIndex = 30;
            this.arena6.Tag = "5";
            this.arena6.Text = "Arena";
            this.arena6.UseVisualStyleBackColor = true;
            this.arena6.Click += new System.EventHandler(this.arena_Click);
            // 
            // arena5
            // 
            this.arena5.Location = new System.Drawing.Point(655, 885);
            this.arena5.Name = "arena5";
            this.arena5.Size = new System.Drawing.Size(152, 30);
            this.arena5.TabIndex = 29;
            this.arena5.Tag = "4";
            this.arena5.Text = "Arena";
            this.arena5.UseVisualStyleBackColor = true;
            this.arena5.Click += new System.EventHandler(this.arena_Click);
            // 
            // arena4
            // 
            this.arena4.Location = new System.Drawing.Point(497, 885);
            this.arena4.Name = "arena4";
            this.arena4.Size = new System.Drawing.Size(152, 30);
            this.arena4.TabIndex = 28;
            this.arena4.Tag = "3";
            this.arena4.Text = "Arena";
            this.arena4.UseVisualStyleBackColor = true;
            this.arena4.Click += new System.EventHandler(this.arena_Click);
            // 
            // arena3
            // 
            this.arena3.Location = new System.Drawing.Point(339, 885);
            this.arena3.Name = "arena3";
            this.arena3.Size = new System.Drawing.Size(152, 30);
            this.arena3.TabIndex = 27;
            this.arena3.Tag = "2";
            this.arena3.Text = "Arena";
            this.arena3.UseVisualStyleBackColor = true;
            this.arena3.Click += new System.EventHandler(this.arena_Click);
            // 
            // kartTutucuKucuk6
            // 
            this.kartTutucuKucuk6.Location = new System.Drawing.Point(810, 663);
            this.kartTutucuKucuk6.Name = "kartTutucuKucuk6";
            this.kartTutucuKucuk6.SavasKarti = null;
            this.kartTutucuKucuk6.Size = new System.Drawing.Size(151, 218);
            this.kartTutucuKucuk6.TabIndex = 17;
            // 
            // kartTutucuKucuk5
            // 
            this.kartTutucuKucuk5.Location = new System.Drawing.Point(653, 663);
            this.kartTutucuKucuk5.Name = "kartTutucuKucuk5";
            this.kartTutucuKucuk5.SavasKarti = null;
            this.kartTutucuKucuk5.Size = new System.Drawing.Size(151, 218);
            this.kartTutucuKucuk5.TabIndex = 17;
            // 
            // kartTutucuKucuk4
            // 
            this.kartTutucuKucuk4.Location = new System.Drawing.Point(496, 663);
            this.kartTutucuKucuk4.Name = "kartTutucuKucuk4";
            this.kartTutucuKucuk4.SavasKarti = null;
            this.kartTutucuKucuk4.Size = new System.Drawing.Size(151, 218);
            this.kartTutucuKucuk4.TabIndex = 17;
            // 
            // kartTutucuKucuk3
            // 
            this.kartTutucuKucuk3.Location = new System.Drawing.Point(339, 663);
            this.kartTutucuKucuk3.Name = "kartTutucuKucuk3";
            this.kartTutucuKucuk3.SavasKarti = null;
            this.kartTutucuKucuk3.Size = new System.Drawing.Size(151, 218);
            this.kartTutucuKucuk3.TabIndex = 17;
            // 
            // kartTutucuKucuk2
            // 
            this.kartTutucuKucuk2.Location = new System.Drawing.Point(182, 663);
            this.kartTutucuKucuk2.Name = "kartTutucuKucuk2";
            this.kartTutucuKucuk2.SavasKarti = null;
            this.kartTutucuKucuk2.Size = new System.Drawing.Size(151, 218);
            this.kartTutucuKucuk2.TabIndex = 17;
            // 
            // kartTutucuKucuk1
            // 
            this.kartTutucuKucuk1.Location = new System.Drawing.Point(20, 663);
            this.kartTutucuKucuk1.Name = "kartTutucuKucuk1";
            this.kartTutucuKucuk1.SavasKarti = null;
            this.kartTutucuKucuk1.Size = new System.Drawing.Size(151, 218);
            this.kartTutucuKucuk1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 943);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savaş Oyun";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private KartTutucuKucuk kartTutucuKucuk1;
        private KartTutucuKucuk kartTutucuKucuk2;
        private KartTutucuKucuk kartTutucuKucuk3;
        private KartTutucuKucuk kartTutucuKucuk4;
        private KartTutucuKucuk kartTutucuKucuk5;
        private KartTutucuKucuk kartTutucuKucuk6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CompScore;
        private System.Windows.Forms.TextBox UserScore;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button FightBtn;
        private System.Windows.Forms.Button arena1;
        private System.Windows.Forms.Button arena2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button arena6;
        private System.Windows.Forms.Button arena5;
        private System.Windows.Forms.Button arena4;
        private System.Windows.Forms.Button arena3;
        private KartTutucu kartTutucu2;
        private KartTutucu kartTutucu1;
        private KartTutucu kartTutucu3;
        private KartTutucu kartTutucu6;
        private KartTutucu kartTutucu5;
        private KartTutucu kartTutucu4;
        private System.Windows.Forms.Label LblTur;
        private System.Windows.Forms.TextBox TxtTur;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox TxtMaxTur;
        private System.Windows.Forms.Label label3;
    }
}

