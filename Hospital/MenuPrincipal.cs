using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void crearFacturaLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFacturaLaboratorio crearFacturaLaboratorio = new CrearFacturaLaboratorio();
            crearFacturaLaboratorio.Show();
        }

        private void crearFacturaFarmaciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFacturaFarmacia crearFacturaFarmacia = new CrearFacturaFarmacia();
            crearFacturaFarmacia.Show();
        }

        private void verFacturasLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerFacturaLaboratorio verFacturaLaboratorio = new VerFacturaLaboratorio();
            verFacturaLaboratorio.Show();
        }

        private void verFacturasFarmaciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerFacturaFarmacia verFacturaFarmacia = new VerFacturaFarmacia();
            verFacturaFarmacia.Show();
        }
    }
}
