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
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }
        SqlConnection Conexion = new SqlConnection("Data Source=(local);Initial Catalog=TallerMecanico;Integrated Security=SSPI");

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string INSERT = "INSERT INTO FACTURA (ID_Factura, Repuesto, Costo_Repuesto, Mano_De_Obra, Total_Factura, Total_Euros, Total_Pesetas, DNI_Cliente, ID_Mecanico) values(@ID_Factura, @Repuesto, @Costo_Repuesto, @Mano_De_Obra, @Total_Factura, @Total_Euros, @Total_Pesetas, @DNI_Cliente, @ID_Mecanico)";
            SqlCommand Altas = new SqlCommand(INSERT, Conexion);
            Altas.Parameters.AddWithValue("ID_Factura",txtID.Text);
            Altas.Parameters.AddWithValue("Repuesto", txtRep.Text);
            Altas.Parameters.AddWithValue("Costo_Repuesto", txtCostoRep.Text);
            Altas.Parameters.AddWithValue("Mano_De_Obra", txtMano.Text);
            Altas.Parameters.AddWithValue("Total_Factura", txtTotal.Text);
            Altas.Parameters.AddWithValue("Total_Euros", txtEuros.Text);
            Altas.Parameters.AddWithValue("Total_Pesetas", txtPesetas.Text);
            Altas.Parameters.AddWithValue("DNI_Cliente", txtCliente.Text);
            Altas.Parameters.AddWithValue("ID_Mecanico", txtMecanico.Text);
            Conexion.Open();
            Altas.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("Factura Almacenada");
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }
            }
            txtID.Focus();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            string UPDATE = "UPDATE FACTURA SET ID_Factura = @ID_Factura, Repuesto = @Repuesto, Costo_Repuesto = @Costo_Repuesto, Mano_De_Obra = @Mano_De_Obra, Total_Factura = @Total_Factura, Total_Euros = @Total_Euros, Total_Pesetas = @Total_Pesetas, DNI_Cliente = @DNI_Cliente, ID_Mecanico = @ID_Mecanico WHERE ID_Factura = @ID_Factura";
            Conexion.Open();
            SqlCommand Modificacion = new SqlCommand(UPDATE, Conexion);
            Modificacion.Parameters.AddWithValue("ID_Factura", txtID.Text);
            Modificacion.Parameters.AddWithValue("Repuesto", txtRep.Text);
            Modificacion.Parameters.AddWithValue("Costo_Repuesto", txtCostoRep.Text);
            Modificacion.Parameters.AddWithValue("Mano_De_Obra", txtMano.Text);
            Modificacion.Parameters.AddWithValue("Total_Factura", txtTotal.Text);
            Modificacion.Parameters.AddWithValue("Total_Euros", txtEuros.Text);
            Modificacion.Parameters.AddWithValue("Total_Pesetas", txtPesetas.Text);
            Modificacion.Parameters.AddWithValue("DNI_Cliente", txtCliente.Text);
            Modificacion.Parameters.AddWithValue("ID_Mecanico", txtMecanico.Text);
            Modificacion.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("Modificacion Realizada");
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }
            }
            txtID.Focus();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            string DELETE = "DELETE FROM FACTURA WHERE ID_Factura = @ID_Factura";
            Conexion.Open();
            SqlCommand Elim = new SqlCommand(DELETE, Conexion);
            Elim.Parameters.AddWithValue("ID_Factura", txtID.Text);
            Elim.ExecuteNonQuery();
            Elim.Dispose();
            Elim = null;
            Conexion.Close();
            MessageBox.Show("Factura Eliminada");
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }
            }
            txtID.Focus();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            string Cons = "SELECT * FROM FACTURA WHERE ID_Factura = @ID_Factura";
            Conexion.Open();
            SqlCommand Consulta = new SqlCommand(Cons, Conexion);
            Consulta.Parameters.AddWithValue("ID_Factura", txtID.Text);
            SqlDataReader Lector = Consulta.ExecuteReader();
            while (Lector.Read())
            {
                txtID.Text = Lector[0].ToString();
                txtRep.Text = Lector[1].ToString();
                txtCostoRep.Text = Lector[2].ToString();
                txtMano.Text = Lector[3].ToString();
                txtTotal.Text = Lector[4].ToString();
                txtEuros.Text = Lector[5].ToString();
                txtPesetas.Text = Lector[6].ToString();
                txtCliente.Text = Lector[7].ToString();
                txtMecanico.Text = Lector[8].ToString();
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
