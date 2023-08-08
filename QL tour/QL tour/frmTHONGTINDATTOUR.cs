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
    public partial class frmTHONGTINDATTOUR : Form
    {
        public frmTHONGTINDATTOUR(string mtour)
        {
            this.mtour = mtour;
            InitializeComponent();
        }
        private string mtour;
        private void frmTHONGTINDATTOUR_Load(object sender, EventArgs e)
        {
            txtTHEMMAKH.Select();
            this.Text = "Thông tin Đặt tour " + mtour;
            var r = new database().Select("SELECT1TOURFORMDATTOUR '" + mtour + "'");
            // MessageBox.Show("Mã nhân viên nhận được: " + mnv);
            //MessageBox.Show(r[0].ToString());
            //set các giá trị vào component của form

            lbMATOUR.Text = r["MATOUR"].ToString();
            lbTENTOUR.Text = r["TENTOUR"].ToString();
            textGIATOUR.Text = r["GIATOUR"].ToString() + " VNĐ";
            textNGAYKH.Text = r["NGAYDI"].ToString();
            textNGAYKT.Text = r["NGAYKETTHUC"].ToString();
            textDIEMDI.Text = r["TENDDI"].ToString();
            textDIEMDEN.Text = r["TENDDEN"].ToString();
            lbLOAITOUR.Text = r["TENLOAITOUR"].ToString();
            textTHANHTIEN.Text = textGIATOUR.Text;
            textMATOUR.Text = lbMATOUR.Text;
            loaddsdattour();
        }
        /*
        private string MAKH = "";
        private string TENKH = "";
        private string SDT = "";
        private string EMAIL = "";
        private string DIACHI = "";
        private string GIOITINH = "";
        */
        private void loaddsdattour()
        {
            
            List<CustomParameter> lstPara = new List<CustomParameter>();           
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = "qưerqewrqwer"
            });
            dgvKIEMRAKH.DataSource = new database().SelectData("SELECTALLKHACHHANG", lstPara);
        }
        private void btnTAOKH_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (txtTENKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng!");
            }
            else if (txtTHEMMAKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng!");
            }
            else if (txtSDT.Text == "0" || txtSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại khách hàng!");
            }
            else if (txtDIACHI.Text == "0" || txtDIACHI.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng!");
            }
            else if (txtEMAIL.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập email khách hàng!");
            }
            else
            {
                string MAKH = txtTHEMMAKH.Text;
                string TENKH = txtTENKH.Text;
                string SDT = txtSDT.Text;
                string GIOITINH = rbNam.Checked ? "Nam" : rbNu.Checked ? "Nữ" : "Khác";// toán tử 2 ngôi
                                                                                 // nếu radiobutton man đc check thfi chọn giá trị 1
                string EMAIL = txtEMAIL.Text;
                string DIACHI = txtDIACHI.Text;
                // khai báo một danh sách tham số = class Customparameter
                List<CustomParameter> lstPara = new List<CustomParameter>();

                sql = "THEMMOIKHACHHANG";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MAKH",
                    value = MAKH
                });
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
                    MessageBox.Show("thêm mới khách hàng thành công !");
                    txtDIACHI.Clear();
                    txtEMAIL.Clear();
                    txtSDT.Clear();
                    txtTENKH.Clear();
                    txtTHEMMAKH.Clear();
                     
                   // this.Dispose();// đóng form khi thêm mới hoặc cập nhật thành công
                }
                else
                {
                    MessageBox.Show("Số điện thoại không được nhập kí tự!. Mã khách hàng không được trùng nhau !!");
                    MessageBox.Show("Thực thi thất bại !");
                }
            }

        }

        private void btnKIEMTRA_Click(object sender, EventArgs e)
        {           
            
            string MAKH = txtTHEMMAKH.Text;
            string TENKH = txtTENKH.Text;
            string SDT = txtSDT.Text;
            string GIOITINH = rbNam.Checked ? "Nam" : rbNu.Checked ? "Nữ" : "Khác";// toán tử 2 ngôi
                                                                                   // nếu radiobutton man đc check thfi chọn giá trị 1
            string EMAIL = txtEMAIL.Text;
            string DIACHI = txtDIACHI.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@MAKH",
                value = MAKH
            });
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
            dgvKIEMRAKH.DataSource = new database().SelectData("SELECTALLKHACHHANGTRACUUDUNGKYTU", lstPara);
            int intRow = ((DataTable)dgvKIEMRAKH.DataSource).Rows.Count;
            if (intRow == 0)
            {
                MessageBox.Show("KHông có thông tin khách hàng này!");
            }
            else
            {
                MessageBox.Show("Có thông tin khách hàng này!");
                lbmakh.Visible = true;
                lbmakh.Text = txtTHEMMAKH.Text;
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnHUY_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTHANHTOAN_Click(object sender, EventArgs e)
        {
            string sql = "";
            int intRow = ((DataTable)dgvKIEMRAKH.DataSource).Rows.Count;
            
            if (intRow <= 0)
            {
                MessageBox.Show("Bạn chưa kiểm tra thông tin khách hàng!");
            }
            else
            {
                if (txtSOHD.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập số hóa đơn!");
                }
                else if (txtMANV.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã nhân viên!");
                }
                else
                {
                    string SOHD = txtSOHD.Text;
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
                    string THANHTIEN = textTHANHTIEN.Text;
                    string MATOUR = textMATOUR.Text;
                    string MAKH = lbmakh.Text;
                    string MANV = txtMANV.Text;
                    string TRANGTHAI = "";

                    List<CustomParameter> lstPara = new List<CustomParameter>();
                        sql = "THEMHOADON";
                        lstPara.Add(new CustomParameter()
                        {
                            key = "@SOHD",
                            value = SOHD
                        });

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
                    if (rs == 1)// nếu thực hiện thành công
                    {                       
                            MessageBox.Show("thêm mới Hoá đơn thành công !");
                            this.Dispose();// đóng form khi thêm mới hoặc cập nhật thành công
                    }
                    else
                    {
                        MessageBox.Show("Số thành tiền không được nhập kí tự!. Hoặc số hóa đơn không được trùng nhau !!" +
                            "kiểm tra mã khách hàng, tour, nhân viên có trong danh sách hay không!");

                        //MessageBox.Show("thực thi thất bại !");
                    }                                             // và danh sách các tham số
                }
            }
        }

        private void frmTHONGTINDATTOUR_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc muốn thoát! ", "Xác Nhận thoát !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
