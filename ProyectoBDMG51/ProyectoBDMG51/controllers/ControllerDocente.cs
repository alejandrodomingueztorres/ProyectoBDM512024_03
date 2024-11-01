using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBDMG51.models

namespace ProyectoBDMG51.controllers
{
    class ControllerDocente
    {
        bool InsertDocente(Docente objD){
        bool resultado=false

            string sql = "insert into Docente(nombreDocente, nombreDocente2, apellidoDocente1, apellidoDocente2, identificacionDocente, correoD, passwordD) values ('" + 
            objD.nombreDocente + "','"+ objD.nombreDocente2 + "','" + objD.apellidoDocente1 + "','" + objD.apellidoDocente2 + "','" + objD.identificacionDocente +
            "','" + objD.correoD + "','" + objD.passwordD + "')";
            ConnectionBD objCBD = new ConnectionBD();
            resultado= objCBD.ExecuteQuery(sql);
            return resultado;
        }
        private string nombreDocente1;
        private string nombreDocente2;
        private string apellidoDocente1;
        private string apellidoDocente2;
        private string identificacionDocente;
        private string correoD;
        private string passwordD;
    }
}
