using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachHangs
{
    public partial class ThongTinKhachHang : Form
    {
        private String tenDN = "tendangnhap2";
        public ThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void btThoát_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new QLBanHangEntities())
            {
                var KH = context.KhachHangs.Where(p => p.TenDangNhap.Contains(tenDN)).FirstOrDefault();
                if (KH != null)
                {

                    lbMaKH.Text = KH.MaKH.ToString();
                    lbHoTen.Text = KH.Ho +" "+ KH.Ten;
                    lbDiaChi.Text = KH.DiaChi;
                    lbEmail.Text = KH.Email;
                    lbSDT.Text = KH.SDT;
                    lbMK.Text = KH.MatKhau;
                    lbLKH.Text = KH.MaLoaiKH.ToString();
                }
            }
        }

        private void ThongTinKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
