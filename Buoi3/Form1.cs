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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var s = int.Parse(txtA.Text) + int.Parse(txtB.Text);
            txtKetQua.Text = s.ToString();
        }

        private void txtTru_Click(object sender, EventArgs e)
        {
            var s = int.Parse(txtA.Text) - int.Parse(txtB.Text);
            txtKetQua.Text = s.ToString();
        }

        private void txtNhan_Click(object sender, EventArgs e)
        {
            var s = int.Parse(txtA.Text) * int.Parse(txtB.Text);
            txtKetQua.Text = s.ToString();
        }

        private void txtChia_Click(object sender, EventArgs e)
        {
            var s = int.Parse(txtA.Text) / int.Parse(txtB.Text);
            txtKetQua.Text = s.ToString();
        }
    }
}
