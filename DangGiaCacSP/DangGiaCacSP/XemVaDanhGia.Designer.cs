
namespace DangGiaCacSP
{
    partial class XemVaDanhGia
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
            this.rtxtDanhGia = new System.Windows.Forms.RichTextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btDanhGia = new System.Windows.Forms.Button();
            this.GVDanhGia = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GVDanhGia)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxtDanhGia
            // 
            this.rtxtDanhGia.Location = new System.Drawing.Point(16, 276);
            this.rtxtDanhGia.Name = "rtxtDanhGia";
            this.rtxtDanhGia.Size = new System.Drawing.Size(581, 96);
            this.rtxtDanhGia.TabIndex = 11;
            this.rtxtDanhGia.Text = "";
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(603, 334);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(90, 37);
            this.btThoat.TabIndex = 9;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btDanhGia
            // 
            this.btDanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDanhGia.Location = new System.Drawing.Point(699, 334);
            this.btDanhGia.Name = "btDanhGia";
            this.btDanhGia.Size = new System.Drawing.Size(90, 37);
            this.btDanhGia.TabIndex = 10;
            this.btDanhGia.Text = "Đánh Giá";
            this.btDanhGia.UseVisualStyleBackColor = true;
            this.btDanhGia.Click += new System.EventHandler(this.btDanhGia_Click);
            // 
            // GVDanhGia
            // 
            this.GVDanhGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVDanhGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVDanhGia.Location = new System.Drawing.Point(16, 31);
            this.GVDanhGia.Name = "GVDanhGia";
            this.GVDanhGia.Size = new System.Drawing.Size(772, 206);
            this.GVDanhGia.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đánh Giá Sản Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Các Đánh Giá Các Sản Phẩm";
            // 
            // XemVaDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 379);
            this.Controls.Add(this.rtxtDanhGia);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btDanhGia);
            this.Controls.Add(this.GVDanhGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "XemVaDanhGia";
            this.Text = "Xem Và Đánh Giá các Sản Phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XemVaDanhGia_FormClosing);
            this.Load += new System.EventHandler(this.XemVaDanhGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVDanhGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtDanhGia;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btDanhGia;
        private System.Windows.Forms.DataGridView GVDanhGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}