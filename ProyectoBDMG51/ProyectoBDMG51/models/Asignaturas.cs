using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDMG51.models
{
    class Asignaturas
    {
        private int idAsignatura;
        private string nombreAsignatura;

        public Asignaturas()
        {
        }

        public Asignaturas(int idAsignatura, string nombreAsignatura)
        {
            this.idAsignatura = idAsignatura;
            this.nombreAsignatura = nombreAsignatura;
        }

        public int IdAsignatura { get => idAsignatura; set => idAsignatura = value; }
        public string NombreAsignatura { get => nombreAsignatura; set => nombreAsignatura = value; }
    }
}
