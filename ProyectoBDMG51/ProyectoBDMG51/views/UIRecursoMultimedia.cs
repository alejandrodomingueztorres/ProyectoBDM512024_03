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
        public UIRecursoMultimedia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tituloRecurso = textBox1.Text;
            string descripcionRecurso = textBox2.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
