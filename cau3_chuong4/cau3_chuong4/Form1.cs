namespace cau3_chuong4
{
    public partial class Form1 : Form
    {
        private const string TienToHoanThanh = "[Hoàn thành] ";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object? sender, EventArgs e)
        {
            string congViec = txtCongViecMoi.Text.Trim();

            if (congViec.Length == 0)
            {
                return;
            }

            lstCongViec.Items.Add(congViec);
            txtCongViecMoi.Clear();
            txtCongViecMoi.Focus();
        }

        private void mnuDanhDauHoanThanh_Click(object? sender, EventArgs e)
        {
            if (lstCongViec.SelectedIndex < 0)
            {
                return;
            }

            int selectedIndex = lstCongViec.SelectedIndex;
            string congViec = lstCongViec.SelectedItem?.ToString() ?? string.Empty;

            if (!congViec.StartsWith(TienToHoanThanh, StringComparison.Ordinal))
            {
                lstCongViec.Items[selectedIndex] = TienToHoanThanh + congViec;
            }
        }

        private void mnuXoaCongViec_Click(object? sender, EventArgs e)
        {
            if (lstCongViec.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn công việc trước khi xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstCongViec.Items.RemoveAt(lstCongViec.SelectedIndex);
        }

        private void mnuXoaTatCa_Click(object? sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn xóa tất cả công việc không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                lstCongViec.Items.Clear();
            }
        }
    }
}
