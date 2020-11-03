namespace WindowsFormsApp
{
    partial class frm_Bai40
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
            this.lbNumberA = new System.Windows.Forms.Label();
            this.lbNumberB = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.txtNumberA = new System.Windows.Forms.TextBox();
            this.txtNumberB = new System.Windows.Forms.TextBox();
            this.btnBai38 = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNumberA
            // 
            this.lbNumberA.AutoSize = true;
            this.lbNumberA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbNumberA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberA.Location = new System.Drawing.Point(70, 40);
            this.lbNumberA.Name = "lbNumberA";
            this.lbNumberA.Size = new System.Drawing.Size(115, 29);
            this.lbNumberA.TabIndex = 0;
            this.lbNumberA.Text = "NumberA";
            // 
            // lbNumberB
            // 
            this.lbNumberB.AutoSize = true;
            this.lbNumberB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbNumberB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberB.Location = new System.Drawing.Point(70, 105);
            this.lbNumberB.Name = "lbNumberB";
            this.lbNumberB.Size = new System.Drawing.Size(116, 29);
            this.lbNumberB.TabIndex = 1;
            this.lbNumberB.Text = "NumberB";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(70, 308);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(81, 29);
            this.lbResult.TabIndex = 2;
            this.lbResult.Text = "Result";
            // 
            // txtNumberA
            // 
            this.txtNumberA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberA.Location = new System.Drawing.Point(248, 37);
            this.txtNumberA.Multiline = true;
            this.txtNumberA.Name = "txtNumberA";
            this.txtNumberA.Size = new System.Drawing.Size(407, 29);
            this.txtNumberA.TabIndex = 3;
            // 
            // txtNumberB
            // 
            this.txtNumberB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberB.Location = new System.Drawing.Point(248, 105);
            this.txtNumberB.Multiline = true;
            this.txtNumberB.Name = "txtNumberB";
            this.txtNumberB.Size = new System.Drawing.Size(407, 29);
            this.txtNumberB.TabIndex = 4;
            // 
            // btnBai38
            // 
            this.btnBai38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBai38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai38.Location = new System.Drawing.Point(74, 218);
            this.btnBai38.Name = "btnBai38";
            this.btnBai38.Size = new System.Drawing.Size(111, 36);
            this.btnBai38.TabIndex = 5;
            this.btnBai38.Text = "Bai38";
            this.btnBai38.UseVisualStyleBackColor = false;
            this.btnBai38.Click += new System.EventHandler(this.btnBai38_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(543, 218);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(112, 36);
            this.btnResult.TabIndex = 6;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(238, 308);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(417, 73);
            this.txtResult.TabIndex = 7;
            // 
            // frm_Bai40
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnBai38);
            this.Controls.Add(this.txtNumberB);
            this.Controls.Add(this.txtNumberA);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbNumberB);
            this.Controls.Add(this.lbNumberA);
            this.Name = "frm_Bai40";
            this.Text = "frm_Bai40";
            this.Load += new System.EventHandler(this.frm_Bai40_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumberA;
        private System.Windows.Forms.Label lbNumberB;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox txtNumberA;
        private System.Windows.Forms.TextBox txtNumberB;
        private System.Windows.Forms.Button btnBai38;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox txtResult;
    }
}