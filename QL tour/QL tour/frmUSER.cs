using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_tour
{
    public partial class frmUSER : Form
    {
        public frmUSER()
        {           
            InitializeComponent();
        }
        public string tendangnhap = "";
        public string loaitk = "";

        private void btnTHOAT_Click(object sender, EventArgs e)
        {       
            Application.Exit();
        }


        private void btnDANGHAP_Click(object sender, EventArgs e)
        {
            if(cbbLOAITK.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return;
            }

            if(string.IsNullOrEmpty(rtxtTAIKHOAN.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản! ");
                rtxtTAIKHOAN.Select();
                return;
            }
            if (string.IsNullOrEmpty(rtxtMATKHAU.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khảu! ");
                rtxtMATKHAU.Select();
                return;
            }
            #region SWTK
            tendangnhap = rtxtTAIKHOAN.Text;
             loaitk = "";
            switch (cbbLOAITK.Text)
            {
                case "Quản trị viên ":
                    loaitk ="admin";
                    break;
                case "Nhân Viên ":
                    loaitk ="nhanvien";
                    break;
                case "Khách Hàng ":
                    loaitk ="khachhang";
                    break;
            }
            #endregion
            List<CustomParameter> lst = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@LOAITAIKHOAN",
                        value= loaitk
                    },
                    new CustomParameter()
                    {
                        key = "@TAIKHOAN",
                        value= rtxtTAIKHOAN.Text
                    },
                    new CustomParameter()
                    {
                        key = "@MATKHAU",
                        value= rtxtMATKHAU.Text
                    },
                };
            var rs = new database().SelectData("DANGNHAP", lst);
            if (rs.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công ! ");
                frmMain fmain = new frmMain();
               this.Hide();
                
                if (loaitk.Equals("admin"))
                {
                    // nếu là admin 
                    
                  //  fmain.DangkytourToolStripMenuItem.Enabled = false;
                }
                
                else if (loaitk.Equals("nhanvien"))
                {
                    // nhân viên ko được sửa thông tin QL nhân viên

                    fmain.QLNVToolStripMenuItem.Enabled = false;
                }
                else
                {
                    // khách hàng chỉ được đăng ký tour
                    fmain.QUANLYToolStripMenuItem.Enabled = false;
                }
                fmain.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại tài khoản và mật khẩu", "Tài khoản hoặc mật khẩu không hợp lệ!  ");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbbLOAITK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rtxtMATKHAU_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtxtMATKHAU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDANGHAP_Click(sender, e);
            }
        }

        private void rtxtTAIKHOAN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDANGHAP_Click(sender, e);
            }
        }

        private void frmUSER_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
            if (MessageBox.Show("Bạn có chắc muốn thoát! " , "Xác Nhận thoát !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

               // Application.Exit();
            

        }

        private void frmUSER_Load(object sender, EventArgs e)
        {

        }

        private void frmUSER_FormClosed(object sender, FormClosedEventArgs e)
        {            

               // Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
