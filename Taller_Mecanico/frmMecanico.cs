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
    public partial class frmMecanico : Form
    {
        public frmMecanico()
        {
            InitializeComponent();
        }
        SqlConnection Conexion = new SqlConnection("Data Source=(local);Initial Catalog=TallerMecanico;Integrated Security=SSPI");

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string INSERT = "INSERT INTO MECANICO (ID_Mecanico, Nombre_Mecanico, ID_Registro) values(@ID_Mecanico, @Nombre_Mecanico, @ID_Registro)";
            SqlCommand Altas = new SqlCommand(INSERT, Conexion);
            Altas.Parameters.AddWithValue("ID_Mecanico", txtID.Text);
            Altas.Parameters.AddWithValue("Nombre_Mecanico", txtNom.Text);
            Altas.Parameters.AddWithValue("ID_Registro", txtFK.Text);
            Conexion.Open();
            Altas.ExecuteNonQuery();
            LlenarTabla();
            Conexion.Close();
            MessageBox.Show("Mecanico Almacenado");
            txtID.Clear();
            txtNom.Clear();
            txtFK.Clear();
            txtID.Focus();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            string UPDATE = "UPDATE MECANICO SET ID_Mecanico = @ID_Mecanico, Nombre_Mecanico = @Nombre_Mecanico, ID_Registro = @ID_Registro  WHERE ID_Mecanico = @ID_Mecanico";
            Conexion.Open();
            SqlCommand Modificacion = new SqlCommand(UPDATE, Conexion);
            Modificacion.Parameters.AddWithValue("ID_Mecanico", txtID.Text);
            Modificacion.Parameters.AddWithValue("Nombre_Mecanico", txtNom.Text);
            Modificacion.Parameters.AddWithValue("ID_Registro", txtFK.Text);
            Modificacion.ExecuteNonQuery();
            LlenarTabla();
            Conexion.Close();
            MessageBox.Show("Modificacion Realizada");
            txtID.Clear();
            txtNom.Clear();
            txtFK.Clear();
            txtID.Focus();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            string DELETE = "DELETE FROM MECANICO WHERE ID_Mecanico = @ID_Mecanico";
            Conexion.Open();
            SqlCommand Elim = new SqlCommand(DELETE, Conexion);
            Elim.Parameters.AddWithValue("ID_Mecanico", txtID.Text);
            Elim.ExecuteNonQuery();
            Elim.Dispose();
            Elim = null;
            LlenarTabla();
            Conexion.Close();
            MessageBox.Show("Mecanico Eliminado");
            txtID.Clear();
            txtNom.Clear();
            txtFK.Clear();
            txtID.Focus();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            string Cons = "SELECT * FROM MECANICO WHERE ID_Mecanico = @ID_Mecanico";
            Conexion.Open();
            SqlCommand Consulta = new SqlCommand(Cons, Conexion);
            Consulta.Parameters.AddWithValue("ID_Mecanico", txtID.Text);
            LlenarTabla();
            SqlDataReader Lector = Consulta.ExecuteReader();
            while (Lector.Read())
            {
                txtID.Text = Lector[0].ToString();
                txtNom.Text = Lector[1].ToString();
                txtFK.Text = Lector[2].ToString();
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

        private void frmMecanico_Load(object sender, EventArgs e)
        {
            string consulta = "select * from MECANICO";
            SqlDataAdapter Adaptador = new SqlDataAdapter(consulta, Conexion);
            DataTable dt = new DataTable();
            Adaptador.Fill(dt);
            dtgvMecanico.DataSource = dt;
        }

        public void LlenarTabla()
        {
            string consulta = "select * from MECANICO";
            SqlDataAdapter Adaptador = new SqlDataAdapter(consulta, Conexion);
            DataTable dt = new DataTable();
            Adaptador.Fill(dt);
            dtgvMecanico.DataSource = dt;
        }
    }
}
