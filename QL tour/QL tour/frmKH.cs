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
    public partial class frmKH : Form
    {
        public frmKH(string mkh)
        {
            this.mkh = mkh;
            InitializeComponent();
        }
        private string mkh;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmKH_Load(object sender, EventArgs e)
        {
            txtMAKH.Select();
            if (string.IsNullOrEmpty(mkh))
            {
                this.Text = "Thêm mới khách hàng";
            }
            else
            {
                this.Text = "Cập nhật thông tin khách hàng "+ mkh;
                var r = new database().Select("SELECTKH '" + mkh + "'");
                // MessageBox.Show("Mã nhân viên nhận được: " + mnv);
                //MessageBox.Show(r[0].ToString());
                //set các giá trị vào component của form

                txtMAKH.Text = r["MAKH"].ToString();
                txtTENKH.Text = r["TENKH"].ToString();
                txtSDTKH.Text = r["SDT"].ToString();
                if (r["GIOITINH"].ToString() == "Nam")
                {
                    rbNam.Checked = true;
                }
                else if (r["GIOITINH"].ToString() == "Nữ")
                {
                    rbNu.Checked = true;
                }
                else
                {
                    rbKhac.Checked = true;
                }
                txtEmail.Text = r["EMAIL"].ToString();
                txtDIACHI.Text = r["DIACHI"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (txtTENKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng!");
            }
            else if (txtMAKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng!");
            }
            else if (txtSDTKH.Text == "0" || txtSDTKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại khách hàng!");
            }
            else if (txtDIACHI.Text == "0" || txtDIACHI.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng!");
            }
            else if(txtEmail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập email khách hàng!");
            }
            else
            {
                string MAKH = txtMAKH.Text;
                string TENKH = txtTENKH.Text;
                string SDT = txtSDTKH.Text;
                string GIOITINH = rbNam.Checked ? "Nam" : rbNu.Checked ? "Nữ" : "Khác";// toán tử 2 ngôi
                                                                                 // nếu radiobutton man đc check thfi chọn giá trị 1

                string EMAIL = txtEmail.Text;
                string DIACHI = txtDIACHI.Text;
                // khai báo một danh sách tham số = class Customparameter
                List<CustomParameter> lstPara = new List<CustomParameter>();
                if (string.IsNullOrEmpty(mkh))// nếu thêm mới sinh viên
                {
                    sql = "THEMMOIKHACHHANG";
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@MAKH",
                        value = MAKH
                    });
                }
                else // nếu cập nhật sinh viên
                {
                    sql = "UPDATEKHACHHANG";
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@MAKH",
                        value = mkh
                    });
                }

                lstPara.Add(new CustomParameter()
                {
                    key = "@TENKH",
                    value = TENKH
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@SDT",
                    value = SDT
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@GIOITINH",
                    value = GIOITINH
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@EMAIL",
                    value = EMAIL
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@DIACHI",
                    value = DIACHI
                });
                var rs = new database().ExeCute(sql, lstPara);// truyền 2 tham số là câu lệnh sql
                                                              // và danh sách các tham số
                if (rs == 1)// nếu thực hiện thành công
                {
                    if (string.IsNullOrEmpty(mkh))// nếu thêm mới
                    {
                        MessageBox.Show("thêm mới khách hàng thành công !");

                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin khách hàng thành công !");
                    }
                    this.Dispose();// đóng form khi thêm mới hoặc cập nhật thành công
                }
                else
                {
                    MessageBox.Show("Số điện thoại không được nhập kí tự!. Mã khách hàng không được trùng nhau !!");
                  //  MessageBox.Show("Thực thi thất bại !");
                }
            }


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát! ", "Xác Nhận thoát !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void frmKH_TextChanged(object sender, EventArgs e)
        {
            if (txtMAKH.Text == "" && txtTENKH.Text == "" && txtDIACHI.Text == "" && txtEmail.Text == "" && txtSDTKH.Text == "")
            {
                btnLuu.Enabled = false;

            }
            else
            {
                btnLuu.Enabled = true;
            }
        }
    }
}
