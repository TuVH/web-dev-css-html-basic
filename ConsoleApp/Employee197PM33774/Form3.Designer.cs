namespace Employee197PM33774
{
    partial class FrmEdit
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.CbbRoom = new System.Windows.Forms.ComboBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.lbRoom = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(607, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 47);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(217, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 47);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CbbRoom
            // 
            this.CbbRoom.FormattingEnabled = true;
            this.CbbRoom.Location = new System.Drawing.Point(217, 242);
            this.CbbRoom.Name = "CbbRoom";
            this.CbbRoom.Size = new System.Drawing.Size(527, 28);
            this.CbbRoom.TabIndex = 13;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(217, 148);
            this.txtBirthday.Multiline = true;
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(527, 32);
            this.txtBirthday.TabIndex = 12;
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoom.Location = new System.Drawing.Point(57, 242);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(162, 32);
            this.lbRoom.TabIndex = 11;
            this.lbRoom.Text = "Phòng ban";
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthday.Location = new System.Drawing.Point(57, 148);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(155, 32);
            this.lbBirthday.TabIndex = 10;
            this.lbBirthday.Text = "Ngày Sinh";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(217, 59);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(527, 32);
            this.txtName.TabIndex = 9;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(57, 59);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(104, 32);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "Họ tên";
            // 
            // FrmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.CbbRoom);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.lbRoom);
            this.Controls.Add(this.lbBirthday);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.Name = "FrmEdit";
            this.Text = "Sửa nhân viên";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox CbbRoom;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
    }
}