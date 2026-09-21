namespace CafeStatusDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateStatus();
        }

        private void timer1_Tick(object? sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            DateTime now = DateTime.Now;
            lblGioHienTai.Text = now.ToString("HH:mm:ss");

            if (now.Hour >= 6 && now.Hour < 22)
            {
                lblTrangThai.Text = "Đang mở cửa";
                lblTrangThai.ForeColor = Color.Green;
            }
            else
            {
                lblTrangThai.Text = "Đã đóng cửa";
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        private void menuDoiMauNen_Click(object? sender, EventArgs e)
        {
            using ColorDialog colorDialog = new();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog.Color;
            }
        }

        private void menuThoat_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
