using ProyectoFinal_Biblioteca.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Biblioteca.Formularios
{
    public partial class frmPrestamo : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmPrestamo()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void CargarBibliotecarios()
        {
            DataTable dt = new DataTable();
            string consulta = "select id, Nombre + ' ' + APaterno + ' ' + AMaterno + ' ' as NombreCompleto from BIBLIOTECARIO";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbBibliotecario.DisplayMember = "NombreCompleto";
            cbBibliotecario.ValueMember = "id";
            cbBibliotecario.DataSource = dt;
        }
        void CargarClientes()
        {
            DataTable dt = new DataTable();
            string consulta = "select id, Nombre + ' ' + APaterno + ' ' + AMaterno + ' ' as NombreCompleto from CLIENTE";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbCliente.DisplayMember = "NombreCompleto";
            cbCliente.ValueMember = "id";
            cbCliente.DataSource = dt;
        }
        void CargarEstado()
        {
            cbEstado.Items.Add("Pendiente");
            cbEstado.Items.Add("Devuelto");
            cbEstado.SelectedIndex = 0;
        }
        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            CargarBibliotecarios();
            CargarClientes();
            CargarEstado();
            Clases.Herramientas h = new Herramientas();
            txtID.Text = h.consecutivo("id", "PRESTAMO").ToString();
        }

    }
}
