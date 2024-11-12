using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBDMG51.models;

namespace ProyectoBDMG51.controllers
{
    class ControllerComentarioEstudiante
    {

        internal BindingSource SelectComentarioEstudiante()
        {
            BindingSource consulta = null;
            string sql = "select concat(contenidoComentarioE, '') as 'Name ComentariosEstudiantes'," + " " +
                "from comentario_estudiante ce";
            Comentario_estudiante objComentarioEstudiante = new Comentario_estudiante();
            consulta = objComentarioEstudiante.SelectComentarioDocente(sql);

            return consulta;
        }

        public bool InsertComentarioEstudiante(Comentario_estudiante objCE)
        {
            bool resultado = false;

            string sql = "insert into comentario_estudiante(contenidoComentarioE, idRecursoMFK, idEstudianteFK) values ('" +
            objCE.ContenidoComentarioE + "','" + objCE.IdRecursoMFK + "','" + objCE.IdEstudianteFK + "')";
            ConnectionBD objCBD = new ConnectionBD();
            resultado = objCBD.ExecuteQuery(sql);
            return resultado;
        }

        public string ReadComentariosEstudiante(Recurso_multimedia objM)
        {
            string resultado = "";

            int idRecursoMFK = objM.IdRecursoM;
            string sql = "SELECT idComentarioE, contenidoComentarioE, fechaComentarioE, idRecursoMFK, idEstudianteFK " +
                     "FROM ComentariosEstudiantes ";

            ConnectionBD objCBD = new ConnectionBD();
            resultado = objCBD.ReaderComms(sql, idRecursoMFK);

            return resultado;
        }
    }
}
