
namespace QL_tour
{
    partial class frmQLTOUR
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
            this.btnTimTOUR = new System.Windows.Forms.Button();
            this.btnThemTOUR = new System.Windows.Forms.Button();
            this.dgvTOUR = new System.Windows.Forms.DataGridView();
            this.MATOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIATOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYKETTHUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALTOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MADDEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MADDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLT01 = new System.Windows.Forms.Button();
            this.btnLT02 = new System.Windows.Forms.Button();
            this.btnmoi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.gb1TRACUUNV = new System.Windows.Forms.GroupBox();
            this.cbTRACUUDATE = new System.Windows.Forms.CheckBox();
            this.txtMLTOUR = new System.Windows.Forms.TextBox();
            this.txtMADDEN = new System.Windows.Forms.TextBox();
            this.txtMADDI = new System.Windows.Forms.TextBox();
            this.lbmadden = new System.Windows.Forms.Label();
            this.lbgiatour = new System.Windows.Forms.Label();
            this.txtGIATOUR = new System.Windows.Forms.TextBox();
            this.mtxtNGAYKETTHUC = new System.Windows.Forms.MaskedTextBox();
            this.lbNGAYKETTHUC = new System.Windows.Forms.Label();
            this.lbmaddi = new System.Windows.Forms.Label();
            this.lbmaltour = new System.Windows.Forms.Label();
            this.lbNGAYDI = new System.Windows.Forms.Label();
            this.lbtentour = new System.Windows.Forms.Label();
            this.lbmatour = new System.Windows.Forms.Label();
            this.mtxtNGAYDI = new System.Windows.Forms.MaskedTextBox();
            this.txttentour = new System.Windows.Forms.TextBox();
            this.txtmatour = new System.Windows.Forms.TextBox();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTOUR)).BeginInit();
            this.gb1TRACUUNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimTOUR
            // 
            this.btnTimTOUR.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTOUR.Location = new System.Drawing.Point(367, 224);
            this.btnTimTOUR.Name = "btnTimTOUR";
            this.btnTimTOUR.Size = new System.Drawing.Size(106, 46);
            this.btnTimTOUR.TabIndex = 9;
            this.btnTimTOUR.Text = "Tìm kiếm";
            this.btnTimTOUR.UseVisualStyleBackColor = true;
            this.btnTimTOUR.Click += new System.EventHandler(this.btnTimTOUR_Click);
            // 
            // btnThemTOUR
            // 
            this.btnThemTOUR.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTOUR.Location = new System.Drawing.Point(480, 224);
            this.btnThemTOUR.Name = "btnThemTOUR";
            this.btnThemTOUR.Size = new System.Drawing.Size(106, 46);
            this.btnThemTOUR.TabIndex = 13;
            this.btnThemTOUR.Text = "Thêm mới";
            this.btnThemTOUR.UseVisualStyleBackColor = true;
            this.btnThemTOUR.Click += new System.EventHandler(this.btnThemTOUR_Click);
            // 
            // dgvTOUR
            // 
            this.dgvTOUR.AllowUserToAddRows = false;
            this.dgvTOUR.AllowUserToDeleteRows = false;
            this.dgvTOUR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTOUR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTOUR.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTOUR.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTOUR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTOUR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTOUR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATOUR,
            this.TENTOUR,
            this.GIATOUR,
            this.NGAYDI,
            this.NGAYKETTHUC,
            this.MOTA,
            this.MALTOUR,
            this.MADDEN,
            this.MADDI});
            this.dgvTOUR.Location = new System.Drawing.Point(0, 277);
            this.dgvTOUR.MultiSelect = false;
            this.dgvTOUR.Name = "dgvTOUR";
            this.dgvTOUR.ReadOnly = true;
            this.dgvTOUR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTOUR.Size = new System.Drawing.Size(868, 183);
            this.dgvTOUR.TabIndex = 16;
            this.dgvTOUR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTOUR_CellContentClick);
            this.dgvTOUR.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTOUR_CellDoubleClick);
            // 
            // MATOUR
            // 
            this.MATOUR.DataPropertyName = "MATOUR";
            this.MATOUR.HeaderText = "Mã Tour";
            this.MATOUR.Name = "MATOUR";
            this.MATOUR.ReadOnly = true;
            // 
            // TENTOUR
            // 
            this.TENTOUR.DataPropertyName = "TENTOUR";
            this.TENTOUR.HeaderText = "Tên Tour";
            this.TENTOUR.Name = "TENTOUR";
            this.TENTOUR.ReadOnly = true;
            // 
            // GIATOUR
            // 
            this.GIATOUR.DataPropertyName = "GIATOUR";
            this.GIATOUR.HeaderText = "Giá Tour";
            this.GIATOUR.Name = "GIATOUR";
            this.GIATOUR.ReadOnly = true;
            // 
            // NGAYDI
            // 
            this.NGAYDI.DataPropertyName = "NGAYDI";
            this.NGAYDI.HeaderText = "Ngày đi";
            this.NGAYDI.Name = "NGAYDI";
            this.NGAYDI.ReadOnly = true;
            // 
            // NGAYKETTHUC
            // 
            this.NGAYKETTHUC.DataPropertyName = "NGAYKETTHUC";
            this.NGAYKETTHUC.HeaderText = "Ngày kết thúc";
            this.NGAYKETTHUC.Name = "NGAYKETTHUC";
            this.NGAYKETTHUC.ReadOnly = true;
            // 
            // MOTA
            // 
            this.MOTA.DataPropertyName = "MOTA";
            this.MOTA.HeaderText = "Mô tả";
            this.MOTA.Name = "MOTA";
            this.MOTA.ReadOnly = true;
            // 
            // MALTOUR
            // 
            this.MALTOUR.DataPropertyName = "MALOAITOUR";
            this.MALTOUR.HeaderText = "Mã loại Tour";
            this.MALTOUR.Name = "MALTOUR";
            this.MALTOUR.ReadOnly = true;
            // 
            // MADDEN
            // 
            this.MADDEN.DataPropertyName = "MADDEN";
            this.MADDEN.HeaderText = "Mã điểm đến";
            this.MADDEN.Name = "MADDEN";
            this.MADDEN.ReadOnly = true;
            // 
            // MADDI
            // 
            this.MADDI.DataPropertyName = "MADDI";
            this.MADDI.HeaderText = "Mã điểm đi";
            this.MADDI.Name = "MADDI";
            this.MADDI.ReadOnly = true;
            // 
            // btnLT01
            // 
            this.btnLT01.Location = new System.Drawing.Point(655, 33);
            this.btnLT01.Name = "btnLT01";
            this.btnLT01.Size = new System.Drawing.Size(99, 33);
            this.btnLT01.TabIndex = 11;
            this.btnLT01.Text = "Trong nước";
            this.btnLT01.UseVisualStyleBackColor = true;
            this.btnLT01.Click += new System.EventHandler(this.btnLT01_Click);
            // 
            // btnLT02
            // 
            this.btnLT02.Location = new System.Drawing.Point(655, 105);
            this.btnLT02.Name = "btnLT02";
            this.btnLT02.Size = new System.Drawing.Size(99, 33);
            this.btnLT02.TabIndex = 12;
            this.btnLT02.Text = "Ngoài nước";
            this.btnLT02.UseVisualStyleBackColor = true;
            this.btnLT02.Click += new System.EventHandler(this.btnLT02_Click);
            // 
            // btnmoi
            // 
            this.btnmoi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmoi.Location = new System.Drawing.Point(593, 224);
            this.btnmoi.Name = "btnmoi";
            this.btnmoi.Size = new System.Drawing.Size(106, 46);
            this.btnmoi.TabIndex = 14;
            this.btnmoi.Text = "Xóa";
            this.btnmoi.UseVisualStyleBackColor = true;
            this.btnmoi.Click += new System.EventHandler(this.btnmoi_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(325, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "Quản lý TOUR";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gb1TRACUUNV
            // 
            this.gb1TRACUUNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb1TRACUUNV.Controls.Add(this.cbTRACUUDATE);
            this.gb1TRACUUNV.Controls.Add(this.btnLT02);
            this.gb1TRACUUNV.Controls.Add(this.btnLT01);
            this.gb1TRACUUNV.Controls.Add(this.txtMLTOUR);
            this.gb1TRACUUNV.Controls.Add(this.txtMADDEN);
            this.gb1TRACUUNV.Controls.Add(this.txtMADDI);
            this.gb1TRACUUNV.Controls.Add(this.lbmadden);
            this.gb1TRACUUNV.Controls.Add(this.lbgiatour);
            this.gb1TRACUUNV.Controls.Add(this.txtGIATOUR);
            this.gb1TRACUUNV.Controls.Add(this.mtxtNGAYKETTHUC);
            this.gb1TRACUUNV.Controls.Add(this.lbNGAYKETTHUC);
            this.gb1TRACUUNV.Controls.Add(this.lbmaddi);
            this.gb1TRACUUNV.Controls.Add(this.lbmaltour);
            this.gb1TRACUUNV.Controls.Add(this.lbNGAYDI);
            this.gb1TRACUUNV.Controls.Add(this.lbtentour);
            this.gb1TRACUUNV.Controls.Add(this.lbmatour);
            this.gb1TRACUUNV.Controls.Add(this.mtxtNGAYDI);
            this.gb1TRACUUNV.Controls.Add(this.txttentour);
            this.gb1TRACUUNV.Controls.Add(this.txtmatour);
            this.gb1TRACUUNV.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1TRACUUNV.Location = new System.Drawing.Point(8, 36);
            this.gb1TRACUUNV.Name = "gb1TRACUUNV";
            this.gb1TRACUUNV.Size = new System.Drawing.Size(848, 172);
            this.gb1TRACUUNV.TabIndex = 17;
            this.gb1TRACUUNV.TabStop = false;
            this.gb1TRACUUNV.Text = "Tra cứu Thông tin tour";
            // 
            // cbTRACUUDATE
            // 
            this.cbTRACUUDATE.AutoSize = true;
            this.cbTRACUUDATE.Location = new System.Drawing.Point(14, 94);
            this.cbTRACUUDATE.Name = "cbTRACUUDATE";
            this.cbTRACUUDATE.Size = new System.Drawing.Size(217, 18);
            this.cbTRACUUDATE.TabIndex = 2;
            this.cbTRACUUDATE.Text = "Tra cứu theo Ngày đi/ Ngày kết thúc";
            this.cbTRACUUDATE.UseVisualStyleBackColor = true;
            this.cbTRACUUDATE.CheckedChanged += new System.EventHandler(this.cbTRACUUDATE_CheckedChanged);
            this.cbTRACUUDATE.Click += new System.EventHandler(this.cbTRACUUDATE_Click);
            // 
            // txtMLTOUR
            // 
            this.txtMLTOUR.Location = new System.Drawing.Point(428, 62);
            this.txtMLTOUR.MaxLength = 5;
            this.txtMLTOUR.Name = "txtMLTOUR";
            this.txtMLTOUR.Size = new System.Drawing.Size(189, 20);
            this.txtMLTOUR.TabIndex = 6;
            // 
            // txtMADDEN
            // 
            this.txtMADDEN.Location = new System.Drawing.Point(428, 118);
            this.txtMADDEN.MaxLength = 6;
            this.txtMADDEN.Name = "txtMADDEN";
            this.txtMADDEN.Size = new System.Drawing.Size(189, 20);
            this.txtMADDEN.TabIndex = 8;
            // 
            // txtMADDI
            // 
            this.txtMADDI.Location = new System.Drawing.Point(428, 90);
            this.txtMADDI.MaxLength = 6;
            this.txtMADDI.Name = "txtMADDI";
            this.txtMADDI.Size = new System.Drawing.Size(189, 20);
            this.txtMADDI.TabIndex = 7;
            // 
            // lbmadden
            // 
            this.lbmadden.AutoSize = true;
            this.lbmadden.Location = new System.Drawing.Point(319, 121);
            this.lbmadden.Name = "lbmadden";
            this.lbmadden.Size = new System.Drawing.Size(81, 14);
            this.lbmadden.TabIndex = 29;
            this.lbmadden.Text = "Mã điểm đến:";
            // 
            // lbgiatour
            // 
            this.lbgiatour.AutoSize = true;
            this.lbgiatour.Location = new System.Drawing.Point(352, 36);
            this.lbgiatour.Name = "lbgiatour";
            this.lbgiatour.Size = new System.Drawing.Size(53, 14);
            this.lbgiatour.TabIndex = 27;
            this.lbgiatour.Text = "Giá tour:";
            // 
            // txtGIATOUR
            // 
            this.txtGIATOUR.Location = new System.Drawing.Point(428, 33);
            this.txtGIATOUR.MaxLength = 13;
            this.txtGIATOUR.Name = "txtGIATOUR";
            this.txtGIATOUR.Size = new System.Drawing.Size(189, 20);
            this.txtGIATOUR.TabIndex = 5;
            // 
            // mtxtNGAYKETTHUC
            // 
            this.mtxtNGAYKETTHUC.Location = new System.Drawing.Point(116, 146);
            this.mtxtNGAYKETTHUC.Mask = "00/00/0000";
            this.mtxtNGAYKETTHUC.Name = "mtxtNGAYKETTHUC";
            this.mtxtNGAYKETTHUC.Size = new System.Drawing.Size(161, 20);
            this.mtxtNGAYKETTHUC.TabIndex = 4;
            this.mtxtNGAYKETTHUC.ValidatingType = typeof(System.DateTime);
            this.mtxtNGAYKETTHUC.Visible = false;
            // 
            // lbNGAYKETTHUC
            // 
            this.lbNGAYKETTHUC.AutoSize = true;
            this.lbNGAYKETTHUC.Location = new System.Drawing.Point(11, 149);
            this.lbNGAYKETTHUC.Name = "lbNGAYKETTHUC";
            this.lbNGAYKETTHUC.Size = new System.Drawing.Size(84, 14);
            this.lbNGAYKETTHUC.TabIndex = 24;
            this.lbNGAYKETTHUC.Text = "Ngày kết thúc:";
            this.lbNGAYKETTHUC.Visible = false;
            this.lbNGAYKETTHUC.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbmaddi
            // 
            this.lbmaddi.AutoSize = true;
            this.lbmaddi.Location = new System.Drawing.Point(332, 93);
            this.lbmaddi.Name = "lbmaddi";
            this.lbmaddi.Size = new System.Drawing.Size(70, 14);
            this.lbmaddi.TabIndex = 23;
            this.lbmaddi.Text = "Mã điểm đi:";
            // 
            // lbmaltour
            // 
            this.lbmaltour.AutoSize = true;
            this.lbmaltour.Location = new System.Drawing.Point(326, 65);
            this.lbmaltour.Name = "lbmaltour";
            this.lbmaltour.Size = new System.Drawing.Size(74, 14);
            this.lbmaltour.TabIndex = 22;
            this.lbmaltour.Text = "Mã loại tour:";
            // 
            // lbNGAYDI
            // 
            this.lbNGAYDI.AutoSize = true;
            this.lbNGAYDI.Location = new System.Drawing.Point(11, 121);
            this.lbNGAYDI.Name = "lbNGAYDI";
            this.lbNGAYDI.Size = new System.Drawing.Size(49, 14);
            this.lbNGAYDI.TabIndex = 17;
            this.lbNGAYDI.Text = "Ngày đi:";
            this.lbNGAYDI.Visible = false;
            // 
            // lbtentour
            // 
            this.lbtentour.AutoSize = true;
            this.lbtentour.Location = new System.Drawing.Point(13, 68);
            this.lbtentour.Name = "lbtentour";
            this.lbtentour.Size = new System.Drawing.Size(57, 14);
            this.lbtentour.TabIndex = 16;
            this.lbtentour.Text = "Tên tour:";
            // 
            // lbmatour
            // 
            this.lbmatour.AutoSize = true;
            this.lbmatour.Location = new System.Drawing.Point(13, 36);
            this.lbmatour.Name = "lbmatour";
            this.lbmatour.Size = new System.Drawing.Size(52, 14);
            this.lbmatour.TabIndex = 15;
            this.lbmatour.Text = "Mã tour:";
            // 
            // mtxtNGAYDI
            // 
            this.mtxtNGAYDI.Location = new System.Drawing.Point(114, 118);
            this.mtxtNGAYDI.Mask = "00/00/0000";
            this.mtxtNGAYDI.Name = "mtxtNGAYDI";
            this.mtxtNGAYDI.Size = new System.Drawing.Size(163, 20);
            this.mtxtNGAYDI.TabIndex = 3;
            this.mtxtNGAYDI.ValidatingType = typeof(System.DateTime);
            this.mtxtNGAYDI.Visible = false;
            // 
            // txttentour
            // 
            this.txttentour.Location = new System.Drawing.Point(116, 65);
            this.txttentour.MaxLength = 100;
            this.txttentour.Name = "txttentour";
            this.txttentour.Size = new System.Drawing.Size(189, 20);
            this.txttentour.TabIndex = 1;
            // 
            // txtmatour
            // 
            this.txtmatour.Location = new System.Drawing.Point(116, 33);
            this.txtmatour.MaxLength = 12;
            this.txtmatour.Name = "txtmatour";
            this.txtmatour.Size = new System.Drawing.Size(189, 20);
            this.txtmatour.TabIndex = 0;
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTHOAT.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.Location = new System.Drawing.Point(706, 224);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(106, 46);
            this.btnTHOAT.TabIndex = 15;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(55, 224);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(106, 46);
            this.btnreset.TabIndex = 10;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // frmQLTOUR
            // 
            this.AcceptButton = this.btnTimTOUR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnTHOAT;
            this.ClientSize = new System.Drawing.Size(868, 460);
            this.Controls.Add(this.gb1TRACUUNV);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnmoi);
            this.Controls.Add(this.dgvTOUR);
            this.Controls.Add(this.btnThemTOUR);
            this.Controls.Add(this.btnTimTOUR);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQLTOUR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL Tour";
            this.Load += new System.EventHandler(this.frmQLTOUR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTOUR)).EndInit();
            this.gb1TRACUUNV.ResumeLayout(false);
            this.gb1TRACUUNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTimTOUR;
        private System.Windows.Forms.Button btnThemTOUR;
        private System.Windows.Forms.Button btnLT01;
        private System.Windows.Forms.Button btnLT02;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYDI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYKETTHUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALTOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADDEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADDI;
        private System.Windows.Forms.Button btnmoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gb1TRACUUNV;
        private System.Windows.Forms.MaskedTextBox mtxtNGAYKETTHUC;
        private System.Windows.Forms.Label lbNGAYKETTHUC;
        private System.Windows.Forms.Label lbmaddi;
        private System.Windows.Forms.Label lbmaltour;
        private System.Windows.Forms.Label lbNGAYDI;
        private System.Windows.Forms.Label lbtentour;
        private System.Windows.Forms.Label lbmatour;
        private System.Windows.Forms.MaskedTextBox mtxtNGAYDI;
        private System.Windows.Forms.TextBox txttentour;
        private System.Windows.Forms.TextBox txtmatour;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label lbgiatour;
        private System.Windows.Forms.TextBox txtGIATOUR;
        private System.Windows.Forms.Label lbmadden;
        private System.Windows.Forms.TextBox txtMADDEN;
        private System.Windows.Forms.TextBox txtMADDI;
        private System.Windows.Forms.TextBox txtMLTOUR;
        private System.Windows.Forms.CheckBox cbTRACUUDATE;
        private System.Windows.Forms.DataGridView dgvTOUR;
    }
}