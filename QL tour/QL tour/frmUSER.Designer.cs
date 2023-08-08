
namespace QL_tour
{
    partial class frmUSER
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDANGHAP = new System.Windows.Forms.Button();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.cbbLOAITK = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtTAIKHOAN = new System.Windows.Forms.TextBox();
            this.rtxtMATKHAU = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐĂNG NHẬP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tài Khoản: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu:";
            // 
            // btnDANGHAP
            // 
            this.btnDANGHAP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDANGHAP.Location = new System.Drawing.Point(107, 238);
            this.btnDANGHAP.Name = "btnDANGHAP";
            this.btnDANGHAP.Size = new System.Drawing.Size(89, 37);
            this.btnDANGHAP.TabIndex = 4;
            this.btnDANGHAP.Text = "Đăng nhập";
            this.btnDANGHAP.UseVisualStyleBackColor = true;
            this.btnDANGHAP.Click += new System.EventHandler(this.btnDANGHAP_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTHOAT.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.Location = new System.Drawing.Point(232, 238);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(85, 37);
            this.btnTHOAT.TabIndex = 5;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
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
            this.cbbLOAITK.Location = new System.Drawing.Point(107, 83);
            this.cbbLOAITK.Name = "cbbLOAITK";
            this.cbbLOAITK.Size = new System.Drawing.Size(232, 24);
            this.cbbLOAITK.TabIndex = 1;
            this.cbbLOAITK.SelectedIndexChanged += new System.EventHandler(this.cbbLOAITK_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Loại TK: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rtxtTAIKHOAN
            // 
            this.rtxtTAIKHOAN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtTAIKHOAN.Location = new System.Drawing.Point(107, 134);
            this.rtxtTAIKHOAN.Name = "rtxtTAIKHOAN";
            this.rtxtTAIKHOAN.Size = new System.Drawing.Size(232, 22);
            this.rtxtTAIKHOAN.TabIndex = 2;
            this.rtxtTAIKHOAN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxtTAIKHOAN_KeyDown);
            // 
            // rtxtMATKHAU
            // 
            this.rtxtMATKHAU.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtMATKHAU.Location = new System.Drawing.Point(107, 187);
            this.rtxtMATKHAU.Name = "rtxtMATKHAU";
            this.rtxtMATKHAU.Size = new System.Drawing.Size(232, 22);
            this.rtxtMATKHAU.TabIndex = 3;
            this.rtxtMATKHAU.UseSystemPasswordChar = true;
            this.rtxtMATKHAU.Enter += new System.EventHandler(this.rtxtMATKHAU_TextChanged);
            this.rtxtMATKHAU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxtMATKHAU_KeyDown);
            // 
            // frmUSER
            // 
            this.AcceptButton = this.btnDANGHAP;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnTHOAT;
            this.ClientSize = new System.Drawing.Size(435, 299);
            this.Controls.Add(this.rtxtMATKHAU);
            this.Controls.Add(this.rtxtTAIKHOAN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbLOAITK);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnDANGHAP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUSER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUSER_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUSER_FormClosed);
            this.Load += new System.EventHandler(this.frmUSER_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDANGHAP;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.ComboBox cbbLOAITK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rtxtTAIKHOAN;
        private System.Windows.Forms.TextBox rtxtMATKHAU;
    }
}