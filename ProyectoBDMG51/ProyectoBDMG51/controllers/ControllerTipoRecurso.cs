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

            string sql = "insert into tipo_recursos(tipoRecurso) values ('" + objTR.TipoRecursos + "')";
            ConnectionBD objCBD = new ConnectionBD();
            resultado = objCBD.ExecuteQuery(sql);
            return resultado;
        }
        public List<string> ListarTiposRecurso(string filtro)
        {
            string sql = "SELECT tipoRecurso FROM tipo_recursos";
            ConnectionBD objCBD = new ConnectionBD();
            List<string> lista = objCBD.ObtenerLista(sql, "tipoRecurso", filtro);
            return lista;
        }
        public List<int> obtenerId(string filtro)
        {
            string sql = "SELECT tipoRecurso FROM tipo_recursos";
            ConnectionBD objCBD = new ConnectionBD();
            List<int> lista = objCBD.ObtenerId(sql, "idTR", filtro);

            return lista;
        }
    }
}
