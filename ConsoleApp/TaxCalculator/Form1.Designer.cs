namespace TaxCalculator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_amount = new System.Windows.Forms.Label();
            this.lb_per = new System.Windows.Forms.Label();
            this.lb_due = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_due = new System.Windows.Forms.TextBox();
            this.lb_percentage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TAX CALCULATOR";
            // 
            // lb_amount
            // 
            this.lb_amount.AutoSize = true;
            this.lb_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_amount.Location = new System.Drawing.Point(41, 78);
            this.lb_amount.Name = "lb_amount";
            this.lb_amount.Size = new System.Drawing.Size(161, 29);
            this.lb_amount.TabIndex = 1;
            this.lb_amount.Text = "Total Amount:";
            // 
            // lb_per
            // 
            this.lb_per.AutoSize = true;
            this.lb_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_per.Location = new System.Drawing.Point(41, 156);
            this.lb_per.Name = "lb_per";
            this.lb_per.Size = new System.Drawing.Size(183, 29);
            this.lb_per.TabIndex = 2;
            this.lb_per.Text = "Tax Percentage";
            // 
            // lb_due
            // 
            this.lb_due.AutoSize = true;
            this.lb_due.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_due.Location = new System.Drawing.Point(41, 225);
            this.lb_due.Name = "lb_due";
            this.lb_due.Size = new System.Drawing.Size(118, 29);
            this.lb_due.TabIndex = 3;
            this.lb_due.Text = "Total Due";
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(375, 72);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(127, 35);
            this.txt_amount.TabIndex = 4;
            this.txt_amount.TextChanged += new System.EventHandler(this.txt_amount_TextChanged);
            // 
            // txt_due
            // 
            this.txt_due.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_due.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_due.Location = new System.Drawing.Point(351, 225);
            this.txt_due.Name = "txt_due";
            this.txt_due.ReadOnly = true;
            this.txt_due.Size = new System.Drawing.Size(151, 35);
            this.txt_due.TabIndex = 6;
            // 
            // lb_percentage
            // 
            this.lb_percentage.AutoSize = true;
            this.lb_percentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_percentage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_percentage.Location = new System.Drawing.Point(435, 156);
            this.lb_percentage.Name = "lb_percentage";
            this.lb_percentage.Size = new System.Drawing.Size(67, 29);
            this.lb_percentage.TabIndex = 7;
            this.lb_percentage.Text = "7.5%";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Complete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_percentage);
            this.Controls.Add(this.txt_due);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.lb_due);
            this.Controls.Add(this.lb_per);
            this.Controls.Add(this.lb_amount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_amount;
        private System.Windows.Forms.Label lb_per;
        private System.Windows.Forms.Label lb_due;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_due;
        private System.Windows.Forms.Label lb_percentage;
        private System.Windows.Forms.Button button1;
    }
}

