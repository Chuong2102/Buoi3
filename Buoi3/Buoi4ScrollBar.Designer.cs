namespace Buoi3
{
    partial class Buoi4ScrollBar
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
            this.hScrBar = new System.Windows.Forms.HScrollBar();
            this.lblValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hScrBar
            // 
            this.hScrBar.Location = new System.Drawing.Point(83, 33);
            this.hScrBar.Name = "hScrBar";
            this.hScrBar.Size = new System.Drawing.Size(606, 22);
            this.hScrBar.TabIndex = 0;
            this.hScrBar.ValueChanged += new System.EventHandler(this.hScrBar_ValueChanged);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(375, 100);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(46, 17);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "label1";
            // 
            // Buoi4ScrollBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 389);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.hScrBar);
            this.Name = "Buoi4ScrollBar";
            this.Text = "Buoi4ScrollBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrBar;
        private System.Windows.Forms.Label lblValue;
    }
}