using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAICU23.Clases
{
    class RecursoTecnologico
    {
        public int numeroRT { get; set; }
        public DateTime fechaAlta { get; set; }
        public bool bajaTecnica { get; set; }
        public bool bajaDefinitiva { get; set; }

        public TipoRecursoTecnologico tipoRT { get; set; }

        public RecursoTecnologico(int numeroRT, DateTime fechaAlta, bool bajaTecnica, bool bajaDefinitiva )
        {
            this.numeroRT = numeroRT;
            this.fechaAlta = fechaAlta;
            this.bajaTecnica = bajaTecnica;
            this.bajaDefinitiva = bajaDefinitiva;

        }
        public bool esReservable()
        {
            if(bajaTecnica==false && bajaDefinitiva == false)
            {
                return true;
            }
            return false;
        }

        public TipoRecursoTecnologico conocerTipoRt()
        {
            //devuelve el puntero del recurso tecnolofico
            return this.tipoRT;
        }


        }


        private RecursoTecnologico obtenerRecursoTecnologicoNoenBaja() {

            RecursoTecnologico recurso = new RecursoTecnologico();
            return  recurso;
        }
    }

}
