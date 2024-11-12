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
    class Comentario_docente
    {
        private int idComentarioD;
        private string contenidoComentarioD;
        private DateTime fechaComentarioD;
        private int idRecursoMFK;
        private int idDocenteFK;
        ConnectionBD objConnection = new ConnectionBD();

        public Comentario_docente()
        {
        }

        public Comentario_docente(string contenidoComentarioD, int idRecursoMFK, int idDocenteFK)
        {
            this.contenidoComentarioD = contenidoComentarioD;
            this.idRecursoMFK = idRecursoMFK;
            this.idDocenteFK = idDocenteFK;
        }

        internal BindingSource SelectComentarioDocente(string sql)
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

        private BindingSource BindingSource()
        {
            throw new NotImplementedException();
        }

        public Comentario_docente(int idComentarioD, string contenidoComentarioD, DateTime fechaComentarioD, int idRecursoMFK, int idDocenteFK)
        {
            this.idComentarioD = idComentarioD;
            this.contenidoComentarioD = contenidoComentarioD;
            this.fechaComentarioD = fechaComentarioD;
            this.idRecursoMFK = idRecursoMFK;
            this.idDocenteFK = idDocenteFK;
        }

        public int IdComentarioD { get => idComentarioD; set => idComentarioD = value; }
        public string ContenidoComentarioD { get => contenidoComentarioD; set => contenidoComentarioD = value; }
        public DateTime FechaComentarioD { get => fechaComentarioD; set => fechaComentarioD = value; }
        public int IdRecursoMFK { get => idRecursoMFK; set => idRecursoMFK = value; }
        public int IdDocenteFK { get => idDocenteFK; set => idDocenteFK = value; }
    }
}
