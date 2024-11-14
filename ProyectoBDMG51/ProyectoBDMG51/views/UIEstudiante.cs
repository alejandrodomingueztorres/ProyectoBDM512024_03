using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBDMG51.models;
using ProyectoBDMG51.controllers;

namespace ProyectoBDMG51.views
{
    public partial class UIEstudiante : Form
    {
        public UIEstudiante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreEstudiante1 = textBox1.Text;
            string nombreEstudiante2 = textBox2.Text;
            string apellidoEstudiante1 = textBox3.Text;
            string apellidoEstudiante2 = textBox4.Text;
            string correoE = textBox5.Text;
            string identificacionE = textBox6.Text;
            string passwordE = textBox7.Text;

            Estudiante objE = new Estudiante(nombreEstudiante1, nombreEstudiante2, apellidoEstudiante1, apellidoEstudiante2, correoE, identificacionE, passwordE);
            ControllerEstudiante objCE = new ControllerEstudiante();
            bool resultado = objCE.InsertEstudiante(objE);

            if (resultado)
            {
                MessageBox.Show("Se insertó correctamente");
            }
            else
            {
                MessageBox.Show("No se ha podido insertar");
            }
        }

        private void UIEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void ShowE_Click(object sender, EventArgs e)
        {

        }
    }
}
