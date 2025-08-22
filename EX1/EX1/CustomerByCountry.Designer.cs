namespace EX1
{
    partial class CustomerByCountry
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
            dgvResult = new DataGridView();
            tbtnShow = new Button();
            cboCountry = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // dgvResult
            // 
            dgvResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(22, 74);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(766, 364);
            dgvResult.TabIndex = 0;
            dgvResult.VirtualMode = true;
            dgvResult.CellContentClick += dgvResult_CellContentClick;
            // 
            // tbtnShow
            // 
            tbtnShow.Location = new Point(619, 24);
            tbtnShow.Name = "tbtnShow";
            tbtnShow.Size = new Size(94, 29);
            tbtnShow.TabIndex = 1;
            tbtnShow.Text = "button1";
            tbtnShow.UseVisualStyleBackColor = true;
            tbtnShow.Click += tbtnShow_Click;
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(134, 24);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(479, 28);
            cboCountry.TabIndex = 2;
            cboCountry.SelectedIndexChanged += cboCountry_SelectedIndexChanged;
            // 
            // CustomerByCountry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboCountry);
            Controls.Add(tbtnShow);
            Controls.Add(dgvResult);
            Name = "CustomerByCountry";
            Text = "CustomerByCountry";
            WindowState = FormWindowState.Maximized;
            Load += CustomerByCountry_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvResult;
        private Button tbtnShow;
        private ComboBox cboCountry;
    }
}