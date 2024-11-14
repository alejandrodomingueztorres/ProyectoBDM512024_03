using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBDMG51.models;

namespace ProyectoBDMG51.controllers
{
    class ControllerEstudiante
    {
        internal BindingSource SelectEstudiante()
        {
            BindingSource consulta = null;
            string sql = "select concat(e.nombreEstudiante1, '', e.apellidoEstudiante1) as 'Name Estudiante'," + " " +
                "from estudiante e";
            Estudiante objEstudiante = new Estudiante();
            consulta = objEstudiante.SelectEstudiante(sql);

            return consulta;
        }


        public bool InsertEstudiante(Estudiante objE){
            bool resultado = false;

            string sql = "insert into estudiante(nombreEstudiante1, nombreEstudiante2, apellidoEstudiante1, apellidoEstudiante2, identificacionE, correoE, passwordE) values ('" + 
            objE.NombreEstudiante1 + "','"+ objE.NombreEstudiante2 + "','" + objE.ApellidoEstudiante1 + "','" + objE.ApellidoEstudiante2 + "','" + objE.IdentificacionE +
            "','" + objE.CorreoE + "','" + objE.PasswordE + "')";
            ConnectionBD objCBD = new ConnectionBD();
            resultado= objCBD.ExecuteQuery(sql);
            return resultado;
        }

        public int LoginEstudiante(Estudiante objE)
        {
            int resultado = 0;

            string sql = "select * from estudiante where correo =" + objE.CorreoE;
            ConnectionBD objCBD = new ConnectionBD();
            resultado = objCBD.Login(sql, objE.PasswordE, "idEstudiante");

            return resultado;
        }
        public List<string> ListarDocente(string filtro)
        {
            string sql = "SELECT nombreEstudiante1 FROM estudiante";
            ConnectionBD objCBD = new ConnectionBD();
            List<string> lista = objCBD.ObtenerLista(sql, "nombreEstudiante1", filtro);
            return lista;
        }
        public List<int> obtenerId(string filtro)
        {
            string sql = "SELECT idEstudiante FROM estudiante";
            ConnectionBD objCBD = new ConnectionBD();
            List<int> lista = objCBD.ObtenerId(sql, "idEstudiante", filtro);

            return lista;
        }
    }
}
