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
        public UIDocente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreDocente1 = textBox1.Text;
            string nombreDocente2 = textBox2.Text;
            string apellidoDocente1 = textBox3.Text;
            string apellidoDocente2 = textBox4.Text;
            string identificacionDocente = textBox5.Text;
            string correoD = textBox6.Text;
            string password = textBox7.Text;

            Docente objD = new Docente(nombreDocente1, nombreDocente2, apellidoDocente1, apellidoDocente2, identificacionDocente, correoD, password);
            ControllerDocente objCD = new ControllerDocente();
            bool resultado = objCD.InsertDocente(objD);
            if (resultado)
            {
                MessageBox.Show("Se insertó correctamente");
            }
            else
            {
                MessageBox.Show("No se ha podido insertar");
            }

        }
    }
}
