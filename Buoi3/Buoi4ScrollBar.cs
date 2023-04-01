using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3
{
    public partial class Buoi4ScrollBar : Form
    {
        public Buoi4ScrollBar()
        {
            InitializeComponent();
        }

        private void hScrBar_ValueChanged(object sender, EventArgs e)
        {
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F + hScrBar.Value, 
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }
    }
}
