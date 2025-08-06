namespace WinFormsApp2
{
    partial class ProductByUnitprice
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
            label2 = new Label();
            txtMaxPrice = new TextBox();
            txtMinPrice = new TextBox();
            btnShow = new Button();
            dgvResault = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResault).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 51);
            label1.Name = "label1";
            label1.Size = new Size(248, 38);
            label1.TabIndex = 0;
            label1.Text = "ป้อนราคาสินค้าเริ่มต้น";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(701, 51);
            label2.Name = "label2";
            label2.Size = new Size(98, 38);
            label2.TabIndex = 1;
            label2.Text = "ถึงราคา";
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.Location = new Point(817, 51);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.Size = new Size(275, 43);
            txtMaxPrice.TabIndex = 2;
            txtMaxPrice.TextChanged += txtMaxPrice_TextChanged;
            // 
            // txtMinPrice
            // 
            txtMinPrice.Location = new Point(309, 51);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.Size = new Size(275, 43);
            txtMinPrice.TabIndex = 2;
            txtMinPrice.TextChanged += txtMinPrice_TextChanged;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(1167, 47);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(160, 47);
            btnShow.TabIndex = 3;
            btnShow.Text = "เเสดงข้อมูล";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // dgvResault
            // 
            dgvResault.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResault.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResault.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResault.Location = new Point(33, 133);
            dgvResault.Name = "dgvResault";
            dgvResault.RowHeadersWidth = 51;
            dgvResault.Size = new Size(1434, 666);
            dgvResault.TabIndex = 4;
            // 
            // ProductByUnitprice
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 832);
            Controls.Add(dgvResault);
            Controls.Add(btnShow);
            Controls.Add(txtMinPrice);
            Controls.Add(txtMaxPrice);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "ProductByUnitprice";
            Text = "ProductByUnitprice";
            WindowState = FormWindowState.Maximized;
            Load += ProductByUnitprice_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResault).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMaxPrice;
        private TextBox txtMinPrice;
        private Button btnShow;
        private DataGridView dgvResault;
    }
}