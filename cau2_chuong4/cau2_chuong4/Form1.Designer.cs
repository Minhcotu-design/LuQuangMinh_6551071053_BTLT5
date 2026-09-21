namespace cau2_chuong4
{
    partial class Form1
    {
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGoiTap;
        private System.Windows.Forms.Label lblSoBuoiTuan;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cboGoiTap;
        private System.Windows.Forms.NumericUpDown numSoBuoiTuan;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.ToolTip toolTip1;

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
            lblTieuDe = new Label();
            lblHoTen = new Label();
            lblSDT = new Label();
            lblEmail = new Label();
            lblNgaySinh = new Label();
            lblGoiTap = new Label();
            lblSoBuoiTuan = new Label();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            cboGoiTap = new ComboBox();
            numSoBuoiTuan = new NumericUpDown();
            btnDangKy = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.Location = new Point(230, 25);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(340, 30);
            lblTieuDe.Text = "ĐĂNG KÝ HỘI VIÊN FITLIFE";
            // 
            // labels
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(80, 95);
            lblHoTen.Text = "Họ và tên:";
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(80, 140);
            lblSDT.Text = "Số điện thoại:";
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(80, 185);
            lblEmail.Text = "Email:";
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(80, 230);
            lblNgaySinh.Text = "Ngày sinh:";
            lblGoiTap.AutoSize = true;
            lblGoiTap.Location = new Point(80, 275);
            lblGoiTap.Text = "Gói tập:";
            lblSoBuoiTuan.AutoSize = true;
            lblSoBuoiTuan.Location = new Point(80, 320);
            lblSoBuoiTuan.Text = "Số buổi/tuần:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(220, 92);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(400, 23);
            toolTip1.SetToolTip(txtHoTen, "Nhập họ và tên đầy đủ của hội viên");
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(220, 137);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(400, 23);
            toolTip1.SetToolTip(txtSDT, "Nhập đúng 10 chữ số, không chứa khoảng trắng hay ký tự đặc biệt");
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(220, 182);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(400, 23);
            toolTip1.SetToolTip(txtEmail, "Email dùng để nhận thông báo lịch tập và khuyến mãi");
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(220, 227);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(200, 23);
            toolTip1.SetToolTip(dtpNgaySinh, "Chọn ngày sinh của hội viên");
            // 
            // cboGoiTap
            // 
            cboGoiTap.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGoiTap.Items.AddRange(new object[] { "Basic", "VIP", "Premium" });
            cboGoiTap.Location = new Point(220, 272);
            cboGoiTap.Name = "cboGoiTap";
            cboGoiTap.Size = new Size(200, 23);
            cboGoiTap.SelectedIndex = 0;
            toolTip1.SetToolTip(cboGoiTap, "Gói VIP và Premium có kèm huấn luyện viên riêng");
            // 
            // numSoBuoiTuan
            // 
            numSoBuoiTuan.Location = new Point(220, 317);
            numSoBuoiTuan.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numSoBuoiTuan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoBuoiTuan.Name = "numSoBuoiTuan";
            numSoBuoiTuan.Size = new Size(100, 23);
            numSoBuoiTuan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            toolTip1.SetToolTip(numSoBuoiTuan, "Chọn số buổi tập mỗi tuần, từ 1 đến 7 buổi");
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(300, 370);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(160, 38);
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            toolTip1.SetToolTip(btnDangKy, "Nhấn để hoàn tất đăng ký hội viên");
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 450);
            Controls.Add(btnDangKy);
            Controls.Add(numSoBuoiTuan);
            Controls.Add(cboGoiTap);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Controls.Add(lblSoBuoiTuan);
            Controls.Add(lblGoiTap);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblEmail);
            Controls.Add(lblSDT);
            Controls.Add(lblHoTen);
            Controls.Add(lblTieuDe);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký hội viên FitLife";
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
