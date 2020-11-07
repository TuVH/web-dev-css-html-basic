namespace Class0711_197PM33774
{
    partial class FrmMang
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
            this.lbMang = new System.Windows.Forms.Label();
            this.btnDtb = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.txtMang = new System.Windows.Forms.TextBox();
            this.lbHienThiKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMang
            // 
            this.lbMang.AutoSize = true;
            this.lbMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMang.Location = new System.Drawing.Point(32, 37);
            this.lbMang.Name = "lbMang";
            this.lbMang.Size = new System.Drawing.Size(77, 29);
            this.lbMang.TabIndex = 0;
            this.lbMang.Text = "Mảng";
            // 
            // btnDtb
            // 
            this.btnDtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDtb.Location = new System.Drawing.Point(36, 102);
            this.btnDtb.Name = "btnDtb";
            this.btnDtb.Size = new System.Drawing.Size(85, 35);
            this.btnDtb.TabIndex = 1;
            this.btnDtb.Text = "ĐTB";
            this.btnDtb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDtb.UseVisualStyleBackColor = false;
            this.btnDtb.Click += new System.EventHandler(this.btnDtb_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(397, 102);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(100, 35);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // txtMang
            // 
            this.txtMang.Location = new System.Drawing.Point(397, 30);
            this.txtMang.Name = "txtMang";
            this.txtMang.Size = new System.Drawing.Size(256, 26);
            this.txtMang.TabIndex = 3;
            // 
            // lbHienThiKetQua
            // 
            this.lbHienThiKetQua.AutoSize = true;
            this.lbHienThiKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHienThiKetQua.Location = new System.Drawing.Point(32, 188);
            this.lbHienThiKetQua.Name = "lbHienThiKetQua";
            this.lbHienThiKetQua.Size = new System.Drawing.Size(194, 29);
            this.lbHienThiKetQua.TabIndex = 4;
            this.lbHienThiKetQua.Text = "Hiển thị kết quả";
            // 
            // FrmMang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbHienThiKetQua);
            this.Controls.Add(this.txtMang);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnDtb);
            this.Controls.Add(this.lbMang);
            this.Name = "FrmMang";
            this.Text = "Mảng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMang;
        private System.Windows.Forms.Button btnDtb;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.TextBox txtMang;
        private System.Windows.Forms.Label lbHienThiKetQua;
    }
}

