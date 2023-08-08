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
    public partial class frmdattour : Form
    {
        public frmdattour()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void loadDSDATTOUR()
        {
            string sql = "SELECTALLDATTOUR";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDATTOUR.DataSource = new database().SelectData(sql, lstPara);
        }
        private string MALOAITOUR = "";
        private void loadLTOUR1()
        {
            string sql = "SELECTLOCLOAIDATTOUR";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@MALOAITOUR",
                value = MALOAITOUR
            });
            dgvDATTOUR.DataSource = new database().SelectData(sql, lstPara);
        }
        private void frmdattour_Load(object sender, EventArgs e)
        {
            cbbDIEMDI.Select();
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key ="@tukhoa",
                    value =""
                }
            };
            // load dữ liệu cho combo mã điểm đi , điểm đến, loại tour
            cbbDIEMDEN.DataSource = new database().SelectData("SELECTALLMADIEMDEN", lst);
            cbbDIEMDEN.DisplayMember = "TENDDEN";// thuộc tính hiển thị
            cbbDIEMDEN.ValueMember = "MADDEN";// giá trị (key) của combox
            cbbDIEMDEN.SelectedIndex = -1;
            cbbDIEMDI.DataSource = new database().SelectData("SELECTALLMADIEMDI", lst);
            cbbDIEMDI.DisplayMember = "TENDDI";// thuộc tính hiển thị
            cbbDIEMDI.ValueMember = "MADDI";// giá trị (key) của combox
            cbbDIEMDI.SelectedIndex = -1;
            loadDSDATTOUR();
        }

        private void btnTrongnuoc_Click(object sender, EventArgs e)
        {
            MALOAITOUR = "LT01";
            loadLTOUR1();
        }

        private void btnNgoaiNUOC_Click(object sender, EventArgs e)
        {
            MALOAITOUR = "LT02";
            loadLTOUR1();
        }

        private void bqtnRESET_Click(object sender, EventArgs e)
        {
            loadDSDATTOUR();
        }
        private string tukhoaMADDEN = "";
        private string tukhoaMADDI = "";
        private string tukhoaNGAYDI = "";
        private void loadDSTOURTRACUUDATTOUR()
        {
            
            if (cbbDIEMDI.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn điểm đi! ");
                return;
            }
            if (cbbDIEMDEN.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn điểm đến! ");
                return;
            }
            DateTime Mngaydi;
            DateTime Mngayketthuc;
            try
            {
                Mngaydi = DateTime.ParseExact(mtxtNGAYDI.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn ngày đi hợp lệ !");
                return;  // không thực hiện các lệnh phái dưới
            }
            try
            {
                Mngayketthuc = DateTime.ParseExact(mtxtNGAYKETTHUC.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn ngày kết thúc hợp lệ !");
                return;  // không thực hiện các lệnh phái dưới
            }
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@MADDEN",
                value = cbbDIEMDEN.SelectedValue.ToString()
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@MADDI",
                value = cbbDIEMDI.SelectedValue.ToString()
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@NGAYDI",
                value = Mngaydi.ToString("yyyy-MM-dd")
                //Mngaydi.ToString("yyyy-MM-dd")
            });
            
            lstPara.Add(new CustomParameter()
            {
                key = "@NGAYKETTHUC",
                value = Mngayketthuc.ToString("yyyy-MM-dd")
            });
            dgvDATTOUR.DataSource = new database().SelectData("SELECTALLTOURLOCDATTOUR", lstPara);
        }
        private void btnLOC_Click(object sender, EventArgs e)
        {
            
            loadDSTOURTRACUUDATTOUR();

        }

        private void mtxtNGAYDI_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvDATTOUR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDATTOUR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var matour = dgvDATTOUR.Rows[e.RowIndex].Cells["TENTOUR"].Value.ToString();
                var giatien = dgvDATTOUR.Rows[e.RowIndex].Cells["GIATOUR"].Value.ToString();
                var mota = dgvDATTOUR.Rows[e.RowIndex].Cells["MOTA"].Value.ToString();
                lbTRUYENVAOTEN.Visible = true;
                lbTRUYENVAOTIEN.Visible = true;
                lbMOTA.Visible = true;
                lbTRUYENVAOTEN.Text = matour;
                lbTRUYENVAOTIEN.Text = giatien + " VNĐ";
                lbMOTA.Text = mota;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbTRUYENVAOTIEN_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDATTOUR_Click(object sender, EventArgs e)
        {
            if (this.dgvDATTOUR.SelectedRows.Count > 0)
            {
                var mabuttontour = dgvDATTOUR.Rows[dgvDATTOUR.SelectedRows[0].Index].Cells["MATOUR"].Value.ToString();
                frmTHONGTINDATTOUR f = new frmTHONGTINDATTOUR(mabuttontour);
                f.ShowDialog();
            }
                
        }

        private void cbbDIEMDI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
