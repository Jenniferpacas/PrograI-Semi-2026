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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double sueldo = Double.Parse(txtsueldo.Text);

            double isss = 0;
            double afp = 0;
            double isr = 0;
            double total = 0;
            double sueldoNeto = 0;


            // ISSS 3%
            isss = sueldo * 0.03;

            // AFP 5.62%
            afp = sueldo * 0.0562;

            // ISR 7.25%
            isr = sueldo * 0.0725;

            // Total de deducciones
            total = isss + afp + isr;

            // Sueldo neto
            sueldoNeto = sueldo - total;
            // Mostrar resultados
            txtISSS.Text = "$ " + Math.Round(isss, 2);
            txtAFP.Text = "$ " + Math.Round(afp, 2);
            txtISR.Text = "$ " + Math.Round(isr, 2);
            txtTOTAL.Text = "$ " + Math.Round(total, 2);
            txtSueldoNeto.Text = "$ " + Math.Round(sueldoNeto, 2);


        }
    }
}
