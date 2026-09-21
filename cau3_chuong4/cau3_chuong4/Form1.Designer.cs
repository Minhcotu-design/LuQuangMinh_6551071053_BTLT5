namespace cau3_chuong4
{
    partial class Form1
    {
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
            txtCongViecMoi = new TextBox();
            btnThem = new Button();
            lstCongViec = new ListBox();
            cmsCongViec = new ContextMenuStrip(components);
            mnuDanhDauHoanThanh = new ToolStripMenuItem();
            mnuXoaCongViec = new ToolStripMenuItem();
            mnuXoaTatCa = new ToolStripMenuItem();
            pnlNhapCongViec = new TableLayoutPanel();
            cmsCongViec.SuspendLayout();
            pnlNhapCongViec.SuspendLayout();
            SuspendLayout();
            // 
            // txtCongViecMoi
            // 
            txtCongViecMoi.Dock = DockStyle.Fill;
            txtCongViecMoi.Location = new Point(3, 8);
            txtCongViecMoi.Margin = new Padding(3, 8, 3, 8);
            txtCongViecMoi.Name = "txtCongViecMoi";
            txtCongViecMoi.PlaceholderText = "Nhập công việc mới";
            txtCongViecMoi.Size = new Size(713, 27);
            txtCongViecMoi.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.AutoSize = true;
            btnThem.Dock = DockStyle.Fill;
            btnThem.Location = new Point(722, 5);
            btnThem.Margin = new Padding(3, 5, 3, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 30);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lstCongViec
            // 
            lstCongViec.ContextMenuStrip = cmsCongViec;
            lstCongViec.Dock = DockStyle.Fill;
            lstCongViec.FormattingEnabled = true;
            lstCongViec.Location = new Point(0, 40);
            lstCongViec.Name = "lstCongViec";
            lstCongViec.Size = new Size(800, 410);
            lstCongViec.TabIndex = 1;
            // 
            // cmsCongViec
            // 
            cmsCongViec.ImageScalingSize = new Size(20, 20);
            cmsCongViec.Items.AddRange(new ToolStripItem[] { mnuDanhDauHoanThanh, mnuXoaCongViec, mnuXoaTatCa });
            cmsCongViec.Name = "cmsCongViec";
            cmsCongViec.Size = new Size(221, 76);
            // 
            // mnuDanhDauHoanThanh
            // 
            mnuDanhDauHoanThanh.Name = "mnuDanhDauHoanThanh";
            mnuDanhDauHoanThanh.Size = new Size(220, 24);
            mnuDanhDauHoanThanh.Text = "Đánh dấu hoàn thành";
            mnuDanhDauHoanThanh.Click += mnuDanhDauHoanThanh_Click;
            // 
            // mnuXoaCongViec
            // 
            mnuXoaCongViec.Name = "mnuXoaCongViec";
            mnuXoaCongViec.Size = new Size(220, 24);
            mnuXoaCongViec.Text = "Xóa công việc này";
            mnuXoaCongViec.Click += mnuXoaCongViec_Click;
            // 
            // mnuXoaTatCa
            // 
            mnuXoaTatCa.Name = "mnuXoaTatCa";
            mnuXoaTatCa.Size = new Size(220, 24);
            mnuXoaTatCa.Text = "Xóa tất cả";
            mnuXoaTatCa.Click += mnuXoaTatCa_Click;
            // 
            // pnlNhapCongViec
            // 
            pnlNhapCongViec.ColumnCount = 2;
            pnlNhapCongViec.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlNhapCongViec.ColumnStyles.Add(new ColumnStyle());
            pnlNhapCongViec.Controls.Add(txtCongViecMoi, 0, 0);
            pnlNhapCongViec.Controls.Add(btnThem, 1, 0);
            pnlNhapCongViec.Dock = DockStyle.Top;
            pnlNhapCongViec.Location = new Point(0, 0);
            pnlNhapCongViec.Name = "pnlNhapCongViec";
            pnlNhapCongViec.RowCount = 1;
            pnlNhapCongViec.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlNhapCongViec.Size = new Size(800, 40);
            pnlNhapCongViec.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstCongViec);
            Controls.Add(pnlNhapCongViec);
            Name = "Form1";
            Text = "Danh sách công việc";
            cmsCongViec.ResumeLayout(false);
            pnlNhapCongViec.ResumeLayout(false);
            pnlNhapCongViec.PerformLayout();
            ResumeLayout(false);
        }

        private TextBox txtCongViecMoi;
        private Button btnThem;
        private ListBox lstCongViec;
        private ContextMenuStrip cmsCongViec;
        private ToolStripMenuItem mnuDanhDauHoanThanh;
        private ToolStripMenuItem mnuXoaCongViec;
        private ToolStripMenuItem mnuXoaTatCa;
        private TableLayoutPanel pnlNhapCongViec;

        #endregion
    }
}
