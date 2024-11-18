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

        private void btn_cva_Click(object sender, EventArgs e)
        {
            string descrizione = tb_descrizione.Text;
            double cva = double.Parse(tb_cva.Text);

            list_CostiVariabiliAcquisto.Items.Add($"{descrizione} costa {cva} euro");
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

        private void btn_cvp_Click_1(object sender, EventArgs e)
        {
            string descrizione = tb_descrizione.Text;
            double cvp = double.Parse(tb_cvp.Text);

            list_CostiVariabiliProduzione.Items.Add($"{descrizione} costa {cvp} euro");
        }

        private void btn_cfa_Click(object sender, EventArgs e)
        {
            string descrizione = tb_descrizione.Text;
            double cfa = double.Parse(tb_cfa.Text);

            list_CostiFissiAcquisto.Items.Add($"{descrizione} costa {cfa} euro");
        }

        private void btn_addQ_Click(object sender, EventArgs e)
        {
            string descrizione = tb_descrizione.Text;
            double cfa = double.Parse(tb_cfa.Text);
            double cvp = double.Parse(tb_cvp.Text);
            double cva = double.Parse(tb_cva.Text);
            double cfp = double.Parse(tb_cfp.Text);
            double q;

            q = (cfa - cfp) / (cvp - cva);

            list_Q.Items.Add($"La quantità di {descrizione} è {Math.Round(q)}");
        }
    }
}