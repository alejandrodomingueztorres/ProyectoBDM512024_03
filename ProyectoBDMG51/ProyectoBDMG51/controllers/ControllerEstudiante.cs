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
            bool resultado = false;

            string sql = "insert into estudiante(nombreEstudiante1, nombreEstudiante2, apellidoEstudiante1, apellidoEstudiante2, identificacionE, correoE, passwordE) values ('" + 
            objE.NombreEstudiante1 + "','"+ objE.NombreEstudiante2 + "','" + objE.ApellidoEstudiante1 + "','" + objE.ApellidoEstudiante2 + "','" + objE.IdentificacionE +
            "','" + objE.CorreoE + "','" + objE.PasswordE + "')";
            ConnectionBD objCBD = new ConnectionBD();
            resultado= objCBD.ExecuteQuery(sql);
            return resultado;
        }
    }
}
