using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBDMG51.models;

namespace ProyectoBDMG51.controllers
{
    class ControllerRecursoMultimedia
    {
        public bool InsertRecursoMultimedia(Recurso_multimedia objRM)
        {
            bool resultado = false;

            string sql = "insert into recurso_multimedia(tituloRecurso, descripcionRecurso, archivoRecurso, idDocenteFK, idEstudianteFK, idAsignaturaFK, idTRFK) values ('" +
            objRM.TituloRecurso + "','" + objRM.DescripcionRecurso + "','" + "@archivoRecurso" + "','" + objRM.IdDocenteFK + "','" + objRM.IdEstudianteFK +
            "','" + objRM.IdAsignaturaFK + "','" + objRM.IdTRFK + "')";
            ConnectionBD objCBD = new ConnectionBD();
            resultado = objCBD.ExecuteQuery(sql, objRM.ArchivoRecurso);
            return resultado;
        }
    }
}
