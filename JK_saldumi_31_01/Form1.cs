using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JK_saldumi_31_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aprekinat_Click(object sender, EventArgs e)
        {
            double naudas_daudzums_eur = Convert.ToDouble(this.naudas_ievade.Text);
            double rezultats_eur = 0;
            rezultats_eur = naudas_daudzums_eur /9.88;
            rezultats_eur = Math.Round(rezultats_eur, 2);
            this.rezultats.Text = rezultats_eur.ToString();
     

        }

        private void naudas_ievade_TextChanged(object sender, EventArgs e)
        {


            

        }

        private void rezultats_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
