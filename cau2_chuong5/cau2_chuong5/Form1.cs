namespace cau2_chuong5
{
    public partial class Form1 : Form
    {
        private readonly List<(Point Start, Point End)> lines = [];
        private bool isDrawing;
        private Point lastPoint;

        public Form1()
        {
            InitializeComponent();
        }

        private void pnlCanvas_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            isDrawing = true;
            lastPoint = e.Location;
            lblViTri.Text = $"Đang vẽ...  Tọa độ: ({e.X}, {e.Y})";
        }

        private void pnlCanvas_MouseMove(object? sender, MouseEventArgs e)
        {
            lblViTri.Text = isDrawing
                ? $"Đang vẽ...  Tọa độ: ({e.X}, {e.Y})"
                : $"Sẵn sàng  Tọa độ: ({e.X}, {e.Y})";

            if (!isDrawing || e.Button != MouseButtons.Left)
            {
                return;
            }

            lines.Add((lastPoint, e.Location));
            lastPoint = e.Location;
            pnlCanvas.Invalidate();
        }

        private void pnlCanvas_MouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            isDrawing = false;
            lblViTri.Text = $"Sẵn sàng  Tọa độ: ({e.X}, {e.Y})";
        }

        private void pnlCanvas_MouseClick(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            lines.Clear();
            isDrawing = false;
            pnlCanvas.Invalidate();
            lblViTri.Text = $"Sẵn sàng  Tọa độ: ({e.X}, {e.Y})";
        }

        private void pnlCanvas_Paint(object? sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using Pen pen = new(Color.Black, 2);
            foreach ((Point start, Point end) in lines)
            {
                e.Graphics.DrawLine(pen, start, end);
            }
        }
    }
}
