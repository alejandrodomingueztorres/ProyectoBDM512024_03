using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDMG51.models
{
    class TipoRecurso
    {
        private int idTR;
        private string tipoRecurso;

        public TipoRecurso(string tipoRecurso)
        {
            this.tipoRecurso = tipoRecurso;
        }

        public TipoRecurso()
        {
        }

        public TipoRecurso(int idTR, string tipoRecurso)
        {
            this.idTR = idTR;
            this.tipoRecurso = tipoRecurso;
        }

        public int IdTR { get => idTR; set => idTR = value; }
        public string TipoRecurso { get => tipoRecurso; set => tipoRecurso = value; }
    }
}
