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
       

        public TipoRecursoTecnologico tipoRT { get; set; }
        public CambioDeEstadoRT cambioE { get; set; } 

       
        public RecursoTecnologico(int numeroRT, DateTime fechaAlta, TipoRecursoTecnologico tipoRT, CambioDeEstadoRT cambioE)
        {
            this.numeroRT = numeroRT;
            this.fechaAlta = fechaAlta;
            this.tipoRT = tipoRT;
            this.cambioE = cambioE;

        }
        

        public TipoRecursoTecnologico conocerTipoRt()
        {
            //devuelve el puntero del recurso tecnolofico
            return this.tipoRT;
        }
        public string obtenerNombreRecursoTecnologico()
        {
            return this.tipoRT.getNombre();
        }


        }


       /* private RecursoTecnologico obtenerRecursoTecnologicoNoenBaja() {

            RecursoTecnologico recurso = new RecursoTecnologico();
            return  recurso;
        }
    }*/

}
