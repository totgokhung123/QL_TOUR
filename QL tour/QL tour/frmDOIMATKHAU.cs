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
    public partial class frmDOIMATKHAU : Form
    {
        public frmDOIMATKHAU()
        {
            InitializeComponent();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            Close();
        }
        public string tendangnhap = "";
        public string loaitk = "";
        private void btnDANGHAP_Click(object sender, EventArgs e)
        {
            if (cbbLOAITK.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return;
            }

            if (string.IsNullOrEmpty(rtxtTAIKHOAN.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản! ");
                rtxtTAIKHOAN.Select();
                return;
            }
            if (string.IsNullOrEmpty(rtxtMATKHAUHIENTAI.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khảu! ");
                rtxtMATKHAUHIENTAI.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtMKMOI.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khảu! ");
                txtMKMOI.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtXACNHANMK.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khảu! ");
                txtXACNHANMK.Select();
                return;
            }
            #region SWTK
            tendangnhap = rtxtTAIKHOAN.Text;
            loaitk = "";
            switch (cbbLOAITK.Text)
            {
                case "Quản trị viên ":
                    loaitk = "admin";
                    break;
                case "Nhân Viên ":
                    loaitk = "nhanvien";
                    break;
                case "Khách Hàng ":
                    loaitk = "khachhang";
                    break;
            }
            #endregion
            if(txtXACNHANMK.Text == txtMKMOI.Text)
            {
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
                        key = "@OldPass",
                        value= rtxtMATKHAUHIENTAI.Text
                    },
                    new CustomParameter()
                    {
                        key = "@NewPass",
                        value= txtMKMOI.Text
                    },
                };
                var rs = new database().SelectData("DOIMATKHAU", lst);
                if (rs.Rows.Count > 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai !!");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng, xin mời nhập lại !!");
                txtXACNHANMK.Clear();
                txtXACNHANMK.Select();                
            }
            
        }

        private void frmDOIMATKHAU_Load(object sender, EventArgs e)
        {

        }

        private void frmDOIMATKHAU_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát! ", "Xác Nhận thoát !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
