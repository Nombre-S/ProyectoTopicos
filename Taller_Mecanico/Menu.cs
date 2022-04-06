using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_Mecanico
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cmdClientes_Click(object sender, EventArgs e)
        {
            frmCliente Cliente = new frmCliente();
            this.Hide();
            Cliente.Show();
        }

        private void cmdVehiculo_Click(object sender, EventArgs e)
        {
            frmVehiculo Vehiculo = new frmVehiculo();
            this.Hide();
            Vehiculo.Show();
        }

        private void cmdRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro Registro = new frmRegistro();
            this.Hide();
            Registro.Show();
        }

        private void cmdMecanico_Click(object sender, EventArgs e)
        {
            frmMecanico Mecanico = new frmMecanico();
            this.Hide();
            Mecanico.Show();
        }

        private void cmdFactura_Click(object sender, EventArgs e)
        {
            frmFactura Factura = new frmFactura();
            this.Hide();
            Factura.Show();
        }

        private void cmdSalida_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
