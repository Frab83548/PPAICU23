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
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantAdmReservaRT v1 = new PantAdmReservaRT();
            v1.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
