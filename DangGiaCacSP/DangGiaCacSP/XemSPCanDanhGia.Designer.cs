
namespace DangGiaCacSP
{
    partial class XemSPCanDanhGia
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
            this.btThoat = new System.Windows.Forms.Button();
            this.btDanhGia = new System.Windows.Forms.Button();
            this.GVSanPham = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GVSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(603, 281);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(90, 37);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btDanhGia
            // 
            this.btDanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDanhGia.Location = new System.Drawing.Point(702, 281);
            this.btDanhGia.Name = "btDanhGia";
            this.btDanhGia.Size = new System.Drawing.Size(90, 37);
            this.btDanhGia.TabIndex = 6;
            this.btDanhGia.Text = "Đánh Giá";
            this.btDanhGia.UseVisualStyleBackColor = true;
            this.btDanhGia.Click += new System.EventHandler(this.btDanhGia_Click);
            // 
            // GVSanPham
            // 
            this.GVSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVSanPham.Location = new System.Drawing.Point(18, 34);
            this.GVSanPham.Name = "GVSanPham";
            this.GVSanPham.Size = new System.Drawing.Size(772, 240);
            this.GVSanPham.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sản Phẩm Đánh Giá";
            // 
            // XemSPCanDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 328);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btDanhGia);
            this.Controls.Add(this.GVSanPham);
            this.Controls.Add(this.label1);
            this.Name = "XemSPCanDanhGia";
            this.Text = "Đánh Giá Sản Phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XemSPCanDanhGia_FormClosing);
            this.Load += new System.EventHandler(this.XemSPCanDanhGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btDanhGia;
        private System.Windows.Forms.DataGridView GVSanPham;
        private System.Windows.Forms.Label label1;
    }
}

