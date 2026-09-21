namespace cau1_chuong5
{
    partial class Form1
    {
        private Label lblMaSP;
        private Label lblSoLuong;
        private Label lblDonGia;
        private TextBox txtMaSP;
        private TextBox txtSoLuong;
        private TextBox txtDonGia;
        private Button btnThem;
        private Button btnXoaTrang;
        private ListBox lstSanPham;

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
            lblMaSP = new Label();
            lblSoLuong = new Label();
            lblDonGia = new Label();
            txtMaSP = new TextBox();
            txtSoLuong = new TextBox();
            txtDonGia = new TextBox();
            btnThem = new Button();
            btnXoaTrang = new Button();
            lstSanPham = new ListBox();
            SuspendLayout();

            lblMaSP.AutoSize = true;
            lblMaSP.Location = new Point(35, 35);
            lblMaSP.Text = "Mã sản phẩm:";

            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(35, 80);
            lblSoLuong.Text = "Số lượng:";

            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(35, 125);
            lblDonGia.Text = "Đơn giá:";

            txtMaSP.Location = new Point(145, 32);
            txtMaSP.Size = new Size(240, 27);
            txtMaSP.TabIndex = 0;

            txtSoLuong.Location = new Point(145, 77);
            txtSoLuong.Size = new Size(240, 27);
            txtSoLuong.TabIndex = 1;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;

            txtDonGia.Location = new Point(145, 122);
            txtDonGia.Size = new Size(240, 27);
            txtDonGia.TabIndex = 2;
            txtDonGia.KeyPress += txtDonGia_KeyPress;

            btnThem.Location = new Point(420, 31);
            btnThem.Size = new Size(130, 35);
            btnThem.Text = "Thêm (F2)";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;

            btnXoaTrang.Location = new Point(420, 76);
            btnXoaTrang.Size = new Size(130, 35);
            btnXoaTrang.Text = "Xóa trắng (F5)";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click;

            lstSanPham.FormattingEnabled = true;
            lstSanPham.HorizontalScrollbar = true;
            lstSanPham.ItemHeight = 20;
            lstSanPham.Location = new Point(35, 180);
            lstSanPham.Size = new Size(515, 164);
            lstSanPham.TabIndex = 3;

            AcceptButton = btnThem;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 385);
            Controls.Add(lstSanPham);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnThem);
            Controls.Add(txtDonGia);
            Controls.Add(txtSoLuong);
            Controls.Add(txtMaSP);
            Controls.Add(lblDonGia);
            Controls.Add(lblSoLuong);
            Controls.Add(lblMaSP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            KeyPreview = true;
            Name = "FormBanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form nhập liệu siêu thị";
            KeyDown += Form1_KeyDown;
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
