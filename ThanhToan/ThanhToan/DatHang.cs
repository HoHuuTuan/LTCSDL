using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThanhToan
{
    public partial class DatHang : Form
    {
        private int MaDHKM = 1;
        private String tenDN = "abc1234";
        public DatHang()
        {
            InitializeComponent();
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            using(var context = new QLBanHangEntities())
            {

                var KH = context.KhachHangs.Where(a => a.TenDangNhap.Contains(tenDN)).FirstOrDefault();
                var DH = context.DonHangs.Where(b => b.MaDonHang == MaDHKM).FirstOrDefault();
                if (KH !=null)
                {
                    lbDiaChi.Text = KH.DiaChi;
                    if (DH != null)
                    {
                        if (KH.MaLoaiKH == 1)
                        {
                            lbTienHang.Text = DH.TongTien.ToString();
                            lbGiamGia.Text = (DH.TongTien * 0 / 100).ToString();
                            lbTongTien.Text = (DH.TongTien - (DH.TongTien * 0 / 100)).ToString();
                        }
                        else if (KH.MaLoaiKH == 2)
                        {
                            lbTienHang.Text = DH.TongTien.ToString();
                            lbGiamGia.Text = (DH.TongTien * 5 / 100).ToString();
                            lbTongTien.Text = (DH.TongTien - (DH.TongTien * 5 / 100)).ToString();
                        }
                    }
                }
                var CTDH = context.ChiTietDonHangs.Where(p => p.MaDonHang == MaDHKM).ToList();
                if (CTDH != null)
                {
                    GVChiTietDonHang.DataSource = CTDH;
                    GVChiTietDonHang.Columns["DonHang"].Visible = false;
                    GVChiTietDonHang.Columns["SanPham"].Visible = false;
                }
            }

        }

        private void rbtCK_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Ngân hàng: Vietcombank\nSoTK: 1234567890", "Tài Khoản", MessageBoxButtons.OK);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void ThanhToan_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đặt hàng thành công!!!", "Thông Báo", MessageBoxButtons.OK);
            Application.ExitThread();
        }
    }
}
