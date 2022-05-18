namespace AttackOfTheKarens
{
    partial class FrmMall
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panMall = new System.Windows.Forms.Panel();
            this.btnStore = new System.Windows.Forms.Button();
            this.tmrKarenSpawner = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdateKarens = new System.Windows.Forms.Timer(this.components);
            this.tmrBossSpawner = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdateBoss = new System.Windows.Forms.Timer(this.components);
            this.tmrgameScore = new System.Windows.Forms.Timer(this.components);
            this.lblMoneySaved = new System.Windows.Forms.Label();
            this.tmrUpdateGame = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdateManager = new System.Windows.Forms.Timer(this.components);
            this.HowToPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panMall
            // 
            this.panMall.BackColor = System.Drawing.Color.Transparent;
            this.panMall.BackgroundImage = global::AttackOfTheKarens.Properties.Resources.mall_bg;
            this.panMall.Location = new System.Drawing.Point(14, 16);
            this.panMall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panMall.Name = "panMall";
            this.panMall.Size = new System.Drawing.Size(641, 719);
            this.panMall.TabIndex = 0;
            // 
            // btnStore
            // 
            this.btnStore.BackColor = System.Drawing.Color.MediumPurple;
            this.btnStore.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStore.Location = new System.Drawing.Point(1277, 81);
            this.btnStore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(143, 79);
            this.btnStore.TabIndex = 3;
            this.btnStore.Text = "Open the Store";
            this.btnStore.UseVisualStyleBackColor = false;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            this.btnStore.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmMall_KeyUp);
            // 
            // tmrKarenSpawner
            // 
            this.tmrKarenSpawner.Tick += new System.EventHandler(this.tmrKarenSpawner_Tick);
            // 
            // tmrUpdateKarens
            // 
            this.tmrUpdateKarens.Enabled = true;
            this.tmrUpdateKarens.Interval = 80;
            this.tmrUpdateKarens.Tick += new System.EventHandler(this.tmrUpdateKarens_Tick);
            // 
            // tmrBossSpawner
            // 
            this.tmrBossSpawner.Enabled = true;
            this.tmrBossSpawner.Tick += new System.EventHandler(this.tmrBossSpawner_Tick);
            // 
            // tmrUpdateBoss
            // 
            this.tmrUpdateBoss.Enabled = true;
            this.tmrUpdateBoss.Tick += new System.EventHandler(this.tmrUpdateBoss_Tick);
            // 
            // tmrgameScore
            // 
            this.tmrgameScore.Enabled = true;
            this.tmrgameScore.Tick += new System.EventHandler(this.gameScore_Tick);
            // 
            // lblMoneySaved
            // 
            this.lblMoneySaved.AutoSize = true;
            this.lblMoneySaved.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMoneySaved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMoneySaved.Location = new System.Drawing.Point(2000, 0);
            this.lblMoneySaved.Name = "lblMoneySaved";
            this.lblMoneySaved.Size = new System.Drawing.Size(119, 41);
            this.lblMoneySaved.TabIndex = 1;
            this.lblMoneySaved.Text = "$ 00.00";
            this.lblMoneySaved.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrUpdateGame
            // 
            this.tmrUpdateGame.Enabled = true;
            this.tmrUpdateGame.Tick += new System.EventHandler(this.tmrUpdateGame_Tick);
            // 
            // tmrUpdateManager
            // 
            this.tmrUpdateManager.Enabled = true;
            this.tmrUpdateManager.Tick += new System.EventHandler(this.updateManager_Tick);
            // 
            // HowToPlay
            // 
            this.HowToPlay.BackColor = System.Drawing.Color.MediumPurple;
            this.HowToPlay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HowToPlay.Location = new System.Drawing.Point(1277, 177);
            this.HowToPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HowToPlay.Name = "HowToPlay";
            this.HowToPlay.Size = new System.Drawing.Size(143, 85);
            this.HowToPlay.TabIndex = 4;
            this.HowToPlay.Text = "How to Play";
            this.HowToPlay.UseVisualStyleBackColor = false;
            this.HowToPlay.Click += new System.EventHandler(this.HowToPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(1294, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(1294, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // FrmMall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1925, 1061);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HowToPlay);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.lblMoneySaved);
            this.Controls.Add(this.panMall);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attack of the Karens!!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMall_FormClosed);
            this.Load += new System.EventHandler(this.FrmMall_Load);
            this.Click += new System.EventHandler(this.btnStore_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panMall;
        private System.Windows.Forms.Timer tmrKarenSpawner;
        private System.Windows.Forms.Timer tmrUpdateKarens;
        private System.Windows.Forms.Timer tmrBossSpawner;
        private System.Windows.Forms.Timer tmrUpdateBoss;
//        private System.Windows.Forms.Timer tmrMoveOwner;
        private System.Windows.Forms.Label lblMoneySaved;
        private System.Windows.Forms.Timer tmrUpdateGame;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Timer tmrgameScore;
        private System.Windows.Forms.Timer tmrUpdateManager;
        private System.Windows.Forms.Button HowToPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}