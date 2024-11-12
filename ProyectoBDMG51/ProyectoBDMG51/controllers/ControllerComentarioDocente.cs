using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBDMG51.models;

namespace ProyectoBDMG51.controllers
{
    class ControllerComentarioDocente
    {

        internal BindingSource SelectComentarioDocente()
        {
            BindingSource consulta = null;
            string sql = "select concat(contenidoComentarioD, '') as 'Name ComentariosDocentes'," + " " +
                "from comentario_docente cd";
            Comentario_docente objComentarioDocente = new Comentario_docente();
            consulta = objComentarioDocente.SelectComentarioDocente(sql);

            return consulta;
        }

        public bool InsertComentarioDocente(Comentario_docente objCD)
        {
            bool resultado = false;

            string sql = "insert into comentario_docente(contenidoComentarioD, idRecursoMFK, idDocenteFK) values ('" +
            objCD.ContenidoComentarioD + "','" + objCD.IdRecursoMFK + "','" + objCD.IdDocenteFK + "')";
            ConnectionBD objCBD = new ConnectionBD();
            resultado = objCBD.ExecuteQuery(sql);
            return resultado;
        }
        public List<Comentario_docente> ReadComentariosDocente(Recurso_multimedia objM)
        {
            List<Comentario_docente> Lista = new List<Comentario_docente>();

            int idRecursoMFK = objM.IdRecursoM;
            string sql = "SELECT idComentarioE, contenidoComentarioE, fechaComentarioE, idRecursoMFK, idEstudianteFK " +
                     "FROM ComentariosDocente ";

            ConnectionBD objCBD = new ConnectionBD();
            Lista = objCBD.ReaderComentariosD(sql, idRecursoMFK);

            return Lista;
        }
    }
}
