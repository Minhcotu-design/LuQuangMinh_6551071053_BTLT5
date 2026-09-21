namespace cau5_chuong4
{
    partial class frmParent
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip;
        private ToolStrip toolStrip;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblSoDon;
        private ToolStripStatusLabel lblGio;
        private ToolStripMenuItem fileMenuItem;
        private ToolStripMenuItem newOrderMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem windowMenuItem;
        private ToolStripMenuItem cascadeMenuItem;
        private ToolStripMenuItem tileHorizontalMenuItem;
        private ToolStripMenuItem tileVerticalMenuItem;
        private ToolStripButton newOrderToolStripButton;
        private System.Windows.Forms.Timer clockTimer;

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
            menuStrip = new MenuStrip();
            fileMenuItem = new ToolStripMenuItem();
            newOrderMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            windowMenuItem = new ToolStripMenuItem();
            cascadeMenuItem = new ToolStripMenuItem();
            tileHorizontalMenuItem = new ToolStripMenuItem();
            tileVerticalMenuItem = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            newOrderToolStripButton = new ToolStripButton();
            statusStrip = new StatusStrip();
            lblSoDon = new ToolStripStatusLabel();
            lblGio = new ToolStripStatusLabel();
            clockTimer = new System.Windows.Forms.Timer(components);
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenuItem, windowMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1000, 24);
            fileMenuItem.Text = "File";
            fileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newOrderMenuItem, exitMenuItem });
            newOrderMenuItem.Text = "Đơn hàng mới";
            newOrderMenuItem.Click += NewOrder_Click;
            exitMenuItem.Text = "Thoát";
            exitMenuItem.Click += Exit_Click;
            windowMenuItem.Text = "Window";
            windowMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadeMenuItem, tileHorizontalMenuItem, tileVerticalMenuItem });
            cascadeMenuItem.Text = "Cascade";
            cascadeMenuItem.Click += Cascade_Click;
            tileHorizontalMenuItem.Text = "Tile Horizontal";
            tileHorizontalMenuItem.Click += TileHorizontal_Click;
            tileVerticalMenuItem.Text = "Tile Vertical";
            tileVerticalMenuItem.Click += TileVertical_Click;
            toolStrip.Items.AddRange(new ToolStripItem[] { newOrderToolStripButton });
            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(1000, 25);
            newOrderToolStripButton.Text = "Đơn hàng mới";
            newOrderToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            newOrderToolStripButton.Click += NewOrder_Click;
            statusStrip.Items.AddRange(new ToolStripItem[] { lblSoDon, lblGio });
            statusStrip.Location = new Point(0, 529);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1000, 22);
            lblSoDon.Spring = true;
            lblSoDon.TextAlign = ContentAlignment.MiddleLeft;
            lblGio.TextAlign = ContentAlignment.MiddleRight;
            clockTimer.Interval = 1000;
            clockTimer.Tick += UpdateClock;
            clockTimer.Start();
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 551);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "frmParent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý đơn hàng - Cửa hàng tạp hóa";
            WindowState = FormWindowState.Maximized;
            MdiChildActivate += Parent_MdiChildActivate;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
