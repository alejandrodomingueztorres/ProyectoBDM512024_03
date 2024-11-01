using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDMG51.models
{
    class Estudiante
    {
        private int idEstudiante;
        private string nombreEstudiante1;
        private string nombreEstudiante2;
        private string apellidoEstudiante1;
        private string apellidoEstudiante2;
        private string correoE;
        private string identificacionE;
        private string passwordE;

        public Estudiante()
        {
        }

        public Estudiante(string nombreEstudiante1, string nombreEstudiante2, string apellidoEstudiante1, string apellidoEstudiante2, string correoE, string identificacionE, string passwordE)
        {
            this.nombreEstudiante1 = nombreEstudiante1;
            this.nombreEstudiante2 = nombreEstudiante2;
            this.apellidoEstudiante1 = apellidoEstudiante1;
            this.apellidoEstudiante2 = apellidoEstudiante2;
            this.correoE = correoE;
            this.identificacionE = identificacionE;
            this.passwordE = passwordE;
        }

        public Estudiante(int idEstudiante, string nombreEstudiante1, string nombreEstudiante2, string apellidoEstudiante1, string apellidoEstudiante2, string correoE, string identificacionE, string passwordE)
        {
            this.idEstudiante = idEstudiante;
            this.nombreEstudiante1 = nombreEstudiante1;
            this.nombreEstudiante2 = nombreEstudiante2;
            this.apellidoEstudiante1 = apellidoEstudiante1;
            this.apellidoEstudiante2 = apellidoEstudiante2;
            this.correoE = correoE;
            this.identificacionE = identificacionE;
            this.passwordE = passwordE;
        }

        public int IdEstudiante { get => idEstudiante; set => idEstudiante = value; }
        public string NombreEstudiante1 { get => nombreEstudiante1; set => nombreEstudiante1 = value; }
        public string NombreEstudiante2 { get => nombreEstudiante2; set => nombreEstudiante2 = value; }
        public string ApellidoEstudiante1 { get => apellidoEstudiante1; set => apellidoEstudiante1 = value; }
        public string ApellidoEstudiante2 { get => apellidoEstudiante2; set => apellidoEstudiante2 = value; }
        public string CorreoE { get => correoE; set => correoE = value; }
        public string IdentificacionE { get => identificacionE; set => identificacionE = value; }
        public string PasswordE { get => passwordE; set => passwordE = value; }
    }
}
