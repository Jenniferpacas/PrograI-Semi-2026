using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiprimeraAplicacion
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

        private void btnCalcular_Click_2(object sender, EventArgs e)
        {
        }

        private void lblValor_Click(object sender, EventArgs e)
        {

        }

        private void lblMetros_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double metros = Double.Parse(txtMetros.Text);
                double tarifa = 0.210;
                double alcantarillado = 0.10;

                double consumo = metros * tarifa;
                double total = consumo + alcantarillado;

                txtVolumen.Text = metros.ToString();
                txtTarifa.Text = tarifa.ToString("0.000");
                txtConsumo.Text = consumo.ToString("0.00");
                txtAlcantarillado.Text = alcantarillado.ToString("0.00");
                txtValor.Text = total.ToString("0.00");
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor ingrese los metros consumidos correctamente");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMetros.Clear();
            txtVolumen.Clear();
            txtTarifa.Clear();
            txtConsumo.Clear();
            txtAlcantarillado.Clear();
            txtValor.Clear();
        }
    }
}
