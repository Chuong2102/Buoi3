namespace Buoi3
{
    partial class Buoi4Word
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.cmbStyle = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnOke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Style";
            // 
            // cmbFont
            // 
            this.cmbFont.FormattingEnabled = true;
            this.cmbFont.Items.AddRange(new object[] {
            "Time New Roman",
            "Courier New",
            "Calibri",
            "Arial"});
            this.cmbFont.Location = new System.Drawing.Point(12, 53);
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(121, 21);
            this.cmbFont.TabIndex = 3;
            this.cmbFont.Text = "Times New Roman";
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.cmbSize.Location = new System.Drawing.Point(219, 53);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(121, 21);
            this.cmbSize.TabIndex = 4;
            this.cmbSize.Text = "8";
            // 
            // cmbStyle
            // 
            this.cmbStyle.FormattingEnabled = true;
            this.cmbStyle.Items.AddRange(new object[] {
            "Bold",
            "Italic",
            "Underline",
            "Regular"});
            this.cmbStyle.Location = new System.Drawing.Point(403, 53);
            this.cmbStyle.Name = "cmbStyle";
            this.cmbStyle.Size = new System.Drawing.Size(121, 21);
            this.cmbStyle.TabIndex = 5;
            this.cmbStyle.Text = "Bold";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhap van ban";
            // 
            // txtBox
            // 
            this.txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.Location = new System.Drawing.Point(115, 146);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(274, 23);
            this.txtBox.TabIndex = 7;
            // 
            // btnOke
            // 
            this.btnOke.Location = new System.Drawing.Point(15, 203);
            this.btnOke.Name = "btnOke";
            this.btnOke.Size = new System.Drawing.Size(75, 23);
            this.btnOke.TabIndex = 8;
            this.btnOke.Text = "Okay";
            this.btnOke.UseVisualStyleBackColor = true;
            this.btnOke.Click += new System.EventHandler(this.btnOke_Click);
            // 
            // Buoi4Word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 442);
            this.Controls.Add(this.btnOke);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbStyle);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.cmbFont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Buoi4Word";
            this.Text = "Buoi4Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFont;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.ComboBox cmbStyle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnOke;
    }
}