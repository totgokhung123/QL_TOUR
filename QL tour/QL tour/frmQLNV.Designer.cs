
namespace QL_tour
{
    partial class frmQLNV
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
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttTimkiem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.gb1TRACUUNV = new System.Windows.Forms.GroupBox();
            this.cbTRACUUDATE = new System.Windows.Forms.CheckBox();
            this.mtxtNGAYVL = new System.Windows.Forms.MaskedTextBox();
            this.lbngayvl = new System.Windows.Forms.Label();
            this.lbcccd = new System.Windows.Forms.Label();
            this.lbsdt = new System.Windows.Forms.Label();
            this.rbKHAC = new System.Windows.Forms.RadioButton();
            this.rbNU = new System.Windows.Forms.RadioButton();
            this.rbNAM = new System.Windows.Forms.RadioButton();
            this.lbgioitinh = new System.Windows.Forms.Label();
            this.lbngaysinh = new System.Windows.Forms.Label();
            this.lbtennv = new System.Windows.Forms.Label();
            this.lbmanv = new System.Windows.Forms.Label();
            this.mtxtNGAYSINH = new System.Windows.Forms.MaskedTextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.gb1TRACUUNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNV
            // 
            this.dgvNV.AllowUserToAddRows = false;
            this.dgvNV.AllowUserToDeleteRows = false;
            this.dgvNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.TENNV,
            this.NGAYSINH,
            this.GIOITINH,
            this.SDT,
            this.CCCD,
            this.NGAYVL});
            this.dgvNV.Location = new System.Drawing.Point(0, 248);
            this.dgvNV.MultiSelect = false;
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.ReadOnly = true;
            this.dgvNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNV.Size = new System.Drawing.Size(800, 202);
            this.dgvNV.TabIndex = 13;
            this.dgvNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNV_CellContentClick);
            this.dgvNV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNV_CellDoubleClick);
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã NV";
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "Tên NV";
            this.TENNV.Name = "TENNV";
            this.TENNV.ReadOnly = true;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.ReadOnly = true;
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.HeaderText = "CMND/CCCD";
            this.CCCD.Name = "CCCD";
            this.CCCD.ReadOnly = true;
            // 
            // NGAYVL
            // 
            this.NGAYVL.DataPropertyName = "NGAYVL";
            this.NGAYVL.HeaderText = "Ngày vào làm";
            this.NGAYVL.Name = "NGAYVL";
            this.NGAYVL.ReadOnly = true;
            // 
            // bttTimkiem
            // 
            this.bttTimkiem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttTimkiem.Location = new System.Drawing.Point(337, 199);
            this.bttTimkiem.Name = "bttTimkiem";
            this.bttTimkiem.Size = new System.Drawing.Size(90, 43);
            this.bttTimkiem.TabIndex = 7;
            this.bttTimkiem.Text = "Tìm kiếm ";
            this.bttTimkiem.UseVisualStyleBackColor = true;
            this.bttTimkiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(433, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "Thêm mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXOA.Location = new System.Drawing.Point(530, 199);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(91, 43);
            this.btnXOA.TabIndex = 10;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(137, 37);
            this.txtmanv.MaxLength = 12;
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(163, 20);
            this.txtmanv.TabIndex = 0;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(137, 67);
            this.txttennv.MaxLength = 35;
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(163, 20);
            this.txttennv.TabIndex = 1;
            this.txttennv.TextChanged += new System.EventHandler(this.txttennv_TextChanged);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTHOAT.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.Location = new System.Drawing.Point(627, 199);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(94, 43);
            this.btnTHOAT.TabIndex = 11;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(449, 64);
            this.txtSDT.MaxLength = 13;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(163, 20);
            this.txtSDT.TabIndex = 3;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(449, 90);
            this.txtCCCD.MaxLength = 13;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(163, 20);
            this.txtCCCD.TabIndex = 4;
            // 
            // gb1TRACUUNV
            // 
            this.gb1TRACUUNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb1TRACUUNV.Controls.Add(this.cbTRACUUDATE);
            this.gb1TRACUUNV.Controls.Add(this.mtxtNGAYVL);
            this.gb1TRACUUNV.Controls.Add(this.lbngayvl);
            this.gb1TRACUUNV.Controls.Add(this.lbcccd);
            this.gb1TRACUUNV.Controls.Add(this.lbsdt);
            this.gb1TRACUUNV.Controls.Add(this.rbKHAC);
            this.gb1TRACUUNV.Controls.Add(this.rbNU);
            this.gb1TRACUUNV.Controls.Add(this.rbNAM);
            this.gb1TRACUUNV.Controls.Add(this.lbgioitinh);
            this.gb1TRACUUNV.Controls.Add(this.lbngaysinh);
            this.gb1TRACUUNV.Controls.Add(this.lbtennv);
            this.gb1TRACUUNV.Controls.Add(this.lbmanv);
            this.gb1TRACUUNV.Controls.Add(this.mtxtNGAYSINH);
            this.gb1TRACUUNV.Controls.Add(this.txttennv);
            this.gb1TRACUUNV.Controls.Add(this.txtSDT);
            this.gb1TRACUUNV.Controls.Add(this.txtmanv);
            this.gb1TRACUUNV.Controls.Add(this.txtCCCD);
            this.gb1TRACUUNV.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1TRACUUNV.Location = new System.Drawing.Point(12, 33);
            this.gb1TRACUUNV.Name = "gb1TRACUUNV";
            this.gb1TRACUUNV.Size = new System.Drawing.Size(776, 160);
            this.gb1TRACUUNV.TabIndex = 14;
            this.gb1TRACUUNV.TabStop = false;
            this.gb1TRACUUNV.Text = "Tra cứu Thông tin nhân viên";
            // 
            // cbTRACUUDATE
            // 
            this.cbTRACUUDATE.AutoSize = true;
            this.cbTRACUUDATE.Location = new System.Drawing.Point(52, 95);
            this.cbTRACUUDATE.Name = "cbTRACUUDATE";
            this.cbTRACUUDATE.Size = new System.Drawing.Size(228, 18);
            this.cbTRACUUDATE.TabIndex = 2;
            this.cbTRACUUDATE.Text = "Tra cứu theo Ngày sinh/ Ngày vào làm";
            this.cbTRACUUDATE.UseVisualStyleBackColor = true;
            this.cbTRACUUDATE.CheckedChanged += new System.EventHandler(this.cbTRACUUDATE_CheckedChanged);
            this.cbTRACUUDATE.Click += new System.EventHandler(this.cbTRACUUDATE_Click);
            // 
            // mtxtNGAYVL
            // 
            this.mtxtNGAYVL.Location = new System.Drawing.Point(449, 119);
            this.mtxtNGAYVL.Mask = "00/00/0000";
            this.mtxtNGAYVL.Name = "mtxtNGAYVL";
            this.mtxtNGAYVL.Size = new System.Drawing.Size(132, 20);
            this.mtxtNGAYVL.TabIndex = 6;
            this.mtxtNGAYVL.ValidatingType = typeof(System.DateTime);
            this.mtxtNGAYVL.Visible = false;
            // 
            // lbngayvl
            // 
            this.lbngayvl.AutoSize = true;
            this.lbngayvl.Location = new System.Drawing.Point(365, 122);
            this.lbngayvl.Name = "lbngayvl";
            this.lbngayvl.Size = new System.Drawing.Size(81, 14);
            this.lbngayvl.TabIndex = 24;
            this.lbngayvl.Text = "Ngày vào làm:";
            this.lbngayvl.Visible = false;
            // 
            // lbcccd
            // 
            this.lbcccd.AutoSize = true;
            this.lbcccd.Location = new System.Drawing.Point(367, 93);
            this.lbcccd.Name = "lbcccd";
            this.lbcccd.Size = new System.Drawing.Size(76, 14);
            this.lbcccd.TabIndex = 23;
            this.lbcccd.Text = "CMND/CCCD:";
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Location = new System.Drawing.Point(362, 67);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(81, 14);
            this.lbsdt.TabIndex = 22;
            this.lbsdt.Text = "Số điện thoại:";
            // 
            // rbKHAC
            // 
            this.rbKHAC.AutoSize = true;
            this.rbKHAC.Location = new System.Drawing.Point(615, 35);
            this.rbKHAC.Name = "rbKHAC";
            this.rbKHAC.Size = new System.Drawing.Size(51, 18);
            this.rbKHAC.TabIndex = 21;
            this.rbKHAC.Text = "Khác";
            this.rbKHAC.UseVisualStyleBackColor = true;
            this.rbKHAC.CheckedChanged += new System.EventHandler(this.rbKHAC_CheckedChanged);
            this.rbKHAC.Click += new System.EventHandler(this.rbKHAC_Click);
            // 
            // rbNU
            // 
            this.rbNU.AutoSize = true;
            this.rbNU.Location = new System.Drawing.Point(539, 35);
            this.rbNU.Name = "rbNU";
            this.rbNU.Size = new System.Drawing.Size(40, 18);
            this.rbNU.TabIndex = 20;
            this.rbNU.Text = "Nữ";
            this.rbNU.UseVisualStyleBackColor = true;
            this.rbNU.CheckedChanged += new System.EventHandler(this.rbNU_CheckedChanged);
            this.rbNU.Click += new System.EventHandler(this.rbNU_Click);
            // 
            // rbNAM
            // 
            this.rbNAM.AutoSize = true;
            this.rbNAM.Location = new System.Drawing.Point(447, 35);
            this.rbNAM.Name = "rbNAM";
            this.rbNAM.Size = new System.Drawing.Size(49, 18);
            this.rbNAM.TabIndex = 19;
            this.rbNAM.Text = "Nam";
            this.rbNAM.UseVisualStyleBackColor = true;
            this.rbNAM.CheckedChanged += new System.EventHandler(this.rbNAM_CheckedChanged);
            this.rbNAM.Click += new System.EventHandler(this.rbNAM_Click);
            // 
            // lbgioitinh
            // 
            this.lbgioitinh.AutoSize = true;
            this.lbgioitinh.Location = new System.Drawing.Point(373, 37);
            this.lbgioitinh.Name = "lbgioitinh";
            this.lbgioitinh.Size = new System.Drawing.Size(56, 14);
            this.lbgioitinh.TabIndex = 18;
            this.lbgioitinh.Text = "Giới tính:";
            // 
            // lbngaysinh
            // 
            this.lbngaysinh.AutoSize = true;
            this.lbngaysinh.Location = new System.Drawing.Point(68, 122);
            this.lbngaysinh.Name = "lbngaysinh";
            this.lbngaysinh.Size = new System.Drawing.Size(63, 14);
            this.lbngaysinh.TabIndex = 17;
            this.lbngaysinh.Text = "Ngày sinh:";
            this.lbngaysinh.Visible = false;
            // 
            // lbtennv
            // 
            this.lbtennv.AutoSize = true;
            this.lbtennv.Location = new System.Drawing.Point(49, 70);
            this.lbtennv.Name = "lbtennv";
            this.lbtennv.Size = new System.Drawing.Size(87, 14);
            this.lbtennv.TabIndex = 16;
            this.lbtennv.Text = "Tên nhân viên:";
            // 
            // lbmanv
            // 
            this.lbmanv.AutoSize = true;
            this.lbmanv.Location = new System.Drawing.Point(49, 40);
            this.lbmanv.Name = "lbmanv";
            this.lbmanv.Size = new System.Drawing.Size(82, 14);
            this.lbmanv.TabIndex = 15;
            this.lbmanv.Text = "Mã nhân viên:";
            this.lbmanv.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // mtxtNGAYSINH
            // 
            this.mtxtNGAYSINH.Location = new System.Drawing.Point(137, 119);
            this.mtxtNGAYSINH.Mask = "00/00/0000";
            this.mtxtNGAYSINH.Name = "mtxtNGAYSINH";
            this.mtxtNGAYSINH.Size = new System.Drawing.Size(132, 20);
            this.mtxtNGAYSINH.TabIndex = 5;
            this.mtxtNGAYSINH.ValidatingType = typeof(System.DateTime);
            this.mtxtNGAYSINH.Visible = false;
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(42, 199);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(82, 43);
            this.btnreset.TabIndex = 8;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(287, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Quản lý nhân viên";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmQLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnTHOAT;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bttTimkiem);
            this.Controls.Add(this.dgvNV);
            this.Controls.Add(this.gb1TRACUUNV);
            this.Name = "frmQLNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLNV";
            this.Load += new System.EventHandler(this.frmQLNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.gb1TRACUUNV.ResumeLayout(false);
            this.gb1TRACUUNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttTimkiem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYVL;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.GroupBox gb1TRACUUNV;
        private System.Windows.Forms.Label lbmanv;
        private System.Windows.Forms.MaskedTextBox mtxtNGAYSINH;
        private System.Windows.Forms.Label lbngaysinh;
        private System.Windows.Forms.Label lbtennv;
        private System.Windows.Forms.Label lbgioitinh;
        private System.Windows.Forms.MaskedTextBox mtxtNGAYVL;
        private System.Windows.Forms.Label lbngayvl;
        private System.Windows.Forms.Label lbcccd;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.RadioButton rbKHAC;
        private System.Windows.Forms.RadioButton rbNU;
        private System.Windows.Forms.RadioButton rbNAM;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbTRACUUDATE;
        private System.Windows.Forms.DataGridView dgvNV;
    }
}