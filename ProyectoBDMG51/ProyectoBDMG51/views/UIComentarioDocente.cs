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
    public partial class UIComentarioDocente : Form
    {
        public UIComentarioDocente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contenidoComentarioD = textBox1.Text;
            string fechaComentarioD = textBox2.Text; 
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
