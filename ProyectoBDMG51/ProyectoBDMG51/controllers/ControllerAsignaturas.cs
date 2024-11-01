using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBDMG51.models;
namespace ProyectoBDMG51.controllers
{
    class ControllerAsignaturas
    {
        bool InsertAsignatura(Asignaturas objA){
        bool resultado=false

            string sql = "insert into asignaturas(nombreAsignatura) values ('" + objA.nombreAsignatura +  "')";
            ConnectionBD objCBD = new ConnectionBD();
            resultado= objCBD.ExecuteQuery(sql);
            return resultado;
        }
    }
}
