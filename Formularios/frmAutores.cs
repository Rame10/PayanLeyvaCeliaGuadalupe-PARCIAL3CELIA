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
    public partial class frmAutores : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmAutores()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }
        void Limpiar()
        {
            txtNombre.Clear();
            txtNacionalidad.Clear();
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "AUTOR").ToString();
            txtNombre.Focus();
        }
        bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtId.Text);
            string cadena = $"select * from AUTOR where id = {id}";
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

        private void frmAutores_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "AUTOR").ToString();
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            Clases.Autores x = new Clases.Autores();
            x.id = int.Parse(txtId.Text);
            x.Nombre = txtNombre.Text;
            x.Nacionalidad = txtNacionalidad.Text;
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
            Busquedas.frmBusquedaAutores x = new Busquedas.frmBusquedaAutores();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtId.Text = x.dgAutores.SelectedRows[0].Cells["id"].Value.ToString();
                txtNombre.Text = x.dgAutores.SelectedRows[0].Cells["Nombre"].Value.ToString();
                txtNacionalidad.Text = x.dgAutores.SelectedRows[0].Cells["Nacionalidad"].Value.ToString();
            }
        }
        void Obtener()
        {
            string consulta = $"select * from AUTOR where id = {txtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtNombre.Text = reader["Nombre"].ToString();
                txtNacionalidad.Text = reader["Nacionalidad"].ToString();
            }
            else
            {
                MessageBox.Show("El ID ingresado no le corresponde a ningún autor");
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
            Clases.Autores x = new Clases.Autores();
            x.id = int.Parse(txtId.Text);
            MessageBox.Show(x.Eliminar());
            Limpiar();
        }
    }
}
