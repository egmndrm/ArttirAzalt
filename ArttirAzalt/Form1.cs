using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArttirAzalt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi=0;

        private void btn10_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(txbSayi.Text);
            if (rbArttir.Checked)
            {
                txbSayi.Text = Convert.ToString(sayi + 10);
            }
            else if (rbAzalt.Checked)
            {
                txbSayi.Text = Convert.ToString(sayi - 10);
            }
        }

        private void rbArttir_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(txbSayi.Text);
            if (rbArttir.Checked)
            {
                txbSayi.Text = Convert.ToString(sayi + 20);
            }
            else if (rbAzalt.Checked)
            {
                txbSayi.Text = Convert.ToString(sayi - 20);
            }
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(txbSayi.Text);
            if (rbArttir.Checked)
            {
                txbSayi.Text = Convert.ToString(sayi + 30);
            }
            else if (rbAzalt.Checked)
            {
                txbSayi.Text = Convert.ToString(sayi - 30);
            }
        }

        private void btn40_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(txbSayi.Text);
            if (rbArttir.Checked)
            {
                txbSayi.Text = Convert.ToString(sayi + 40);
            }
            else if (rbAzalt.Checked)
            {
                txbSayi.Text = Convert.ToString(sayi - 40);
            }
        }
    }
}
