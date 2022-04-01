using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Taller_Mecanico
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }
        SqlConnection Conexion = new SqlConnection("Data Source=(local);Initial Catalog=TallerMecanico;Integrated Security=SSPI");

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            SqlCommand Altas = new SqlCommand("insert into CLIENTES (DNI_Cliente,Nombre_Cliente,Apellidos_Cliente,telefono,Direccion_Cliente) values(@DNI_Cliente,@Nombre_Cliente,@Apellidos_Cliente,@telefono,@Direccion_Cliente)", Conexion);
            Altas.Parameters.AddWithValue("DNI_Cliente", txtDNI.Text);
            Altas.Parameters.AddWithValue("Nombre_Cliente", txtNombre.Text);
            Altas.Parameters.AddWithValue("Apellidos_Cliente", txtApellidos.Text);
            Altas.Parameters.AddWithValue("telefono", txtTelefono.Text);
            Altas.Parameters.AddWithValue("Direccion_Cliente", txtDireccion.Text);
            Conexion.Open();
            Altas.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("Socio Almacenados");
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtDNI.Focus();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {

        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {

        }
        
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
