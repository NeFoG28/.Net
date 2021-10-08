using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_satu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckrica.Checked == true)
            {
                txtrica.Visible = true;
                txtrica.Focus();
            }
            else
            {
                txtrica.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtnama.Focus();
            txtsop.Visible = false;
            txtrica.Visible = false;
            txtteh.Visible = false;
            txttotal.ReadOnly = true;
        }

        private void cksop_CheckedChanged(object sender, EventArgs e)
        {
            if(cksop.Checked == true)
            {
                txtsop.Visible = true;
                txtsop.Focus();
            }
            else
            {
                txtsop.Visible=false;
            }
        }

        private void ckteh_CheckedChanged(object sender, EventArgs e)
        {
            if (ckteh.Checked == true)
            {
                txtteh.Visible = true;
                txtteh.Focus();
            }
            else
            {
                txtteh.Visible = false;
            }
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            double total = 0;
            int sop, rica, teh;
            if (cksop.Checked)
            { 
                sop = int.Parse(txtsop.Text);
                total = total + 9000 * sop;
            }
            if (ckrica.Checked)
            {
                rica = int.Parse(txtsop.Text);
                total = total + 8500 * rica;
            }
            if (ckteh.Checked)
            {
                teh = int.Parse(txtteh.Text);
                total = total + 2000 * teh;
            }
            if (rbYa.Checked)
            {
                total = total - 0.25 * total;
                txttotal.Text = total.ToString();
            }
            else
            {
                txttotal.Text = total.ToString();

            }
        }
    }
}
