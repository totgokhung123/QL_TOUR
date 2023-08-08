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
    public partial class frmQLTOUR : Form
    {
        public frmQLTOUR()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void loadDSTOUR()
        {
            string sql = "SELECTALLTOUR";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvTOUR.DataSource = new database().SelectData(sql, lstPara);
        }

        private void frmQLTOUR_Load(object sender, EventArgs e)
        {
            txtmatour.Select();
            loadDSTOUR();
        }

        private string tukhoaMATOUR = "";
        private string tukhoaTENTOUR = "";
        private string tukhoaGIATOUR = "";
        private string tukhoaNGAYDI = "";
        private string tukhoaNGAYKETTHUC = "";
        private string tukhoaMOTA = "";
        private string tukhoaMALTOUR = "";
        private string tukhoaMADDI = "";
        private string tukhoaMADDEN = "";
        //private DateTime Mngaydi;
       // private DateTime Mngayketthuc;
        private void loadDSTOURTRACUU()
        {
            /*
            DateTime Mngaydi;
            DateTime Mngayketthuc;
            try
            {
                Mngaydi = DateTime.ParseExact(mtxtNGAYDI.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                // MessageBox.Show("Ngày sinh không hợp lệ !");
                //mtxtNGAYDI.Select();// trỏ chuột về mtxtNGAYSSINH
                return;  // không thực hiện các lệnh phái dưới
            }
            /*
            try
            {
                Mngayketthuc = DateTime.ParseExact(mtxtNGAYKETTHUC.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                //MessageBox.Show("Ngày sinh không hợp lệ !");
                // mtxtNGAYKETTHUC.Select();// trỏ chuột về mtxtNGAYSSINH
                return;  // không thực hiện các lệnh phái dưới
            }
            */
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@MATOUR",
                value = tukhoaMATOUR
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@TENTOUR",
                value = tukhoaTENTOUR
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@GIATOUR",
                value = tukhoaGIATOUR
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@NGAYDI",
                value = tukhoa
                //Mngaydi.ToString("yyyy-MM-dd")
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@NGAYKETTHUC",
                value = tukhoa
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@MOTA",
                value = tukhoaMOTA
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@MALOAITOUR",
                value = tukhoaMALTOUR
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@MADDI",
                value = tukhoaMADDI
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@MADDEN",
                value = tukhoaMADDEN
            });
            dgvTOUR.DataSource = new database().SelectData("SELECTALLTOURTRACUU", lstPara);
            if (txtmatour.TextLength > 4)
            {
                txtmatour.Clear();
            }
            else if (txttentour.TextLength > 100)
            {
                txttentour.Clear();
            }
            else if (txtGIATOUR.TextLength > 13)
            {
                txtGIATOUR.Clear();
            }
            else if(txtMADDEN.TextLength > 5)
            {
                txtMADDEN.Clear();
            }
            else if(txtMADDI.TextLength > 5)
            {
                txtMADDI.Clear();
            }
            else if(txtMLTOUR.TextLength > 4)
            {
                txtMLTOUR.Clear();
            }
        }



        private void loadtracuuNGAYDI()
        {
            DateTime testngaydi;
            try
            {
                testngaydi = DateTime.ParseExact(mtxtNGAYDI.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            }
            catch (Exception)
            {
                mtxtNGAYDI.Clear();// trỏ chuột về mtxtNGAYSSINH
                loadDSTOURTRACUU();
                return;  // không thực hiện các lệnh phái dưới
            }
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@NGAYDI",
                value = testngaydi.ToString("yyyy-MM-dd")
            });
            dgvTOUR.DataSource = new database().SelectData("SELECTALLDATENGAYDI", lstPara);
        }
        private void loadtracuuNGAYKETTHUC()
        {
            DateTime testngayketthuc;
            try
            {
                testngayketthuc = DateTime.ParseExact(mtxtNGAYKETTHUC.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            }
            catch (Exception)
            {
                mtxtNGAYKETTHUC.Clear();// trỏ chuột về mtxtNGAYSSINH
                return;  // không thực hiện các lệnh phái dưới
            }
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@NGAYKETTHUC",
                value = testngayketthuc.ToString("yyyy-MM-dd")
            });
            dgvTOUR.DataSource = new database().SelectData("SELECTALLDATENVNGAYKETTHUC", lstPara);
        }
        private void loadALLDATE()
        {
            DateTime testngaydi;
            DateTime testngayketthuc;
            try
            {
                testngaydi = DateTime.ParseExact(mtxtNGAYDI.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                testngayketthuc = DateTime.ParseExact(mtxtNGAYKETTHUC.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
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
                key = "@NGAYDI",
                value = testngaydi.ToString("yyyy-MM-dd")
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@NGAYKETTHUC",
                value = testngayketthuc.ToString("yyyy-MM-dd")
            });
            dgvTOUR.DataSource = new database().SelectData("SELECTALLDATENGAYDINGAYKETTHUC", lstPara);
        }

        private void btnTimTOUR_Click(object sender, EventArgs e)
        {
            tukhoaMATOUR = txtmatour.Text;
            tukhoaTENTOUR = txttentour.Text;
            tukhoaGIATOUR = txtGIATOUR.Text;        
            tukhoaMADDI = txtMADDI.Text;
            tukhoaMADDEN = txtMADDEN.Text;
            tukhoaMALTOUR = txtMLTOUR.Text;
            // loadDSTOURTRACUU();
            loadtracuuNGAYDI();
            loadtracuuNGAYKETTHUC();
            loadALLDATE();


        }

        private void dgvTOUR_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var matour = dgvTOUR.Rows[e.RowIndex].Cells["MATOUR"].Value.ToString();
                // MessageBox.Show("Mã nhân viên: " + dgvNV.Rows[e.RowIndex].Cells["MANV"].Value.ToString());
                // truyền mã nhân viên vào form nhân viên
                new frmTOUR(matour).ShowDialog();
                // sau khi form frmnv đc đóng lại cần load lại danh sách nhân viên
                loadDSTOUR();
            }
        }

        private void btnThemTOUR_Click(object sender, EventArgs e)
        {
            new frmTOUR(null).ShowDialog(); // nếu thêm mới tour -> mã tour = null
            loadDSTOUR();
        }
        private string MALOAITOUR = "";
        private void loadLTOUR1()
        {
            string sql = "SELECTLOCLOAITOUR";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@MALOAITOUR",
                value = MALOAITOUR
            });
            dgvTOUR.DataSource = new database().SelectData(sql, lstPara);
        }
        private void btnLT01_Click(object sender, EventArgs e)
        {
            MALOAITOUR = "LT01";
            loadLTOUR1();
        }

        private void btnLT02_Click(object sender, EventArgs e)
        {
            MALOAITOUR = "LT02";
            loadLTOUR1();
        }
        private void dgvTOUR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnmoi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa TOUR: " + dgvTOUR.Rows[dgvTOUR.SelectedRows[0].Index].Cells["TENTOUR"].Value.ToString()+ " ?", "Xác Nhận Xóa !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                    if (this.dgvTOUR.SelectedRows.Count > 0)
                {
                    var matour = dgvTOUR.Rows[dgvTOUR.SelectedRows[0].Index].Cells["MATOUR"].Value.ToString();
                    var sql = "DELETETOUR";
                    var lstPara = new List<CustomParameter>()
                        {
                            new CustomParameter
                            {
                                key = "@MATOUR",
                                value = matour
                            }
                        };
                    new database().ExeCute(sql, lstPara);
                    MessageBox.Show("Xóa khách hàng thành công");
                    loadDSTOUR();
                    //dgvTOUR.Rows.RemoveAt(this.dgvTOUR.SelectedRows[0].Index);
                }                                 
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            loadDSTOUR();
        }

        private void cbTRACUUDATE_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbTRACUUDATE_Click(object sender, EventArgs e)
        {
            if (cbTRACUUDATE.Checked == false)
            {
                mtxtNGAYDI.Visible = false;
                mtxtNGAYKETTHUC.Visible = false;
                lbNGAYDI.Visible = false;
                lbNGAYKETTHUC.Visible = false;
                ///// mở khóa chức nawgn tim khong theo ngay thang
                lbmatour.Enabled = true;
                lbmaltour.Enabled = true;
                lbtentour.Enabled = true;
                lbgiatour.Enabled = true;
                lbmaddi.Enabled = true;
                lbmadden.Enabled = true;
                btnLT01.Enabled = true;
                btnLT02.Enabled = true;
                txtmatour.Enabled = true;
                txttentour.Enabled = true;
                txtMADDI.Enabled = true;
                txtMADDEN.Enabled = true;
                txtGIATOUR.Enabled = true;
                txtMLTOUR.Enabled = true;
            }
            else
            {
                mtxtNGAYDI.Clear();
                mtxtNGAYKETTHUC.Clear();
                mtxtNGAYDI.Visible = true;
                mtxtNGAYKETTHUC.Visible = true;
                lbNGAYDI.Visible = true;
                lbNGAYKETTHUC.Visible = true;
                // khoachuc nang tim khong theo ngay thang
                lbmatour.Enabled = false;
                lbmaltour.Enabled = false;
                lbtentour.Enabled = false;
                lbgiatour.Enabled = false;
                lbmaddi.Enabled = false;
                lbmadden.Enabled = false;
                btnLT01.Enabled = false;
                btnLT02.Enabled = false;
                txtmatour.Enabled = false;
                txttentour.Enabled = false;
                txtMADDI.Enabled = false;
                txtMADDEN.Enabled = false;
                txtGIATOUR.Enabled = false;
                txtMLTOUR.Enabled = false;
                //  isChecked = false;
            }
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
