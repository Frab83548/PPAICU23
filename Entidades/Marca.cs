using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAICU23.Clases
{
    class Marca
    {
        public string Nombre { get; set; }

        public List <Modelo> modelos { get; set; }

        public Marca(string Nombre, List <Modelo> modelos)
        {
            this.Nombre = Nombre;
            this.modelos = modelos; 

        }
    }
}
