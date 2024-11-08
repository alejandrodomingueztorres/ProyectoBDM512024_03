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
    public partial class UIAsignaturas : Form
    {
        public UIAsignaturas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreAsignatura = textBox1.Text;

            Asignaturas objA = new Asignaturas(nombreAsignatura);
            ControllerAsignaturas objCA = new ControllerAsignaturas();
            bool resultado = objCA.InsertAsignatura(objA);

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
