using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_di_Pareggio
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cvp_Click(object sender, EventArgs e)
        {

        }

        private void tb_cvp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cfp_Click(object sender, EventArgs e)
        {
            string descrizione = tb_descrizione.Text;
            double cfp = double.Parse(tb_cfp.Text);

            list_CostiFissiProduzione.Items.Add($"{descrizione} costa {cfp} euro");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_CostiFissiProduzione_Click(object sender, EventArgs e)
        {

        }

        private void lb_DescrizioneProdFissi_Click(object sender, EventArgs e)
        {
            
        }

        private void lb_DescrizioneAcquistoVariabili_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void list_CostiFissiAcquisto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lb_DescrizioneProdVariabili_Click(object sender, EventArgs e)
        {
                    }

        private void tb_descrizioneCFa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}