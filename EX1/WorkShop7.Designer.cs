namespace EX1
{
    partial class WorkShop7
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
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // dgvResult
            // 
            dgvResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(2, 47);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(1239, 646);
            dgvResult.TabIndex = 0;
            dgvResult.CellContentClick += dgvResult_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Moji", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, -9);
            label1.Name = "label1";
            label1.Size = new Size(403, 53);
            label1.TabIndex = 1;
            label1.Text = "ข้อมูลจำนวนสินค้าแยกตามประเภท";
            label1.Click += label1_Click;
            // 
            // WorkShop7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 719);
            Controls.Add(label1);
            Controls.Add(dgvResult);
            Name = "WorkShop7";
            Text = "WorkShop7";
            WindowState = FormWindowState.Maximized;
            Load += WorkShop7_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvResult;
        private Label label1;
    }
}