namespace Buoi3
{
    partial class frmMain
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblSoa = new System.Windows.Forms.Label();
            this.lnlSob = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtTru = new System.Windows.Forms.Button();
            this.txtNhan = new System.Windows.Forms.Button();
            this.txtChia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(71, 44);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(103, 26);
            this.txtA.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(71, 143);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(88, 24);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Cong";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(71, 87);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(103, 26);
            this.txtB.TabIndex = 2;
            // 
            // lblSoa
            // 
            this.lblSoa.AutoSize = true;
            this.lblSoa.Location = new System.Drawing.Point(12, 52);
            this.lblSoa.Name = "lblSoa";
            this.lblSoa.Size = new System.Drawing.Size(29, 13);
            this.lblSoa.TabIndex = 3;
            this.lblSoa.Text = "So a";
            // 
            // lnlSob
            // 
            this.lnlSob.AutoSize = true;
            this.lnlSob.Location = new System.Drawing.Point(12, 95);
            this.lnlSob.Name = "lnlSob";
            this.lnlSob.Size = new System.Drawing.Size(29, 13);
            this.lnlSob.TabIndex = 4;
            this.lnlSob.Text = "So b";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Enabled = false;
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(293, 71);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(219, 38);
            this.txtKetQua.TabIndex = 5;
            // 
            // txtTru
            // 
            this.txtTru.Location = new System.Drawing.Point(192, 143);
            this.txtTru.Name = "txtTru";
            this.txtTru.Size = new System.Drawing.Size(88, 24);
            this.txtTru.TabIndex = 6;
            this.txtTru.Text = "Tru";
            this.txtTru.UseVisualStyleBackColor = true;
            this.txtTru.Click += new System.EventHandler(this.txtTru_Click);
            // 
            // txtNhan
            // 
            this.txtNhan.Location = new System.Drawing.Point(316, 143);
            this.txtNhan.Name = "txtNhan";
            this.txtNhan.Size = new System.Drawing.Size(88, 24);
            this.txtNhan.TabIndex = 7;
            this.txtNhan.Text = "Nhan";
            this.txtNhan.UseVisualStyleBackColor = true;
            this.txtNhan.Click += new System.EventHandler(this.txtNhan_Click);
            // 
            // txtChia
            // 
            this.txtChia.Location = new System.Drawing.Point(446, 143);
            this.txtChia.Name = "txtChia";
            this.txtChia.Size = new System.Drawing.Size(88, 24);
            this.txtChia.TabIndex = 8;
            this.txtChia.Text = "Chia";
            this.txtChia.UseVisualStyleBackColor = true;
            this.txtChia.Click += new System.EventHandler(this.txtChia_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(606, 322);
            this.Controls.Add(this.txtChia);
            this.Controls.Add(this.txtNhan);
            this.Controls.Add(this.txtTru);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.lnlSob);
            this.Controls.Add(this.lblSoa);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtA);
            this.Name = "frmMain";
            this.Text = "Quan ly san banh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblSoa;
        private System.Windows.Forms.Label lnlSob;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button txtTru;
        private System.Windows.Forms.Button txtNhan;
        private System.Windows.Forms.Button txtChia;
    }
}

