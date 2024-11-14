using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBDMG51.models;

namespace ProyectoBDMG51.controllers
{
    class ControllerAsignaturas
    {
        internal BindingSource SelectAsignatura()
        {
            BindingSource consulta = new BindingSource();
            string sql = "SELECT a.nombreAsignatura AS 'Nombre Asignatura' FROM asignaturas a";
            Asignaturas objAsignaturas = new Asignaturas();
            consulta.DataSource = objAsignaturas.SelectAsignatura(sql);

            return consulta;
        }
        public bool InsertAsignatura(Asignaturas objA){
            bool resultado = false;

            string sql = "insert into asignaturas(nombreAsignatura) values ('" + objA.NombreAsignatura +  "')";
            ConnectionBD objCBD = new ConnectionBD();
            resultado= objCBD.ExecuteQuery(sql);
            return resultado;


        }
        public List<string> ListarAsignaturas(string filtro)
        {
            string sql = "SELECT nombreAsignatura FROM Asignaturas";
            ConnectionBD objCBD = new ConnectionBD();
            List<string> lista = objCBD.ObtenerLista(sql, "nombreAsignatura", filtro);
            return lista;
        }
        public List<int> obtenerId(string filtro)
        {
            string sql = "SELECT idAsignatura FROM Asignaturas";
            ConnectionBD objCBD = new ConnectionBD();
            List<int> lista = objCBD.ObtenerId(sql, "idAsignatura", filtro);

            return lista;
        }
    }

    
}
