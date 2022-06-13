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
        public List<Modelo> modelos;
        public List<Modelo> modelos2;
        public Marca marca1;
        public Marca marca2;
        public CentroDeInvestigacion c1;
        public CentroDeInvestigacion c2;
        public List<RecursoTecnologico> recursosTec;

        public PersistenciaDatos()
        {
            TipoRecursos = new List<TipoRecursoTecnologico>();
            TipoRecursos.Add(new TipoRecursoTecnologico("balanza de precision", ""));
            TipoRecursos.Add(new TipoRecursoTecnologico("microscopio", ""));
            TipoRecursos.Add(new TipoRecursoTecnologico("resonador magnetico", ""));
            TipoRecursos.Add(new TipoRecursoTecnologico("equipamiento de computo de datos de alto rendimiento", ""));

            //MessageBox.Show(TipoRecursos[0].ToString());
            Estado e1 = new Estado("Baja Tecnica", "", "Estado", true, true);
            Estado e2 = new Estado("Baja Definitiva", "", "Estado", true, true);
            Estado e3 = new Estado("Disponible", "", "Estado", true, true);

            DateTime fechaHoraInicio = new DateTime(2022, 3, 13, 12, 39, 30);
            DateTime fechaHoraFin = new DateTime(2022, 7, 12, 13, 45, 00);
            DateTime fechaHoraInicio2 = new DateTime(2022, 5, 09, 10, 08, 9);
            DateTime fechaHoraFin2 = new DateTime(2022, 5, 10, 19, 33, 07);
            DateTime fechaHoraInicio3 = new DateTime(2022, 3, 10, 10, 08, 9);
            DateTime fechaHoraFin3 = new DateTime(2022, 4, 10, 19, 33, 07);


            CambioDeEstadoRT cambio1 = new CambioDeEstadoRT(fechaHoraInicio, fechaHoraFin, e1);
            CambioDeEstadoRT cambio2 = new CambioDeEstadoRT(fechaHoraInicio2, fechaHoraFin2, e3);
            CambioDeEstadoRT cambio3 = new CambioDeEstadoRT(fechaHoraInicio3, fechaHoraFin3, e3);


            RecursoTecnologico recurso1 = new RecursoTecnologico(23, DateTime.Now, TipoRecursos[0], cambio1);
            RecursoTecnologico recurso2 = new RecursoTecnologico(2, DateTime.Now, TipoRecursos[0], cambio1);
            RecursoTecnologico recurso3 = new RecursoTecnologico(12, DateTime.Now, TipoRecursos[1], cambio2);
            RecursoTecnologico recurso4 = new RecursoTecnologico(5, DateTime.Now, TipoRecursos[2], cambio2);

            recursosTec.Add(recurso1); recursosTec.Add(recurso2); recursosTec.Add(recurso3); recursosTec.Add(recurso4);



            Modelo mod1 = new Modelo("PS1000-C1");
            Modelo mod2 = new Modelo("PS510-C1");
            Modelo mod3 = new Modelo("Modelo3");
            Modelo mod4 = new Modelo("Modelo4");

            modelos.Add(mod1);
            modelos.Add(mod2);
            modelos2.Add(mod3);
            modelos2.Add(mod4);



            marca1 = new Marca("RADWAG", modelos);
            marca2 = new Marca("Toshiba", modelos2);

           





        }

        internal List<TipoRecursoTecnologico> TipoRecursos { get => TipoRecursos; set => TipoRecursos = value; }
        //internal List<Modelo> marca1 { get => marca1; set => tipoRecursos = value; }
        // internal List<RecursoTecnologico> Recursos { get => Recursos; set => Recursos = value; }



    }
}
