using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konveri_Suhu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txthasil.ReadOnly = true;
            txtsuhu.Focus();
            comboBoxSuhu.Enabled = false;
            btnKonveri.Enabled = false;

        }

        private void btnKonveri_Click(object sender, EventArgs e)
        {
            float x, hasil;
            string satuan = null;
            x = float.Parse(txtsuhu.Text);
            hasil = x;
            if(comboBoxSuhu.SelectedIndex == 0)
            {
                if(rbFahreinheit.Checked)
                {
                    hasil = (9 * x) / 5 + 32;
                }
                if(rbReamur.Checked)
                {
                    hasil = x * 4 / 5;
                }
            }
            if (comboBoxSuhu.SelectedIndex == 1)
            {
                if(rbCelcius.Checked)
                {
                    hasil = (x - 32) * 5 / 9;
                }
                if(rbReamur.Checked)
                {
                    hasil = (x - 32) * 4 / 9;
                }
            }
            if (comboBoxSuhu.SelectedIndex == 2)
            {
                if (rbCelcius.Checked)
                {
                    hasil = x * 5 / 4;
                }
                if (rbFahreinheit.Checked)
                {
                    hasil = x * 9 / 4 + 32;
                }
            }
            if(rbCelcius.Checked)
                {
                    satuan = "Celcius";
                }
            if (rbFahreinheit.Checked)
            {
                satuan = "Fahreomheit";
            }
            if (rbReamur.Checked)
            {
                satuan = "Reamur";
            }
            txthasil.Text = hasil.ToString() + " " + satuan;
        }

        private void txtsuhu_TextChanged(object sender, EventArgs e)
        {
            comboBoxSuhu.Enabled = true;
        }

        private void comboBoxSuhu_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnKonveri.Enabled = true;
        }
    }
}
