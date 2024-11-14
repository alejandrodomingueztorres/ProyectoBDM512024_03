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
        int idAsignatura;
        int idDocente;
        int idTipoRecurso;
        int idEstudiante;
        int rol;

        
        List<string> asignaturas;
        public UIRecursoMultimedia(int id, int rol)
        {
            InitializeComponent();
            if (rol == 1)
            {
                idDocente = id;
                label10.Text = "Docente";
            }
            else
            {
                idEstudiante = id;
                label10.Text = "Estudiante";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tituloRecurso = textBox1.Text;
            string descripcionRecurso = textBox3.Text;
            string archivoRecurso = textBox4.Text;
            ControllerRecursoMultimedia objCRM = new ControllerRecursoMultimedia();
            Recurso_multimedia objRM = new Recurso_multimedia(tituloRecurso, descripcionRecurso, archivoRecurso, idDocente, idEstudiante, idAsignatura, idTipoRecurso);
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
            int index = comboBox3.SelectedIndex;
            index = comboBox4.SelectedIndex;
            idAsignatura = (int)comboBox4.SelectedItem;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            index = comboBox2.SelectedIndex;
            idDocente = (int)comboBox2.SelectedIndex;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox5.SelectedIndex;
            index = comboBox6.SelectedIndex;
            idTipoRecurso = (int)comboBox6.SelectedIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControllerAsignaturas objA = new ControllerAsignaturas();
            comboBox1.DataSource = objA.ListarAsignaturas(textBox5.Text);
            comboBox2.DataSource = objA.obtenerId(textBox5.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ControllerDocente objD = new ControllerDocente();
            comboBox3.DataSource = objD.ListarDocente(textBox6.Text);
            comboBox4.DataSource = objD.obtenerId(textBox6.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ControllerTipoRecurso objCTR = new ControllerTipoRecurso();
            comboBox5.DataSource = objCTR.ListarTiposRecurso(textBox7.Text);
            comboBox6.DataSource = objCTR.obtenerId(textBox7.Text);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
