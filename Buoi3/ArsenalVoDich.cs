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
    public partial class ArsenalVoDich : Form
    {
        public ArsenalVoDich()
        {
            InitializeComponent();
        }

        private void ArsenalVoDich_Load(object sender, EventArgs e)
        {

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (radBlue.Checked)
                picColor.BackColor = Color.Blue;
            if (radRed.Checked)
                picColor.BackColor = Color.Red;
            if (radYellow.Checked)
                picColor.BackColor = Color.Yellow;
        }
    }
}
