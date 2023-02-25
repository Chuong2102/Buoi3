namespace Buoi3
{
    partial class ArsenalVoDich
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
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radYellow = new System.Windows.Forms.RadioButton();
            this.picColor = new System.Windows.Forms.PictureBox();
            this.btnChoose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
            this.SuspendLayout();
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Location = new System.Drawing.Point(63, 27);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(45, 17);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Location = new System.Drawing.Point(63, 73);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(46, 17);
            this.radBlue.TabIndex = 1;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            // 
            // radYellow
            // 
            this.radYellow.AutoSize = true;
            this.radYellow.Location = new System.Drawing.Point(63, 126);
            this.radYellow.Name = "radYellow";
            this.radYellow.Size = new System.Drawing.Size(56, 17);
            this.radYellow.TabIndex = 2;
            this.radYellow.TabStop = true;
            this.radYellow.Text = "Yellow";
            this.radYellow.UseVisualStyleBackColor = true;
            // 
            // picColor
            // 
            this.picColor.BackColor = System.Drawing.Color.Red;
            this.picColor.Location = new System.Drawing.Point(294, 57);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(159, 86);
            this.picColor.TabIndex = 3;
            this.picColor.TabStop = false;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(131, 207);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(158, 39);
            this.btnChoose.TabIndex = 4;
            this.btnChoose.Text = "Choose color";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // ArsenalVoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 365);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.picColor);
            this.Controls.Add(this.radYellow);
            this.Controls.Add(this.radBlue);
            this.Controls.Add(this.radRed);
            this.Name = "ArsenalVoDich";
            this.Text = "ArsenalVoDich";
            this.Load += new System.EventHandler(this.ArsenalVoDich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radYellow;
        private System.Windows.Forms.PictureBox picColor;
        private System.Windows.Forms.Button btnChoose;
    }
}