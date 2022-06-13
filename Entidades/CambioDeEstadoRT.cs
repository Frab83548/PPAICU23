using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAICU23.Clases
{
    class CambioDeEstadoRT
    {
        private DateTime fechaHoraDesde { get; set; }
        private DateTime fechaHoraHasta { get; set; }
        private Estado estado { get; set; }

        public CambioDeEstadoRT(DateTime fechaHoraDesde, DateTime fechaHoraHasta, Estado estado)
        {
            this.fechaHoraDesde = fechaHoraDesde;
            this.fechaHoraHasta = fechaHoraHasta;
            this.estado = estado;
        }

        public override bool Equals(object obj)
        {
            return obj is CambioDeEstadoRT rT &&
                   fechaHoraDesde == rT.fechaHoraDesde &&
                   fechaHoraHasta == rT.fechaHoraHasta &&
                   EqualityComparer<Estado>.Default.Equals(estado, rT.estado);
        }

        public bool esActual()
        {
            return true;
        }

        public bool esReservable()
        {

            return this.estado.getEsReservable();
        }

        public string getNombreEstado()
        {
            return estado.getNombre();
        }
    }
}
    
