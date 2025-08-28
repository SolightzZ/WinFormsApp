namespace EX1
{
    partial class WorkShop8
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
            label1 = new Label();
            btnShow = new Button();
            cboCategory = new ComboBox();
            cboYear = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // dgvResult
            // 
            dgvResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(2, 123);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(1561, 663);
            dgvResult.TabIndex = 0;
            dgvResult.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 51);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 1;
            label1.Text = "เลือกประเภทสินค้า";
            label1.Click += label1_Click;
            // 
            // btnShow
            // 
            btnShow.BackColor = SystemColors.ActiveCaption;
            btnShow.ForeColor = SystemColors.ActiveCaptionText;
            btnShow.Location = new Point(1108, 45);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(197, 29);
            btnShow.TabIndex = 2;
            btnShow.Text = "แสดงข้อมูล";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(217, 46);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(537, 28);
            cboCategory.TabIndex = 3;
            // 
            // cboYear
            // 
            cboYear.FormattingEnabled = true;
            cboYear.Location = new Point(861, 46);
            cboYear.Name = "cboYear";
            cboYear.Size = new Size(225, 28);
            cboYear.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(780, 54);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 5;
            label2.Text = "ปีที่จำหน่าย";
            // 
            // WorkShop8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1585, 798);
            Controls.Add(label2);
            Controls.Add(cboYear);
            Controls.Add(cboCategory);
            Controls.Add(btnShow);
            Controls.Add(label1);
            Controls.Add(dgvResult);
            Name = "WorkShop8";
            Text = "WorkShop8";
            WindowState = FormWindowState.Maximized;
            Load += WorkShop8_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvResult;
        private Label label1;
        private Button btnShow;
        private ComboBox cboCategory;
        private ComboBox cboYear;
        private Label label2;
    }
}