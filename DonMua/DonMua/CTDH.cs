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
                var CTDH = context.ChiTietDonHangs.Where(a => a.MaDonHang.Value == MaDH).ToList();
                if (CTDH != null)
                { 
                    dataGridView1.DataSource = CTDH;
                    dataGridView1.Columns["DonHang"].Visible = false;
                    dataGridView1.Columns["SanPham"].Visible = false;
                }
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
