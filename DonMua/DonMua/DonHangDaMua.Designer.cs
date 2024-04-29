
namespace DonMua
{
    partial class DonHangDaMua
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btChiTietDH = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.GVDonHang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GVDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btChiTietDH
            // 
            this.btChiTietDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChiTietDH.Location = new System.Drawing.Point(533, 324);
            this.btChiTietDH.Name = "btChiTietDH";
            this.btChiTietDH.Size = new System.Drawing.Size(160, 38);
            this.btChiTietDH.TabIndex = 17;
            this.btChiTietDH.Text = "Chi Tiết Đơn Hàng";
            this.btChiTietDH.UseVisualStyleBackColor = true;
            this.btChiTietDH.Click += new System.EventHandler(this.btChiTietDH_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(699, 324);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(91, 38);
            this.btThoat.TabIndex = 18;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // GVDonHang
            // 
            this.GVDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVDonHang.Location = new System.Drawing.Point(15, 36);
            this.GVDonHang.Name = "GVDonHang";
            this.GVDonHang.Size = new System.Drawing.Size(775, 282);
            this.GVDonHang.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Đơn Hàng";
            // 
            // DonHangDaMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 373);
            this.Controls.Add(this.btChiTietDH);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.GVDonHang);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DonHangDaMua";
            this.Text = "Đơn Hàng Đã Mua";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DonHangDaMua_FormClosed);
            this.Load += new System.EventHandler(this.DonHangDaMua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btChiTietDH;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DataGridView GVDonHang;
        private System.Windows.Forms.Label label1;
    }
}

