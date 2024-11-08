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
    public partial class UITipoRecurso : Form
    {
        public UITipoRecurso()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InsertTR_Click(object sender, EventArgs e)
        {
            string nombreTR = textBox1.Text;

            TipoRecurso objTR = new TipoRecurso(nombreTR);
            ControllerTipoRecurso objCTR = new ControllerTipoRecurso();
            bool resultado = objCTR.InsertTipoRecurso(objTR);

            if (resultado)
            {
                MessageBox.Show("Se insertó correctamente");
            }
            else
            {
                MessageBox.Show("No se ha podido insertar");
            }
        }
    }
}
