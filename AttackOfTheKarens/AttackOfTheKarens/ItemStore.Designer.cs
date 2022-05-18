namespace AttackOfTheKarens
{
    partial class ItemStore
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
            this.BuyManager = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BuyManager
            // 
            this.BuyManager.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BuyManager.Location = new System.Drawing.Point(194, 50);
            this.BuyManager.Name = "BuyManager";
            this.BuyManager.Size = new System.Drawing.Size(107, 40);
            this.BuyManager.TabIndex = 0;
            this.BuyManager.Text = "Purchase";
            this.BuyManager.UseVisualStyleBackColor = true;
            this.BuyManager.Click += new System.EventHandler(this.BuyManager_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(21, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 40);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Buy a Manager for a random store";
            // 
            // ItemStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AttackOfTheKarens.Properties.Resources.ShopShelves;
            this.ClientSize = new System.Drawing.Size(322, 383);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BuyManager);
            this.Name = "ItemStore";
            this.Text = "ItemStore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button BuyManager;
        private System.Windows.Forms.TextBox textBox1;
    }
    #endregion

   
}