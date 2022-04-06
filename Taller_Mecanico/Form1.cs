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

        public void LLenarTabla()
        {
            string consulta = "select * from CLIENTES";
            SqlDataAdapter Adaptador = new SqlDataAdapter(consulta, Conexion);
            DataTable dt = new DataTable();
            Adaptador.Fill(dt);
            dtgvClientes.DataSource = dt;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string INSERT = "INSERT INTO CLIENTES (DNI_Cliente,Nombre_Cliente,Apellidos_Cliente,telefono,Direccion_Cliente) values(@DNI_Cliente,@Nombre_Cliente,@Apellidos_Cliente,@telefono,@Direccion_Cliente)";
            SqlCommand Altas = new SqlCommand(INSERT, Conexion);
            Altas.Parameters.AddWithValue("DNI_Cliente", txtDNI.Text);
            Altas.Parameters.AddWithValue("Nombre_Cliente", txtNombre.Text);
            Altas.Parameters.AddWithValue("Apellidos_Cliente", txtApellidos.Text);
            Altas.Parameters.AddWithValue("telefono", txtTelefono.Text);
            Altas.Parameters.AddWithValue("Direccion_Cliente", txtDireccion.Text);
            Conexion.Open();
            Altas.ExecuteNonQuery();
            LLenarTabla();
            Conexion.Close();
            MessageBox.Show("Cliente Almacenado");
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtDNI.Focus();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            string UPDATE = "UPDATE CLIENTES SET DNI_Cliente = @DNI_Cliente, Nombre_Cliente = @Nombre_Cliente, Apellidos_Cliente = @Apellidos_Cliente, telefono = @telefono, Direccion_Cliente = @Direccion_Cliente WHERE DNI_Cliente = @DNI_Cliente";
            Conexion.Open();
            SqlCommand Modificacion = new SqlCommand(UPDATE, Conexion);
            Modificacion.Parameters.AddWithValue("DNI_Cliente", txtDNI.Text);
            Modificacion.Parameters.AddWithValue("Nombre_Cliente", txtNombre.Text);
            Modificacion.Parameters.AddWithValue("Apellidos_Cliente", txtApellidos.Text);
            Modificacion.Parameters.AddWithValue("telefono", txtTelefono.Text);
            Modificacion.Parameters.AddWithValue("Direccion_Cliente", txtDireccion.Text);
            Modificacion.ExecuteNonQuery();
            LLenarTabla();
            Conexion.Close();
            MessageBox.Show("Modificacion Realizada");
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtDNI.Focus();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            string DELETE = "DELETE FROM CLIENTES WHERE DNI_Cliente = @DNI_Cliente";
            Conexion.Open();
            SqlCommand Elim = new SqlCommand(DELETE, Conexion);
            Elim.Parameters.AddWithValue("DNI_Cliente", txtDNI.Text);
            Elim.ExecuteNonQuery();
            Elim.Dispose();
            Elim = null;
            LLenarTabla();
            Conexion.Close();
            MessageBox.Show("Cliente Eliminado");
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtDNI.Focus();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            string Cons = "SELECT * FROM CLIENTES WHERE DNI_Cliente = @DNI_Cliente";
            Conexion.Open();
            SqlCommand Consulta = new SqlCommand(Cons, Conexion);
            Consulta.Parameters.AddWithValue("DNI_Cliente", txtDNI.Text);
            LLenarTabla();
            SqlDataReader Lector = Consulta.ExecuteReader();
            while (Lector.Read())
            {
                txtDNI.Text = Lector[0].ToString();
                txtNombre.Text = Lector[1].ToString();
                txtApellidos.Text = Lector[2].ToString();
                txtTelefono.Text = Lector[3].ToString();
                txtDireccion.Text = Lector[4].ToString();
            }
            Conexion.Close();
            MessageBox.Show("Consulta Realizada");
        }
        
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            frmMenu Menu = new frmMenu();
            this.Close();
            Menu.Show();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            string consulta = "select * from CLIENTES";
            SqlDataAdapter Adaptador = new SqlDataAdapter(consulta,Conexion);
            DataTable dt = new DataTable();
            Adaptador.Fill(dt);
            dtgvClientes.DataSource = dt;
        }
    }
}
