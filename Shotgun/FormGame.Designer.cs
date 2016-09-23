namespace Shotgun
{
    partial class FormGame
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
            this.PanelPlayer = new System.Windows.Forms.Panel();
            this.LblPointP = new System.Windows.Forms.Label();
            this.LblAmmoCountPlay = new System.Windows.Forms.Label();
            this.BtnBlock = new System.Windows.Forms.Button();
            this.BtnShoot = new System.Windows.Forms.Button();
            this.LblPointsPlay = new System.Windows.Forms.Label();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.LblAmmo = new System.Windows.Forms.Label();
            this.LblPlayer = new System.Windows.Forms.Label();
            this.BtnShotgun = new System.Windows.Forms.Button();
            this.PanelNPC = new System.Windows.Forms.Panel();
            this.LblPointN = new System.Windows.Forms.Label();
            this.LblNpcIconLoad = new System.Windows.Forms.Label();
            this.LblNpcIconShoot = new System.Windows.Forms.Label();
            this.LblNpcIconBlock = new System.Windows.Forms.Label();
            this.LblNpcIconShotgun = new System.Windows.Forms.Label();
            this.LblComputer = new System.Windows.Forms.Label();
            this.LblAmmoCountNpc = new System.Windows.Forms.Label();
            this.LblNumOfAmmoNPC = new System.Windows.Forms.Label();
            this.LblPointsNPC = new System.Windows.Forms.Label();
            this.LblVs = new System.Windows.Forms.Label();
            this.BtnStartGame = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.LblCooseScore = new System.Windows.Forms.Label();
            this.TxtChoose = new System.Windows.Forms.TextBox();
            this.PanelPlayer.SuspendLayout();
            this.PanelNPC.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPlayer
            // 
            this.PanelPlayer.Controls.Add(this.LblPointP);
            this.PanelPlayer.Controls.Add(this.LblAmmoCountPlay);
            this.PanelPlayer.Controls.Add(this.BtnBlock);
            this.PanelPlayer.Controls.Add(this.BtnShoot);
            this.PanelPlayer.Controls.Add(this.LblPointsPlay);
            this.PanelPlayer.Controls.Add(this.BtnLoad);
            this.PanelPlayer.Controls.Add(this.LblAmmo);
            this.PanelPlayer.Controls.Add(this.LblPlayer);
            this.PanelPlayer.Controls.Add(this.BtnShotgun);
            this.PanelPlayer.Location = new System.Drawing.Point(31, 66);
            this.PanelPlayer.Name = "PanelPlayer";
            this.PanelPlayer.Size = new System.Drawing.Size(400, 400);
            this.PanelPlayer.TabIndex = 4;
            // 
            // LblPointP
            // 
            this.LblPointP.AutoSize = true;
            this.LblPointP.Location = new System.Drawing.Point(18, 8);
            this.LblPointP.Name = "LblPointP";
            this.LblPointP.Size = new System.Drawing.Size(55, 20);
            this.LblPointP.TabIndex = 13;
            this.LblPointP.Text = "Poäng";
            // 
            // LblAmmoCountPlay
            // 
            this.LblAmmoCountPlay.BackColor = System.Drawing.SystemColors.Control;
            this.LblAmmoCountPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAmmoCountPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAmmoCountPlay.Location = new System.Drawing.Point(337, 4);
            this.LblAmmoCountPlay.Name = "LblAmmoCountPlay";
            this.LblAmmoCountPlay.Size = new System.Drawing.Size(60, 60);
            this.LblAmmoCountPlay.TabIndex = 7;
            this.LblAmmoCountPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnBlock
            // 
            this.BtnBlock.BackgroundImage = global::Shotgun.Properties.Resources.Block;
            this.BtnBlock.Location = new System.Drawing.Point(13, 269);
            this.BtnBlock.Name = "BtnBlock";
            this.BtnBlock.Size = new System.Drawing.Size(109, 110);
            this.BtnBlock.TabIndex = 6;
            this.BtnBlock.UseVisualStyleBackColor = true;
            this.BtnBlock.Click += new System.EventHandler(this.BtnBlock_Click);
            // 
            // BtnShoot
            // 
            this.BtnShoot.Image = global::Shotgun.Properties.Resources.Shoot;
            this.BtnShoot.Location = new System.Drawing.Point(131, 264);
            this.BtnShoot.Name = "BtnShoot";
            this.BtnShoot.Size = new System.Drawing.Size(120, 120);
            this.BtnShoot.TabIndex = 1;
            this.BtnShoot.UseVisualStyleBackColor = true;
            this.BtnShoot.Click += new System.EventHandler(this.BtnShoot_Click);
            // 
            // LblPointsPlay
            // 
            this.LblPointsPlay.BackColor = System.Drawing.SystemColors.Control;
            this.LblPointsPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPointsPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPointsPlay.Location = new System.Drawing.Point(13, 44);
            this.LblPointsPlay.Name = "LblPointsPlay";
            this.LblPointsPlay.Size = new System.Drawing.Size(60, 60);
            this.LblPointsPlay.TabIndex = 8;
            this.LblPointsPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Image = global::Shotgun.Properties.Resources.Reload;
            this.BtnLoad.Location = new System.Drawing.Point(257, 264);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(120, 120);
            this.BtnLoad.TabIndex = 0;
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // LblAmmo
            // 
            this.LblAmmo.Image = global::Shotgun.Properties.Resources.Bullet2;
            this.LblAmmo.Location = new System.Drawing.Point(231, 8);
            this.LblAmmo.Name = "LblAmmo";
            this.LblAmmo.Size = new System.Drawing.Size(100, 100);
            this.LblAmmo.TabIndex = 3;
            // 
            // LblPlayer
            // 
            this.LblPlayer.AutoSize = true;
            this.LblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayer.Location = new System.Drawing.Point(169, 178);
            this.LblPlayer.Name = "LblPlayer";
            this.LblPlayer.Size = new System.Drawing.Size(146, 32);
            this.LblPlayer.TabIndex = 8;
            this.LblPlayer.Text = "SPELARE";
            // 
            // BtnShotgun
            // 
            this.BtnShotgun.Image = global::Shotgun.Properties.Resources.Shotgun;
            this.BtnShotgun.Location = new System.Drawing.Point(2, 138);
            this.BtnShotgun.Name = "BtnShotgun";
            this.BtnShotgun.Size = new System.Drawing.Size(120, 120);
            this.BtnShotgun.TabIndex = 2;
            this.BtnShotgun.Text = "Shotgun";
            this.BtnShotgun.UseVisualStyleBackColor = true;
            this.BtnShotgun.Click += new System.EventHandler(this.BtnShotgun_Click);
            // 
            // PanelNPC
            // 
            this.PanelNPC.Controls.Add(this.LblPointN);
            this.PanelNPC.Controls.Add(this.LblNpcIconLoad);
            this.PanelNPC.Controls.Add(this.LblNpcIconShoot);
            this.PanelNPC.Controls.Add(this.LblNpcIconBlock);
            this.PanelNPC.Controls.Add(this.LblNpcIconShotgun);
            this.PanelNPC.Controls.Add(this.LblComputer);
            this.PanelNPC.Controls.Add(this.LblAmmoCountNpc);
            this.PanelNPC.Controls.Add(this.LblNumOfAmmoNPC);
            this.PanelNPC.Controls.Add(this.LblPointsNPC);
            this.PanelNPC.Location = new System.Drawing.Point(509, 70);
            this.PanelNPC.Name = "PanelNPC";
            this.PanelNPC.Size = new System.Drawing.Size(400, 396);
            this.PanelNPC.TabIndex = 7;
            // 
            // LblPointN
            // 
            this.LblPointN.AutoSize = true;
            this.LblPointN.Location = new System.Drawing.Point(333, 4);
            this.LblPointN.Name = "LblPointN";
            this.LblPointN.Size = new System.Drawing.Size(55, 20);
            this.LblPointN.TabIndex = 14;
            this.LblPointN.Text = "Poäng";
            // 
            // LblNpcIconLoad
            // 
            this.LblNpcIconLoad.Image = global::Shotgun.Properties.Resources.Reload;
            this.LblNpcIconLoad.Location = new System.Drawing.Point(11, 264);
            this.LblNpcIconLoad.Name = "LblNpcIconLoad";
            this.LblNpcIconLoad.Size = new System.Drawing.Size(120, 120);
            this.LblNpcIconLoad.TabIndex = 16;
            // 
            // LblNpcIconShoot
            // 
            this.LblNpcIconShoot.Image = global::Shotgun.Properties.Resources.Shoot;
            this.LblNpcIconShoot.Location = new System.Drawing.Point(137, 264);
            this.LblNpcIconShoot.Name = "LblNpcIconShoot";
            this.LblNpcIconShoot.Size = new System.Drawing.Size(120, 120);
            this.LblNpcIconShoot.TabIndex = 15;
            // 
            // LblNpcIconBlock
            // 
            this.LblNpcIconBlock.Image = global::Shotgun.Properties.Resources.Block;
            this.LblNpcIconBlock.Location = new System.Drawing.Point(277, 264);
            this.LblNpcIconBlock.Name = "LblNpcIconBlock";
            this.LblNpcIconBlock.Size = new System.Drawing.Size(120, 120);
            this.LblNpcIconBlock.TabIndex = 14;
            // 
            // LblNpcIconShotgun
            // 
            this.LblNpcIconShotgun.Image = global::Shotgun.Properties.Resources.Shotgun;
            this.LblNpcIconShotgun.Location = new System.Drawing.Point(268, 144);
            this.LblNpcIconShotgun.Name = "LblNpcIconShotgun";
            this.LblNpcIconShotgun.Size = new System.Drawing.Size(120, 120);
            this.LblNpcIconShotgun.TabIndex = 13;
            // 
            // LblComputer
            // 
            this.LblComputer.AutoSize = true;
            this.LblComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComputer.Location = new System.Drawing.Point(135, 178);
            this.LblComputer.Name = "LblComputer";
            this.LblComputer.Size = new System.Drawing.Size(113, 32);
            this.LblComputer.TabIndex = 10;
            this.LblComputer.Text = "DATOR";
            // 
            // LblAmmoCountNpc
            // 
            this.LblAmmoCountNpc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAmmoCountNpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAmmoCountNpc.Location = new System.Drawing.Point(3, 4);
            this.LblAmmoCountNpc.Name = "LblAmmoCountNpc";
            this.LblAmmoCountNpc.Size = new System.Drawing.Size(60, 60);
            this.LblAmmoCountNpc.TabIndex = 7;
            this.LblAmmoCountNpc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNumOfAmmoNPC
            // 
            this.LblNumOfAmmoNPC.Image = global::Shotgun.Properties.Resources.Bullet2;
            this.LblNumOfAmmoNPC.Location = new System.Drawing.Point(69, 4);
            this.LblNumOfAmmoNPC.Name = "LblNumOfAmmoNPC";
            this.LblNumOfAmmoNPC.Size = new System.Drawing.Size(100, 100);
            this.LblNumOfAmmoNPC.TabIndex = 6;
            // 
            // LblPointsNPC
            // 
            this.LblPointsNPC.BackColor = System.Drawing.SystemColors.Control;
            this.LblPointsNPC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPointsNPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPointsNPC.Location = new System.Drawing.Point(328, 40);
            this.LblPointsNPC.Name = "LblPointsNPC";
            this.LblPointsNPC.Size = new System.Drawing.Size(60, 60);
            this.LblPointsNPC.TabIndex = 9;
            this.LblPointsNPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblVs
            // 
            this.LblVs.AutoSize = true;
            this.LblVs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVs.Location = new System.Drawing.Point(437, 247);
            this.LblVs.Name = "LblVs";
            this.LblVs.Size = new System.Drawing.Size(68, 29);
            this.LblVs.TabIndex = 9;
            this.LblVs.Text = "MOT";
            // 
            // BtnStartGame
            // 
            this.BtnStartGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnStartGame.Location = new System.Drawing.Point(398, 479);
            this.BtnStartGame.Name = "BtnStartGame";
            this.BtnStartGame.Size = new System.Drawing.Size(163, 43);
            this.BtnStartGame.TabIndex = 11;
            this.BtnStartGame.Text = "Starta Spel";
            this.BtnStartGame.UseVisualStyleBackColor = true;
            this.BtnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnQuit.Location = new System.Drawing.Point(822, 472);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(127, 43);
            this.BtnQuit.TabIndex = 12;
            this.BtnQuit.Text = "Avsluta";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // LblCooseScore
            // 
            this.LblCooseScore.AutoSize = true;
            this.LblCooseScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCooseScore.Location = new System.Drawing.Point(12, 486);
            this.LblCooseScore.Name = "LblCooseScore";
            this.LblCooseScore.Size = new System.Drawing.Size(328, 25);
            this.LblCooseScore.TabIndex = 13;
            this.LblCooseScore.Text = "Välj hur många poäng du vill köra till:";
            // 
            // TxtChoose
            // 
            this.TxtChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtChoose.Location = new System.Drawing.Point(341, 485);
            this.TxtChoose.Name = "TxtChoose";
            this.TxtChoose.Size = new System.Drawing.Size(39, 30);
            this.TxtChoose.TabIndex = 14;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 527);
            this.Controls.Add(this.TxtChoose);
            this.Controls.Add(this.LblCooseScore);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnStartGame);
            this.Controls.Add(this.LblVs);
            this.Controls.Add(this.PanelNPC);
            this.Controls.Add(this.PanelPlayer);
            this.Name = "FormGame";
            this.ShowIcon = false;
            this.Text = "SHOTGUN";
            this.PanelPlayer.ResumeLayout(false);
            this.PanelPlayer.PerformLayout();
            this.PanelNPC.ResumeLayout(false);
            this.PanelNPC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button BtnShoot;
        private System.Windows.Forms.Button BtnShotgun;
        private System.Windows.Forms.Label LblAmmo;
        private System.Windows.Forms.Panel PanelPlayer;
        private System.Windows.Forms.Panel PanelNPC;
        private System.Windows.Forms.Label LblNumOfAmmoNPC;
        private System.Windows.Forms.Label LblPlayer;
        private System.Windows.Forms.Label LblVs;
        private System.Windows.Forms.Label LblComputer;
        private System.Windows.Forms.Button BtnBlock;
        private System.Windows.Forms.Button BtnStartGame;
        private System.Windows.Forms.Button BtnQuit;
        public System.Windows.Forms.Label LblAmmoCountPlay;
        public System.Windows.Forms.Label LblAmmoCountNpc;
        public System.Windows.Forms.Label LblPointsPlay;
        public System.Windows.Forms.Label LblPointsNPC;
        private System.Windows.Forms.Label LblPointP;
        private System.Windows.Forms.Label LblPointN;
        private System.Windows.Forms.Label LblNpcIconLoad;
        private System.Windows.Forms.Label LblNpcIconShoot;
        private System.Windows.Forms.Label LblNpcIconBlock;
        private System.Windows.Forms.Label LblNpcIconShotgun;
        private System.Windows.Forms.Label LblCooseScore;
        private System.Windows.Forms.TextBox TxtChoose;
    }
}