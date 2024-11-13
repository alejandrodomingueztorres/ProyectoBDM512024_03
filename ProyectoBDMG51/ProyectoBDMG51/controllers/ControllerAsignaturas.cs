using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBDMG51.models;


namespace ProyectoBDMG51.controllers
{
    class ControllerAsignaturas
    {
        internal DataTable SelectAsignaturaDataTable(string nombreAsignatura)
        {
            string sql = "SELECT nombreAsignatura AS 'Nombre Asignatura' FROM asignaturas WHERE nombreAsignatura LIKE @nombreAsignatura";

            
            DataTable dt = new DataTable();
            ConnectionBD objCBD = new ConnectionBD();
            Asignaturas objAsignaturas = new Asignaturas();
            dt = objAsignaturas.SelectAsignaturaDataTable(sql, new Dictionary<string, object> {
                {"@nombreAsignatura", "%" + nombreAsignatura + "%"}  
            });

            return dt; 
        }
        public bool InsertAsignatura(Asignaturas objA){
            bool resultado = false;

            string sql = "insert into asignaturas(nombreAsignatura) values ('" + objA.NombreAsignatura +  "')";
            ConnectionBD objCBD = new ConnectionBD();
            resultado= objCBD.ExecuteQuery(sql, new Dictionary<string, object> {
                {"@nombreAsignatura", objA.NombreAsignatura }
            });
            return resultado;


        }
    }

    
}
