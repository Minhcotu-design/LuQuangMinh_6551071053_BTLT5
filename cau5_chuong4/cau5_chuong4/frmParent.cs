namespace cau5_chuong4
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
            UpdateOrderCount();
            UpdateClock(this, EventArgs.Empty);
        }

        private void NewOrder_Click(object? sender, EventArgs e)
        {
            var order = new frmDonHang
            {
                MdiParent = this
            };
            order.Show();
        }

        private void Exit_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void Cascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileHorizontal_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void TileVertical_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void Parent_MdiChildActivate(object? sender, EventArgs e)
        {
            UpdateOrderCount();
        }

        private void UpdateOrderCount()
        {
            lblSoDon.Text = $"Số đơn đang mở: {MdiChildren.Length}";
        }

        private void UpdateClock(object? sender, EventArgs e)
        {
            lblGio.Text = $"Giờ: {DateTime.Now:HH:mm:ss}";
        }
    }
}
