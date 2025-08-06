namespace WinFormsApp2
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
            label1 = new Label();
            cboCountry = new ComboBox();
            tbtnShow = new Button();
            dgvResult = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 57);
            label1.Name = "label1";
            label1.Size = new Size(148, 38);
            label1.TabIndex = 0;
            label1.Text = "เลือกประเทศ";
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(280, 57);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(430, 45);
            cboCountry.TabIndex = 1;
            cboCountry.SelectedIndexChanged += cboCountry_SelectedIndexChanged;
            // 
            // tbtnShow
            // 
            tbtnShow.Location = new Point(801, 58);
            tbtnShow.Name = "tbtnShow";
            tbtnShow.Size = new Size(161, 44);
            tbtnShow.TabIndex = 2;
            tbtnShow.Text = "เเสดงข้อมูล";
            tbtnShow.UseVisualStyleBackColor = true;
            tbtnShow.Click += tbtnShow_Click;
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(52, 122);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(1419, 698);
            dgvResult.TabIndex = 3;
            dgvResult.CellContentClick += dgvResult_CellContentClick;
            // 
            // CustomerByCountry
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 832);
            Controls.Add(dgvResult);
            Controls.Add(tbtnShow);
            Controls.Add(cboCountry);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "CustomerByCountry";
            Text = "CustomerByCountry";
            Load += CustomerByCountry_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboCountry;
        private Button tbtnShow;
        private DataGridView dgvResult;
    }
}