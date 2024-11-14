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

        private void Show_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT a.nombreAsignatura AS 'Nombre Asignatura' FROM asignaturas a";

            ControllerAsignaturas controllerAsignaturas = new ControllerAsignaturas();
            BindingSource resultadoConsulta = controllerAsignaturas.SelectAsignatura();

            dgvResultados.DataSource = resultadoConsulta;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UIDocente UID = new UIDocente();
        }
    }
}
