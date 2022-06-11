using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAICU23.Entidades
{
    class Turno
    {
        public DateTime? FechaGeneracion { get; set; }
        public DateTime? DiaSemana { get; set; }

        public DateTime? FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }

    }
}
