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
    public partial class UIEstudiante : Form
    {
        public UIEstudiante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreEstudiante1 = textBox1.Text;
            string apellidoEstudiante1 = textBox2.Text;
            string correoE = textBox3.Text;
            string identificacionE = textBox4.Text;
            string passwordE = textBox5.Text;
        }
    }
}
