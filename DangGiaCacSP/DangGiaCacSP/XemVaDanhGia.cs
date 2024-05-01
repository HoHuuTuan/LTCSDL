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
    public partial class XemVaDanhGia : Form
    {
        private int MaSP;
        private int MaKH;
        public XemVaDanhGia(int data,int data2)
        {
            InitializeComponent();
            MaSP = data;
            MaKH = data2;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            XemSPCanDanhGia SPDG = new XemSPCanDanhGia();
            this.Hide();
            SPDG.Show();
        }

        private void XemVaDanhGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            XemSPCanDanhGia SPDG = new XemSPCanDanhGia();
            SPDG.Show();
        }

        private void btDanhGia_Click(object sender, EventArgs e)
        {
            using(var context = new QLBanHangEntities())
            {
                if (rtxtDanhGia != null)
                {
                    DanhGia newDG = new DanhGia
                    {
                        NoiDung = rtxtDanhGia.Text,
                        MaKH = MaKH,
                        MaSanPham = MaSP
                    };
                    context.DanhGias.Add(newDG);
                    context.SaveChanges();
                    MessageBox.Show("Đã thêm đánh giá");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đánh giá");
                }
            }
            ShowData();
        }
        private void XemVaDanhGia_Load(object sender, EventArgs e)
        {
            ShowData();
        }
        private void ShowData()
        {
            using (var context = new QLBanHangEntities())
            {
                var DGSP = context.DanhGias.Where(p => p.MaSanPham.Value == MaSP).ToList();
                if (DGSP != null)
                {
                    GVDanhGia.DataSource = DGSP;
                    GVDanhGia.Columns["KhachHang"].Visible = false;
                    GVDanhGia.Columns["SanPham"].Visible = false;
                }
            }
        }
    }
}
