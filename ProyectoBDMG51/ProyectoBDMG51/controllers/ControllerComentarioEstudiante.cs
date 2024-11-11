using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBDMG51.models;

namespace ProyectoBDMG51.controllers
{
    class ControllerComentarioEstudiante
    {
        public bool InsertComentarioEstudiante(Comentario_estudiante objCE)
        {
            bool resultado = false;

            string sql = "insert into comentario_estudiante(contenidoComentarioE, idRecursoMFK, idEstudianteFK) values ('" +
            objCE.ContenidoComentarioE + "','" + objCE.IdRecursoMFK + "','" + objCE.IdEstudianteFK + "')";
            ConnectionBD objCBD = new ConnectionBD();
            resultado = objCBD.ExecuteQuery(sql);
            return resultado;
        }
    }
}
