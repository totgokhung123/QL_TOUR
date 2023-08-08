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
    public partial class frmNV : Form
    {
        public frmNV(string mnv)
        {
            this.mnv = mnv; // truyền lại mã sinh viên khi form chạy

            InitializeComponent();
        }
        private string mnv;
        private void frmNV_Load(object sender, EventArgs e)
        {

            txtMaNV.Select();
            if (string.IsNullOrEmpty(mnv))
            {
                this.Text = "Thêm mới nhân viên";
            }
            else
            {
                this.Text = "Cập nhật thông tin nhân viên"+ mnv;
                var r = new database().Select("SELECTNV '" + mnv + "'");
                // MessageBox.Show("Mã nhân viên nhận được: " + mnv);
                //MessageBox.Show(r[0].ToString());
                //set các giá trị vào component của form

                txtMaNV.Text = r["MANV"].ToString();
                txtTenNV.Text = r["TENNV"].ToString();
                MtxtNGAYSINH.Text = r["NGAYSINH"].ToString();
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
                txtSDT.Text = r["SDT"].ToString();
                txtCCCD.Text = r["CCCD"].ToString();
                MtxtNGAYVL.Text = r["NGAYVL"].ToString();
            }
        }





        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            // button bttluu sẽ sử lý 1 trong 2 tình huống
            // trường hợp 1: nếu mã nhân viên không có giá trị -> thêm mới nhân viên
            // trường hợp 2: nếu mã nhân viên có giá trị -> cập nhật thông tin nhân viên
            /* ý tưởng 
             -- cho dù thêm mới hay cập nhật --
            thì đều cần các giá trị như : tên, ngày sinh, giới tính
            quê quán = > các giá trị này đúng cho cả 2 trường hợp
            --- riêng cập nhật nhân viên , cần quan tâm tới mã nhân viên

             */
            string sql = "";

            if(txtTenNV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên!");
            }
            else if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên nhân viên!");
            }
            else if(txtSDT.Text == "0" || txtSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại nhân viên!");
            }
            else if (txtCCCD.Text == "0" || txtCCCD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập căn cước công dân nhân viên!");
            }               
            else
            {
                string MANV = txtMaNV.Text;
                string TENNV = txtTenNV.Text;
                DateTime NGAYSINH;
                try
                {
                    NGAYSINH = DateTime.ParseExact(MtxtNGAYSINH.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ !");
                    MtxtNGAYSINH.Select();// trỏ chuột về mtxtNGAYSSINH
                    return;// không thực hiện các lệnh phái dưới
                }
                // vì ngày sinh ở masketbox chúng ta set theo dạng dd/mm/yyy
                //nhưng  trong csld lại lưu yyyy-mm-dd
                //=> chúng ta cần chuyến từ dd/mm/yyyy sang yyyy-mm-dd
                // string GIOITINH = txt.Text;
                string GIOITINH = rbNam.Checked ? "Nam" : rbNu.Checked ? "Nữ" : "Khác";// toán tử 2 ngôi
                                                                                       // nếu radiobutton man đc check thfi chọn giá trị 1

                string SDT = txtSDT.Text;
                string CCCD = txtCCCD.Text;
                DateTime NGAYVL;
                try
                {
                    NGAYVL = DateTime.ParseExact(MtxtNGAYVL.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ngày vào làm không hợp lệ !");
                    MtxtNGAYVL.Select();// trỏ chuột về mtxtNGAYSSINH
                    return;// không thực hiện các lệnh phái dưới
                }
                // khai báo một danh sách tham số = class Customparameter
                List<CustomParameter> lstPara = new List<CustomParameter>();
                if (string.IsNullOrEmpty(mnv))// nếu thêm mới sinh viên
                {
                    sql = "THEMMOINHANVIEN";
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@MANV",
                        value = MANV
                    });
                }
                else // nếu cập nhật sinh viên
                {
                    sql = "UPDATENHANVIEN";
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@MANV",
                        value = mnv
                    });
                }

                lstPara.Add(new CustomParameter()
                {
                    key = "@TENNV",
                    value = TENNV
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@NGAYSINH",
                    value = NGAYSINH.ToString("yyyy-MM-dd")
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@GIOITINH",
                    value = GIOITINH
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@SDT",
                    value = SDT
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@CCCD",
                    value = CCCD
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@NGAYVL",
                    value = NGAYVL.ToString("yyyy-MM-dd")
                });
                
                var rs = new database().ExeCute(sql, lstPara);// truyền 2 tham số là câu lệnh sql
                  
                // và danh sách các tham số
                if (rs == 1)// nếu thực hiện thành công
                {
                    if (string.IsNullOrEmpty(mnv))// nếu thêm mới
                    {
                        MessageBox.Show("thêm mới nhân viên thành công !");

                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin nhân viên thành công !");
                    }
                    this.Dispose();// đóng form khi thêm mới hoặc cập nhật thành công
                }
                else
                {
                    MessageBox.Show("Số điện thoại,căn cước công dân không được nhập kí tự!. Mã nhân viên không được trùng nhau !!");
                   // MessageBox.Show("Thực thi thất bại !");
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát! ", "Xác Nhận thoát !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void frmNV_TextChanged(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" && txtTenNV.Text == "" && txtSDT.Text == "" && txtCCCD.Text == "")
            {
                if (MtxtNGAYSINH.Text == "" && MtxtNGAYVL.Text == "")
                {
                    bttLuu.Enabled = false;
                }
                else
                {
                    bttLuu.Enabled = false;
                }
            }
            else
            {
                if (MtxtNGAYSINH.Text == "" && MtxtNGAYVL.Text == "")
                {
                    bttLuu.Enabled = false;
                }
                else
                {
                    bttLuu.Enabled = true;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
