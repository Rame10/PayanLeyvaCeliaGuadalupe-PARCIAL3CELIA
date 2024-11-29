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
    public partial class frmClientes : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmClientes()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void Cargarcb()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from COLONIA";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbDomicilio.DisplayMember = "Colonia";
            cbDomicilio.ValueMember = "id";
            cbDomicilio.DataSource = dt;
        }
        void Limpiar()
        {
            txtNombre.Clear();
            txtAPaterno.Clear();
            txtAMaterno.Clear();
            txtCURP.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "CLIENTE").ToString();
            txtNombre.Focus();
            Cargarcb();
        }
        bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtId.Text);
            string cadena = $"select * from CLIENTE where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(cadena, con);
            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                a = true;
            }
            else
            {
                a = false;
            }
            con.Close();
            return a;
        }
        private void frmClientes_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "CLIENTE").ToString();
            Cargarcb();
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            Clases.Clientes x = new Clases.Clientes();
            x.id = int.Parse(txtId.Text);
            x.Nombre = txtNombre.Text;
            x.APaterno = txtAPaterno.Text;
            x.AMaterno = txtAMaterno.Text;
            x.idDomicilio = int.Parse(cbDomicilio.SelectedValue.ToString());
            x.CURP = txtCURP.Text;
            x.Telefono = txtTelefono.Text;
            x.Email = txtEmail.Text;
            if (encontro() == true)
            {
                MessageBox.Show(x.Actualizar());
            }
            else
            {
                MessageBox.Show(x.Guardar());
            }
            Limpiar();
        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.frmBusquedaClientes x = new Busquedas.frmBusquedaClientes();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtId.Text = x.dgClientes.SelectedRows[0].Cells["id"].Value.ToString();
                txtNombre.Text = x.dgClientes.SelectedRows[0].Cells["Nombre"].Value.ToString();
                txtAPaterno.Text = x.dgClientes.SelectedRows[0].Cells["APaterno"].Value.ToString();
                txtAMaterno.Text = x.dgClientes.SelectedRows[0].Cells["AMaterno"].Value.ToString();
                cbDomicilio.SelectedValue = int.Parse(x.dgClientes.SelectedRows[0].Cells["idDomicilio"].Value.ToString());
                txtCURP.Text = x.dgClientes.SelectedRows[0].Cells["CURP"].Value.ToString();
                txtTelefono.Text = x.dgClientes.SelectedRows[0].Cells["Telefono"].Value.ToString();
                txtEmail.Text = x.dgClientes.SelectedRows[0].Cells["Email"].Value.ToString();
            }
        }
        void Obtener()
        {
            string consulta = $"select * from CLIENTE where id = {txtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtNombre.Text = reader["Nombre"].ToString();
                txtAPaterno.Text = reader["APaterno"].ToString();
                txtAMaterno.Text = reader["AMaterno"].ToString();
                cbDomicilio.SelectedValue = int.Parse(reader["idDomicilio"].ToString());
                txtCURP.Text = reader["CURP"].ToString();
                txtTelefono.Text = reader["Telefono"].ToString();
                txtEmail.Text = reader["Email"].ToString();
            }
            else
            {
                MessageBox.Show("El ID ingresado no le corresponde a ningún domicilio.");
            }
            con.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "0" || txtId.Text == "")
            {
                MessageBox.Show("ID no válido");
            }
            else
            {
                Obtener();
            }
        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            Clases.Clientes x = new Clientes();
            x.id = int.Parse(txtId.Text);
            MessageBox.Show(x.Eliminar());
            Limpiar();
        }
    }
}
