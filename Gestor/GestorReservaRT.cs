using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAICU23.Clases;
using PPAICU23.Persistencia;

namespace PPAICU23.Gestor
{
    class GestorReservaRT
    {
        public List<TipoRecursoTecnologico> tipoDeRecursosTecnologicos;

        public GestorReservaRT()
        {
            this.tipoDeRecursosTecnologicos = new List<TipoRecursoTecnologico>();
        }

        public List<TipoRecursoTecnologico> TipoDeRecursosTecnologicos { get => tipoDeRecursosTecnologicos; set => tipoDeRecursosTecnologicos = value; }

        public void BuscarTiposDeRT()
        {
            PersistenciaDatos datos = new PersistenciaDatos(); 
            foreach(TipoRecursoTecnologico tipoRecurso in datos.TipoRecursos)
            {
                string nombre = tipoRecurso.nombre;
            }
        }
            
    }
}
