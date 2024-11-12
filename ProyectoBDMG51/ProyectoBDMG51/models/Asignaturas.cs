using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDMG51.models
{
    class Asignaturas
    {
        private int idAsignatura;
        private string nombreAsignatura;
        ConnectionBD objConnection = new ConnectionBD();

        public Asignaturas()
        {
        }

        public Asignaturas(string nombreAsignatura)
        {
            this.nombreAsignatura = nombreAsignatura;
        }

        public Asignaturas(int idAsignatura, string nombreAsignatura)
        {
            this.idAsignatura = idAsignatura;
            this.nombreAsignatura = nombreAsignatura;
        }

        internal BindingSource SelectAsignatura(string sql)
        {
            BindingSource consulta = BindingSource();
            
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, objConnection.DataSource());
                objConnection.ConnectOpened();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                consulta.DataSource = dt; 

            } catch (Exception w)
            {
                Console.WriteLine("ERROOOOOOR" + w.Message);
                objConnection.ConnectClosed();
            }
            finally
            {
                objConnection.ConnectClosed();
            }

            return consulta;

        }

        public int IdAsignatura { get => idAsignatura; set => idAsignatura = value; }
        public string NombreAsignatura { get => nombreAsignatura; set => nombreAsignatura = value; }
    }
}
