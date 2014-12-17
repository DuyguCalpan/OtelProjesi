namespace Otel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rezervasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boşOdalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doluOdalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervasyonToolStripMenuItem,
            this.müşteriAraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rezervasyonToolStripMenuItem
            // 
            this.rezervasyonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boşOdalarToolStripMenuItem,
            this.doluOdalarToolStripMenuItem});
            this.rezervasyonToolStripMenuItem.Name = "rezervasyonToolStripMenuItem";
            this.rezervasyonToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.rezervasyonToolStripMenuItem.Text = "Odalar";
            // 
            // boşOdalarToolStripMenuItem
            // 
            this.boşOdalarToolStripMenuItem.Name = "boşOdalarToolStripMenuItem";
            this.boşOdalarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.boşOdalarToolStripMenuItem.Text = "Boş Odalar";
            this.boşOdalarToolStripMenuItem.Click += new System.EventHandler(this.boşOdalarToolStripMenuItem_Click);
            // 
            // doluOdalarToolStripMenuItem
            // 
            this.doluOdalarToolStripMenuItem.Name = "doluOdalarToolStripMenuItem";
            this.doluOdalarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.doluOdalarToolStripMenuItem.Text = "Dolu Odalar";
            this.doluOdalarToolStripMenuItem.Click += new System.EventHandler(this.doluOdalarToolStripMenuItem_Click);
            // 
            // müşteriAraToolStripMenuItem
            // 
            this.müşteriAraToolStripMenuItem.Name = "müşteriAraToolStripMenuItem";
            this.müşteriAraToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.müşteriAraToolStripMenuItem.Text = "Müşteri Ara";
            this.müşteriAraToolStripMenuItem.Click += new System.EventHandler(this.müşteriAraToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boşOdalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doluOdalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriAraToolStripMenuItem;
    }
}

