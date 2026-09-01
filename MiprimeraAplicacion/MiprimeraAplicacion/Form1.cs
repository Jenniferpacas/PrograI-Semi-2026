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
            cboPrioridad.Items.Add("Dolor de pecho");
            cboPrioridad.Items.Add("Dificultad para respirar");
            cboPrioridad.Items.Add("Hemorragia severa");
            cboPrioridad.Items.Add("Dolor moderado");
            cboPrioridad.Items.Add("Fiebre");
            cboPrioridad.Items.Add("Dolor leve");

        }

        private void btnCalcular_Click_2(object sender, EventArgs e)
        {
        }

        private void btnClasificar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                int edad = int.Parse(txtEdad.Text);

                int opcion = cboPrioridad.SelectedIndex;

                int prioridad = 0;
                string clasificacion = "";
                string tiempo = "";

                if (opcion == -1)
                {
                    MessageBox.Show("Seleccione el síntoma del paciente"); return;
                }

                if (opcion == 0 || opcion == 1 || opcion == 2)
                {
                    prioridad = 1; clasificacion = "EMERGENCIA"; tiempo = "Atención inmediata";
                }
                else if (opcion == 3)
                {
                    prioridad = 2; clasificacion = "URGENTE"; tiempo = "Atención en menos de 15 minutos";
                }
                else if (opcion == 4)
                {
                    prioridad = 3; clasificacion = "MENOS URGENTE"; tiempo = "Atención en menos de 30 minutos";
                }
                else if (opcion == 5)
                {
                    prioridad = 4; clasificacion = "NO URGENTE"; tiempo = "Puede esperar";
                }
                ltsRespuesta.Items.Clear();

                ltsRespuesta.Items.Add("GESTIÓN DE TIEMPO - TRIAGE");
                ltsRespuesta.Items.Add("--------------------------------");
                ltsRespuesta.Items.Add("Paciente: " + nombre);
                ltsRespuesta.Items.Add("Edad: " + edad);
                ltsRespuesta.Items.Add("Síntoma: " + cboPrioridad.Text);
                ltsRespuesta.Items.Add("Prioridad: " + prioridad);
                ltsRespuesta.Items.Add("Clasificación: " + clasificacion);
                ltsRespuesta.Items.Add("Tiempo de atención: " + tiempo);
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor ingrese los datos correctamente");
            }
            }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear(); txtEdad.Clear(); cboPrioridad .SelectedIndex = -1; ltsRespuesta.Items.Clear(); txtSintomas.Clear();
        }
    }
}
