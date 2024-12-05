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
    public partial class frmLibros : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmLibros()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void CargarAutor()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from AUTOR";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbAutores.DisplayMember = "Nombre";
            cbAutores.ValueMember = "id";
            cbAutores.DataSource = dt;
        }

        void CargarGenero()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from GENERO";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbGeneros.DisplayMember = "Nombre";
            cbGeneros.ValueMember = "id";
            cbGeneros.DataSource = dt;
        }
        void CargarEditorial()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from EDITORIAL";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbEditoriales.DisplayMember = "Nombre";
            cbEditoriales.ValueMember = "id";
            cbEditoriales.DataSource = dt;
        }
        void CargarCategoria()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from CATEGORIA";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbCategorias.DisplayMember = "Categoria";
            cbCategorias.ValueMember = "id";
            cbCategorias.DataSource = dt;
        }
        
        bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtId.Text);
            string cadena = $"select * from LIBRO where id = {id}";
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

        private void frmLibros_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "LIBRO").ToString();
            CargarAutor();
            CargarGenero();
            CargarEditorial();
            CargarCategoria();
        }
        void Limpiar()
        {
            txtTitulo.Clear();
            txtISBN.Clear();
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "LIBRO").ToString();
            txtTitulo.Focus();
            CargarAutor();
            CargarGenero();
            CargarEditorial();
            CargarCategoria();
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            Clases.Libros x = new Clases.Libros();
            x.id = int.Parse(txtId.Text);
            x.Titulo = txtTitulo.Text;
            x.ISBN = txtISBN.Text;
            x.idAutor = int.Parse(cbAutores.SelectedValue.ToString());
            x.idGenero = int.Parse(cbGeneros.SelectedValue.ToString());
            x.idEditorial = int.Parse(cbEditoriales.SelectedValue.ToString());
            x.idCategoria = int.Parse(cbCategorias.SelectedValue.ToString());
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
            Busquedas.frmBusquedaLibros x = new Busquedas.frmBusquedaLibros();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtId.Text = x.dgLibros.SelectedRows[0].Cells["id"].Value.ToString();
                txtTitulo.Text = x.dgLibros.SelectedRows[0].Cells["Titulo"].Value.ToString();
                txtISBN.Text = x.dgLibros.SelectedRows[0].Cells["ISBN"].Value.ToString();
                cbAutores.SelectedValue = int.Parse(x.dgLibros.SelectedRows[0].Cells["idAutor"].Value.ToString());
                cbGeneros.SelectedValue = int.Parse(x.dgLibros.SelectedRows[0].Cells["idGenero"].Value.ToString());
                cbEditoriales.SelectedValue = int.Parse(x.dgLibros.SelectedRows[0].Cells["idEditorial"].Value.ToString());
                cbCategorias.SelectedValue = int.Parse(x.dgLibros.SelectedRows[0].Cells["idCategoria"].Value.ToString());
            }
        }

        void Obtener()
        {
            string consulta = $"select * from LIBRO where id = {txtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtTitulo.Text = reader["Titulo"].ToString();
                txtISBN.Text = reader["ISBN"].ToString();
                cbAutores.SelectedValue = int.Parse(reader["idAutor"].ToString());
                cbGeneros.SelectedValue = int.Parse(reader["idGenero"].ToString());
                cbEditoriales.SelectedValue = int.Parse(reader["idEditorial"].ToString());
                cbCategorias.SelectedValue = int.Parse(reader["idCategoria"].ToString());
            }
            else
            {
                MessageBox.Show("El ID ingresado no le corresponde a ningún libro.");
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
            Clases.Libros x = new Clases.Libros();
            x.id = int.Parse(txtId.Text);
            MessageBox.Show(x.Eliminar());
            Limpiar();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.frmRLibros x = new Reportes.frmRLibros();
            x.ShowDialog();
        }
    }
}
