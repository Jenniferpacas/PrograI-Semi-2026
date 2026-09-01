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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           try
            {
                int n = int.Parse(txtN.Text);
                int acumulado = 0;
                ltsRespuesta.Items.Clear();
                for (int i = 1; i <= n; i++)
                {
                    acumulado += i;
                    ltsRespuesta.Items.Add("Mes " + i + " - Acumulado: " + acumulado);
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Por favor ingrese el número de meses correctamente");
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            ltsRespuesta.Items.Clear();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
