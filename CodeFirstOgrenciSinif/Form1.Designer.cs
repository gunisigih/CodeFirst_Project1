namespace CodeFirstOgrenciSinif
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
            this.sınıflarınTanımlanmasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ögrencilerinTanımlanmasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sınıflarınTanımlanmasıToolStripMenuItem,
            this.ögrencilerinTanımlanmasıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sınıflarınTanımlanmasıToolStripMenuItem
            // 
            this.sınıflarınTanımlanmasıToolStripMenuItem.Name = "sınıflarınTanımlanmasıToolStripMenuItem";
            this.sınıflarınTanımlanmasıToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.sınıflarınTanımlanmasıToolStripMenuItem.Text = "SınıflarınTanımlanması";
            this.sınıflarınTanımlanmasıToolStripMenuItem.Click += new System.EventHandler(this.sınıflarınTanımlanmasıToolStripMenuItem_Click);
            // 
            // ögrencilerinTanımlanmasıToolStripMenuItem
            // 
            this.ögrencilerinTanımlanmasıToolStripMenuItem.Name = "ögrencilerinTanımlanmasıToolStripMenuItem";
            this.ögrencilerinTanımlanmasıToolStripMenuItem.Size = new System.Drawing.Size(162, 20);
            this.ögrencilerinTanımlanmasıToolStripMenuItem.Text = "Ögrencilerin Tanımlanması";
            this.ögrencilerinTanımlanmasıToolStripMenuItem.Click += new System.EventHandler(this.ögrencilerinTanımlanmasıToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem sınıflarınTanımlanmasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ögrencilerinTanımlanmasıToolStripMenuItem;
    }
}

