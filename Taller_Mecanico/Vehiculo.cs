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
    public partial class frmVehiculo : Form
    {
        public frmVehiculo()
        {
            InitializeComponent();
        }
        SqlConnection Conexion = new SqlConnection("Data Source=(local);Initial Catalog=TallerMecanico;Integrated Security=SSPI");

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string INSERT = "INSERT INTO VEHICULO (Matricula, Modelo, Color, DNI_Cliente) VALUES(@Matricula, @Modelo, @Color, @DNI_Cliente)";
            SqlCommand Altas = new SqlCommand(INSERT, Conexion);
            Altas.Parameters.AddWithValue("Matricula", txtMatricula.Text);
            Altas.Parameters.AddWithValue("Modelo", txtModelo.Text);
            Altas.Parameters.AddWithValue("Color", txtColor.Text);
            Altas.Parameters.AddWithValue("DNI_Cliente", txtDNI.Text);
            Conexion.Open();
            Altas.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("Vehiculo Almacenado");
            txtMatricula.Clear();
            txtModelo.Clear();
            txtColor.Clear();
            txtDNI.Clear();
            txtMatricula.Focus();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            string UPDATE = "UPDATE VEHICULO SET Matricula = @Matricula, Modelo = @Modelo, Color = @Color, DNI_Cliente = @DNI_Cliente";
            SqlCommand Modificacion = new SqlCommand(UPDATE, Conexion);
            Modificacion.Parameters.AddWithValue("Matricula", txtMatricula.Text);
            Modificacion.Parameters.AddWithValue("Modelo", txtModelo.Text);
            Modificacion.Parameters.AddWithValue("Color", txtColor.Text);
            Modificacion.Parameters.AddWithValue("DNI_Cliente", txtDNI.Text);
            Conexion.Open();
            Modificacion.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("Modificacion Realizada");
            txtMatricula.Clear();
            txtModelo.Clear();
            txtColor.Clear();
            txtDNI.Clear();
            txtMatricula.Focus();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            string DELETE = "DELETE FROM VEHICULO WHERE Matricula = @Matricula";
            SqlCommand Elim = new SqlCommand(DELETE, Conexion);
            Elim.Parameters.AddWithValue("Matricula", txtMatricula.Text);
            Conexion.Open();
            Elim.ExecuteNonQuery();
            Elim.Dispose();
            Elim = null;
            Conexion.Close();
            MessageBox.Show("Vehiculo Eliminado");
            txtMatricula.Clear();
            txtModelo.Clear();
            txtColor.Clear();
            txtDNI.Clear();
            txtMatricula.Focus();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            string Cons = "SELECT * FROM VEHICULO WHERE Matricula = @Matricula";
            Conexion.Open();
            SqlCommand Consulta = new SqlCommand(Cons, Conexion);
            Consulta.Parameters.AddWithValue("Matricula", txtMatricula.Text);
            SqlDataReader Lector = Consulta.ExecuteReader();
            while (Lector.Read())
            {
                txtMatricula.Text = Lector[0].ToString();
                txtModelo.Text = Lector[1].ToString();
                txtColor.Text = Lector[2].ToString();
                txtDNI.Text = Lector[3].ToString();
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
    }
}
