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
    public partial class UIDocente : Form
    {
        int rol;
        public UIDocente()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string nombre1 = textBox1.Text;
            string nombre2 = textBox2.Text;
            string apellido1 = textBox3.Text;
            string apellido2 = textBox4.Text;
            string identificacion = textBox5.Text;
            string correo = textBox6.Text;
            string password = textBox7.Text;
            bool resultado = false;

            if (string.IsNullOrEmpty(nombre1) || string.IsNullOrEmpty(apellido1) || string.IsNullOrEmpty(identificacion) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor ingrese datos");
            }

            if (radioButton1.Checked)
            {
                rol = 1;
            }
            if (radioButton2.Checked)
            {
                rol = 2;
            }
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                switch (rol)
                {
                    case 1:
                        Docente objD = new Docente(nombre1, nombre2, apellido1, apellido2, identificacion, correo, password);
                        ControllerDocente objCD = new ControllerDocente();
                        resultado = objCD.InsertDocente(objD);
                        break;
                    case 2:
                        Estudiante objE = new Estudiante(nombre1, nombre2, apellido1, apellido2, identificacion, correo, password);
                        ControllerEstudiante objCE = new ControllerEstudiante();
                        resultado = objCE.InsertEstudiante(objE);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un rol");
            }
            if (resultado)
            {
                MessageBox.Show("Se insertó correctamente");
            }
            else
            {
                MessageBox.Show("No se ha podido insertar");
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ShowD_Click(object sender, EventArgs e)
        {
            string correo = textBox8.Text;
            string password = textBox9.Text;
            bool resultado;
            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor ingrese su correo y contraseña.");
            }
            if (radioButton3.Checked)
            {
                rol = 1;
            }
            if (radioButton4.Checked)
            {
                rol = 2;
            }
            if (!radioButton3.Checked && !radioButton4.Checked)
            {
                resultado = false;
                switch (rol)
                {
                    case 1:
                        Docente objD = new Docente(correo, password);
                        ControllerDocente objCD = new ControllerDocente();
                        resultado = objCD.LoginDocente(objD);
                        break;
                    case 2:
                        Estudiante objE = new Estudiante(correo, password);
                        ControllerEstudiante objCE = new ControllerEstudiante();
                        resultado = objCE.LoginEstudiante(objE);
                        break;
                }
                if (resultado)
                {
                    MessageBox.Show("Se ha ingresado correctamente");
                }
                else
                {
                    MessageBox.Show("No se ha podido ingresar");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un rol");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
