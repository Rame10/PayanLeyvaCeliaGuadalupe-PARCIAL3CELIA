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
        void CargarLibros()
        {
            DataTable dt = new DataTable();
            string consulta = "select id, Titulo from LIBRO";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbLibros.DisplayMember = "Titulo";
            cbLibros.ValueMember = "id";
            cbLibros.DataSource = dt;
        }
        void Cargardg()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("", con);
            da.SelectCommand.CommandType = CommandType.Text;
            da.SelectCommand.CommandText = "select PD.id, PD.idPrestamo, PD.idLibro, L.Titulo as Libro, PD.Cantidad from PRESTAMO_DETALLE PD INNER JOIN LIBRO L on L.id = PD.idLibro where PD.idPrestamo = @idPrestamo";
            da.SelectCommand.Parameters.Clear();
            da.SelectCommand.Parameters.AddWithValue("@idPrestamo", txtID.Text);
            da.Fill(dt);
            dgPrestamo.DataSource = dt;
        }
        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            CargarBibliotecarios();
            CargarClientes();
            CargarEstado();
            CargarLibros();
            Clases.Herramientas h = new Herramientas();
            txtID.Text = h.consecutivo("id", "PRESTAMO").ToString();
            Confdg();
        }

        DataTable dt = new DataTable();
        void Confdg()
        {
            dt.Columns.Add("id");
            dt.Columns.Add("idPrestamo");
            dt.Columns.Add("idLibro");
            dt.Columns.Add("Libro");
            dt.Columns.Add("Cantidad");
            dgPrestamo.DataSource = dt;
        }
        void Agregar()
        {
            DataRow fila = dt.NewRow();
            fila["id"] = 0;
            fila["idPrestamo"] = txtID.Text;
            fila["idLibro"] = cbLibros.SelectedValue.ToString();
            fila["Libro"] = cbLibros.Text;
            fila["Cantidad"] = txtCantidad.Text;
            dt.Rows.Add(fila);
            dgPrestamo.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Clases.Prestamo x = new Clases.Prestamo();
            x.id = int.Parse(txtID.Text);
            x.idBibliotecario = int.Parse(cbBibliotecario.SelectedValue.ToString());
            x.idCliente = int.Parse(cbCliente.SelectedValue.ToString());
            x.FechaPrestamo = dtpFecha.Value.ToString("yyyy/MM/dd");
            x.FechaDevolucion = dtpFechaDevolucion.Value.ToString("yyyy/MM/dd");
            x.Estado = cbEstado.SelectedIndex;
            x.Guardar();
            foreach (DataGridViewRow fila in dgPrestamo.Rows)
            {
                x.idLibro = int.Parse(fila.Cells[2].Value.ToString());
                x.Cantidad = int.Parse(fila.Cells[4].Value.ToString());
                x.GuardarDetalle();
            }
            MessageBox.Show("SE GUARDÓ EL REGISTRO");
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Formularios.frmBusquedaPrestamos x = new Formularios.frmBusquedaPrestamos();
            x.ShowDialog();
            if (x.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                txtID.Text = x.dsvPrestamo.vPRESTAMO[x.vPRESTAMOBindingSource.Position].id.ToString();
                dtpFecha.Value = x.dsvPrestamo.vPRESTAMO[x.vPRESTAMOBindingSource.Position].FechaPrestamo;
                dtpFechaDevolucion.Value = x.dsvPrestamo.vPRESTAMO[x.vPRESTAMOBindingSource.Position].FechaDevolucion;
                cbBibliotecario.SelectedValue = x.dsvPrestamo.vPRESTAMO[x.vPRESTAMOBindingSource.Position].idBibliotecario;
                cbCliente.SelectedValue = x.dsvPrestamo.vPRESTAMO[x.vPRESTAMOBindingSource.Position].idCliente;
                cbEstado.SelectedValue = x.dsvPrestamo.vPRESTAMO[x.vPRESTAMOBindingSource.Position].Estado;
                dgPrestamo.DataSource = x.dsvPrestamoDetalle.vPRESTAMO_DETALLE;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string consulta = $"delete from PRESTAMO where id = {int.Parse(txtID.Text)}";
            SqlCommand cmd = new SqlCommand(consulta, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("SE ELIMINÓ EL REGISTRO");
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
