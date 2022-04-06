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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        SqlConnection Conexion = new SqlConnection("Data Source=(local);Initial Catalog=TallerMecanico;Integrated Security=SSPI");

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string INSERT = "INSERT INTO REGISTRO(ID_Registro, Matricula, Fecha_Entrada, Hora_Entrada) values(@ID_Registro, @Matricula, @Fecha_Entrada, @Hora_Entrada)";
            SqlCommand Altas = new SqlCommand(INSERT, Conexion);
            Altas.Parameters.AddWithValue("ID_Registro", txtID.Text);
            Altas.Parameters.AddWithValue("Matricula", txtMat.Text);
            Altas.Parameters.AddWithValue("Fecha_Entrada", txtFec.Text);
            Altas.Parameters.AddWithValue("Hora_Entrada", txtHora.Text);
            Conexion.Open();
            Altas.ExecuteNonQuery();
            LlenarTabla();
            Conexion.Close();
            MessageBox.Show("Registro Almacenado");
            txtID.Clear();
            txtMat.Clear();
            txtFec.Clear();
            txtHora.Clear();
            txtID.Focus();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            string UPDATE = "UPDATE REGISTRO SET ID_Registro = @ID_Registro, Matricula = @Matricula, Fecha_Entrada = @Fecha_Entrada, Hora_Entrada = @Hora_Entrada WHERE ID_Registro = @ID_Registro";
            Conexion.Open();
            SqlCommand Modificacion = new SqlCommand(UPDATE, Conexion);
            Modificacion.Parameters.AddWithValue("ID_Registro", txtID.Text);
            Modificacion.Parameters.AddWithValue("Matricula", txtMat.Text);
            Modificacion.Parameters.AddWithValue("Fecha_Entrada", txtFec.Text);
            Modificacion.Parameters.AddWithValue("Hora_Entrada", txtHora.Text);
            Modificacion.ExecuteNonQuery();
            LlenarTabla();
            Conexion.Close();
            MessageBox.Show("Modificacion Realizada");
            txtID.Clear();
            txtMat.Clear();
            txtFec.Clear();
            txtHora.Clear();
            txtID.Focus();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            string DELETE = "DELETE FROM REGISTRO WHERE ID_Registro = @ID_Registro";
            Conexion.Open();
            SqlCommand Elim = new SqlCommand(DELETE, Conexion);
            Elim.Parameters.AddWithValue("ID_Registro", txtID.Text);
            Elim.ExecuteNonQuery();
            Elim.Dispose();
            Elim = null;
            LlenarTabla();
            Conexion.Close();
            MessageBox.Show("Registro Eliminado");
            txtID.Clear();
            txtMat.Clear();
            txtFec.Clear();
            txtHora.Clear();
            txtID.Focus();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            string Cons = "SELECT * FROM REGISTRO WHERE ID_Registro = @ID_Registro";
            Conexion.Open();
            LlenarTabla();
            SqlCommand Consulta = new SqlCommand(Cons, Conexion);
            Consulta.Parameters.AddWithValue("ID_Registro", txtID.Text);
            SqlDataReader Lector = Consulta.ExecuteReader();
            while (Lector.Read())
            {
                txtID.Text = Lector[0].ToString();
                txtMat.Text = Lector[1].ToString();
                txtFec.Text = Lector[2].ToString();
                txtHora.Text = Lector[3].ToString();
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

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            string consulta = "select * from REGISTRO";
            SqlDataAdapter Adaptador = new SqlDataAdapter(consulta, Conexion);
            DataTable dt = new DataTable();
            Adaptador.Fill(dt);
            dtgvRegistro.DataSource = dt;
        }

        public void LlenarTabla()
        {
            string consulta = "select * from REGISTRO";
            SqlDataAdapter Adaptador = new SqlDataAdapter(consulta, Conexion);
            DataTable dt = new DataTable();
            Adaptador.Fill(dt);
            dtgvRegistro.DataSource = dt;
        }
    }
}
