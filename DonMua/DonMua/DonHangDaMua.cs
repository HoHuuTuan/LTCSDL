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
                var result = (from DonHang in context.DonHangs.Where(a => a.MaKH == KH.MaKH)
                              join KhachHang in context.KhachHangs on DonHang.MaKH equals KhachHang.MaKH
                              select new
                              {
                                  MaDH = DonHang.MaDonHang,
                                  TenKH = KhachHang.Ho + " " + KhachHang.Ten,
                                  TongTien = DonHang.TongTien,
                                  NgayTao = DonHang.NgayTao,
                                  TrangThai = DonHang.TrangThai
                              }).ToList();
                GVDonHang.DataSource = result;
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
                int MaDH = Convert.ToInt32(row.Cells[0].Value.ToString());
                var DH = context.DonHangs.Find(MaDH);
                CTDH ctdh = new CTDH(DH.MaDonHang);
                this.Hide();
                ctdh.Show();
            }
        }
    }
}
