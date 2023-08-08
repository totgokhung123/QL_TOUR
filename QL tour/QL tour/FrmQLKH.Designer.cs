
namespace QL_tour
{
    partial class FrmQLKH
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
            this.btnTimKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXOA = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.gb1KH = new System.Windows.Forms.GroupBox();
            this.txtDIACHI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbKHAC = new System.Windows.Forms.RadioButton();
            this.rbNU = new System.Windows.Forms.RadioButton();
            this.rbNAM = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTENKH = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtMAKH = new System.Windows.Forms.TextBox();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.btnRESET = new System.Windows.Forms.Button();
            this.btnTHOAT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.gb1KH.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKH
            // 
            this.btnTimKH.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKH.Location = new System.Drawing.Point(374, 199);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(91, 43);
            this.btnTimKH.TabIndex = 5;
            this.btnTimKH.Text = "Tìm kiếm";
            this.btnTimKH.UseVisualStyleBackColor = true;
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKH.Location = new System.Drawing.Point(471, 199);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(91, 43);
            this.btnThemKH.TabIndex = 7;
            this.btnThemKH.Text = "Thêm mới";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // dgvKH
            // 
            this.dgvKH.AllowUserToAddRows = false;
            this.dgvKH.AllowUserToDeleteRows = false;
            this.dgvKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKH.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvKH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.TENKH,
            this.SDT,
            this.GIOITINH,
            this.EMAIL,
            this.DIACHI});
            this.dgvKH.Location = new System.Drawing.Point(-1, 247);
            this.dgvKH.MultiSelect = false;
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.ReadOnly = true;
            this.dgvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKH.Size = new System.Drawing.Size(800, 202);
            this.dgvKH.TabIndex = 4;
            this.dgvKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellContentClick);
            this.dgvKH.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellContentDoubleClick);
            this.dgvKH.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellDoubleClick);
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã KH";
            this.MAKH.Name = "MAKH";
            this.MAKH.ReadOnly = true;
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên KH";
            this.TENKH.Name = "TENKH";
            this.TENKH.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới Tính";
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.ReadOnly = true;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa Chỉ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            // 
            // btnXOA
            // 
            this.btnXOA.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXOA.Location = new System.Drawing.Point(568, 199);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(91, 43);
            this.btnXOA.TabIndex = 8;
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
            this.label8.Location = new System.Drawing.Point(285, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "Quản lý khách hàng";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gb1KH
            // 
            this.gb1KH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb1KH.Controls.Add(this.txtDIACHI);
            this.gb1KH.Controls.Add(this.label7);
            this.gb1KH.Controls.Add(this.label6);
            this.gb1KH.Controls.Add(this.label5);
            this.gb1KH.Controls.Add(this.rbKHAC);
            this.gb1KH.Controls.Add(this.rbNU);
            this.gb1KH.Controls.Add(this.rbNAM);
            this.gb1KH.Controls.Add(this.label4);
            this.gb1KH.Controls.Add(this.label2);
            this.gb1KH.Controls.Add(this.label1);
            this.gb1KH.Controls.Add(this.txtTENKH);
            this.gb1KH.Controls.Add(this.txtSDT);
            this.gb1KH.Controls.Add(this.txtMAKH);
            this.gb1KH.Controls.Add(this.txtEMAIL);
            this.gb1KH.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1KH.Location = new System.Drawing.Point(10, 33);
            this.gb1KH.Name = "gb1KH";
            this.gb1KH.Size = new System.Drawing.Size(776, 160);
            this.gb1KH.TabIndex = 17;
            this.gb1KH.TabStop = false;
            this.gb1KH.Text = "Tra cứu Thông tin khách hàng";
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.Location = new System.Drawing.Point(447, 93);
            this.txtDIACHI.MaxLength = 50;
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(163, 20);
            this.txtDIACHI.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 14);
            this.label7.TabIndex = 24;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 14);
            this.label6.TabIndex = 23;
            this.label6.Text = "EMAIL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 14);
            this.label5.TabIndex = 22;
            this.label5.Text = "Số điện thoại:";
            // 
            // rbKHAC
            // 
            this.rbKHAC.AutoSize = true;
            this.rbKHAC.Location = new System.Drawing.Point(621, 35);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 18;
            this.label4.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 14);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã khách hàng:";
            // 
            // txtTENKH
            // 
            this.txtTENKH.Location = new System.Drawing.Point(137, 67);
            this.txtTENKH.MaxLength = 35;
            this.txtTENKH.Name = "txtTENKH";
            this.txtTENKH.Size = new System.Drawing.Size(163, 20);
            this.txtTENKH.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(137, 93);
            this.txtSDT.MaxLength = 13;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(163, 20);
            this.txtSDT.TabIndex = 2;
            // 
            // txtMAKH
            // 
            this.txtMAKH.Location = new System.Drawing.Point(137, 37);
            this.txtMAKH.MaxLength = 12;
            this.txtMAKH.Name = "txtMAKH";
            this.txtMAKH.Size = new System.Drawing.Size(163, 20);
            this.txtMAKH.TabIndex = 0;
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(447, 67);
            this.txtEMAIL.MaxLength = 30;
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(163, 20);
            this.txtEMAIL.TabIndex = 3;
            // 
            // btnRESET
            // 
            this.btnRESET.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRESET.Location = new System.Drawing.Point(26, 199);
            this.btnRESET.Name = "btnRESET";
            this.btnRESET.Size = new System.Drawing.Size(91, 43);
            this.btnRESET.TabIndex = 6;
            this.btnRESET.Text = "Reset";
            this.btnRESET.UseVisualStyleBackColor = true;
            this.btnRESET.Click += new System.EventHandler(this.btnRESET_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTHOAT.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.Location = new System.Drawing.Point(663, 199);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(91, 43);
            this.btnTHOAT.TabIndex = 9;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // FrmQLKH
            // 
            this.AcceptButton = this.btnTimKH;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnTHOAT;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnRESET);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.dgvKH);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.btnTimKH);
            this.Controls.Add(this.gb1KH);
            this.Name = "FrmQLKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách khách hàng";
            this.Load += new System.EventHandler(this.FrmQLKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.gb1KH.ResumeLayout(false);
            this.gb1KH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gb1KH;
        private System.Windows.Forms.TextBox txtDIACHI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbKHAC;
        private System.Windows.Forms.RadioButton rbNU;
        private System.Windows.Forms.RadioButton rbNAM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTENKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtMAKH;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.Button btnRESET;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.DataGridView dgvKH;
    }
}