using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBDMG51.models;

namespace ProyectoBDMG51.controllers
{
    class ControllerTipoRecurso
    {
        public bool InsertTipoRecurso(TipoRecurso objTR)
        {
            bool resultado = false;

            string sql = "insert into tipo_recursos(tipoRecurso) values ('" + objTR.TipoRecurso + "')";
            ConnectionBD objCBD = new ConnectionBD();
            resultado = objCBD.ExecuteQuery(sql);
            return resultado;
        }
    }
}
