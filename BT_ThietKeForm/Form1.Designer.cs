namespace BT_ThietKeForm
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nguyễnHuỳnhTiếnKhảiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TkBai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bài2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nguyễnHuỳnhTiếnKhảiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nguyễnHuỳnhTiếnKhảiToolStripMenuItem
            // 
            this.nguyễnHuỳnhTiếnKhảiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TkBai1,
            this.bài2ToolStripMenuItem,
            this.bài3ToolStripMenuItem});
            this.nguyễnHuỳnhTiếnKhảiToolStripMenuItem.Name = "nguyễnHuỳnhTiếnKhảiToolStripMenuItem";
            this.nguyễnHuỳnhTiếnKhảiToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
            this.nguyễnHuỳnhTiếnKhảiToolStripMenuItem.Text = "Nguyễn Huỳnh Tiến Khải";
            // 
            // TkBai1
            // 
            this.TkBai1.Image = ((System.Drawing.Image)(resources.GetObject("TkBai1.Image")));
            this.TkBai1.Name = "TkBai1";
            this.TkBai1.Size = new System.Drawing.Size(180, 22);
            this.TkBai1.Text = "Bài 1";
            this.TkBai1.Click += new System.EventHandler(this.TkBai1_Click);
            // 
            // bài2ToolStripMenuItem
            // 
            this.bài2ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bài2ToolStripMenuItem.Image")));
            this.bài2ToolStripMenuItem.Name = "bài2ToolStripMenuItem";
            this.bài2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bài2ToolStripMenuItem.Text = "Bài 2";
            // 
            // bài3ToolStripMenuItem
            // 
            this.bài3ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bài3ToolStripMenuItem.Image")));
            this.bài3ToolStripMenuItem.Name = "bài3ToolStripMenuItem";
            this.bài3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bài3ToolStripMenuItem.Text = "Bài 3";
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChinh";
            this.Text = "Chương trình chính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nguyễnHuỳnhTiếnKhảiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TkBai1;
        private System.Windows.Forms.ToolStripMenuItem bài2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài3ToolStripMenuItem;
    }
}

