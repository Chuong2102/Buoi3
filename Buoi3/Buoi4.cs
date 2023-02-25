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
    public partial class Buoi4 : Form
    {
        public Buoi4()
        {
            InitializeComponent();
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstMonAn.Items != null)
            {
                if(lstMonAn.SelectedItem != null)
                {
                    // THem
                    lstDich.Items.Add(lstMonAn.SelectedItem);
                    // Xoa
                    lstMonAn.Items.Remove(lstMonAn.SelectedItem);
                    //
                    Check();
                }
                
            }

        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            // Them
            lstDich.Items.AddRange(lstMonAn.Items);

            // Xoa
            lstMonAn.Items.Clear();

            //
            Check();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstDich.Items != null)
            {
                if(lstDich.SelectedItem != null)
                {
                    // THem
                    lstMonAn.Items.Add(lstDich.SelectedItem);
                    // Xoa
                    lstDich.Items.Remove(lstDich.SelectedItem);

                    //
                    Check();
                }
                
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            // THem
            lstMonAn.Items.AddRange(lstDich.Items);

            // Xoa
            lstDich.Items.Clear();

            //
            Check();
        }

        void Check()
        {
            if(lstDich.Items.Count > 0)
            {
                btnRemove.Enabled = true;
                btnRemoveAll.Enabled = true;
            }
            else
            {
                btnRemove.Enabled = false;
                btnRemoveAll.Enabled = false;
            }

            if(lstMonAn.Items.Count > 0)
            {
                btnAdd.Enabled = true;
                btnAddAll.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnAddAll.Enabled = false;
            }


        }

        

    }
}
