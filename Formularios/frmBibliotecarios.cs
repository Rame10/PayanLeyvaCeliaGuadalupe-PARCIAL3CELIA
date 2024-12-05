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
    public partial class frmBibliotecarios : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmBibliotecarios()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void Cargarcb()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from DOMICILIO";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbDomicilio.DisplayMember = "Calle";
            cbDomicilio.ValueMember = "id";
            cbDomicilio.DataSource = dt;
        }
        void LlenarCb()
        {
            cbTurno.Items.Add("Matutino");
            cbTurno.Items.Add("Vespertino");
            cbTurno.SelectedIndex = 0;
        }
        void Limpiar()
        {
            txtNombre.Clear();
            txtAPaterno.Clear();
            txtAMaterno.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
            txtTelefono.Clear();
            txtEmail.Clear();
            txtRFC.Clear();
            txtNSS.Clear();
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "BIBLIOTECARIO").ToString();
            txtNombre.Focus();
            Cargarcb();
            cbTurno.SelectedIndex = 0;
        }
        bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtId.Text);
            string cadena = $"select * from BIBLIOTECARIO where id = {id}";
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

        private void frmBibliotecarios_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "BIBLIOTECARIO").ToString();
            Cargarcb();
            LlenarCb();
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            Clases.Bibliotecarios x = new Clases.Bibliotecarios();
            x.id = int.Parse(txtId.Text);
            x.Nombre = txtNombre.Text;
            x.APaterno = txtAPaterno.Text;
            x.AMaterno = txtAMaterno.Text;
            x.idDomicilio = int.Parse(cbDomicilio.SelectedValue.ToString());
            string fechanacimiento = dtpFechaNacimiento.Value.Year.ToString() + "/" + dtpFechaNacimiento.Value.Month.ToString() + "/" + dtpFechaNacimiento.Value.Day.ToString();
            x.FechaDeNacimiento = fechanacimiento;
            x.Telefono = txtTelefono.Text;
            x.Email = txtEmail.Text;    
            x.RFC = txtRFC.Text;
            x.NSS = txtNSS.Text;
            x.Turno = cbTurno.SelectedIndex;
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
            Busquedas.frmBusquedaBibliotecarios x = new Busquedas.frmBusquedaBibliotecarios();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtId.Text = x.dgBibliotecarios.SelectedRows[0].Cells["id"].Value.ToString();
                txtNombre.Text = x.dgBibliotecarios.SelectedRows[0].Cells["Nombre"].Value.ToString();
                txtAPaterno.Text = x.dgBibliotecarios.SelectedRows[0].Cells["ApellidoPaterno"].Value.ToString();
                txtAMaterno.Text = x.dgBibliotecarios.SelectedRows[0].Cells["ApellidoMaterno"].Value.ToString();
                cbDomicilio.SelectedValue = int.Parse(x.dgBibliotecarios.SelectedRows[0].Cells["idDomicilio"].Value.ToString());
                dtpFechaNacimiento.Value = DateTime.Parse(x.dgBibliotecarios.SelectedRows[0].Cells["FechaDeNacimiento"].Value.ToString());
                txtTelefono.Text = x.dgBibliotecarios.SelectedRows[0].Cells["Telefono"].Value.ToString();
                txtEmail.Text = x.dgBibliotecarios.SelectedRows[0].Cells["Email"].Value.ToString();
                txtRFC.Text = x.dgBibliotecarios.SelectedRows[0].Cells["RFC"].Value.ToString();
                txtNSS.Text = x.dgBibliotecarios.SelectedRows[0].Cells["NSS"].Value.ToString();
                cbTurno.SelectedIndex = int.Parse(x.dgBibliotecarios.SelectedRows[0].Cells["Turno"].Value.ToString());
            }
        }
        void Obtener()
        {
            string consulta = $"select * from BIBLIOTECARIO where id = {txtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtNombre.Text = reader["Nombre"].ToString();
                txtAPaterno.Text = reader["APaterno"].ToString();
                txtAMaterno.Text = reader["AMaterno"].ToString();
                cbDomicilio.SelectedValue = int.Parse(reader["idDomicilio"].ToString());
                dtpFechaNacimiento.Value = DateTime.Parse(reader["FechaDeNacimiento"].ToString());
                txtTelefono.Text = reader["Telefono"].ToString();
                txtEmail.Text = reader["Email"].ToString();
                txtRFC.Text = reader["RFC"].ToString();
                txtNSS.Text = reader["NSS"].ToString();
                cbTurno.SelectedIndex = int.Parse(reader["Turno"].ToString());
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
            Clases.Bibliotecarios x = new Bibliotecarios();
            x.id = int.Parse(txtId.Text);
            MessageBox.Show(x.Eliminar());
            Limpiar();
        }
    }
}
