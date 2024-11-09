using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBDMG51.models;

namespace ProyectoBDMG51.controllers
{
    class ControllerDocente
    {
        public bool InsertDocente(Docente objD){
            bool resultado = false;

            string sql = "insert into docente(nombreDocente, nombreDocente2, apellidoDocente1, apellidoDocente2, identificacionDocente, correoD, passwordD) values ('" + 
            objD.NombreDocente1 + "','"+ objD.NombreDocente2 + "','" + objD.ApellidoDocente1 + "','" + objD.ApellidoDocente2 + "','" + objD.IdentificacionDocente +
            "','" + objD.CorreoD + "','" + objD.PasswordD + "')";
            ConnectionBD objCBD = new ConnectionBD();
            resultado= objCBD.ExecuteQuery(sql);
            return resultado;
        }
        public bool LoginDocente(Docente objD)
        {
            bool resultado = false;

            string sql = "select * from docente where correo =" + objD.CorreoD;
            ConnectionBD objCBD = new ConnectionBD();
            resultado = objCBD.Login(sql, objD.PasswordD);

            return resultado;
        }
    }
}
