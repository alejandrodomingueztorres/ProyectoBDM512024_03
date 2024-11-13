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
        private ConnectionBD objConnection = new ConnectionBD();

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

       

        
        public DataTable SelectAsignaturaDataTable(string sql, Dictionary<string, object> parameters)
        {
            DataTable dt = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, objConnection.DataSource());

                
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }

                objConnection.ConnectOpened();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                objConnection.ConnectClosed();
            }

            return dt;
        }

        public int IdAsignatura { get => idAsignatura; set => idAsignatura = value; }
        public string NombreAsignatura { get => nombreAsignatura; set => nombreAsignatura = value; }
    }
}
