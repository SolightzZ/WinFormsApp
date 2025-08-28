namespace EX1
{
    partial class FromProduct
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
            cboSupplierCountry = new ComboBox();
            btnShow = new Button();
            label2 = new Label();
            cboShipCountry = new ComboBox();
            cboYear = new ComboBox();
            dgvResult = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 40);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 1;
            label1.Text = "สินค้าจากประเทศ";
            // 
            // cboSupplierCountry
            // 
            cboSupplierCountry.FormattingEnabled = true;
            cboSupplierCountry.Location = new Point(157, 32);
            cboSupplierCountry.Name = "cboSupplierCountry";
            cboSupplierCountry.Size = new Size(456, 28);
            cboSupplierCountry.TabIndex = 2;
            cboSupplierCountry.SelectedIndexChanged += cboSupplierCountry_SelectedIndexChanged;
            // 
            // btnShow
            // 
            btnShow.BackColor = SystemColors.ActiveCaption;
            btnShow.Location = new Point(636, 66);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(262, 58);
            btnShow.TabIndex = 3;
            btnShow.Text = "แสดงข้อมูล";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 99);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 1;
            label2.Text = "ส่งไปขายที่ประเทศ";
            // 
            // cboShipCountry
            // 
            cboShipCountry.FormattingEnabled = true;
            cboShipCountry.Location = new Point(157, 96);
            cboShipCountry.Name = "cboShipCountry";
            cboShipCountry.Size = new Size(456, 28);
            cboShipCountry.TabIndex = 2;
            cboShipCountry.SelectedIndexChanged += cboShipCountry_SelectedIndexChanged;
            // 
            // cboYear
            // 
            cboYear.FormattingEnabled = true;
            cboYear.Location = new Point(717, 32);
            cboYear.Name = "cboYear";
            cboYear.Size = new Size(181, 28);
            cboYear.TabIndex = 4;
            cboYear.SelectedIndexChanged += cboYear_SelectedIndexChanged;
            // 
            // dgvResult
            // 
            dgvResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(-1, 175);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(1723, 723);
            dgvResult.TabIndex = 5;
            dgvResult.CellContentClick += dgvResult_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(636, 38);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 1;
            label3.Text = "ปีที่จำหน่าย";
            // 
            // FromProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1747, 910);
            Controls.Add(dgvResult);
            Controls.Add(cboYear);
            Controls.Add(btnShow);
            Controls.Add(cboShipCountry);
            Controls.Add(label2);
            Controls.Add(cboSupplierCountry);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FromProduct";
            StartPosition = FormStartPosition.Manual;
            Text = "FromProduct";
            WindowState = FormWindowState.Maximized;
            Load += FromProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboSupplierCountry;
        private Button btnShow;
        private Label label2;
        private ComboBox cboShipCountry;
        private ComboBox cboYear;
        private DataGridView dgvResult;
        private Label label3;
    }
}