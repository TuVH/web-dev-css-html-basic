namespace Bakery_197PM33774
{
    partial class Frm_add
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
            this.lb_kindName = new System.Windows.Forms.Label();
            this.lb_cakeName = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_cakeName = new System.Windows.Forms.TextBox();
            this.Cbb_kindName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_kindName
            // 
            this.lb_kindName.AutoSize = true;
            this.lb_kindName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kindName.Location = new System.Drawing.Point(42, 78);
            this.lb_kindName.Name = "lb_kindName";
            this.lb_kindName.Size = new System.Drawing.Size(88, 20);
            this.lb_kindName.TabIndex = 0;
            this.lb_kindName.Text = "Kindname";
            // 
            // lb_cakeName
            // 
            this.lb_cakeName.AutoSize = true;
            this.lb_cakeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cakeName.Location = new System.Drawing.Point(37, 25);
            this.lb_cakeName.Name = "lb_cakeName";
            this.lb_cakeName.Size = new System.Drawing.Size(96, 20);
            this.lb_cakeName.TabIndex = 3;
            this.lb_cakeName.Text = "CakeName";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(204, 118);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(88, 41);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(389, 118);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(85, 41);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_cakeName
            // 
            this.txt_cakeName.Location = new System.Drawing.Point(162, 25);
            this.txt_cakeName.Name = "txt_cakeName";
            this.txt_cakeName.Size = new System.Drawing.Size(371, 20);
            this.txt_cakeName.TabIndex = 6;
            // 
            // Cbb_kindName
            // 
            this.Cbb_kindName.FormattingEnabled = true;
            this.Cbb_kindName.Location = new System.Drawing.Point(162, 75);
            this.Cbb_kindName.Name = "Cbb_kindName";
            this.Cbb_kindName.Size = new System.Drawing.Size(371, 21);
            this.Cbb_kindName.TabIndex = 9;
            // 
            // Frm_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cbb_kindName);
            this.Controls.Add(this.txt_cakeName);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lb_cakeName);
            this.Controls.Add(this.lb_kindName);
            this.Name = "Frm_add";
            this.Text = "Add Cake";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_kindName;
        private System.Windows.Forms.Label lb_cakeName;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_cakeName;
        private System.Windows.Forms.ComboBox Cbb_kindName;
    }
}