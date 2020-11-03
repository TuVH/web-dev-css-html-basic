using System.Security.Cryptography.X509Certificates;

namespace TaxCalculator
{
    partial class frm_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_form));
            this.lb_subject = new System.Windows.Forms.Label();
            this.lb_A = new System.Windows.Forms.Label();
            this.lb_B = new System.Windows.Forms.Label();
            this.lb_C = new System.Windows.Forms.Label();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.txt_C = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_subject
            // 
            this.lb_subject.AutoSize = true;
            this.lb_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subject.Location = new System.Drawing.Point(52, 42);
            this.lb_subject.Name = "lb_subject";
            this.lb_subject.Size = new System.Drawing.Size(101, 29);
            this.lb_subject.TabIndex = 0;
            this.lb_subject.Text = "Subject";
            // 
            // lb_A
            // 
            this.lb_A.AutoSize = true;
            this.lb_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_A.Location = new System.Drawing.Point(57, 95);
            this.lb_A.Name = "lb_A";
            this.lb_A.Size = new System.Drawing.Size(36, 29);
            this.lb_A.TabIndex = 1;
            this.lb_A.Text = "A:";
            // 
            // lb_B
            // 
            this.lb_B.AutoSize = true;
            this.lb_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_B.Location = new System.Drawing.Point(312, 95);
            this.lb_B.Name = "lb_B";
            this.lb_B.Size = new System.Drawing.Size(37, 29);
            this.lb_B.TabIndex = 2;
            this.lb_B.Text = "B:";
            // 
            // lb_C
            // 
            this.lb_C.AutoSize = true;
            this.lb_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_C.Location = new System.Drawing.Point(593, 95);
            this.lb_C.Name = "lb_C";
            this.lb_C.Size = new System.Drawing.Size(38, 29);
            this.lb_C.TabIndex = 3;
            this.lb_C.Text = "C:";
            // 
            // txt_A
            // 
            this.txt_A.Location = new System.Drawing.Point(111, 97);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(100, 26);
            this.txt_A.TabIndex = 4;
            // 
            // txt_B
            // 
            this.txt_B.Location = new System.Drawing.Point(374, 99);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(100, 26);
            this.txt_B.TabIndex = 5;
            // 
            // txt_C
            // 
            this.txt_C.Location = new System.Drawing.Point(648, 97);
            this.txt_C.Name = "txt_C";
            this.txt_C.Size = new System.Drawing.Size(100, 26);
            this.txt_C.TabIndex = 6;
            // 
            // txt_result
            // 
            this.txt_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_result.ForeColor = System.Drawing.Color.Yellow;
            this.txt_result.Location = new System.Drawing.Point(57, 320);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(691, 26);
            this.txt_result.TabIndex = 7;
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(333, 202);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(123, 48);
            this.btn_submit.TabIndex = 8;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lb_result.Location = new System.Drawing.Point(352, 269);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(87, 29);
            this.lb_result.TabIndex = 9;
            this.lb_result.Text = "Result";
            // 
            // frm_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_C);
            this.Controls.Add(this.txt_B);
            this.Controls.Add(this.txt_A);
            this.Controls.Add(this.lb_C);
            this.Controls.Add(this.lb_B);
            this.Controls.Add(this.lb_A);
            this.Controls.Add(this.lb_subject);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_form";
            this.Text = "Solve";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_subject;
        private System.Windows.Forms.Label lb_A;
        private System.Windows.Forms.Label lb_B;
        private System.Windows.Forms.Label lb_C;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.TextBox txt_C;
        public System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lb_result;
    }
}