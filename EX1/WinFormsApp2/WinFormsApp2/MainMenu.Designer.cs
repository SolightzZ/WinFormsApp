namespace WinFormsApp2
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
            workshopToolStripMenuItem = new ToolStripMenuItem();
            workshop1ToolStripMenuItem = new ToolStripMenuItem();
            workshop2ToolStripMenuItem = new ToolStripMenuItem();
            workshop3ToolStripMenuItem = new ToolStripMenuItem();
            workshop4ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { workshopToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1361, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // workshopToolStripMenuItem
            // 
            workshopToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { workshop1ToolStripMenuItem, workshop2ToolStripMenuItem, workshop3ToolStripMenuItem, workshop4ToolStripMenuItem });
            workshopToolStripMenuItem.Name = "workshopToolStripMenuItem";
            workshopToolStripMenuItem.Size = new Size(89, 24);
            workshopToolStripMenuItem.Text = "Workshop";
            workshopToolStripMenuItem.Click += workshopToolStripMenuItem_Click;
            // 
            // workshop1ToolStripMenuItem
            // 
            workshop1ToolStripMenuItem.Name = "workshop1ToolStripMenuItem";
            workshop1ToolStripMenuItem.Size = new Size(224, 26);
            workshop1ToolStripMenuItem.Text = "workshop1";
            // 
            // workshop2ToolStripMenuItem
            // 
            workshop2ToolStripMenuItem.Name = "workshop2ToolStripMenuItem";
            workshop2ToolStripMenuItem.Size = new Size(224, 26);
            workshop2ToolStripMenuItem.Text = "workshop2";
            workshop2ToolStripMenuItem.Click += workshop2ToolStripMenuItem_Click;
            // 
            // workshop3ToolStripMenuItem
            // 
            workshop3ToolStripMenuItem.Name = "workshop3ToolStripMenuItem";
            workshop3ToolStripMenuItem.Size = new Size(224, 26);
            workshop3ToolStripMenuItem.Text = "workshop3";
            workshop3ToolStripMenuItem.Click += workshop3ToolStripMenuItem_Click;
            // 
            // workshop4ToolStripMenuItem
            // 
            workshop4ToolStripMenuItem.Name = "workshop4ToolStripMenuItem";
            workshop4ToolStripMenuItem.Size = new Size(224, 26);
            workshop4ToolStripMenuItem.Text = "workshop4";
            workshop4ToolStripMenuItem.Click += workshop4ToolStripMenuItem_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 552);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            Name = "MainMenu";
            Text = "MainMenu";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem workshopToolStripMenuItem;
        private ToolStripMenuItem workshop1ToolStripMenuItem;
        private ToolStripMenuItem workshop2ToolStripMenuItem;
        private ToolStripMenuItem workshop3ToolStripMenuItem;
        private ToolStripMenuItem workshop4ToolStripMenuItem;
    }
}