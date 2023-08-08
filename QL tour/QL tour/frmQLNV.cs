using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_tour
{
    public partial class frmQLNV : Form
    {
        public frmQLNV()
        {
            InitializeComponent();
        }

        private void frmQLNV_Load(object sender, EventArgs e)
        {
            txtmanv.Select();
            LoadDSNV();
        }
        private string tukhoa = "";
        // ĐEMO TEWST
        private string tukhoaMANV = "";
        private string tukhoaTENNV = "";
        private string tukhoaNGAYSINH = "";
       // private DateTime tukhoaNGAYSINH ;
        private string tukhoaGIOITINH = "";
        private string tukhoaSDT = "";
        private string tukhoaCCCD = "";
        private string tukhoaNGAYVL = "";
        private void LoadDSNV()
        {
            // load toàn bộ danh sách khi form được load
            // khai váo list
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvNV.DataSource = new database().SelectData("SELECTALLNHANVIEN",lstPara);
            dgvNV.Columns["MANV"].HeaderText = "Mã NV";
            dgvNV.Columns["TENNV"].HeaderText = "Tên NV";
            dgvNV.Columns["NGAYSINH"].HeaderText = "Ngày Sinh";
            dgvNV.Columns["GIOITINH"].HeaderText = "Giới tính";
            dgvNV.Columns["SDT"].HeaderText = "SĐT";
            dgvNV.Columns["CCCD"].HeaderText = "CMND/CCCD";
            dgvNV.Columns["NGAYVL"].HeaderText = "Ngày vào làm";
        }
       // private string testngaysinh = "";
        private void loaddatenvNGAYSINH()
        {
            DateTime testngaysinh;
           // DateTime testngayvl;
            try
            {
                testngaysinh = DateTime.ParseExact(mtxtNGAYSINH.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);          
                
            }
            catch (Exception)
            {
                mtxtNGAYSINH.Clear();// trỏ chuột về mtxtNGAYSSINH
                loadDSNVTRACUU();
                return;  // không thực hiện các lệnh phái dưới
            }
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@NGAYSINH",
                value = testngaysinh.ToString("yyyy-MM-dd")
            });
            dgvNV.DataSource = new database().SelectData("SELECTALLDATENV", lstPara);
        }
        private void loaddatenvNGAYVL()
        {
            DateTime testngayvl;
            try
            {

                testngayvl = DateTime.ParseExact(mtxtNGAYVL.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                
            }
            catch (Exception)
            {
                mtxtNGAYVL.Clear();// trỏ chuột về mtxtNGAYSSINH
               // loadDSNVTRACUU();
                return;  // không thực hiện các lệnh phái dưới
            }
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@NGAYVL",
                value = testngayvl.ToString("yyyy-MM-dd")
            });
            dgvNV.DataSource = new database().SelectData("SELECTALLDATENVNGAYVL", lstPara);
        }
        private void loadALLDATE()
        {
            DateTime testngayvl;
             DateTime testngaysinh;
            try
            {
                testngaysinh = DateTime.ParseExact(mtxtNGAYSINH.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                testngayvl = DateTime.ParseExact(mtxtNGAYVL.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);               
            }
            catch (Exception)
            {
                //mtxtNGAYVL.Clear();// trỏ chuột về mtxtNGAYSSINH
                //loadDSNVTRACUU();
                return;  // không thực hiện các lệnh phái dưới
            }
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@NGAYSINH",
                value = testngaysinh.ToString("yyyy-MM-dd")
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@NGAYVL",
                value = testngayvl.ToString("yyyy-MM-dd")
            });
            dgvNV.DataSource = new database().SelectData("SELECTALLDATENGAYSINHNGAYVL", lstPara);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvNV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // double click vào form nhân viên trên dgv
            // hiện ra form cập nhật thông tin nhân viên
            // để cập nhật 
            
            if(e.RowIndex>=0)
            {
                var mnv = dgvNV.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
                // MessageBox.Show("Mã nhân viên: " + dgvNV.Rows[e.RowIndex].Cells["MANV"].Value.ToString());
                // truyền mã nhân viên vào form nhân viên
                new frmNV(mnv).ShowDialog();
                // sau khi form frmnv đc đóng lại cần load lại danh sách nhân viên
                LoadDSNV();
            }
        }
       // public frmNV nv;
        private void button2_Click(object sender, EventArgs e)
        {
            new frmNV(null).ShowDialog(); // nếu thêm mới sinh viên -> mã sinh viên = null
            LoadDSNV();
        }

        private void loadDSNVTRACUU()
        {
            string GIOITINH = rbNAM.Checked ? "Nam" : rbNU.Checked ? "Nữ" : rbKHAC.Checked ? "Khác" : "";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa1",
                value = tukhoaMANV
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa2",
                value = tukhoaTENNV
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa3",
                value = tukhoa
                //dtpngaysinh.Value.ToString("yyyy-MM-dd")
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa4",
                value = GIOITINH
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa5",
                value = tukhoaSDT
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa6",
                value = tukhoaCCCD
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa7",
                value = tukhoa
            });
            dgvNV.DataSource = new database().SelectData("SELECTALLNHANHVIENTRACUU", lstPara);
            dgvNV.Columns["MANV"].HeaderText = "Mã NV";
            dgvNV.Columns["TENNV"].HeaderText = "Tên NV";
            dgvNV.Columns["NGAYSINH"].HeaderText = "Ngày Sinh";
            dgvNV.Columns["GIOITINH"].HeaderText = "Giới tính";
            dgvNV.Columns["SDT"].HeaderText = "SĐT";
            dgvNV.Columns["CCCD"].HeaderText = "CMND/CCCD";
            dgvNV.Columns["NGAYVL"].HeaderText = "Ngày vào làm";
            if (txtmanv.TextLength > 4)
            {
                txtmanv.Clear();
            }
            if (txttennv.TextLength > 32)
            {
                txttennv.Clear();
            }
            if (txtSDT.TextLength > 13)
            {
                txtSDT.Clear();
            }
            if (txtCCCD.TextLength > 13)
            {
                txtCCCD.Clear();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            tukhoaMANV = txtmanv.Text;
            tukhoaTENNV = txttennv.Text;
            
            //tukhoaNGAYSINH = txtNGAYSINH.Text;
            tukhoaGIOITINH = txtSDT.Text;
            tukhoaSDT = txtSDT.Text;
            tukhoaCCCD = txtCCCD.Text;
            tukhoaNGAYVL = mtxtNGAYVL.Text;
          //   loadDSNVTRACUU();

                loaddatenvNGAYSINH();

                loaddatenvNGAYVL();
                loadALLDATE();

           // loaddatenvNGAYSINH();
          //  loaddatenvNGAYVL();
           // loadALLDATE();



        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa Nhân viên: " + dgvNV.Rows[dgvNV.SelectedRows[0].Index].Cells["TENNV"].Value.ToString() + " ?", "Xác Nhận Xóa !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.dgvNV.SelectedRows.Count > 0)
                {
                    var manv = dgvNV.Rows[dgvNV.SelectedRows[0].Index].Cells["MANV"].Value.ToString();
                    var sql = "DELETE1NV";
                    var lstPara = new List<CustomParameter>()
                        {
                            new CustomParameter
                            {
                                key = "@MANV",
                                value = manv
                            }
                        };
                    new database().ExeCute(sql, lstPara);
                    MessageBox.Show("Xóa khách hàng thành công");
                    LoadDSNV();
                    
                }

            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttennv_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            LoadDSNV();
        }



       // tạo unchecked cho radio button

        bool isChecked = false;
        private void rbNAM_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rbNAM.Checked;
        }

        private void rbNAM_Click(object sender, EventArgs e)
        {

            if (rbNAM.Checked && !isChecked)
                rbNAM.Checked = false;
            else
            {
                rbNAM.Checked = true;
                isChecked = false;
            }
        }

        private void rbNU_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rbNU.Checked;
        }

        private void rbNU_Click(object sender, EventArgs e)
        {
            if (rbNU.Checked && !isChecked)
                rbNU.Checked = false;
            else
            {
                rbNU.Checked = true;
                isChecked = false;
            }
        }

        private void rbKHAC_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rbKHAC.Checked;
        }

        private void rbKHAC_Click(object sender, EventArgs e)
        {
            if (rbKHAC.Checked && !isChecked)
                rbKHAC.Checked = false;
            else
            {
                rbKHAC.Checked = true;
                isChecked = false;
            }
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            Close();
        }


private void cbTRACUUDATE_CheckedChanged(object sender, EventArgs e)
        {
            //isChecked = cbTRACUUDATE.Checked;
        }

        private void cbTRACUUDATE_Click(object sender, EventArgs e)
        {
            if (cbTRACUUDATE.Checked == false)
            {
                mtxtNGAYSINH.Visible = false;
                mtxtNGAYVL.Visible = false;
                lbngaysinh.Visible = false;
                lbngayvl.Visible = false;
                ///// mở khóa chức nawgn tim khong theo ngay thang
                lbmanv.Enabled = true;
                lbtennv.Enabled = true;
                lbsdt.Enabled = true;
                lbgioitinh.Enabled = true;
                lbcccd.Enabled = true;
                txtmanv.Enabled = true;
                txttennv.Enabled = true;
                txtCCCD.Enabled = true;
                txtSDT.Enabled = true;
                rbNU.Enabled = true;
                rbNAM.Enabled = true;
                rbKHAC.Enabled = true;
            }
            else
            {
                mtxtNGAYSINH.Clear();
                mtxtNGAYVL.Clear();
                lbngaysinh.Visible = true;
                lbngayvl.Visible = true;
                mtxtNGAYSINH.Visible = true;
                mtxtNGAYVL.Visible = true;
                // khoachuc nang tim khong theo ngay thang
                lbmanv.Enabled = false;
                lbtennv.Enabled = false;
                lbsdt.Enabled = false;
                lbgioitinh.Enabled = false;
                lbcccd.Enabled = false;
                txtmanv.Enabled = false;
                txttennv.Enabled = false;
                txtCCCD.Enabled = false;
                txtSDT.Enabled = false;
                rbNU.Enabled = false;
                rbNAM.Enabled = false;
                rbKHAC.Enabled = false;


                //  isChecked = false;
            }
            
        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //  SqlConnection connection;
        //  SqlCommand command;             
    }
}
