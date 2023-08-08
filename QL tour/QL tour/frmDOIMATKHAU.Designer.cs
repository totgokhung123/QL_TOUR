
namespace QL_tour
{
    partial class frmDOIMATKHAU
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
            this.rtxtMATKHAUHIENTAI = new System.Windows.Forms.TextBox();
            this.rtxtTAIKHOAN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbLOAITK = new System.Windows.Forms.ComboBox();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMKMOI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtXACNHANMK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxtMATKHAUHIENTAI
            // 
            this.rtxtMATKHAUHIENTAI.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtMATKHAUHIENTAI.Location = new System.Drawing.Point(134, 167);
            this.rtxtMATKHAUHIENTAI.MaxLength = 30;
            this.rtxtMATKHAUHIENTAI.Name = "rtxtMATKHAUHIENTAI";
            this.rtxtMATKHAUHIENTAI.Size = new System.Drawing.Size(232, 22);
            this.rtxtMATKHAUHIENTAI.TabIndex = 3;
            this.rtxtMATKHAUHIENTAI.UseSystemPasswordChar = true;
            // 
            // rtxtTAIKHOAN
            // 
            this.rtxtTAIKHOAN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtTAIKHOAN.Location = new System.Drawing.Point(134, 123);
            this.rtxtTAIKHOAN.MaxLength = 20;
            this.rtxtTAIKHOAN.Name = "rtxtTAIKHOAN";
            this.rtxtTAIKHOAN.Size = new System.Drawing.Size(232, 22);
            this.rtxtTAIKHOAN.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Loại TK: ";
            // 
            // cbbLOAITK
            // 
            this.cbbLOAITK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbLOAITK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLOAITK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLOAITK.FormattingEnabled = true;
            this.cbbLOAITK.Items.AddRange(new object[] {
            "Quản trị viên ",
            "Nhân Viên ",
            "Khách Hàng "});
            this.cbbLOAITK.Location = new System.Drawing.Point(134, 80);
            this.cbbLOAITK.Name = "cbbLOAITK";
            this.cbbLOAITK.Size = new System.Drawing.Size(232, 24);
            this.cbbLOAITK.TabIndex = 1;
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTHOAT.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.Location = new System.Drawing.Point(262, 310);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(85, 37);
            this.btnTHOAT.TabIndex = 7;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(137, 310);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 37);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnDANGHAP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mật khẩu hiện tại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tài Khoản: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // txtMKMOI
            // 
            this.txtMKMOI.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKMOI.Location = new System.Drawing.Point(134, 210);
            this.txtMKMOI.MaxLength = 30;
            this.txtMKMOI.Name = "txtMKMOI";
            this.txtMKMOI.Size = new System.Drawing.Size(232, 22);
            this.txtMKMOI.TabIndex = 4;
            this.txtMKMOI.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mật khẩu mới:";
            // 
            // txtXACNHANMK
            // 
            this.txtXACNHANMK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXACNHANMK.Location = new System.Drawing.Point(134, 253);
            this.txtXACNHANMK.MaxLength = 30;
            this.txtXACNHANMK.Name = "txtXACNHANMK";
            this.txtXACNHANMK.Size = new System.Drawing.Size(232, 22);
            this.txtXACNHANMK.TabIndex = 5;
            this.txtXACNHANMK.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Xác nhận mật khẩu:";
            // 
            // frmDOIMATKHAU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 380);
            this.Controls.Add(this.txtXACNHANMK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMKMOI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtxtMATKHAUHIENTAI);
            this.Controls.Add(this.rtxtTAIKHOAN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbLOAITK);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDOIMATKHAU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDOIMATKHAU_FormClosing);
            this.Load += new System.EventHandler(this.frmDOIMATKHAU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rtxtMATKHAUHIENTAI;
        private System.Windows.Forms.TextBox rtxtTAIKHOAN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbLOAITK;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMKMOI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtXACNHANMK;
        private System.Windows.Forms.Label label6;
    }
}