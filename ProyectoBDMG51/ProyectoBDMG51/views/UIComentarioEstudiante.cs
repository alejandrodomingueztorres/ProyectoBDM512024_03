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
    public partial class UIComentarioEstudiante : Form
    {
        public UIComentarioEstudiante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contenidoComentarioE = textBox1.Text;
            string fechaComentarioE = textBox2.Text;
        }
    }
}
