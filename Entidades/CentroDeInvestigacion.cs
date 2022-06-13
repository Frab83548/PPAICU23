using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAICU23.Clases
{
    class CentroDeInvestigacion
    {
        public string Nombre  { get; set; }
        public List<RecursoTecnologico> RecursosTecnologicos{ get; set; }

        public CentroDeInvestigacion(string nombre, List<RecursoTecnologico> recusosTec)
        {
            this.Nombre = nombre;
            this.RecursosTecnologicos = recusosTec;
        }
    }
}
