using PPAICU23.Clases;
using PPAICU23.Gestor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAICU23.Interfaces
{
    public partial class PantAdmReserva : Form
    {
        private GestorReservaRT gestor;
        public PantAdmReserva()
        {
            InitializeComponent();
            gestor = new GestorReservaRT(this);
        }
        Boolean bandera = false;
        private void pant_Load(object sender, EventArgs e)
        {
            
            cargarCmbTipoRecursos();
            bandera = true;
            if (bandera == true)
            {
                MessageBox.Show("Por favor seleccione un Tipo de Recurso Tecnologico");
            }

        }

        private void cargarCmbTipoRecursos()
        {
            List<String> tipoRecursos = new List<String>();
            try { tipoRecursos = gestor.BuscarTiposDeRT(); }
            catch
            {
                MessageBox.Show("No se pudo cargar el combo");
            }
            

            foreach (String tipoRecurso in tipoRecursos)
            {
                CBtiposRT.Items.Add(tipoRecurso);
            }
            bandera = true;
        }
       
private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (CBtiposRT.GetItemText(CBtiposRT.SelectedItem) == "")
            {
                MessageBox.Show("No ha seleccionado ningun Recurso Tecnologico");
            }
            else
            {
                tomarSeleccionDeTipodeRT();
            }

        }

        private void tomarSeleccionDeTipodeRT()
        {
            String tipodeRT = CBtiposRT.GetItemText(CBtiposRT.SelectedItem);
            this.gestor.TomarSeleccionDeTR(tipodeRT);
        }
       /* public void tomarSeleccionTarifa()
        {
            // Toma los datos de la tarifa seleccionada y se los envia como parametro al gestor
            var tarifaSeleccionada = new List<string>();

            var entrada = ((TipoEntrada)cmb_tipo_entrada.SelectedItem).id_tipo_entrada.ToString();
            var visita = ((TipoVisita)cmb_tipo_visita.SelectedItem).id_tipo_visita.ToString();
            var guia = ck_guiado.Checked.ToString();

            tarifaSeleccionada.Add(entrada);
            tarifaSeleccionada.Add(visita);
            tarifaSeleccionada.Add(guia);

            this.gestor.tomarSeleccionTarifa(tarifaSeleccionada);
        }

*/


    }
}
