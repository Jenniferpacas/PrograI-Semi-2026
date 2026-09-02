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


        /*
    Pie Cuadrado
    Vara Cuadrada
    Yarda Cuadrada
    Metro Cuadrado
    Tareas
    Manzana
    Hectárea
         */

    Double[] valores={0.092903,0.698896,0.836127,1,437.5,6988.96,10000};
    private void Form1_Load(object sender, EventArgs e)
    {

    }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int de = cboDe .SelectedIndex, a = cboA.SelectedIndex;

            double cantidad = Double.Parse(txtTotal .Text);

            double respuesta = valores[a] / valores[de] * cantidad;

            lblResouesta.Text = "Respuesta: " + Math.Round(respuesta, 4).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
