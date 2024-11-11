using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDMG51.models
{
    class Comentario_estudiante
    {
        private int idComentarioE;
        private string contenidoComentarioE;
        private DateTime fechaComentarioE;
        private int idRecursoMFK;
        private int idEstudianteFK;

        public Comentario_estudiante()
        {
        }

        public Comentario_estudiante(string contenidoComentarioE, int idRecursoMFK, int idEstudianteFK)
        {
            this.contenidoComentarioE = contenidoComentarioE;
            this.idRecursoMFK = idRecursoMFK;
            this.idEstudianteFK = idEstudianteFK;
        }

        public Comentario_estudiante(int idComentarioE, string contenidoComentarioE, DateTime fechaComentarioE, int idRecursoMFK, int idEstudianteFK)
        {
            this.idComentarioE = idComentarioE;
            this.contenidoComentarioE = contenidoComentarioE;
            this.fechaComentarioE = fechaComentarioE;
            this.idRecursoMFK = idRecursoMFK;
            this.idEstudianteFK = idEstudianteFK;
        }

        public int IdComentarioE { get => idComentarioE; set => idComentarioE = value; }
        public string ContenidoComentarioE { get => contenidoComentarioE; set => contenidoComentarioE = value; }
        public DateTime FechaComentarioE { get => fechaComentarioE; set => fechaComentarioE = value; }
        public int IdRecursoMFK { get => idRecursoMFK; set => idRecursoMFK = value; }
        public int IdEstudianteFK { get => idEstudianteFK; set => idEstudianteFK = value; }
    }
}
