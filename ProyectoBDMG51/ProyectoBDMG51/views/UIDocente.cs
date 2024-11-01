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
    public partial class UIDocente : Form
    {
        public UIDocente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreDocente1 = textBox1.Text;
            string apellidoDocente1 = textBox2.Text;
            string identificacionDocente = textBox3.Text;
            string correoD = textBox4.Text;
            string password = textBox5.Text;

        }
    }
}
