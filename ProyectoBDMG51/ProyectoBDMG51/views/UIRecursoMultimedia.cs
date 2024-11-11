using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string descripcionRecurso = textBox2.Text;
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
    }
}
