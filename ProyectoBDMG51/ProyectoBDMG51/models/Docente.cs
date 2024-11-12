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
    class Docente
    {
        private int idDocente;
        private string nombreDocente1;
        private string nombreDocente2;
        private string apellidoDocente1;
        private string apellidoDocente2;
        private string identificacionDocente;
        private string correoD;
        private string passwordD;
        ConnectionBD objConnection = new ConnectionBD();

        public Docente()
        {
        }

        public Docente(string correoD, string passwordD)
        {
            this.correoD = correoD;
            this.passwordD = passwordD;
        }

        internal BindingSource SelectDocente(string sql)
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

            }
            catch (Exception w)
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

        public Docente(string nombreDocente1, string nombreDocente2, string apellidoDocente1, string apellidoDocente2, string identificacionDocente, string correoD, string passwordD)
        {
            this.nombreDocente1 = nombreDocente1;
            this.nombreDocente2 = nombreDocente2;
            this.apellidoDocente1 = apellidoDocente1;
            this.apellidoDocente2 = apellidoDocente2;
            this.identificacionDocente = identificacionDocente;
            this.correoD = correoD;
            this.passwordD = passwordD;
        }

        public Docente(int idDocente, string nombreDocente1, string nombreDocente2, string apellidoDocente1, string apellidoDocente2, string identificacionDocente, string correoD, string passwordD)
        {
            this.idDocente = idDocente;
            this.nombreDocente1 = nombreDocente1;
            this.nombreDocente2 = nombreDocente2;
            this.apellidoDocente1 = apellidoDocente1;
            this.apellidoDocente2 = apellidoDocente2;
            this.identificacionDocente = identificacionDocente;
            this.correoD = correoD;
            this.passwordD = passwordD;
        }

        public int IdDocente { get => idDocente; set => idDocente = value; }
        public string NombreDocente1 { get => nombreDocente1; set => nombreDocente1 = value; }
        public string NombreDocente2 { get => nombreDocente2; set => nombreDocente2 = value; }
        public string ApellidoDocente1 { get => apellidoDocente1; set => apellidoDocente1 = value; }
        public string ApellidoDocente2 { get => apellidoDocente2; set => apellidoDocente2 = value; }
        public string IdentificacionDocente { get => identificacionDocente; set => identificacionDocente = value; }
        public string CorreoD { get => correoD; set => correoD = value; }
        public string PasswordD { get => passwordD; set => passwordD = value; }
    }
}
