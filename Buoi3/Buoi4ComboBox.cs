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
    public partial class Buoi4ComboBox : Form
    {
        public Buoi4ComboBox()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromName(cmbChooseColor.SelectedItem.ToString());
        }
    }
}
