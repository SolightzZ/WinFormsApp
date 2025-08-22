namespace WinForms_2
{
    partial class MainMenu
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
            menuStrip1 = new MenuStrip();
            ใบงานToolStripMenuItem = new ToolStripMenuItem();
            ใบงาน1ToolStripMenuItem1 = new ToolStripMenuItem();
            ใบงาน2ToolStripMenuItem = new ToolStripMenuItem();
            ใบงาน3ToolStripMenuItem = new ToolStripMenuItem();
            ใบงาน4ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ใบงานToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ใบงานToolStripMenuItem
            // 
            ใบงานToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ใบงาน1ToolStripMenuItem1, ใบงาน2ToolStripMenuItem, ใบงาน3ToolStripMenuItem, ใบงาน4ToolStripMenuItem });
            ใบงานToolStripMenuItem.Name = "ใบงานToolStripMenuItem";
            ใบงานToolStripMenuItem.Size = new Size(60, 24);
            ใบงานToolStripMenuItem.Text = "ใบงาน";
            // 
            // ใบงาน1ToolStripMenuItem1
            // 
            ใบงาน1ToolStripMenuItem1.Name = "ใบงาน1ToolStripMenuItem1";
            ใบงาน1ToolStripMenuItem1.Size = new Size(224, 26);
            ใบงาน1ToolStripMenuItem1.Text = "ใบงาน1";
            // 
            // ใบงาน2ToolStripMenuItem
            // 
            ใบงาน2ToolStripMenuItem.Name = "ใบงาน2ToolStripMenuItem";
            ใบงาน2ToolStripMenuItem.Size = new Size(224, 26);
            ใบงาน2ToolStripMenuItem.Text = "ใบงาน2";
            // 
            // ใบงาน3ToolStripMenuItem
            // 
            ใบงาน3ToolStripMenuItem.Name = "ใบงาน3ToolStripMenuItem";
            ใบงาน3ToolStripMenuItem.Size = new Size(224, 26);
            ใบงาน3ToolStripMenuItem.Text = "ใบงาน3";
            ใบงาน3ToolStripMenuItem.Click += ใบงาน3ToolStripMenuItem_Click;
            // 
            // ใบงาน4ToolStripMenuItem
            // 
            ใบงาน4ToolStripMenuItem.Name = "ใบงาน4ToolStripMenuItem";
            ใบงาน4ToolStripMenuItem.Size = new Size(224, 26);
            ใบงาน4ToolStripMenuItem.Text = "ใบงาน4";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainMenu";
            Text = "MainMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ใบงานToolStripMenuItem;
        private ToolStripMenuItem ใบงาน1ToolStripMenuItem1;
        private ToolStripMenuItem ใบงาน2ToolStripMenuItem;
        private ToolStripMenuItem ใบงาน3ToolStripMenuItem;
        private ToolStripMenuItem ใบงาน4ToolStripMenuItem;
    }
}