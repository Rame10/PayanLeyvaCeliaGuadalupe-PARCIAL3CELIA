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
    public partial class frmGeneros : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmGeneros()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }
        void Limpiar()
        {
            txtNombre.Clear();
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "GENERO").ToString();
            txtNombre.Focus();
        }
        bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtId.Text);
            string cadena = $"select * from GENERO where id = {id}";
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

        private void frmGeneros_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "GENERO").ToString();
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            Clases.Generos x = new Clases.Generos();
            x.id = int.Parse(txtId.Text);
            x.Nombre = txtNombre.Text;
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
            Busquedas.frmBusquedaGeneros x = new Busquedas.frmBusquedaGeneros();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtId.Text = x.dgGeneros.SelectedRows[0].Cells["id"].Value.ToString();
                txtNombre.Text = x.dgGeneros.SelectedRows[0].Cells["Nombre"].Value.ToString();
            }
        }
        void Obtener()
        {
            string consulta = $"select * from GENERO where id = {txtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtNombre.Text = reader["Nombre"].ToString();
            }
            else
            {
                MessageBox.Show("El ID ingresado no le corresponde a ningún género");
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
            Clases.Generos x = new Generos();
            x.id = int.Parse(txtId.Text);
            MessageBox.Show(x.Eliminar());
            Limpiar();
        }
    }
}
