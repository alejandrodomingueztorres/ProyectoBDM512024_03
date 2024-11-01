using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDMG51.models
{
    class Recurso_multimedia
    {
        private int idRecursoM;
        private string tituloRecurso;
        private DateTime fechaCreacionR;
        private string descripcionRecurso;
        private string archivoRecurso;
        private int idDocenteFK;
        private int idEstudianteFK;
        private int idAsignaturaFK;
        private int idTRFK;

        public Recurso_multimedia()
        {
        }

        public Recurso_multimedia(int idRecursoM, string tituloRecurso, DateTime fechaCreacionR, string descripcionRecurso)
        {
            this.idRecursoM = idRecursoM;
            this.tituloRecurso = tituloRecurso;
            this.fechaCreacionR = fechaCreacionR;
            this.descripcionRecurso = descripcionRecurso;
        }

        public int IdRecursoM { get => idRecursoM; set => idRecursoM = value; }
        public string TituloRecurso { get => tituloRecurso; set => tituloRecurso = value; }
        public DateTime FechaCreacionR { get => fechaCreacionR; set => fechaCreacionR = value; }
        public string DescripcionRecurso { get => descripcionRecurso; set => descripcionRecurso = value; }
        public int IdTRFK { get => idTRFK; set => idTRFK = value; }
        public string ArchivoRecurso { get => archivoRecurso; set => archivoRecurso = value; }
        public int IdDocenteFK { get => idDocenteFK; set => idDocenteFK = value; }
        public int IdEstudianteFK { get => idEstudianteFK; set => idEstudianteFK = value; }
        public int IdAsignaturaFK { get => idAsignaturaFK; set => idAsignaturaFK = value; }
    }
}
