using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            string index = "";
            foreach (string item in lstDanhsach1.SelectedItems)
            {
                lstDanhsach2.Items.Add(item);
                index = item;
            }
            lstDanhsach1.Items.Remove(index);
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            string index = "";
            foreach (string item in lstDanhsach2.SelectedItems)
            {
                lstDanhsach1.Items.Add(item);
                index = item;
            }
            lstDanhsach2.Items.Remove(index);
        }

        private void btnallphai_Click(object sender, EventArgs e)
        {
            for(int i=0; i<lstDanhsach1.Items.Count;i++)
            {
                lstDanhsach2.Items.Add(lstDanhsach1.Items[i].ToString());
            }
            lstDanhsach1.Items.Clear();
        }

        private void btnallTrai_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDanhsach2.Items.Count; i++)
            {
                lstDanhsach1.Items.Add(lstDanhsach2.Items[i].ToString());
            }
            lstDanhsach2.Items.Clear();
        }

        private void btnadditemphai_Click(object sender, EventArgs e)
        {
            lstDanhsach2.Items.Add(txtItems.Text);
            txtItems.Clear();
        }

        private void btnadditemtrai_Click(object sender, EventArgs e)
        {
            lstDanhsach1.Items.Add(txtItems.Text);
            txtItems.Clear();
        }
    }
}
