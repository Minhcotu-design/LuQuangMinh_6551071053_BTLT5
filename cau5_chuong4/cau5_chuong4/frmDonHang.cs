namespace cau5_chuong4
{
    public partial class frmDonHang : Form
    {
        public frmDonHang()
        {
            InitializeComponent();
        }

        private void AddProduct_Click(object? sender, EventArgs e)
        {
            var productName = txtTenSanPham.Text.Trim();
            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSanPham.Focus();
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text.Trim(), out var unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            var quantity = (int)nudSoLuong.Value;
            var item = new ListViewItem(productName);
            item.SubItems.Add(quantity.ToString());
            item.SubItems.Add(unitPrice.ToString("N0"));
            item.SubItems.Add((quantity * unitPrice).ToString("N0"));
            item.Tag = unitPrice;
            lvSanPham.Items.Add(item);
            UpdateTotal();
            txtTenSanPham.Clear();
            nudSoLuong.Value = 1;
            txtDonGia.Clear();
            txtTenSanPham.Focus();
        }

        private void DeleteSelected_Click(object? sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (ListViewItem item in lvSanPham.SelectedItems)
            {
                item.Remove();
            }
            UpdateTotal();
        }

        private void EditQuantity_Click(object? sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var item = lvSanPham.SelectedItems[0];
            var quantity = int.Parse(item.SubItems[1].Text);
            using var dialog = new QuantityDialog(quantity);
            if (dialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            item.SubItems[1].Text = dialog.Quantity.ToString();
            var unitPrice = (decimal)item.Tag!;
            item.SubItems[3].Text = (dialog.Quantity * unitPrice).ToString("N0");
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (ListViewItem item in lvSanPham.Items)
            {
                total += decimal.Parse(item.SubItems[3].Text, System.Globalization.NumberStyles.Number);
            }
            lblTongTien.Text = $"Tổng tiền: {total:N0} đ";
        }

        private void Order_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (lvSanPham.Items.Count == 0)
            {
                return;
            }

            var result = MessageBox.Show(
                "Đơn hàng vẫn còn sản phẩm chưa chốt. Bạn có chắc muốn đóng không?",
                "Xác nhận đóng đơn hàng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            e.Cancel = result == DialogResult.No;
        }

        private sealed class QuantityDialog : Form
        {
            private readonly NumericUpDown quantityInput;
            public int Quantity => (int)quantityInput.Value;

            public QuantityDialog(int quantity)
            {
                Text = "Sửa số lượng";
                FormBorderStyle = FormBorderStyle.FixedDialog;
                StartPosition = FormStartPosition.CenterParent;
                ClientSize = new Size(260, 115);
                MinimizeBox = false;
                MaximizeBox = false;
                ShowInTaskbar = false;

                var label = new Label { AutoSize = true, Location = new Point(12, 15), Text = "Số lượng mới:" };
                quantityInput = new NumericUpDown
                {
                    Location = new Point(115, 12),
                    Size = new Size(125, 23),
                    Minimum = 1,
                    Maximum = 1_000_000,
                    Value = Math.Clamp(quantity, 1, 1_000_000)
                };
                var okButton = new Button { DialogResult = DialogResult.OK, Location = new Point(115, 62), Size = new Size(60, 28), Text = "OK" };
                var cancelButton = new Button { DialogResult = DialogResult.Cancel, Location = new Point(180, 62), Size = new Size(60, 28), Text = "Hủy" };
                Controls.AddRange(new Control[] { label, quantityInput, okButton, cancelButton });
                AcceptButton = okButton;
                CancelButton = cancelButton;
            }
        }
    }
}
