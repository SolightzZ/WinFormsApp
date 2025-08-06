namespace EX1
{
    partial class ShowAllProducts
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
            dgvResult2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResult2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(117, 37);
            label1.TabIndex = 0;
            label1.Text = "ข้อมูลสินค้า";
            label1.Click += label1_Click;
            // 
            // dgvResult2
            // 
            dgvResult2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResult2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResult2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult2.Location = new Point(12, 67);
            dgvResult2.Name = "dgvResult2";
            dgvResult2.RowHeadersWidth = 51;
            dgvResult2.Size = new Size(825, 597);
            dgvResult2.TabIndex = 1;
            dgvResult2.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ShowAllProducts
            // 
            AutoScaleDimensions = new SizeF(15F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 810);
            Controls.Add(dgvResult2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "ShowAllProducts";
            Text = "โชว์ข้อมูลสินค้าทั้งหมด";
            Load += ShowAllProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvResult2;
    }
}