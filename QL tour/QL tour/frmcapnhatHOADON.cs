using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_tour
{
    public partial class frmcapnhatHOADON : Form
    {
        public frmcapnhatHOADON(string sohd)
        {
            this.sohd = sohd;
            InitializeComponent();
        }
        private string sohd;

        private void frmcapnhatHOADON_Load(object sender, EventArgs e)
        {
            txtSHD.Select();
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key ="@tukhoa",
                    value =""
                }
            };
            if (string.IsNullOrEmpty(sohd))
            {
                this.Text = "Thêm mới hóa đơn";
            }
            else
            {
                this.Text = "Cập nhật thông tin hóa đơn" + sohd;
                var r = new database().Select("SELECT1HOADON '" + sohd + "'");
                // MessageBox.Show("Mã nhân viên nhận được: " + mnv);
                //MessageBox.Show(r[0].ToString());
                //set các giá trị vào component của form


                txtSHD.Text = r["SOHD"].ToString();
                mtxtNGAYLAP.Text = r["NGAYLAP"].ToString();
                txtTHANHTIEN.Text = r["THANHTIEN"].ToString();
                txtMATOUR.Text = r["MATOUR"].ToString();
                txtMANV.Text = r["MANV"].ToString();
                txtMAKH.Text = r["MAKH"].ToString();
                txtTRANGTHAI.Text = r["TRANGTHAI"].ToString();

            }
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (txtSHD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số hóa đơn!");
            }
            else if (txtTHANHTIEN.Text == "" || txtTHANHTIEN.Text == "0")
            {
                MessageBox.Show("Bạn chưa nhập thành tiền!");
            }
            else if (txtMATOUR.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã tour!");
            }
            else if (txtMAKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng!");
            }
            else if (txtMANV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên!");
            }
            else
            {
                string SOHD = txtSHD.Text;
                DateTime NGAYLAP;
                try
                {
                    NGAYLAP = DateTime.ParseExact(mtxtNGAYLAP.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ngày lập không hợp lệ! ");
                    mtxtNGAYLAP.Select();
                    return;
                }
                string THANHTIEN = txtTHANHTIEN.Text;
                string MATOUR = txtMATOUR.Text;
                string MAKH = txtMAKH.Text;
                string MANV = txtMANV.Text;
                string TRANGTHAI = txtTRANGTHAI.Text;

                List<CustomParameter> lstPara = new List<CustomParameter>();
                if (string.IsNullOrEmpty(sohd))// nếu thêm mới tour
                {
                    sql = "THEMHOADON";
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@SOHD",
                        value = SOHD
                    });
                }
                else // nếu cập nhật sinh viên
                {
                    sql = "UPDATEHOADON";
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@SOHD",
                        value = sohd
                    });
                }


                lstPara.Add(new CustomParameter()
                {
                    key = "@NGAYLAP",
                    value = NGAYLAP.ToString("yyyy-MM-dd")
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@THANHTIEN",
                    value = THANHTIEN
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@MATOUR",
                    value = MATOUR
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@MAKH",
                    value = MAKH
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@MANV",
                    value = MANV
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@TRANGTHAI",
                    value = TRANGTHAI
                });
                var rs = new database().ExeCute(sql, lstPara);// truyền 2 tham số là câu lệnh sql
                                                              // và danh sách các tham số
                if (rs == 1)// nếu thực hiện thành công
                {
                    if (string.IsNullOrEmpty(sohd))// nếu thêm mới
                    {
                        MessageBox.Show("thêm mới Hoá đơn thành công !");

                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin Hóa đơn thành công !");
                    }
                    this.Dispose();// đóng form khi thêm mới hoặc cập nhật thành công
                }
                else
                {
                    MessageBox.Show("Số thành tiền không được nhập kí tự!. Hoặc số hóa đơn không được trùng nhau !!" +
                        "kiểm tra mã khách hàng, tour, nhân viên có trong danh sách hay không!");

                    //MessageBox.Show("thực thi thất bại !");
                }
            }
        }

        private void btnHUY_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát! ", "Xác Nhận thoát !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void frmcapnhatHOADON_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frmcapnhatHOADON_TextChanged(object sender, EventArgs e)
        {
            if (txtSHD.Text == "" && txtMAKH.Text == "" && txtMANV.Text == "" && txtMATOUR.Text == "" && txtTHANHTIEN.Text == "" && txtTRANGTHAI.Text == "")
            {
                if (mtxtNGAYLAP.Text == "")
                {
                    btnLUU.Enabled = false;
                }
                else
                {
                    btnLUU.Enabled = false;
                }
            }
            else
            {
                if (mtxtNGAYLAP.Text == "" )
                {
                    btnLUU.Enabled = false;
                }
                else
                {
                    btnLUU.Enabled = true;
                }
            }
        }
    }
}
