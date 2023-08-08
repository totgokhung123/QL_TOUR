
namespace QL_tour
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HETHONGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DOIMKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.THOATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QUANLYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLNVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLKHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLTOURToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLHOADONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DangkytourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TROGIUPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HUONGDANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HETHONGToolStripMenuItem,
            this.QUANLYToolStripMenuItem,
            this.DangkytourToolStripMenuItem,
            this.TROGIUPToolStripMenuItem,
            this.thoatmenu});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // HETHONGToolStripMenuItem
            // 
            this.HETHONGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DOIMKToolStripMenuItem,
            this.THOATToolStripMenuItem});
            this.HETHONGToolStripMenuItem.Name = "HETHONGToolStripMenuItem";
            this.HETHONGToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.HETHONGToolStripMenuItem.Tag = "";
            this.HETHONGToolStripMenuItem.Text = "Hệ Thống";
            // 
            // DOIMKToolStripMenuItem
            // 
            this.DOIMKToolStripMenuItem.Name = "DOIMKToolStripMenuItem";
            this.DOIMKToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.DOIMKToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.DOIMKToolStripMenuItem.Click += new System.EventHandler(this.DOIMKToolStripMenuItem_Click);
            // 
            // THOATToolStripMenuItem
            // 
            this.THOATToolStripMenuItem.Name = "THOATToolStripMenuItem";
            this.THOATToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.THOATToolStripMenuItem.Text = "Thoát";
            this.THOATToolStripMenuItem.Click += new System.EventHandler(this.THOATToolStripMenuItem_Click_1);
            // 
            // QUANLYToolStripMenuItem
            // 
            this.QUANLYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QLNVToolStripMenuItem,
            this.QLKHToolStripMenuItem,
            this.QLTOURToolStripMenuItem,
            this.QLHOADONToolStripMenuItem});
            this.QUANLYToolStripMenuItem.Name = "QUANLYToolStripMenuItem";
            this.QUANLYToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.QUANLYToolStripMenuItem.Tag = "";
            this.QUANLYToolStripMenuItem.Text = "Quản Lý";
            // 
            // QLNVToolStripMenuItem
            // 
            this.QLNVToolStripMenuItem.Name = "QLNVToolStripMenuItem";
            this.QLNVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.QLNVToolStripMenuItem.Text = "Nhân Viên";
            this.QLNVToolStripMenuItem.Click += new System.EventHandler(this.QLNVToolStripMenuItem_Click_1);
            // 
            // QLKHToolStripMenuItem
            // 
            this.QLKHToolStripMenuItem.Name = "QLKHToolStripMenuItem";
            this.QLKHToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.QLKHToolStripMenuItem.Text = "Khách Hàng";
            this.QLKHToolStripMenuItem.Click += new System.EventHandler(this.QLKHToolStripMenuItem_Click_1);
            // 
            // QLTOURToolStripMenuItem
            // 
            this.QLTOURToolStripMenuItem.Name = "QLTOURToolStripMenuItem";
            this.QLTOURToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.QLTOURToolStripMenuItem.Text = "Tour Du Lịch";
            this.QLTOURToolStripMenuItem.Click += new System.EventHandler(this.QLTOURToolStripMenuItem_Click_1);
            // 
            // QLHOADONToolStripMenuItem
            // 
            this.QLHOADONToolStripMenuItem.Name = "QLHOADONToolStripMenuItem";
            this.QLHOADONToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.QLHOADONToolStripMenuItem.Text = "Hóa Đơn";
            this.QLHOADONToolStripMenuItem.Click += new System.EventHandler(this.QLHOADONToolStripMenuItem_Click);
            // 
            // DangkytourToolStripMenuItem
            // 
            this.DangkytourToolStripMenuItem.Name = "DangkytourToolStripMenuItem";
            this.DangkytourToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.DangkytourToolStripMenuItem.Text = "Đăng ký tour";
            this.DangkytourToolStripMenuItem.Click += new System.EventHandler(this.DangkytourToolStripMenuItem_Click);
            // 
            // TROGIUPToolStripMenuItem
            // 
            this.TROGIUPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HUONGDANToolStripMenuItem});
            this.TROGIUPToolStripMenuItem.Name = "TROGIUPToolStripMenuItem";
            this.TROGIUPToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.TROGIUPToolStripMenuItem.Text = "Trợ Giúp";
            this.TROGIUPToolStripMenuItem.Click += new System.EventHandler(this.TROGIUPToolStripMenuItem_Click);
            // 
            // HUONGDANToolStripMenuItem
            // 
            this.HUONGDANToolStripMenuItem.Name = "HUONGDANToolStripMenuItem";
            this.HUONGDANToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.HUONGDANToolStripMenuItem.Text = "Hướng Dẫn Sử Dụng";
            this.HUONGDANToolStripMenuItem.Click += new System.EventHandler(this.HUONGDANToolStripMenuItem_Click);
            // 
            // thoatmenu
            // 
            this.thoatmenu.Name = "thoatmenu";
            this.thoatmenu.Size = new System.Drawing.Size(49, 20);
            this.thoatmenu.Text = "Thoát";
            this.thoatmenu.Click += new System.EventHandler(this.thoatmenu_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::QL_tour.Properties.Resources.z4559454237880_92f78dbf058fee0579c603e587288d10;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 437);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 464);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chính";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HETHONGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DOIMKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem THOATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLKHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLTOURToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLHOADONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TROGIUPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HUONGDANToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem DangkytourToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem QUANLYToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem QLNVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatmenu;
    }
}

