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
    public partial class FrmQLKH : Form
    {
        public FrmQLKH()
        {
            InitializeComponent();
        }



        private string tukhoaMAKH = "";
        private string tukhoaTENKH = "";
        private string tukhoaSDT = "";
        private string TUKHOAEMAIL = "";
        private string TUKHOADIACHI = "";
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void loadDSKHTRACUU()
        {
            string GIOITINH = rbNAM.Checked ? "Nam" : rbNU.Checked ? "Nữ" : rbKHAC.Checked ? "Khác" : "";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@MAKH",
                value = tukhoaMAKH
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@TENKH",
                value = tukhoaTENKH
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@SDT",
                value = tukhoaSDT
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@GIOITINH",
                value = GIOITINH
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@EMAIL",
                value = TUKHOAEMAIL
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@DIACHI",
                value = TUKHOADIACHI
            });
            dgvKH.DataSource = new database().SelectData("SELECTALLKHACHHANGTRACUU", lstPara);
            if(txtMAKH.TextLength > 4)
            {
                txtMAKH.Clear();
            }
            if (txtTENKH.TextLength > 32)
            {
                txtMAKH.Clear();
            }
            if (txtSDT.TextLength > 13)
            {
                txtMAKH.Clear();
            }
            if (txtEMAIL.TextLength > 30)
            {
                txtMAKH.Clear();
            }
            if (txtDIACHI.TextLength > 50)
            {
                txtMAKH.Clear();
            }
        }
        private void btnTimKH_Click(object sender, EventArgs e)
        {
            tukhoaMAKH = txtMAKH.Text;
            tukhoaTENKH = txtTENKH.Text;
            tukhoaSDT = txtSDT.Text;
            TUKHOAEMAIL = txtEMAIL.Text;
            TUKHOADIACHI = txtDIACHI.Text;
            loadDSKHTRACUU();
            
            // tukhoa = txtTimKH.Text;
            //  loadDSKH();
        }
        private string tukhoa = "";
        private void loadDSKH()
        {
            string sql = "SELECTALLKHACHHANG";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvKH.DataSource = new database().SelectData(sql, lstPara);
        }

        private void FrmQLKH_Load(object sender, EventArgs e)
        {
            txtMAKH.Select();
            loadDSKH();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            new frmKH(null).ShowDialog();
            loadDSKH();
        }

        private void dgvKH_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var mkh = dgvKH.Rows[e.RowIndex].Cells["MAKH"].Value.ToString();
                // MessageBox.Show("Mã nhân viên: " + dgvNV.Rows[e.RowIndex].Cells["MANV"].Value.ToString());
                // truyền mã nhân viên vào form nhân viên
                new frmKH(mkh).ShowDialog();
                // sau khi form frmnv đc đóng lại cần load lại danh sách nhân viên
                loadDSKH();
            }
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa Khách hàng: " + dgvKH.Rows[dgvKH.SelectedRows[0].Index].Cells["TENKH"].Value.ToString() + " ?", "Xác Nhận Xóa !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.dgvKH.SelectedRows.Count > 0)
                {
                    var makh = dgvKH.Rows[dgvKH.SelectedRows[0].Index].Cells["MAKH"].Value.ToString();
                    var sql = "DELETEKH";
                    var lstPara = new List<CustomParameter>()
                        {
                            new CustomParameter
                            {
                                key = "@MAKH",
                                value = makh
                            }
                        };
                    new database().ExeCute(sql, lstPara);
                    MessageBox.Show("Xóa khách hàng thành công");
                    loadDSKH();
                }
            }
        }
        bool ischecked = false;
        private void rbNAM_CheckedChanged(object sender, EventArgs e)
        {
            ischecked = rbNAM.Checked;
        }

        private void rbNAM_Click(object sender, EventArgs e)
        {
            if (rbNAM.Checked && !ischecked)
                rbNAM.Checked = false;
            else
            {
                rbNAM.Checked = true;
                ischecked = false;
            }
        }

        private void rbNU_CheckedChanged(object sender, EventArgs e)
        {
            ischecked = rbNU.Checked;
        }

        private void rbNU_Click(object sender, EventArgs e)
        {
            if (rbNU.Checked && !ischecked)
                rbNU.Checked = false;
            else
            {
                rbNU.Checked = true;
                ischecked = false;
            }
        }

        private void rbKHAC_CheckedChanged(object sender, EventArgs e)
        {
            ischecked = rbKHAC.Checked;
        }

        private void rbKHAC_Click(object sender, EventArgs e)
        {
            if (rbKHAC.Checked && !ischecked)
                rbKHAC.Checked = false;
            else
            {
                rbKHAC.Checked = true;
                ischecked = false;
            }
        }

        private void btnRESET_Click(object sender, EventArgs e)
        {
            loadDSKH();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
