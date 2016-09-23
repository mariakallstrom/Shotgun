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
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnShoot = new System.Windows.Forms.Button();
            this.BtnShotgun = new System.Windows.Forms.Button();
            this.LblAmmo = new System.Windows.Forms.Label();
            this.PanelPlayer = new System.Windows.Forms.Panel();
            this.LblAmmoCountPlay = new System.Windows.Forms.Label();
            this.BtnBlock = new System.Windows.Forms.Button();
            this.PanelNPC = new System.Windows.Forms.Panel();
            this.LblAmmoCountNpc = new System.Windows.Forms.Label();
            this.LblNumOfAmmoNPC = new System.Windows.Forms.Label();
            this.LblPlayer = new System.Windows.Forms.Label();
            this.LblVs = new System.Windows.Forms.Label();
            this.LblComputer = new System.Windows.Forms.Label();
            this.BtnStartGame = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.LblPointsPlay = new System.Windows.Forms.Label();
            this.LblPointsNPC = new System.Windows.Forms.Label();
            this.LblPointP = new System.Windows.Forms.Label();
            this.LblPointN = new System.Windows.Forms.Label();
            this.PanelPlayer.SuspendLayout();
            this.PanelNPC.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(3, 186);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(85, 40);
            this.BtnLoad.TabIndex = 0;
            this.BtnLoad.Text = "Ladda";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnShoot
            // 
            this.BtnShoot.Location = new System.Drawing.Point(3, 93);
            this.BtnShoot.Name = "BtnShoot";
            this.BtnShoot.Size = new System.Drawing.Size(85, 39);
            this.BtnShoot.TabIndex = 1;
            this.BtnShoot.Text = "Skjut";
            this.BtnShoot.UseVisualStyleBackColor = true;
            this.BtnShoot.Click += new System.EventHandler(this.BtnShoot_Click);
            // 
            // BtnShotgun
            // 
            this.BtnShotgun.Location = new System.Drawing.Point(110, 169);
            this.BtnShotgun.Name = "BtnShotgun";
            this.BtnShotgun.Size = new System.Drawing.Size(88, 57);
            this.BtnShotgun.TabIndex = 2;
            this.BtnShotgun.Text = "Shotgun";
            this.BtnShotgun.UseVisualStyleBackColor = true;
            this.BtnShotgun.Click += new System.EventHandler(this.BtnShotgun_Click);
            // 
            // LblAmmo
            // 
            this.LblAmmo.AutoSize = true;
            this.LblAmmo.Location = new System.Drawing.Point(23, 14);
            this.LblAmmo.Name = "LblAmmo";
            this.LblAmmo.Size = new System.Drawing.Size(88, 20);
            this.LblAmmo.TabIndex = 3;
            this.LblAmmo.Text = "Antal Skott";
            // 
            // PanelPlayer
            // 
            this.PanelPlayer.Controls.Add(this.LblAmmoCountPlay);
            this.PanelPlayer.Controls.Add(this.BtnBlock);
            this.PanelPlayer.Controls.Add(this.BtnShoot);
            this.PanelPlayer.Controls.Add(this.BtnLoad);
            this.PanelPlayer.Controls.Add(this.LblAmmo);
            this.PanelPlayer.Controls.Add(this.BtnShotgun);
            this.PanelPlayer.Location = new System.Drawing.Point(93, 94);
            this.PanelPlayer.Name = "PanelPlayer";
            this.PanelPlayer.Size = new System.Drawing.Size(201, 229);
            this.PanelPlayer.TabIndex = 4;
            // 
            // LblAmmoCountPlay
            // 
            this.LblAmmoCountPlay.BackColor = System.Drawing.SystemColors.Control;
            this.LblAmmoCountPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAmmoCountPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAmmoCountPlay.Location = new System.Drawing.Point(132, 14);
            this.LblAmmoCountPlay.Name = "LblAmmoCountPlay";
            this.LblAmmoCountPlay.Size = new System.Drawing.Size(60, 60);
            this.LblAmmoCountPlay.TabIndex = 7;
            this.LblAmmoCountPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnBlock
            // 
            this.BtnBlock.Location = new System.Drawing.Point(3, 138);
            this.BtnBlock.Name = "BtnBlock";
            this.BtnBlock.Size = new System.Drawing.Size(85, 42);
            this.BtnBlock.TabIndex = 6;
            this.BtnBlock.Text = "Blocka";
            this.BtnBlock.UseVisualStyleBackColor = true;
            this.BtnBlock.Click += new System.EventHandler(this.BtnBlock_Click);
            // 
            // PanelNPC
            // 
            this.PanelNPC.Controls.Add(this.LblAmmoCountNpc);
            this.PanelNPC.Controls.Add(this.LblNumOfAmmoNPC);
            this.PanelNPC.Location = new System.Drawing.Point(379, 94);
            this.PanelNPC.Name = "PanelNPC";
            this.PanelNPC.Size = new System.Drawing.Size(200, 229);
            this.PanelNPC.TabIndex = 7;
            // 
            // LblAmmoCountNpc
            // 
            this.LblAmmoCountNpc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAmmoCountNpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAmmoCountNpc.Location = new System.Drawing.Point(125, 14);
            this.LblAmmoCountNpc.Name = "LblAmmoCountNpc";
            this.LblAmmoCountNpc.Size = new System.Drawing.Size(60, 60);
            this.LblAmmoCountNpc.TabIndex = 7;
            this.LblAmmoCountNpc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNumOfAmmoNPC
            // 
            this.LblNumOfAmmoNPC.AutoSize = true;
            this.LblNumOfAmmoNPC.Location = new System.Drawing.Point(17, 14);
            this.LblNumOfAmmoNPC.Name = "LblNumOfAmmoNPC";
            this.LblNumOfAmmoNPC.Size = new System.Drawing.Size(88, 20);
            this.LblNumOfAmmoNPC.TabIndex = 6;
            this.LblNumOfAmmoNPC.Text = "Antal Skott";
            // 
            // LblPlayer
            // 
            this.LblPlayer.AutoSize = true;
            this.LblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayer.Location = new System.Drawing.Point(114, 49);
            this.LblPlayer.Name = "LblPlayer";
            this.LblPlayer.Size = new System.Drawing.Size(146, 32);
            this.LblPlayer.TabIndex = 8;
            this.LblPlayer.Text = "SPELARE";
            // 
            // LblVs
            // 
            this.LblVs.AutoSize = true;
            this.LblVs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVs.Location = new System.Drawing.Point(313, 52);
            this.LblVs.Name = "LblVs";
            this.LblVs.Size = new System.Drawing.Size(44, 29);
            this.LblVs.TabIndex = 9;
            this.LblVs.Text = "VS";
            // 
            // LblComputer
            // 
            this.LblComputer.AutoSize = true;
            this.LblComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComputer.Location = new System.Drawing.Point(420, 49);
            this.LblComputer.Name = "LblComputer";
            this.LblComputer.Size = new System.Drawing.Size(113, 32);
            this.LblComputer.TabIndex = 10;
            this.LblComputer.Text = "DATOR";
            // 
            // BtnStartGame
            // 
            this.BtnStartGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnStartGame.Location = new System.Drawing.Point(31, 329);
            this.BtnStartGame.Name = "BtnStartGame";
            this.BtnStartGame.Size = new System.Drawing.Size(114, 43);
            this.BtnStartGame.TabIndex = 11;
            this.BtnStartGame.Text = "Starta Spel";
            this.BtnStartGame.UseVisualStyleBackColor = true;
            this.BtnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(508, 329);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(127, 43);
            this.BtnQuit.TabIndex = 12;
            this.BtnQuit.Text = "Avsluta";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // LblPointsPlay
            // 
            this.LblPointsPlay.BackColor = System.Drawing.SystemColors.Control;
            this.LblPointsPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPointsPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPointsPlay.Location = new System.Drawing.Point(20, 35);
            this.LblPointsPlay.Name = "LblPointsPlay";
            this.LblPointsPlay.Size = new System.Drawing.Size(60, 60);
            this.LblPointsPlay.TabIndex = 8;
            this.LblPointsPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPointsNPC
            // 
            this.LblPointsNPC.BackColor = System.Drawing.SystemColors.Control;
            this.LblPointsNPC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPointsNPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPointsNPC.Location = new System.Drawing.Point(588, 35);
            this.LblPointsNPC.Name = "LblPointsNPC";
            this.LblPointsNPC.Size = new System.Drawing.Size(60, 60);
            this.LblPointsNPC.TabIndex = 9;
            this.LblPointsNPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPointP
            // 
            this.LblPointP.AutoSize = true;
            this.LblPointP.Location = new System.Drawing.Point(25, 11);
            this.LblPointP.Name = "LblPointP";
            this.LblPointP.Size = new System.Drawing.Size(55, 20);
            this.LblPointP.TabIndex = 13;
            this.LblPointP.Text = "Poäng";
            // 
            // LblPointN
            // 
            this.LblPointN.AutoSize = true;
            this.LblPointN.Location = new System.Drawing.Point(593, 11);
            this.LblPointN.Name = "LblPointN";
            this.LblPointN.Size = new System.Drawing.Size(55, 20);
            this.LblPointN.TabIndex = 14;
            this.LblPointN.Text = "Poäng";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 384);
            this.Controls.Add(this.LblPointN);
            this.Controls.Add(this.LblPointP);
            this.Controls.Add(this.LblPointsNPC);
            this.Controls.Add(this.LblPointsPlay);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnStartGame);
            this.Controls.Add(this.LblComputer);
            this.Controls.Add(this.LblVs);
            this.Controls.Add(this.LblPlayer);
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
    }
}