namespace EX1
{
    partial class test
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
            bntT = new Button();
            SuspendLayout();
            // 
            // bntT
            // 
            bntT.Location = new Point(305, 172);
            bntT.Name = "bntT";
            bntT.Size = new Size(94, 29);
            bntT.TabIndex = 0;
            bntT.Text = "button1";
            bntT.TextAlign = ContentAlignment.TopCenter;
            bntT.UseVisualStyleBackColor = true;
            bntT.Click += bntT_Click;
            // 
            // test
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bntT);
            Name = "test";
            Text = "test";
            Load += test_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button bntT;
    }
}