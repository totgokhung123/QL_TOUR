
namespace QL_tour
{
    partial class frmTOUR
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
            this.txtMATOUR = new System.Windows.Forms.TextBox();
            this.txtTENTOUR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGIATOUR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxtNGAYDI = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNGAYKETTHUC = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rtxtMOTA = new System.Windows.Forms.RichTextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.cbbMADDEN = new System.Windows.Forms.ComboBox();
            this.cbbMADDI = new System.Windows.Forms.ComboBox();
            this.cbbMALTOUR = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Tour:";
            // 
            // txtMATOUR
            // 
            this.txtMATOUR.Location = new System.Drawing.Point(181, 48);
            this.txtMATOUR.MaxLength = 12;
            this.txtMATOUR.Name = "txtMATOUR";
            this.txtMATOUR.Size = new System.Drawing.Size(251, 20);
            this.txtMATOUR.TabIndex = 1;
            this.txtMATOUR.TextChanged += new System.EventHandler(this.frmTOUR_TextChanged);
            // 
            // txtTENTOUR
            // 
            this.txtTENTOUR.Location = new System.Drawing.Point(181, 74);
            this.txtTENTOUR.MaxLength = 100;
            this.txtTENTOUR.Name = "txtTENTOUR";
            this.txtTENTOUR.Size = new System.Drawing.Size(251, 20);
            this.txtTENTOUR.TabIndex = 2;
            this.txtTENTOUR.TextChanged += new System.EventHandler(this.frmTOUR_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Tour:";
            // 
            // txtGIATOUR
            // 
            this.txtGIATOUR.Location = new System.Drawing.Point(181, 100);
            this.txtGIATOUR.MaxLength = 13;
            this.txtGIATOUR.Name = "txtGIATOUR";
            this.txtGIATOUR.Size = new System.Drawing.Size(251, 20);
            this.txtGIATOUR.TabIndex = 3;
            this.txtGIATOUR.TextChanged += new System.EventHandler(this.frmTOUR_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá Tour:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã loại Tour:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã điểm đến:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã điểm đi:";
            // 
            // mtxtNGAYDI
            // 
            this.mtxtNGAYDI.Location = new System.Drawing.Point(181, 126);
            this.mtxtNGAYDI.Mask = "00/00/0000";
            this.mtxtNGAYDI.Name = "mtxtNGAYDI";
            this.mtxtNGAYDI.Size = new System.Drawing.Size(100, 20);
            this.mtxtNGAYDI.TabIndex = 4;
            this.mtxtNGAYDI.ValidatingType = typeof(System.DateTime);
            this.mtxtNGAYDI.TextChanged += new System.EventHandler(this.frmTOUR_TextChanged);
            // 
            // mtxtNGAYKETTHUC
            // 
            this.mtxtNGAYKETTHUC.Location = new System.Drawing.Point(181, 152);
            this.mtxtNGAYKETTHUC.Mask = "00/00/0000";
            this.mtxtNGAYKETTHUC.Name = "mtxtNGAYKETTHUC";
            this.mtxtNGAYKETTHUC.Size = new System.Drawing.Size(100, 20);
            this.mtxtNGAYKETTHUC.TabIndex = 5;
            this.mtxtNGAYKETTHUC.ValidatingType = typeof(System.DateTime);
            this.mtxtNGAYKETTHUC.TextChanged += new System.EventHandler(this.frmTOUR_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(98, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ngày đi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(98, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 14);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ngày kết thúc:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(98, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 14);
            this.label10.TabIndex = 18;
            this.label10.Text = "Mô tả:";
            // 
            // rtxtMOTA
            // 
            this.rtxtMOTA.Location = new System.Drawing.Point(181, 178);
            this.rtxtMOTA.MaxLength = 300;
            this.rtxtMOTA.Name = "rtxtMOTA";
            this.rtxtMOTA.Size = new System.Drawing.Size(251, 77);
            this.rtxtMOTA.TabIndex = 6;
            this.rtxtMOTA.Text = "";
            this.rtxtMOTA.TextChanged += new System.EventHandler(this.frmTOUR_TextChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(191, 360);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 49);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(303, 360);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 49);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cbbMADDEN
            // 
            this.cbbMADDEN.FormattingEnabled = true;
            this.cbbMADDEN.Location = new System.Drawing.Point(181, 294);
            this.cbbMADDEN.Name = "cbbMADDEN";
            this.cbbMADDEN.Size = new System.Drawing.Size(251, 21);
            this.cbbMADDEN.TabIndex = 8;
            this.cbbMADDEN.SelectedIndexChanged += new System.EventHandler(this.cbbMADDEN_SelectedIndexChanged);
            this.cbbMADDEN.TextChanged += new System.EventHandler(this.frmTOUR_TextChanged);
            // 
            // cbbMADDI
            // 
            this.cbbMADDI.FormattingEnabled = true;
            this.cbbMADDI.Location = new System.Drawing.Point(181, 321);
            this.cbbMADDI.Name = "cbbMADDI";
            this.cbbMADDI.Size = new System.Drawing.Size(251, 21);
            this.cbbMADDI.TabIndex = 9;
            this.cbbMADDI.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.cbbMADDI.TextChanged += new System.EventHandler(this.frmTOUR_TextChanged);
            // 
            // cbbMALTOUR
            // 
            this.cbbMALTOUR.FormattingEnabled = true;
            this.cbbMALTOUR.Location = new System.Drawing.Point(181, 267);
            this.cbbMALTOUR.Name = "cbbMALTOUR";
            this.cbbMALTOUR.Size = new System.Drawing.Size(251, 21);
            this.cbbMALTOUR.TabIndex = 7;
            this.cbbMALTOUR.SelectedIndexChanged += new System.EventHandler(this.cbbMALTOUR_SelectedIndexChanged);
            this.cbbMALTOUR.TextChanged += new System.EventHandler(this.frmTOUR_TextChanged);
            // 
            // frmTOUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 474);
            this.Controls.Add(this.cbbMALTOUR);
            this.Controls.Add(this.cbbMADDI);
            this.Controls.Add(this.cbbMADDEN);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.rtxtMOTA);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mtxtNGAYKETTHUC);
            this.Controls.Add(this.mtxtNGAYDI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGIATOUR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTENTOUR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMATOUR);
            this.Controls.Add(this.label1);
            this.Name = "frmTOUR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTOUR";
            this.Load += new System.EventHandler(this.frmTOUR_Load);
            this.TextChanged += new System.EventHandler(this.frmTOUR_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMATOUR;
        private System.Windows.Forms.TextBox txtTENTOUR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGIATOUR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxtNGAYDI;
        private System.Windows.Forms.MaskedTextBox mtxtNGAYKETTHUC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtxtMOTA;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cbbMADDEN;
        private System.Windows.Forms.ComboBox cbbMADDI;
        private System.Windows.Forms.ComboBox cbbMALTOUR;
    }
}