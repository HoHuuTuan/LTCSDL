using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonMua
{
    public partial class DonHangDaMua : Form
    {
        public DonHangDaMua()
        {
            InitializeComponent();
        }

        private void DonHangDaMua_Load(object sender, EventArgs e)
        {
            using (var context = new QLBanHangEntities())
            {
                var KH = context.KhachHangs.Where(p => p.TenDangNhap.Contains("abc1234")).FirstOrDefault();
                var DH = context.DonHangs.Where(a => a.MaKH == KH.MaKH).FirstOrDefault();
                if (DH != null)
                {
                    var result = context.DonHangs.ToList();
                    GVDonHang.DataSource = result;
                    GVDonHang.Columns["ChiTietDonHangs"].Visible = false;
                    GVDonHang.Columns["KhachHang"].Visible = false;

                }
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void DonHangDaMua_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void btChiTietDH_Click(object sender, EventArgs e)
        {
            using (var context = new QLBanHangEntities())
            {
                DataGridViewRow row = GVDonHang.SelectedRows[0];
                int MaDH = Convert.ToInt16(row.Cells[0].Value.ToString());
                var DH = context.DonHangs.Find(MaDH);
                CTDH ctdh = new CTDH(DH.MaDonHang);
                this.Hide();
                ctdh.Show();
            }
        }
    }
}
