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
            string archivoRecurso = textBox4.Text;
            ControllerRecursoMultimedia objCRM = new ControllerRecursoMultimedia();
            Recurso_multimedia objRM = new Recurso_multimedia(tituloRecurso, descripcionRecurso, archivoRecurso);
            bool resultado = objCRM.InsertRecursoMultimedia(objRM);
            if (resultado){ MessageBox.Show("Se insertó correctamente");
            } else { MessageBox.Show("No se ha podido insertar"); 
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rutaRecurso = openFileDialog1.FileName;
                    textBox4.Text = rutaRecurso;
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
