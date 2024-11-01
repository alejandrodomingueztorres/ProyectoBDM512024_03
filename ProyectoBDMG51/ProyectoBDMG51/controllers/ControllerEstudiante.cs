using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBDMG51.models;

namespace ProyectoBDMG51.controllers
{
    class ControllerEstudiante
    {
        bool InsertEstudiante(Estudiante objE){
        bool resultado=false

            string sql = "insert into estudiante(nombreEstudiante1, nombreEstudiante2, apellidoEstudiante1, apellidoEstudiante2, identificacionE, correoE, passwordE) values ('" + 
            objE.nombreEstudiante1 + "','"+ objE.nombreEstudiante2 + "','" + objE.apellidoEstudiante1 + "','" + objE.apellidoEstudiante2 + "','" + objE.identificacionE +
            "','" + objE.correoE + "','" + objE.passwordE + "')";
            ConnectionBD objCBD = new ConnectionBD();
            resultado= objCBD.ExecuteQuery(sql);
            return resultado;
        }
    }
}
