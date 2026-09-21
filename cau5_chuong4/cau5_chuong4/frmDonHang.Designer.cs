namespace cau5_chuong4
{
    partial class frmDonHang
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTenSanPham;
        private Label lblSoLuong;
        private Label lblDonGia;
        private TextBox txtTenSanPham;
        private NumericUpDown nudSoLuong;
        private TextBox txtDonGia;
        private Button btnThem;
        private ListView lvSanPham;
        private ColumnHeader colTen;
        private ColumnHeader colSoLuong;
        private ColumnHeader colDonGia;
        private ColumnHeader colThanhTien;
        private Label lblTongTien;
        private ContextMenuStrip contextMenuListView;
        private ToolStripMenuItem deleteItemMenu;
        private ToolStripMenuItem editQuantityMenu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTenSanPham = new Label();
            lblSoLuong = new Label();
            lblDonGia = new Label();
            txtTenSanPham = new TextBox();
            nudSoLuong = new NumericUpDown();
            txtDonGia = new TextBox();
            btnThem = new Button();
            lvSanPham = new ListView();
            colTen = new ColumnHeader();
            colSoLuong = new ColumnHeader();
            colDonGia = new ColumnHeader();
            colThanhTien = new ColumnHeader();
            lblTongTien = new Label();
            contextMenuListView = new ContextMenuStrip(components);
            deleteItemMenu = new ToolStripMenuItem();
            editQuantityMenu = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            contextMenuListView.SuspendLayout();
            SuspendLayout();
            lblTenSanPham.AutoSize = true;
            lblTenSanPham.Location = new Point(20, 22);
            lblTenSanPham.Text = "Tên sản phẩm:";
            txtTenSanPham.Location = new Point(115, 18);
            txtTenSanPham.Size = new Size(230, 23);
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(365, 22);
            lblSoLuong.Text = "Số lượng:";
            nudSoLuong.Location = new Point(430, 18);
            nudSoLuong.Minimum = 1;
            nudSoLuong.Maximum = 1000000;
            nudSoLuong.Value = 1;
            nudSoLuong.Size = new Size(90, 23);
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(540, 22);
            lblDonGia.Text = "Đơn giá:";
            txtDonGia.Location = new Point(600, 18);
            txtDonGia.Size = new Size(120, 23);
            btnThem.Location = new Point(740, 17);
            btnThem.Size = new Size(90, 25);
            btnThem.Text = "Thêm";
            btnThem.Click += AddProduct_Click;
            lvSanPham.Columns.AddRange(new ColumnHeader[] { colTen, colSoLuong, colDonGia, colThanhTien });
            lvSanPham.ContextMenuStrip = contextMenuListView;
            lvSanPham.FullRowSelect = true;
            lvSanPham.GridLines = true;
            lvSanPham.Location = new Point(20, 65);
            lvSanPham.MultiSelect = false;
            lvSanPham.Size = new Size(810, 330);
            lvSanPham.View = View.Details;
            colTen.Text = "Tên sản phẩm";
            colTen.Width = 300;
            colSoLuong.Text = "SL";
            colSoLuong.Width = 100;
            colDonGia.Text = "Đơn giá";
            colDonGia.Width = 180;
            colThanhTien.Text = "Thành tiền";
            colThanhTien.Width = 200;
            lblTongTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTongTien.Location = new Point(620, 415);
            lblTongTien.Text = "Tổng tiền: 0 đ";
            contextMenuListView.Items.AddRange(new ToolStripItem[] { deleteItemMenu, editQuantityMenu });
            deleteItemMenu.Text = "Xóa dòng đã chọn";
            deleteItemMenu.Click += DeleteSelected_Click;
            editQuantityMenu.Text = "Sửa số lượng";
            editQuantityMenu.Click += EditQuantity_Click;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 460);
            Controls.Add(lblTongTien);
            Controls.Add(lvSanPham);
            Controls.Add(btnThem);
            Controls.Add(txtDonGia);
            Controls.Add(nudSoLuong);
            Controls.Add(txtTenSanPham);
            Controls.Add(lblDonGia);
            Controls.Add(lblSoLuong);
            Controls.Add(lblTenSanPham);
            Name = "frmDonHang";
            Text = "Đơn hàng mới";
            FormClosing += Order_FormClosing;
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            contextMenuListView.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
