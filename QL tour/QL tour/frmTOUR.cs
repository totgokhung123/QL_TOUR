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
    public partial class frmTOUR : Form
    {
        public frmTOUR(string mtour)
            
        {
            this.mtour = mtour;
            InitializeComponent();
        }
        private string mtour;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTOUR_Load(object sender, EventArgs e)
        {
            txtMATOUR.Select();
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key ="@tukhoa",
                    value =""
                }
            };
            // load dữ liệu cho combo mã điểm đi , điểm đến, loại tour
            cbbMALTOUR.DataSource = new database().SelectData("SELECTALLMALOAITOUR", lst);
            cbbMALTOUR.DisplayMember = "TENLOAITOUR";// thuộc tính hiển thị
            cbbMALTOUR.ValueMember = "MALOAITOUR";// giá trị (key) của combox
            cbbMALTOUR.SelectedIndex = -1;
            cbbMADDEN.DataSource = new database().SelectData("SELECTALLMADIEMDEN", lst);
            cbbMADDEN.DisplayMember = "TENDDEN";// thuộc tính hiển thị
            cbbMADDEN.ValueMember = "MADDEN";// giá trị (key) của combox
            cbbMADDEN.SelectedIndex = -1;
            cbbMADDI.DataSource = new database().SelectData("SELECTALLMADIEMDI", lst);
            cbbMADDI.DisplayMember = "TENDDI";// thuộc tính hiển thị
            cbbMADDI.ValueMember = "MADDI";// giá trị (key) của combox
            cbbMADDI.SelectedIndex = -1;
            if (string.IsNullOrEmpty(mtour))
            {
                this.Text = "Thêm mới Tour";
            }
            else
            {
                this.Text = "Cập nhật thông tin Tour" + mtour;
                var r = new database().Select("SELECT1TOUR '" + mtour + "'");
                // MessageBox.Show("Mã nhân viên nhận được: " + mnv);
                //MessageBox.Show(r[0].ToString());
                //set các giá trị vào component của form

    
                txtMATOUR.Text = r["MATOUR"].ToString();
                txtTENTOUR.Text = r["TENTOUR"].ToString();
                txtGIATOUR.Text = r["GIATOUR"].ToString();             
                mtxtNGAYDI.Text = r["NGAYDI"].ToString();
                mtxtNGAYKETTHUC.Text = r["NGAYKETTHUC"].ToString();
                rtxtMOTA.Text = r["MOTA"].ToString();
                cbbMALTOUR.SelectedValue = r["MALOAITOUR"].ToString();
                cbbMADDEN.SelectedValue = r["MADDEN"].ToString();
                cbbMADDI.SelectedValue = r["MADDI"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // ràng buộ phải chọn mã điểm đến, đi ,mã loại mới lưu được
            if(cbbMALTOUR.SelectedIndex <0 )
            {
                MessageBox.Show("Vui lòng chọn mã loại tour! ");
                    return;
            }
            if (cbbMADDEN.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn mã điểm đến! ");
                return;
            }
            if (cbbMADDI.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn mã điểm đi! ");
                return;
            }
            if (txtMATOUR.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã tour!");
            }
            else if (txtTENTOUR.Text == "")
            {
                MessageBox.Show("Bạn chưa nhậ tên tour!");
            }
            else if (txtGIATOUR.Text == "0" || txtGIATOUR.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá tour !");
            }
            else if (rtxtMOTA.Text == "0" || rtxtMOTA.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mô tả tour!");
            }
            else
            {
                string sql = "";
                string MATOUR = txtMATOUR.Text;
                string TENTOUR = txtTENTOUR.Text;
                string GIATOUR = txtGIATOUR.Text;
                DateTime NGAYDI;
                try
                {
                    NGAYDI = DateTime.ParseExact(mtxtNGAYDI.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ngày đi không hợp lệ !");
                    mtxtNGAYDI.Select();// trỏ chuột về mtxtNGAYDI
                    return;// không thực hiện các lệnh phái dưới
                }
                DateTime NGAYKETTHUC;
                try
                {
                    NGAYKETTHUC = DateTime.ParseExact(mtxtNGAYKETTHUC.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ngày vào làm không hợp lệ !");
                    mtxtNGAYKETTHUC.Select();// trỏ chuột về mtxtNGAYSSINH
                    return;// không thực hiện các lệnh phái dưới
                }
                string MOTA = rtxtMOTA.Text;
                /*
                string MALOAITOUR = cbbMALTOUR.Text;
                string MADDEN = cbbMADDEN.Text;
                string MADDI = cbbMADDI.Text;
                */

                // khai báo một danh sách tham số = class Customparameter
                List<CustomParameter> lstPara = new List<CustomParameter>();
                if (string.IsNullOrEmpty(mtour))// nếu thêm mới tour
                {
                    sql = "THEMMOITOUR";
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@MATOUR",
                        value = MATOUR
                    });
                }
                else // nếu cập nhật sinh viên
                {
                    sql = "UPDATETOUR";
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@MATOUR",
                        value = mtour
                    });
                }

                lstPara.Add(new CustomParameter()
                {
                    key = "@TENTOUR",
                    value = TENTOUR
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@GIATOUR",
                    value = GIATOUR
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@NGAYDI",
                    value = NGAYDI.ToString("yyyy-MM-dd")
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@NGAYKETTHUC",
                    value = NGAYKETTHUC.ToString("yyyy-MM-dd")
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@MOTA",
                    value = MOTA
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@MALOAITOUR",
                    value = cbbMALTOUR.SelectedValue.ToString()
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@MADDEN",
                    value = cbbMADDEN.SelectedValue.ToString()
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@MADDI",
                    value = cbbMADDI.SelectedValue.ToString()
                });
                var rs = new database().ExeCute(sql, lstPara);// truyền 2 tham số là câu lệnh sql
                                                              // và danh sách các tham số
                if (rs == 1)// nếu thực hiện thành công
                {
                    if (string.IsNullOrEmpty(mtour))// nếu thêm mới
                    {
                        MessageBox.Show("thêm mới TOUR thành công !");

                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin TOUR thành công !");
                    }
                    this.Dispose();// đóng form khi thêm mới hoặc cập nhật thành công
                }
                else
                {
                    MessageBox.Show("Bạn thử kiểm tra xem mã tour không được trùng nhau ! hoặc giá tour không được nhập ký tự !!");
                  //  MessageBox.Show("thực thi thất bại !");
                }
            }
            
        }

        private void cbbMADDEN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát! ", "Xác Nhận thoát !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
            
            
        }

        private void cbbMALTOUR_SelectedIndexChanged(object sender, EventArgs e)
        {          
        }

        private void frmTOUR_TextChanged(object sender, EventArgs e)
        {
            if (txtMATOUR.Text == "" && txtTENTOUR.Text == "" && txtGIATOUR.Text == "" && rtxtMOTA.Text == "" && cbbMADDEN.SelectedIndex <0 && cbbMALTOUR.SelectedIndex < 0 && cbbMADDI.SelectedIndex <0)
            {
                if (mtxtNGAYDI.Text == "" && mtxtNGAYKETTHUC.Text == "")
                {
                    btnLuu.Enabled = false;
                }
                else
                {
                    btnLuu.Enabled = false;
                }
            }
            else
            {
                if (mtxtNGAYDI.Text == "" && mtxtNGAYKETTHUC.Text == "")
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
}
