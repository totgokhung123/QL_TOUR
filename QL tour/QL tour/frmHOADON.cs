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
    public partial class frmHOADON : Form
    {
        public frmHOADON()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void loadhoadon()
        {
            string sql = "SELECTALLHOADON";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvHOADON.DataSource = new database().SelectData(sql, lstPara);
        }

        private void frmHOADON_Load(object sender, EventArgs e)
        {
            txtSOHD.Select();
            loadhoadon();
        }
        private string sohd = "";
        private string thanhtien = "";
        private string ngaylap = "";
        // private DateTime tukhoaNGAYSINH ;
        private string matour = "";
        private string makh = "";
        private string manv = "";
        private void loadHOADONTRACUU()
        {

            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@SOHD",
                value = sohd
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@THANHTIEN",
                value = thanhtien
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@NGAYLAP",
                value = tukhoa
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@MATOUR",
                value = matour
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@MAKH",
                value = makh
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@MANV",
                value = manv
            });
            dgvHOADON.DataSource = new database().SelectData("SELECTALLHOADONTRACUU", lstPara);
            if (txtSOHD.TextLength > 4)
            {
                txtSOHD.Clear();
            }
            if (txtMATOUR.TextLength > 5)
            {
                txtMATOUR.Clear();
            }
            if (txtMAKH.TextLength > 4)
            {
                txtMAKH.Clear();
            }
            if (txtMANV.TextLength > 4)
            {
                txtMANV.Clear();
            }
            if (txtTHANHTIEN.TextLength > 12)
            {
                txtTHANHTIEN.Clear();
            }
        }
        private void loadngaylaphoadon()
        {
            DateTime ngaylap;
            try
            {
                 ngaylap = DateTime.ParseExact(mtxtNGAYLAP.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            }
            catch (Exception)
            {
                mtxtNGAYLAP.Clear();// trỏ chuột về mtxtNGAYSSINH
                loadHOADONTRACUU();
                return;  // không thực hiện các lệnh phái dưới
            }
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@NGAYLAP",
                value = ngaylap.ToString("yyyy-MM-dd")
            });
            dgvHOADON.DataSource = new database().SelectData("SELECTALLNGAYLAPHOADON", lstPara);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            sohd = txtSOHD.Text;
            thanhtien = txtTHANHTIEN.Text;
            matour = txtMATOUR.Text;
            makh = txtMAKH.Text;
            manv = txtMANV.Text;

            //loadHOADONTRACUU();
            loadngaylaphoadon();
           // tukhoa = txtTIMKIEM.Text;
           //  loadhoadon();
        }

        private void txtTIMKIEM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            new frmcapnhatHOADON(null).ShowDialog(); // nếu thêm mới tour -> mã tour = null
            loadhoadon();
        }

        private void dgvHOADON_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var sohd = dgvHOADON.Rows[e.RowIndex].Cells["SOHD"].Value.ToString();
                // MessageBox.Show("Mã nhân viên: " + dgvNV.Rows[e.RowIndex].Cells["MANV"].Value.ToString());
                // truyền mã nhân viên vào form nhân viên
                new frmcapnhatHOADON(sohd).ShowDialog();
                // sau khi form frmnv đc đóng lại cần load lại danh sách nhân viên
                loadhoadon();
            }
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa hóa đơn: " + dgvHOADON.Rows[dgvHOADON.SelectedRows[0].Index].Cells["SOHD"].Value.ToString() + " ?", "Xác Nhận Xóa !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.dgvHOADON.SelectedRows.Count > 0)
                {
                    var sohd = dgvHOADON.Rows[dgvHOADON.SelectedRows[0].Index].Cells["SOHD"].Value.ToString();
                    var sql = "DELETEHOADON";
                    var lstPara = new List<CustomParameter>()
                        {
                            new CustomParameter
                            {
                                key = "@SOHD",
                                value = sohd
                            }
                        };
                    new database().ExeCute(sql, lstPara);
                    MessageBox.Show("Xóa khách hàng thành công");
                    loadhoadon();
                    //dgvTOUR.Rows.RemoveAt(this.dgvTOUR.SelectedRows[0].Index);
                }
            }
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            loadhoadon();
        }

        private void cbTRACUUDATE_Click(object sender, EventArgs e)
        {
            if (cbTRACUUDATE.Checked == false)
            {
                mtxtNGAYLAP.Visible = false;
                lbngaylap.Visible = false;
                ///// mở khóa chức nawgn tim khong theo ngay thang
                lbmakhachhang.Enabled = true;
                lbmanv.Enabled = true;
                lbmatour.Enabled = true;
                lbsohd.Enabled = true;
                lbthanhtien.Enabled = true;
                txtMAKH.Enabled = true;
                txtMANV.Enabled = true;
                txtMATOUR.Enabled = true;
                txtSOHD.Enabled = true;
                txtTHANHTIEN.Enabled = true;

            }
            else
            {
                mtxtNGAYLAP.Clear();
                mtxtNGAYLAP.Visible = true;
                lbngaylap.Visible = true;
                // khoachuc nang tim khong theo ngay thang
                lbmakhachhang.Enabled = false;
                lbmanv.Enabled = false;
                lbmatour.Enabled = false;
                lbsohd.Enabled = false;
                lbthanhtien.Enabled = false;
                txtMAKH.Enabled = false;
                txtMANV.Enabled = false;
                txtMATOUR.Enabled = false;
                txtSOHD.Enabled = false;
                txtTHANHTIEN.Enabled = false;
                //  isChecked = false;
            }
        }
    }
}
