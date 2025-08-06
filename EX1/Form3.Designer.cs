namespace EX1
{
    partial class Form3
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
            btnshow = new Button();
            txtMinPrice = new TextBox();
            txtMaxPrice = new TextBox();
            dgvResultShow = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResultShow).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 50);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 0;
            label1.Text = "ป้อนราคาสินค้า เริ่มต้น";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 51);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 0;
            label2.Text = "ถึงราคา";
            label2.Click += label2_Click;
            // 
            // btnshow
            // 
            btnshow.Location = new Point(571, 46);
            btnshow.Name = "btnshow";
            btnshow.Size = new Size(153, 29);
            btnshow.TabIndex = 1;
            btnshow.Text = "แสดงข้อมูล";
            btnshow.UseVisualStyleBackColor = true;
            btnshow.Click += btnshow_Click;
            // 
            // txtMinPrice
            // 
            txtMinPrice.Location = new Point(164, 47);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.Size = new Size(168, 27);
            txtMinPrice.TabIndex = 2;
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.Location = new Point(397, 48);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.Size = new Size(168, 27);
            txtMaxPrice.TabIndex = 2;
            // 
            // dgvResultShow
            // 
            dgvResultShow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResultShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultShow.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvResultShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultShow.Location = new Point(12, 93);
            dgvResultShow.Name = "dgvResultShow";
            dgvResultShow.RowHeadersWidth = 51;
            dgvResultShow.Size = new Size(776, 344);
            dgvResultShow.TabIndex = 3;
            dgvResultShow.CellContentClick += dgvResultShow_CellContentClick;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvResultShow);
            Controls.Add(txtMaxPrice);
            Controls.Add(txtMinPrice);
            Controls.Add(btnshow);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvResultShow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnshow;
        private TextBox txtMinPrice;
        private TextBox txtMaxPrice;
        private DataGridView dgvResultShow;
    }
}