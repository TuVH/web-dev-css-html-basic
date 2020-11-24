namespace Employee197PM33774
{
    partial class FrmAdd
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
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lbRoom = new System.Windows.Forms.Label();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.CbbRoom = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(48, 23);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(104, 32);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Họ tên";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(208, 23);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(527, 32);
            this.txtName.TabIndex = 1;
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthday.Location = new System.Drawing.Point(48, 112);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(155, 32);
            this.lbBirthday.TabIndex = 2;
            this.lbBirthday.Text = "Ngày Sinh";
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoom.Location = new System.Drawing.Point(48, 206);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(162, 32);
            this.lbRoom.TabIndex = 3;
            this.lbRoom.Text = "Phòng ban";
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(208, 112);
            this.txtBirthday.Multiline = true;
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(527, 32);
            this.txtBirthday.TabIndex = 4;
            // 
            // CbbRoom
            // 
            this.CbbRoom.FormattingEnabled = true;
            this.CbbRoom.Location = new System.Drawing.Point(208, 206);
            this.CbbRoom.Name = "CbbRoom";
            this.CbbRoom.Size = new System.Drawing.Size(527, 28);
            this.CbbRoom.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(208, 308);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 47);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(598, 308);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 47);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmAdd
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
            this.Name = "FrmAdd";
            this.Text = "Thêm Nhân Viên";
            this.Load += new System.EventHandler(this.FrmAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.ComboBox CbbRoom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}