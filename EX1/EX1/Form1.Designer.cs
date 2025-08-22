namespace EX1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            BTNOK = new Button();
            txtName = new TextBox();
            label1 = new Label();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // BTNOK
            // 
            BTNOK.FlatStyle = FlatStyle.Popup;
            BTNOK.Font = new Font("Moji", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTNOK.ForeColor = SystemColors.ActiveCaptionText;
            BTNOK.Location = new Point(346, 262);
            BTNOK.Name = "BTNOK";
            BTNOK.Size = new Size(295, 83);
            BTNOK.TabIndex = 0;
            BTNOK.TabStop = false;
            BTNOK.Text = "OK";
            BTNOK.UseVisualStyleBackColor = true;
            BTNOK.Click += button1_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Moji", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(12, 156);
            txtName.Name = "txtName";
            txtName.Size = new Size(979, 83);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Moji", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(450, 84);
            label1.Name = "label1";
            label1.Size = new Size(112, 56);
            label1.TabIndex = 2;
            label1.Text = "ป้อนชื่อ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 660);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(BTNOK);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNOK;
        private TextBox txtName;
        private Label label1;
        private BindingSource bindingSource1;
    }
}
