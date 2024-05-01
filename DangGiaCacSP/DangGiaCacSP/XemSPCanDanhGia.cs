using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangGiaCacSP
{
    public partial class XemSPCanDanhGia : Form
    {
        private String TenDN = "abc1234";
        private int MaKH;
        public XemSPCanDanhGia()
        {
            InitializeComponent();
        }

        private void XemSPCanDanhGia_Load(object sender, EventArgs e)
        {
            using (var context = new QLBanHangEntities())
            {
                var KH = context.KhachHangs.Where(p => p.TenDangNhap == TenDN).FirstOrDefault();
                MaKH = KH.MaKH;
                var SP = context.SanPhams.ToList();
                if (SP != null)
                {
                    GVSanPham.DataSource = SP;
                    GVSanPham.Columns["ChiTietDonHangs"].Visible = false;
                    GVSanPham.Columns["DanhGias"].Visible = false;
                    GVSanPham.Columns["HangGiay"].Visible = false;
                    GVSanPham.Columns["KhuyenMais"].Visible = false;
                }

            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btDanhGia_Click(object sender, EventArgs e)
        {
                DataGridViewRow row = GVSanPham.SelectedRows[0];
                int MaSP = Convert.ToInt16(row.Cells[0].Value.ToString());
                XemVaDanhGia DG = new XemVaDanhGia(MaSP,MaKH);
                this.Hide();
                DG.Show();
        }

        private void XemSPCanDanhGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
