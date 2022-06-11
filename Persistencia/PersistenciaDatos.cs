using PPAICU23.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace PPAICU23.Persistencia
{
    class PersistenciaDatos
    {
        public List<TipoRecursoTecnologico> tipoRecursos;

        public PersistenciaDatos()
        {
            TipoRecursos = new List<TipoRecursoTecnologico>();
            TipoRecursos.Add(new TipoRecursoTecnologico("balanza de precision", ""));
            TipoRecursos.Add(new TipoRecursoTecnologico("microscopio", ""));
            TipoRecursos.Add(new TipoRecursoTecnologico("resonador magnetico", ""));
            TipoRecursos.Add(new TipoRecursoTecnologico("equipamiento de computo de datos de alto rendimiento", ""));

            //MessageBox.Show(TipoRecursos[0].ToString());
           
            

        }

        internal List<TipoRecursoTecnologico> TipoRecursos { get => tipoRecursos; set => tipoRecursos = value; }
    }
}
