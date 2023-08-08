using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words;
using Aspose.Words.Tables;
using ThuVienWinform.Report.AsposeWordExtension;
namespace QL_tour
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private string taikhoan;
        private string loaitk;
        private void frmMain_Load(object sender, EventArgs e)
        {
            /*
            var u = new frmUSER();
            u.ShowDialog();
            /// sau khi form dang nhap dc tat, lay tai khoan da dang nhap
            /// 
            taikhoan = u.tendangnhap;
            loaitk = u.loaitk;
            if(loaitk.Equals("admin"))
            {
                // nếu là admin 
                DangkytourToolStripMenuItem.Enabled = false;
            }
            else if(loaitk.Equals("nhanvien"))
            {
                // nhân viên ko được sửa thông tin QL nhân viên
                QLNVToolStripMenuItem.Enabled = false;
            }
            else
            {
                // khách hàng chỉ được đăng ký tour
                QUANLYToolStripMenuItem.Enabled = false;
            }

            */


           // var db = new database();
          //  dgv1.DataSource = db.SelectData(null);
        }

        private void OPENFORM(Form f)
        {
            this.panel1.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            f.Show();

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (MessageBox.Show("Bạn có chắc muốn thoát! " , "Xác Nhận thoát !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QLNVToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmQLNV f = new frmQLNV();
            OPENFORM(f);
            this.Size = new Size(816, 489);
        }

        private void QLKHToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmQLKH f = new FrmQLKH();
            OPENFORM(f);
            this.Size = new Size(816, 489);
        }

        private void QLTOURToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmQLTOUR f = new frmQLTOUR();
            OPENFORM(f);
            this.Size = new Size(884, 499);
        }

        private void THOATToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Hide();
            // frmMain_Load(sender,e);
            // Show();
            Close();
        }

        private void QLHOADONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHOADON f = new frmHOADON();
            OPENFORM(f);
            this.Size = new Size(831, 495);
        }

        private void DangkytourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdattour f = new frmdattour();
            OPENFORM(f);
            this.Size = new Size(1018, 503);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void thoatmenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DOIMKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDOIMATKHAU f = new frmDOIMATKHAU();
            f.ShowDialog();
        }

        private void TROGIUPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HUONGDANToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                thoatmenu_Click(sender, e);
            }
        }
    }
}
