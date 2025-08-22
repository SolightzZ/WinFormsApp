namespace EX1
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
            workshop5ToolStripMenuItem = new ToolStripMenuItem();
            helpsToolStripMenuItem = new ToolStripMenuItem();
            workshop6ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { workshopToolStripMenuItem, helpsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // workshopToolStripMenuItem
            // 
            workshopToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { workshop1ToolStripMenuItem, workshop2ToolStripMenuItem, workshop3ToolStripMenuItem, workshop4ToolStripMenuItem, workshop5ToolStripMenuItem, workshop6ToolStripMenuItem });
            workshopToolStripMenuItem.Name = "workshopToolStripMenuItem";
            workshopToolStripMenuItem.Size = new Size(87, 24);
            workshopToolStripMenuItem.Text = "workshop";
            // 
            // workshop1ToolStripMenuItem
            // 
            workshop1ToolStripMenuItem.Name = "workshop1ToolStripMenuItem";
            workshop1ToolStripMenuItem.Size = new Size(224, 26);
            workshop1ToolStripMenuItem.Text = "workshop1";
            workshop1ToolStripMenuItem.Click += Workshop1ToolStripMenuItem_Click;
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
            // workshop5ToolStripMenuItem
            // 
            workshop5ToolStripMenuItem.Name = "workshop5ToolStripMenuItem";
            workshop5ToolStripMenuItem.Size = new Size(224, 26);
            workshop5ToolStripMenuItem.Text = "workshop5";
            workshop5ToolStripMenuItem.Click += workshop5ToolStripMenuItem_Click;
            // 
            // helpsToolStripMenuItem
            // 
            helpsToolStripMenuItem.Name = "helpsToolStripMenuItem";
            helpsToolStripMenuItem.Size = new Size(61, 24);
            helpsToolStripMenuItem.Text = "Helps";
            helpsToolStripMenuItem.Click += helpsToolStripMenuItem_Click;
            // 
            // workshop6ToolStripMenuItem
            // 
            workshop6ToolStripMenuItem.Name = "workshop6ToolStripMenuItem";
            workshop6ToolStripMenuItem.Size = new Size(224, 26);
            workshop6ToolStripMenuItem.Text = "workshop6";
            workshop6ToolStripMenuItem.Click += workshop6ToolStripMenuItem_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
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
        private ToolStripMenuItem helpsToolStripMenuItem;
        private ToolStripMenuItem workshop5ToolStripMenuItem;
        private ToolStripMenuItem workshop6ToolStripMenuItem;
    }
}