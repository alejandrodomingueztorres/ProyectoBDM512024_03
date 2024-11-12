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
    class Comentario_estudiante
    {
        private int idComentarioE;
        private string contenidoComentarioE;
        private string fechaComentarioE;
        private int idRecursoMFK;
        private int idEstudianteFK;
        ConnectionBD objConnection = new ConnectionBD();

        public Comentario_estudiante()
        {
        }

        public Comentario_estudiante(string contenidoComentarioE, int idRecursoMFK, int idEstudianteFK)
        {
            this.contenidoComentarioE = contenidoComentarioE;
            this.idRecursoMFK = idRecursoMFK;
            this.idEstudianteFK = idEstudianteFK;
        }

        internal BindingSource SelectComentarioDocente(string sql)
        {
            BindingSource consulta = new BindingSource();

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

        public Comentario_estudiante(int idComentarioE, string contenidoComentarioE, string fechaComentarioE, int idRecursoMFK, int idEstudianteFK)
        {
            this.idComentarioE = idComentarioE;
            this.contenidoComentarioE = contenidoComentarioE;
            this.fechaComentarioE = fechaComentarioE;
            this.idRecursoMFK = idRecursoMFK;
            this.idEstudianteFK = idEstudianteFK;
        }

        public int IdComentarioE { get => idComentarioE; set => idComentarioE = value; }
        public string ContenidoComentarioE { get => contenidoComentarioE; set => contenidoComentarioE = value; }
        public string FechaComentarioE { get => fechaComentarioE; set => fechaComentarioE = value; }
        public int IdRecursoMFK { get => idRecursoMFK; set => idRecursoMFK = value; }
        public int IdEstudianteFK { get => idEstudianteFK; set => idEstudianteFK = value; }
    }
}
