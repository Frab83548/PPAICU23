using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAICU23.Clases
{
    class TipoRecursoTecnologico
    {
        public string nombre;
        public string descripcion;

        public TipoRecursoTecnologico(string nombre, string descripcion)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public string Descripcion { get; set; }
        public string Nombre { get; set; }

        public string getNombre()
        {
            return Nombre;
        }

    }
}
