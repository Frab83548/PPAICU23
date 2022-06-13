using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAICU23.Clases;
using PPAICU23.Interfaces;
using PPAICU23.Persistencia;


namespace PPAICU23.Gestor
{
    class GestorReservaRT
    {

        public List<TipoRecursoTecnologico> tipoDeRecursosTecnologicos;
        public PantAdmReserva principal;
        public GestorReservaRT(PantAdmReserva _principal)
        {
            principal = _principal;
            //this.tipoDeRecursosTecnologicos = new List<TipoRecursoTecnologico>();
        }

        public List<TipoRecursoTecnologico> TipoDeRecursosTecnologicos { get => tipoDeRecursosTecnologicos; set => tipoDeRecursosTecnologicos = value; }

        public List<String> BuscarTiposDeRT()
        {
           PersistenciaDatos datos = new PersistenciaDatos();
            List<String> tipoRecursos = new List<String>();
            foreach (TipoRecursoTecnologico tipoRecurso in datos.TipoRecursos)
            {
                tipoRecursos.Add(tipoRecurso.getNombre());
            }
            return tipoRecursos;
        }

        public void TomarSeleccionDeTR(String tipoRT)
        {
            BuscarRTcorrespondiente(tipoRT);
        }

        private void BuscarRTcorrespondiente(String tipoRT) 
        {
            PersistenciaDatos datos = new PersistenciaDatos();
            List<TipoRecursoTecnologico> tipoRecursos = new List<TipoRecursoTecnologico>();
            foreach (RecursoTecnologico recurso in datos.recursosTec)
            {
                if(recurso.obtenerNombreRecursoTecnologico() == tipoRT)
                recurso.conocerTipoRt();
            }


        }
       
            
    }
}
