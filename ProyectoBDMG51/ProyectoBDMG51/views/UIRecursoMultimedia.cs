using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBDMG51.controllers;
using ProyectoBDMG51.models;

namespace ProyectoBDMG51.views
{
    public partial class UIRecursoMultimedia : Form
    {
        string rutaRecurso;
        public UIRecursoMultimedia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tituloRecurso = textBox1.Text;
            string descripcionRecurso = textBox3.Text;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rutaRecurso = openFileDialog1.FileName;
                    Console.WriteLine("Name File " + rutaRecurso);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowRM_Click(object sender, EventArgs e)
        {
            string tituloRecurso = textBox2.Text;
            ControllerAsignaturas objectCA = new ControllerAsignaturas();
            BindingSource consulta = objectCA.SelectAsignatura();
            ControllerEstudiante objectCE = new ControllerEstudiante();
            _ = objectCE.SelectEstudiante();
            ControllerDocente objectCD = new ControllerDocente();
            _ = objectCD.SelectDocente();
            ControllerComentarioEstudiante objectCCE = new ControllerComentarioEstudiante();
            _ = objectCCE.SelectComentarioEstudiante();
            ControllerComentarioDocente objectCCD = new ControllerComentarioDocente();
            _ = objectCCD.SelectComentarioDocente();
            dataGridView1.DataSource = consulta;
        }
    }
}
