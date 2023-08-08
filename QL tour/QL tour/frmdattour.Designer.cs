
namespace QL_tour
{
    partial class frmdattour
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbLOC = new System.Windows.Forms.GroupBox();
            this.mtxtNGAYKETTHUC = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtNGAYDI = new System.Windows.Forms.MaskedTextBox();
            this.bqtnRESET = new System.Windows.Forms.Button();
            this.btnLOC = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbDIEMDEN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbDIEMDI = new System.Windows.Forms.ComboBox();
            this.btnNgoaiNUOC = new System.Windows.Forms.Button();
            this.btnTrongnuoc = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.dgvDATTOUR = new System.Windows.Forms.DataGridView();
            this.MATOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIATOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYKETTHUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDATTOUR = new System.Windows.Forms.Button();
            this.lbTRUYENVAOTEN = new System.Windows.Forms.Label();
            this.lbTRUYENVAOTIEN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMOTA = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.gbLOC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATTOUR)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLOC
            // 
            this.gbLOC.Controls.Add(this.mtxtNGAYKETTHUC);
            this.gbLOC.Controls.Add(this.label4);
            this.gbLOC.Controls.Add(this.mtxtNGAYDI);
            this.gbLOC.Controls.Add(this.bqtnRESET);
            this.gbLOC.Controls.Add(this.btnLOC);
            this.gbLOC.Controls.Add(this.label3);
            this.gbLOC.Controls.Add(this.label2);
            this.gbLOC.Controls.Add(this.cbbDIEMDEN);
            this.gbLOC.Controls.Add(this.label1);
            this.gbLOC.Controls.Add(this.cbbDIEMDI);
            this.gbLOC.Controls.Add(this.btnNgoaiNUOC);
            this.gbLOC.Controls.Add(this.btnTrongnuoc);
            this.gbLOC.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLOC.Location = new System.Drawing.Point(12, 12);
            this.gbLOC.Name = "gbLOC";
            this.gbLOC.Size = new System.Drawing.Size(227, 361);
            this.gbLOC.TabIndex = 0;
            this.gbLOC.TabStop = false;
            this.gbLOC.Text = "Lọc kết quả";
            // 
            // mtxtNGAYKETTHUC
            // 
            this.mtxtNGAYKETTHUC.Location = new System.Drawing.Point(6, 269);
            this.mtxtNGAYKETTHUC.Mask = "00/00/0000";
            this.mtxtNGAYKETTHUC.Name = "mtxtNGAYKETTHUC";
            this.mtxtNGAYKETTHUC.Size = new System.Drawing.Size(215, 20);
            this.mtxtNGAYKETTHUC.TabIndex = 3;
            this.mtxtNGAYKETTHUC.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngày kết thúc";
            // 
            // mtxtNGAYDI
            // 
            this.mtxtNGAYDI.Location = new System.Drawing.Point(6, 216);
            this.mtxtNGAYDI.Mask = "00/00/0000";
            this.mtxtNGAYDI.Name = "mtxtNGAYDI";
            this.mtxtNGAYDI.Size = new System.Drawing.Size(215, 20);
            this.mtxtNGAYDI.TabIndex = 2;
            this.mtxtNGAYDI.ValidatingType = typeof(System.DateTime);
            this.mtxtNGAYDI.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtNGAYDI_MaskInputRejected);
            // 
            // bqtnRESET
            // 
            this.bqtnRESET.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bqtnRESET.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bqtnRESET.Location = new System.Drawing.Point(121, 309);
            this.bqtnRESET.Name = "bqtnRESET";
            this.bqtnRESET.Size = new System.Drawing.Size(87, 34);
            this.bqtnRESET.TabIndex = 9;
            this.bqtnRESET.Text = "Reset";
            this.bqtnRESET.UseVisualStyleBackColor = true;
            this.bqtnRESET.Click += new System.EventHandler(this.bqtnRESET_Click);
            // 
            // btnLOC
            // 
            this.btnLOC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLOC.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLOC.Location = new System.Drawing.Point(23, 309);
            this.btnLOC.Name = "btnLOC";
            this.btnLOC.Size = new System.Drawing.Size(87, 34);
            this.btnLOC.TabIndex = 4;
            this.btnLOC.Text = "Lọc kết quả";
            this.btnLOC.UseVisualStyleBackColor = true;
            this.btnLOC.Click += new System.EventHandler(this.btnLOC_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày đi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Điểm đến";
            // 
            // cbbDIEMDEN
            // 
            this.cbbDIEMDEN.FormattingEnabled = true;
            this.cbbDIEMDEN.Location = new System.Drawing.Point(6, 160);
            this.cbbDIEMDEN.Name = "cbbDIEMDEN";
            this.cbbDIEMDEN.Size = new System.Drawing.Size(215, 22);
            this.cbbDIEMDEN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Điểm đi";
            // 
            // cbbDIEMDI
            // 
            this.cbbDIEMDI.FormattingEnabled = true;
            this.cbbDIEMDI.Location = new System.Drawing.Point(6, 98);
            this.cbbDIEMDI.Name = "cbbDIEMDI";
            this.cbbDIEMDI.Size = new System.Drawing.Size(215, 22);
            this.cbbDIEMDI.TabIndex = 0;
            this.cbbDIEMDI.SelectedIndexChanged += new System.EventHandler(this.cbbDIEMDI_SelectedIndexChanged);
            // 
            // btnNgoaiNUOC
            // 
            this.btnNgoaiNUOC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNgoaiNUOC.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNgoaiNUOC.Location = new System.Drawing.Point(121, 32);
            this.btnNgoaiNUOC.Name = "btnNgoaiNUOC";
            this.btnNgoaiNUOC.Size = new System.Drawing.Size(87, 34);
            this.btnNgoaiNUOC.TabIndex = 6;
            this.btnNgoaiNUOC.Text = "Ngoài nước";
            this.btnNgoaiNUOC.UseVisualStyleBackColor = true;
            this.btnNgoaiNUOC.Click += new System.EventHandler(this.btnNgoaiNUOC_Click);
            // 
            // btnTrongnuoc
            // 
            this.btnTrongnuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrongnuoc.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrongnuoc.Location = new System.Drawing.Point(16, 32);
            this.btnTrongnuoc.Name = "btnTrongnuoc";
            this.btnTrongnuoc.Size = new System.Drawing.Size(87, 34);
            this.btnTrongnuoc.TabIndex = 5;
            this.btnTrongnuoc.Text = "Trong nước";
            this.btnTrongnuoc.UseVisualStyleBackColor = true;
            this.btnTrongnuoc.Click += new System.EventHandler(this.btnTrongnuoc_Click);
            // 
            // dgvDATTOUR
            // 
            this.dgvDATTOUR.AllowUserToAddRows = false;
            this.dgvDATTOUR.AllowUserToDeleteRows = false;
            this.dgvDATTOUR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDATTOUR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDATTOUR.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDATTOUR.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDATTOUR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDATTOUR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDATTOUR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDATTOUR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATOUR,
            this.TENTOUR,
            this.GIATOUR,
            this.NGAYDI,
            this.NGAYKETTHUC,
            this.MOTA});
            this.dgvDATTOUR.Location = new System.Drawing.Point(245, 18);
            this.dgvDATTOUR.MultiSelect = false;
            this.dgvDATTOUR.Name = "dgvDATTOUR";
            this.dgvDATTOUR.ReadOnly = true;
            this.dgvDATTOUR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDATTOUR.Size = new System.Drawing.Size(751, 195);
            this.dgvDATTOUR.TabIndex = 9;
            this.dgvDATTOUR.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDATTOUR_CellClick);
            this.dgvDATTOUR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDATTOUR_CellContentClick);
            // 
            // MATOUR
            // 
            this.MATOUR.DataPropertyName = "MATOUR";
            this.MATOUR.FillWeight = 58.5965F;
            this.MATOUR.HeaderText = "Mã Tour";
            this.MATOUR.Name = "MATOUR";
            this.MATOUR.ReadOnly = true;
            // 
            // TENTOUR
            // 
            this.TENTOUR.DataPropertyName = "TENTOUR";
            this.TENTOUR.FillWeight = 156.2573F;
            this.TENTOUR.HeaderText = "Tên Tour";
            this.TENTOUR.Name = "TENTOUR";
            this.TENTOUR.ReadOnly = true;
            // 
            // GIATOUR
            // 
            this.GIATOUR.DataPropertyName = "GIATOUR";
            this.GIATOUR.FillWeight = 68.36258F;
            this.GIATOUR.HeaderText = "Giá Tour";
            this.GIATOUR.Name = "GIATOUR";
            this.GIATOUR.ReadOnly = true;
            // 
            // NGAYDI
            // 
            this.NGAYDI.DataPropertyName = "NGAYDI";
            this.NGAYDI.FillWeight = 97.66083F;
            this.NGAYDI.HeaderText = "Ngày đi";
            this.NGAYDI.Name = "NGAYDI";
            this.NGAYDI.ReadOnly = true;
            // 
            // NGAYKETTHUC
            // 
            this.NGAYKETTHUC.DataPropertyName = "NGAYKETTHUC";
            this.NGAYKETTHUC.FillWeight = 97.66083F;
            this.NGAYKETTHUC.HeaderText = "Ngày kết thúc";
            this.NGAYKETTHUC.Name = "NGAYKETTHUC";
            this.NGAYKETTHUC.ReadOnly = true;
            // 
            // MOTA
            // 
            this.MOTA.DataPropertyName = "MOTA";
            this.MOTA.FillWeight = 12.46193F;
            this.MOTA.HeaderText = "Mô tả";
            this.MOTA.Name = "MOTA";
            this.MOTA.ReadOnly = true;
            this.MOTA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MOTA.Visible = false;
            // 
            // btnDATTOUR
            // 
            this.btnDATTOUR.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDATTOUR.Location = new System.Drawing.Point(248, 20);
            this.btnDATTOUR.Name = "btnDATTOUR";
            this.btnDATTOUR.Size = new System.Drawing.Size(128, 49);
            this.btnDATTOUR.TabIndex = 10;
            this.btnDATTOUR.Text = "Đặt Tour";
            this.btnDATTOUR.UseVisualStyleBackColor = true;
            this.btnDATTOUR.Click += new System.EventHandler(this.btnDATTOUR_Click);
            // 
            // lbTRUYENVAOTEN
            // 
            this.lbTRUYENVAOTEN.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTRUYENVAOTEN.Location = new System.Drawing.Point(85, 5);
            this.lbTRUYENVAOTEN.Name = "lbTRUYENVAOTEN";
            this.lbTRUYENVAOTEN.Size = new System.Drawing.Size(523, 34);
            this.lbTRUYENVAOTEN.TabIndex = 12;
            this.lbTRUYENVAOTEN.Text = "label5";
            this.lbTRUYENVAOTEN.Visible = false;
            // 
            // lbTRUYENVAOTIEN
            // 
            this.lbTRUYENVAOTIEN.AutoSize = true;
            this.lbTRUYENVAOTIEN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTRUYENVAOTIEN.Location = new System.Drawing.Point(84, 29);
            this.lbTRUYENVAOTIEN.Name = "lbTRUYENVAOTIEN";
            this.lbTRUYENVAOTIEN.Size = new System.Drawing.Size(54, 19);
            this.lbTRUYENVAOTIEN.TabIndex = 13;
            this.lbTRUYENVAOTIEN.Text = "label6";
            this.lbTRUYENVAOTIEN.Visible = false;
            this.lbTRUYENVAOTIEN.Click += new System.EventHandler(this.lbTRUYENVAOTIEN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Giá tour:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tên tour:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mô tả:";
            // 
            // lbMOTA
            // 
            this.lbMOTA.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMOTA.Location = new System.Drawing.Point(7, 81);
            this.lbMOTA.Name = "lbMOTA";
            this.lbMOTA.Size = new System.Drawing.Size(378, 102);
            this.lbMOTA.TabIndex = 17;
            this.lbMOTA.Text = "label8";
            this.lbMOTA.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbTRUYENVAOTEN);
            this.panel1.Location = new System.Drawing.Point(245, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 242);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::QL_tour.Properties.Resources.z4559454237880_92f78dbf058fee0579c603e587288d10;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(7, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 191);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lbMOTA);
            this.panel2.Controls.Add(this.btnDATTOUR);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbTRUYENVAOTIEN);
            this.panel2.Location = new System.Drawing.Point(353, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 191);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTHOAT.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.Location = new System.Drawing.Point(35, 389);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(87, 34);
            this.btnTHOAT.TabIndex = 11;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmdattour
            // 
            this.AcceptButton = this.btnLOC;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnTHOAT;
            this.ClientSize = new System.Drawing.Size(1002, 464);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.dgvDATTOUR);
            this.Controls.Add(this.gbLOC);
            this.Controls.Add(this.panel1);
            this.Name = "frmdattour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tour";
            this.Load += new System.EventHandler(this.frmdattour_Load);
            this.gbLOC.ResumeLayout(false);
            this.gbLOC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATTOUR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLOC;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button bqtnRESET;
        private System.Windows.Forms.Button btnLOC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbDIEMDEN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbDIEMDI;
        private System.Windows.Forms.Button btnNgoaiNUOC;
        private System.Windows.Forms.Button btnTrongnuoc;
        private System.Windows.Forms.DataGridView dgvDATTOUR;
        private System.Windows.Forms.Button btnDATTOUR;
        private System.Windows.Forms.MaskedTextBox mtxtNGAYDI;
        private System.Windows.Forms.MaskedTextBox mtxtNGAYKETTHUC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTRUYENVAOTIEN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTRUYENVAOTEN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMOTA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYDI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYKETTHUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
        private System.Windows.Forms.Button btnTHOAT;
    }
}