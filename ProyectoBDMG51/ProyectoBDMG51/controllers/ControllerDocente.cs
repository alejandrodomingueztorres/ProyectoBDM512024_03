using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBDMG51.models;

namespace ProyectoBDMG51.controllers
{
    class ControllerDocente
    {
        internal BindingSource SelectDocente()
        {
            BindingSource consulta = null;
            string sql = "select concat(d.nombreDocente1, '', d.apellidoDocente1) as 'Name Docentes'," + " " +
                "from docente d";
            Docente objDocente = new Docente();
            consulta = objDocente.SelectDocente(sql);

            return consulta;
        }



        public bool InsertDocente(Docente objD){
            bool resultado = false;

            string sql = "insert into docente(nombreDocente1, nombreDocente2, apellidoDocente1, apellidoDocente2, identificacionDocente, correoD, passwordD) values ('" + 
            objD.NombreDocente1 + "','"+ objD.NombreDocente2 + "','" + objD.ApellidoDocente1 + "','" + objD.ApellidoDocente2 + "','" + objD.IdentificacionDocente +
            "','" + objD.CorreoD + "','" + objD.PasswordD + "')";
            ConnectionBD objCBD = new ConnectionBD();
            resultado= objCBD.ExecuteQuery(sql);
            return resultado;
        }
        public int LoginDocente(Docente objD)
        {
            int resultado = 0;

            string sql = "select * from docente where correo =" + objD.CorreoD;
            ConnectionBD objCBD = new ConnectionBD();
            resultado = objCBD.Login(sql, objD.PasswordD, "idDocente");

            return resultado;
        }
        public List<string> ListarDocente(string filtro)
        {
            string sql = "SELECT nombreDocente1 FROM docente";
            ConnectionBD objCBD = new ConnectionBD();
            List<string> lista = objCBD.ObtenerLista(sql, "nombreDocente1", filtro);
            return lista;
        }
        public List<int> obtenerId(string filtro)
        {
            string sql = "SELECT idDocente FROM docente";
            ConnectionBD objCBD = new ConnectionBD();
            List<int> lista = objCBD.ObtenerId(sql, "idEstudiante", filtro);

            return lista;
        }

    }
}
