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
            aprekinasana_selga(0);
            aprekinasana_barbelite(0);
            aprekinasana_special(0);

        }

        private void naudas_ievade_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void rezultats_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void aprekinasana_kopa(double daudzums_kopa)
        {

        }
        private void aprekinasana_selga(double selgas_daudzums)
        {
            try
            {
                double naudas_daudzums_eur = Convert.ToDouble(this.textBox1.Text);
                double rezultats_eur = 0;
                if (naudas_daudzums_eur.ToString().All(char.IsDigit))
                {
                    rezultats_eur = naudas_daudzums_eur / 5;
                    rezultats_eur = Math.Round(rezultats_eur, 2);
                    this.textBox4.Text = rezultats_eur.ToString();
                }
                else
                {
                    Console.WriteLine("ievadi ciparus");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void aprekinasana_barbelite(double barbelites_daudzums)
        {
            try
            {

                double naudas_daudzums_eur = Convert.ToDouble(this.textBox2.Text);
                double rezultats_eur = 0;
                if (naudas_daudzums_eur.ToString().All(char.IsDigit))
                {
                    rezultats_eur = naudas_daudzums_eur / 7;
                    rezultats_eur = Math.Round(rezultats_eur, 2);
                    this.textBox5.Text = rezultats_eur.ToString();
                }
                else
                {
                }
                    Console.WriteLine("ievadi ciparus");
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
        }
        private void aprekinasana_special(double special_daudzums)
        {
            try
            {
                double naudas_daudzums_eur = Convert.ToDouble(this.textBox3.Text);
                double rezultats_eur = 0;
                if (naudas_daudzums_eur.ToString().All(char.IsDigit))
                {

                    rezultats_eur = naudas_daudzums_eur / 5;
                    rezultats_eur = Math.Round(rezultats_eur, 2);
                    this.textBox6.Text = rezultats_eur.ToString();
                }
                else
                {
                    Console.WriteLine("ievadi ciparus");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
