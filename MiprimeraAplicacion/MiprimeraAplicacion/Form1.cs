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
    public partial class Conversores : Form
    {
        public Conversores()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
        Monedas
        Longitud
        Masa
        Volumen
        Almacenamiento
        Tiempo
        Area
        */
        }


        String[][] etiquetas = {
    new string[]{"Dolar", "Quetzal", "Lempira", "Cordobas", "Colon CR",
                 "Peso Mexicano", "Peso Colombiano", "Sol Peruano",
                 "Euro", "Libra Esterlina"},

    new string[]{"Metros", "Cm", "Pulgadas", "Pies", "Varas",
                 "Yardas", "Km", "Millas", "Milimetros", "Micrometros"},

    new string[]{"Kilogramo", "Gramo", "Miligramo", "Libra", "Onza",
                 "Tonelada", "Microgramo", "Quintal", "Stone", "Tonelada Corta"},

    new string[]{"Litro", "Mililitro", "Galon", "Metro Cubico",
                 "Centimetro Cubico", "Pinta", "Cuarto", "Taza",
                 "Cucharada", "Cucharadita"},

    new string[]{"Bit", "Byte", "Kilobyte", "Megabyte", "Gigabyte",
                 "Terabyte", "Petabyte", "Kibibyte", "Mebibyte", "Gibibyte"},

    new string[]{"Segundo", "Minuto", "Hora", "Dia", "Semana",
                 "Mes", "Año", "Milisegundo", "Microsegundo", "Decada"},

    new string[]{"Metro Cuadrado", "Centimetro Cuadrado",
                 "Kilometro Cuadrado", "Pie Cuadrado", "Pulgada Cuadrada",
                 "Hectarea", "Acre", "Milimetro Cuadrado",
                 "Yarda Cuadrada", "Milla Cuadrada"}
};
Double[][] valores = {
    
    new double[]{ 1, 18.78, 7.66, 26.15, 8.75, 36.78, 504.12, 0.86, 147.50, 0.74}, // Monedas

    new double[]{ 1, 100, 39.3701, 3.28084, 1.1963, 1.09361, 0.001, 0.000621371, 1000000, 1000000000}, // Longitud

    new double[]{1, 16, 453.592, 0.453592, 0.01, 0.001, 0.0005, 0.00000220462, 0.00000000220462, 0.000453592}, // Masa

    new double[]{1, 3.78541, 8, 3785.41, 128, 16, 256, 768, 0.00378541, 3785.41}, // Volumen

    new double[]{1, 8e+9, 1e+9, 1e+6, 1000, 0.001, 2e+9, 1e-6, 1e-9, 1e-12}, // Almacenamiento

    new double[]{1, 86400, 1440, 24, 0.142857, 0.0328767, 0.00273973, 86400000, 0.0666667, 0.000273973}, // Tiempo

    new double[]{1, 1e+6, 0.386102, 1.196e+6, 1.076e+7, 1.55e+9, 100, 1, 10000, 4046.86} // Area
    };
  private void btnConvertir_Click(object sender, EventArgs e)
        {
            int de = cboDeConversor.SelectedIndex;
            int a = cboAConversor.SelectedIndex;
            int opcion = cboTipoConversor.SelectedIndex;

            double cantidad = Double.Parse(txtCantidadConversor.Text);
            double respuesta = valores[opcion][a] / valores[opcion][de] * cantidad;
            lblRespuestaConversor.Text = respuesta.ToString();
        }

        private void cboTipoConversor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpiamos los valores anteriores
            cboDeConversor.Items.Clear();
            cboAConversor.Items.Clear();

            //Asignamos los nuevos valores
            int opcion = cboTipoConversor.SelectedIndex;

            cboDeConversor.Items.AddRange(etiquetas[opcion]);
            cboAConversor.Items.AddRange(etiquetas[opcion]);

        }
    }
}
