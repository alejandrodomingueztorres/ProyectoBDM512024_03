using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBDMG51.models;

namespace ProyectoBDMG51.controllers
{
    class ControllerComentarioDocente
    {
        public bool InsertComentarioDocente(Comentario_docente objCD)
        {
            bool resultado = false;

            string sql = "insert into comentario_docente(contenidoComentarioD, idRecursoMFK, idDocenteFK) values ('" +
            objCD.ContenidoComentarioD + "','" + objCD.IdRecursoMFK + "','" + objCD.IdDocenteFK + "')";
            ConnectionBD objCBD = new ConnectionBD();
            resultado = objCBD.ExecuteQuery(sql);
            return resultado;
        }
    }
}
