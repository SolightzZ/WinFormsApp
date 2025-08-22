namespace EX1
{
    partial class ProductByCategory
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
            cboCategory = new ComboBox();
            tbtnShow = new Button();
            dgvResult = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(206, 12);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(300, 28);
            cboCategory.TabIndex = 0;
            // 
            // tbtnShow
            // 
            tbtnShow.Location = new Point(552, 11);
            tbtnShow.Name = "tbtnShow";
            tbtnShow.Size = new Size(94, 29);
            tbtnShow.TabIndex = 1;
            tbtnShow.Text = "button1";
            tbtnShow.UseVisualStyleBackColor = true;
            tbtnShow.Click += tbtnShow_Click;
            // 
            // dgvResult
            // 
            dgvResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(22, 56);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(758, 365);
            dgvResult.TabIndex = 2;
            // 
            // ProductByCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvResult);
            Controls.Add(tbtnShow);
            Controls.Add(cboCategory);
            Name = "ProductByCategory";
            Text = "ProductByCategory";
            WindowState = FormWindowState.Maximized;
            Load += ProductByCategory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboCategory;
        private Button tbtnShow;
        private DataGridView dgvResult;
    }
}