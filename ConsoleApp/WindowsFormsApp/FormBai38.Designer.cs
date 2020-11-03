namespace WindowsFormsApp
{
    partial class frm_Bai38
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
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnBai40 = new System.Windows.Forms.Button();
            this.btnTranfer = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.Location = new System.Drawing.Point(69, 53);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(94, 29);
            this.lbAmount.TabIndex = 0;
            this.lbAmount.Text = "Amount";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(80, 180);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(81, 29);
            this.lbResult.TabIndex = 1;
            this.lbResult.Text = "Result";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(194, 46);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(493, 40);
            this.txtAmount.TabIndex = 2;
            // 
            // btnBai40
            // 
            this.btnBai40.BackColor = System.Drawing.Color.Yellow;
            this.btnBai40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai40.Location = new System.Drawing.Point(74, 113);
            this.btnBai40.Name = "btnBai40";
            this.btnBai40.Size = new System.Drawing.Size(96, 44);
            this.btnBai40.TabIndex = 3;
            this.btnBai40.Text = "Bai40";
            this.btnBai40.UseVisualStyleBackColor = false;
            this.btnBai40.Click += new System.EventHandler(this.btnBai40_Click);
            // 
            // btnTranfer
            // 
            this.btnTranfer.BackColor = System.Drawing.Color.Cyan;
            this.btnTranfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranfer.Location = new System.Drawing.Point(498, 113);
            this.btnTranfer.Name = "btnTranfer";
            this.btnTranfer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnTranfer.Size = new System.Drawing.Size(104, 44);
            this.btnTranfer.TabIndex = 4;
            this.btnTranfer.Text = "Tranfer";
            this.btnTranfer.UseVisualStyleBackColor = false;
            this.btnTranfer.Click += new System.EventHandler(this.btnTranfer_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(194, 180);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(493, 303);
            this.txtResult.TabIndex = 5;
            // 
            // frm_Bai38
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(899, 488);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnTranfer);
            this.Controls.Add(this.btnBai40);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbAmount);
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.Name = "frm_Bai38";
            this.Text = "frm_Bai38";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnBai40;
        private System.Windows.Forms.Button btnTranfer;
        private System.Windows.Forms.TextBox txtResult;
    }
}