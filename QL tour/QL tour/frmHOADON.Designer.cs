
namespace QL_tour
{
    partial class frmHOADON
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTHEM = new System.Windows.Forms.Button();
            this.dgvHOADON = new System.Windows.Forms.DataGridView();
            this.btnXOA = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.gb1TRACUUNV = new System.Windows.Forms.GroupBox();
            this.cbTRACUUDATE = new System.Windows.Forms.CheckBox();
            this.lbmatour = new System.Windows.Forms.Label();
            this.txtMATOUR = new System.Windows.Forms.TextBox();
            this.lbmanv = new System.Windows.Forms.Label();
            this.lbmakhachhang = new System.Windows.Forms.Label();
            this.lbngaylap = new System.Windows.Forms.Label();
            this.lbthanhtien = new System.Windows.Forms.Label();
            this.lbsohd = new System.Windows.Forms.Label();
            this.mtxtNGAYLAP = new System.Windows.Forms.MaskedTextBox();
            this.txtTHANHTIEN = new System.Windows.Forms.TextBox();
            this.txtMAKH = new System.Windows.Forms.TextBox();
            this.txtSOHD = new System.Windows.Forms.TextBox();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnTHOAT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHOADON)).BeginInit();
            this.gb1TRACUUNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(351, 199);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(91, 43);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnTHEM
            // 
            this.btnTHEM.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHEM.Location = new System.Drawing.Point(448, 199);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(91, 43);
            this.btnTHEM.TabIndex = 9;
            this.btnTHEM.Text = "Thêm Mới";
            this.btnTHEM.UseVisualStyleBackColor = true;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // dgvHOADON
            // 
            this.dgvHOADON.AllowUserToAddRows = false;
            this.dgvHOADON.AllowUserToDeleteRows = false;
            this.dgvHOADON.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHOADON.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHOADON.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHOADON.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHOADON.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHOADON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHOADON.Location = new System.Drawing.Point(0, 248);
            this.dgvHOADON.MultiSelect = false;
            this.dgvHOADON.Name = "dgvHOADON";
            this.dgvHOADON.ReadOnly = true;
            this.dgvHOADON.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHOADON.Size = new System.Drawing.Size(815, 208);
            this.dgvHOADON.TabIndex = 12;
            this.dgvHOADON.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHOADON_CellDoubleClick);
            // 
            // btnXOA
            // 
            this.btnXOA.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXOA.Location = new System.Drawing.Point(545, 199);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(91, 43);
            this.btnXOA.TabIndex = 10;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(302, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "Quản lý hóa đơn";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gb1TRACUUNV
            // 
            this.gb1TRACUUNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb1TRACUUNV.Controls.Add(this.cbTRACUUDATE);
            this.gb1TRACUUNV.Controls.Add(this.lbmatour);
            this.gb1TRACUUNV.Controls.Add(this.txtMATOUR);
            this.gb1TRACUUNV.Controls.Add(this.lbmanv);
            this.gb1TRACUUNV.Controls.Add(this.lbmakhachhang);
            this.gb1TRACUUNV.Controls.Add(this.lbngaylap);
            this.gb1TRACUUNV.Controls.Add(this.lbthanhtien);
            this.gb1TRACUUNV.Controls.Add(this.lbsohd);
            this.gb1TRACUUNV.Controls.Add(this.mtxtNGAYLAP);
            this.gb1TRACUUNV.Controls.Add(this.txtTHANHTIEN);
            this.gb1TRACUUNV.Controls.Add(this.txtMAKH);
            this.gb1TRACUUNV.Controls.Add(this.txtSOHD);
            this.gb1TRACUUNV.Controls.Add(this.txtMANV);
            this.gb1TRACUUNV.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1TRACUUNV.Location = new System.Drawing.Point(11, 33);
            this.gb1TRACUUNV.Name = "gb1TRACUUNV";
            this.gb1TRACUUNV.Size = new System.Drawing.Size(791, 160);
            this.gb1TRACUUNV.TabIndex = 17;
            this.gb1TRACUUNV.TabStop = false;
            this.gb1TRACUUNV.Text = "Tra cứu Thông tin hóa đơn";
            // 
            // cbTRACUUDATE
            // 
            this.cbTRACUUDATE.AutoSize = true;
            this.cbTRACUUDATE.Location = new System.Drawing.Point(65, 101);
            this.cbTRACUUDATE.Name = "cbTRACUUDATE";
            this.cbTRACUUDATE.Size = new System.Drawing.Size(143, 18);
            this.cbTRACUUDATE.TabIndex = 2;
            this.cbTRACUUDATE.Text = "Tra cứu theo Ngày lập";
            this.cbTRACUUDATE.UseVisualStyleBackColor = true;
            this.cbTRACUUDATE.Click += new System.EventHandler(this.cbTRACUUDATE_Click);
            // 
            // lbmatour
            // 
            this.lbmatour.AutoSize = true;
            this.lbmatour.Location = new System.Drawing.Point(404, 46);
            this.lbmatour.Name = "lbmatour";
            this.lbmatour.Size = new System.Drawing.Size(52, 14);
            this.lbmatour.TabIndex = 25;
            this.lbmatour.Text = "Mã tour:";
            // 
            // txtMATOUR
            // 
            this.txtMATOUR.Location = new System.Drawing.Point(462, 43);
            this.txtMATOUR.MaxLength = 13;
            this.txtMATOUR.Name = "txtMATOUR";
            this.txtMATOUR.Size = new System.Drawing.Size(163, 20);
            this.txtMATOUR.TabIndex = 4;
            // 
            // lbmanv
            // 
            this.lbmanv.AutoSize = true;
            this.lbmanv.Location = new System.Drawing.Point(374, 99);
            this.lbmanv.Name = "lbmanv";
            this.lbmanv.Size = new System.Drawing.Size(82, 14);
            this.lbmanv.TabIndex = 23;
            this.lbmanv.Text = "Mã nhân viên:";
            // 
            // lbmakhachhang
            // 
            this.lbmakhachhang.AutoSize = true;
            this.lbmakhachhang.Location = new System.Drawing.Point(364, 73);
            this.lbmakhachhang.Name = "lbmakhachhang";
            this.lbmakhachhang.Size = new System.Drawing.Size(92, 14);
            this.lbmakhachhang.TabIndex = 22;
            this.lbmakhachhang.Text = "Mã khách hàng:";
            // 
            // lbngaylap
            // 
            this.lbngaylap.AutoSize = true;
            this.lbngaylap.Location = new System.Drawing.Point(62, 128);
            this.lbngaylap.Name = "lbngaylap";
            this.lbngaylap.Size = new System.Drawing.Size(55, 14);
            this.lbngaylap.TabIndex = 17;
            this.lbngaylap.Text = "Ngày lập:";
            this.lbngaylap.Visible = false;
            // 
            // lbthanhtien
            // 
            this.lbthanhtien.AutoSize = true;
            this.lbthanhtien.Location = new System.Drawing.Point(62, 76);
            this.lbthanhtien.Name = "lbthanhtien";
            this.lbthanhtien.Size = new System.Drawing.Size(68, 14);
            this.lbthanhtien.TabIndex = 16;
            this.lbthanhtien.Text = "Thành tiền:";
            // 
            // lbsohd
            // 
            this.lbsohd.AutoSize = true;
            this.lbsohd.Location = new System.Drawing.Point(62, 46);
            this.lbsohd.Name = "lbsohd";
            this.lbsohd.Size = new System.Drawing.Size(72, 14);
            this.lbsohd.TabIndex = 15;
            this.lbsohd.Text = "Số hóa đơn:";
            // 
            // mtxtNGAYLAP
            // 
            this.mtxtNGAYLAP.Location = new System.Drawing.Point(150, 125);
            this.mtxtNGAYLAP.Mask = "00/00/0000";
            this.mtxtNGAYLAP.Name = "mtxtNGAYLAP";
            this.mtxtNGAYLAP.Size = new System.Drawing.Size(132, 20);
            this.mtxtNGAYLAP.TabIndex = 3;
            this.mtxtNGAYLAP.ValidatingType = typeof(System.DateTime);
            this.mtxtNGAYLAP.Visible = false;
            // 
            // txtTHANHTIEN
            // 
            this.txtTHANHTIEN.Location = new System.Drawing.Point(150, 73);
            this.txtTHANHTIEN.MaxLength = 13;
            this.txtTHANHTIEN.Name = "txtTHANHTIEN";
            this.txtTHANHTIEN.Size = new System.Drawing.Size(163, 20);
            this.txtTHANHTIEN.TabIndex = 1;
            // 
            // txtMAKH
            // 
            this.txtMAKH.Location = new System.Drawing.Point(462, 70);
            this.txtMAKH.MaxLength = 13;
            this.txtMAKH.Name = "txtMAKH";
            this.txtMAKH.Size = new System.Drawing.Size(163, 20);
            this.txtMAKH.TabIndex = 5;
            // 
            // txtSOHD
            // 
            this.txtSOHD.Location = new System.Drawing.Point(150, 43);
            this.txtSOHD.MaxLength = 12;
            this.txtSOHD.Name = "txtSOHD";
            this.txtSOHD.Size = new System.Drawing.Size(163, 20);
            this.txtSOHD.TabIndex = 0;
            // 
            // txtMANV
            // 
            this.txtMANV.Location = new System.Drawing.Point(462, 96);
            this.txtMANV.MaxLength = 13;
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(163, 20);
            this.txtMANV.TabIndex = 6;
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(37, 199);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(91, 43);
            this.btnreset.TabIndex = 8;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTHOAT.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.Location = new System.Drawing.Point(642, 199);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(91, 43);
            this.btnTHOAT.TabIndex = 11;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // frmHOADON
            // 
            this.AcceptButton = this.btnTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnTHOAT;
            this.ClientSize = new System.Drawing.Size(815, 456);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gb1TRACUUNV);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.dgvHOADON);
            this.Controls.Add(this.btnTHEM);
            this.Controls.Add(this.btnTimKiem);
            this.Name = "frmHOADON";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.frmHOADON_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHOADON)).EndInit();
            this.gb1TRACUUNV.ResumeLayout(false);
            this.gb1TRACUUNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTHEM;
        private System.Windows.Forms.DataGridView dgvHOADON;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gb1TRACUUNV;
        private System.Windows.Forms.Label lbmatour;
        private System.Windows.Forms.TextBox txtMATOUR;
        private System.Windows.Forms.Label lbmanv;
        private System.Windows.Forms.Label lbmakhachhang;
        private System.Windows.Forms.Label lbngaylap;
        private System.Windows.Forms.Label lbthanhtien;
        private System.Windows.Forms.Label lbsohd;
        private System.Windows.Forms.MaskedTextBox mtxtNGAYLAP;
        private System.Windows.Forms.TextBox txtTHANHTIEN;
        private System.Windows.Forms.TextBox txtMAKH;
        private System.Windows.Forms.TextBox txtSOHD;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.CheckBox cbTRACUUDATE;
    }
}