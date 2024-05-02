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
    public partial class CTDH : Form
    {
        private int MaDH;
        public CTDH(int data)
        {
            InitializeComponent();
            MaDH = data;
        }

        private void CTDH_Load(object sender, EventArgs e)
        {
            using (var context = new QLBanHangEntities())
            {
                var result = (from ChiTietDonHang in context.ChiTietDonHangs .Where(a => a.MaDonHang.Value == MaDH)
                              join SanPham in context.SanPhams on ChiTietDonHang.MaSanPham equals SanPham.MaSanPham
                              select new
                              {
                                  MaDonHang = ChiTietDonHang.MaDonHang,
                                  TenSanPham = SanPham.TenSP,
                                  SoLuong = ChiTietDonHang.SoLuong,
                                  TongTienSP = ChiTietDonHang.TongTienSP
                              }).ToList();

                dataGridView1.DataSource = result;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DonHangDaMua DHDM = new DonHangDaMua();
            this.Hide();
            DHDM.Show();
        }

        private void CTDH_FormClosing(object sender, FormClosingEventArgs e)
        {
            DonHangDaMua DHDM = new DonHangDaMua();
            DHDM.Show();
        }
    }
}
