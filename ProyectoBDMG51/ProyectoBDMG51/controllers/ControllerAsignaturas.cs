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
            BindingSource consulta = null;
            string sql = "select concat(a.nombreAsignatura, '') as 'Name Asignatura'," + " " +
                "from asignaturas a";
            Asignaturas objAsignaturas = new Asignaturas();
            consulta = objAsignaturas.SelectAsignatura(sql);

            return consulta;
        }
        public bool InsertAsignatura(Asignaturas objA){
            bool resultado = false;

            string sql = "insert into asignaturas(nombreAsignatura) values ('" + objA.NombreAsignatura +  "')";
            ConnectionBD objCBD = new ConnectionBD();
            resultado= objCBD.ExecuteQuery(sql);
            return resultado;


        }
    }

    
}
