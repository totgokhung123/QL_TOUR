
namespace QL_tour
{
    partial class frmcapnhatHOADON
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSHD = new System.Windows.Forms.TextBox();
            this.mtxtNGAYLAP = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMATOUR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMAKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTRANGTHAI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTHANHTIEN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLUU = new System.Windows.Forms.Button();
            this.btnHUY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số hóa đơn:";
            // 
            // txtSHD
            // 
            this.txtSHD.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSHD.Location = new System.Drawing.Point(135, 54);
            this.txtSHD.MaxLength = 6;
            this.txtSHD.Name = "txtSHD";
            this.txtSHD.Size = new System.Drawing.Size(213, 22);
            this.txtSHD.TabIndex = 0;
            this.txtSHD.TextChanged += new System.EventHandler(this.frmcapnhatHOADON_TextChanged);
            // 
            // mtxtNGAYLAP
            // 
            this.mtxtNGAYLAP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtNGAYLAP.Location = new System.Drawing.Point(135, 80);
            this.mtxtNGAYLAP.Mask = "00/00/0000";
            this.mtxtNGAYLAP.Name = "mtxtNGAYLAP";
            this.mtxtNGAYLAP.Size = new System.Drawing.Size(89, 22);
            this.mtxtNGAYLAP.TabIndex = 1;
            this.mtxtNGAYLAP.ValidatingType = typeof(System.DateTime);
            this.mtxtNGAYLAP.TextChanged += new System.EventHandler(this.frmcapnhatHOADON_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày lập:";
            // 
            // txtMATOUR
            // 
            this.txtMATOUR.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMATOUR.Location = new System.Drawing.Point(135, 134);
            this.txtMATOUR.MaxLength = 12;
            this.txtMATOUR.Name = "txtMATOUR";
            this.txtMATOUR.Size = new System.Drawing.Size(213, 22);
            this.txtMATOUR.TabIndex = 3;
            this.txtMATOUR.TextChanged += new System.EventHandler(this.frmcapnhatHOADON_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã tour:";
            // 
            // txtMAKH
            // 
            this.txtMAKH.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAKH.Location = new System.Drawing.Point(135, 160);
            this.txtMAKH.MaxLength = 12;
            this.txtMAKH.Name = "txtMAKH";
            this.txtMAKH.Size = new System.Drawing.Size(213, 22);
            this.txtMAKH.TabIndex = 4;
            this.txtMAKH.TextChanged += new System.EventHandler(this.frmcapnhatHOADON_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã KH:";
            // 
            // txtMANV
            // 
            this.txtMANV.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMANV.Location = new System.Drawing.Point(135, 186);
            this.txtMANV.MaxLength = 12;
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(213, 22);
            this.txtMANV.TabIndex = 5;
            this.txtMANV.TextChanged += new System.EventHandler(this.frmcapnhatHOADON_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã NV:";
            // 
            // txtTRANGTHAI
            // 
            this.txtTRANGTHAI.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTRANGTHAI.Location = new System.Drawing.Point(135, 212);
            this.txtTRANGTHAI.MaxLength = 30;
            this.txtTRANGTHAI.Name = "txtTRANGTHAI";
            this.txtTRANGTHAI.Size = new System.Drawing.Size(213, 22);
            this.txtTRANGTHAI.TabIndex = 6;
            this.txtTRANGTHAI.TextChanged += new System.EventHandler(this.frmcapnhatHOADON_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Trạng Thái:";
            // 
            // txtTHANHTIEN
            // 
            this.txtTHANHTIEN.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTHANHTIEN.Location = new System.Drawing.Point(135, 106);
            this.txtTHANHTIEN.MaxLength = 13;
            this.txtTHANHTIEN.Name = "txtTHANHTIEN";
            this.txtTHANHTIEN.Size = new System.Drawing.Size(213, 22);
            this.txtTHANHTIEN.TabIndex = 2;
            this.txtTHANHTIEN.TextChanged += new System.EventHandler(this.frmcapnhatHOADON_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Thành Tiền:";
            // 
            // btnLUU
            // 
            this.btnLUU.Location = new System.Drawing.Point(135, 264);
            this.btnLUU.Name = "btnLUU";
            this.btnLUU.Size = new System.Drawing.Size(75, 38);
            this.btnLUU.TabIndex = 7;
            this.btnLUU.Text = "Lưu";
            this.btnLUU.UseVisualStyleBackColor = true;
            this.btnLUU.Click += new System.EventHandler(this.btnLUU_Click);
            // 
            // btnHUY
            // 
            this.btnHUY.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHUY.Location = new System.Drawing.Point(236, 264);
            this.btnHUY.Name = "btnHUY";
            this.btnHUY.Size = new System.Drawing.Size(75, 38);
            this.btnHUY.TabIndex = 8;
            this.btnHUY.Text = "Hủy";
            this.btnHUY.UseVisualStyleBackColor = true;
            this.btnHUY.Click += new System.EventHandler(this.btnHUY_Click);
            // 
            // frmcapnhatHOADON
            // 
            this.AcceptButton = this.btnLUU;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHUY;
            this.ClientSize = new System.Drawing.Size(466, 345);
            this.Controls.Add(this.btnHUY);
            this.Controls.Add(this.btnLUU);
            this.Controls.Add(this.txtTHANHTIEN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTRANGTHAI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMANV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMAKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMATOUR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxtNGAYLAP);
            this.Controls.Add(this.txtSHD);
            this.Controls.Add(this.label1);
            this.Name = "frmcapnhatHOADON";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật hóa đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmcapnhatHOADON_FormClosing);
            this.Load += new System.EventHandler(this.frmcapnhatHOADON_Load);
            this.TextChanged += new System.EventHandler(this.frmcapnhatHOADON_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSHD;
        private System.Windows.Forms.MaskedTextBox mtxtNGAYLAP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMATOUR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMAKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTRANGTHAI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTHANHTIEN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLUU;
        private System.Windows.Forms.Button btnHUY;
    }
}