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
    public partial class frmColonias : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmColonias()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }
        void Limpiar()
        {
            txtColonia.Clear();
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "COLONIA").ToString();
            txtColonia.Focus();
        }
        bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtId.Text);
            string cadena = $"select * from COLONIA where id = {id}";
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

        private void frmColonias_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "COLONIA").ToString();
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            Clases.Colonias x = new Clases.Colonias();
            x.id = int.Parse(txtId.Text);
            x.Colonia = txtColonia.Text;
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
            Busquedas.frmBusquedaColonias x = new Busquedas.frmBusquedaColonias();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtId.Text = x.dgColonias.SelectedRows[0].Cells["id"].Value.ToString();
                txtColonia.Text = x.dgColonias.SelectedRows[0].Cells["Colonia"].Value.ToString();
            }
        }
        void Obtener()
        {
            string consulta = $"select * from COLONIA where id = {txtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtColonia.Text = reader["Colonia"].ToString();
            }
            else
            {
                MessageBox.Show("El ID ingresado no le corresponde a ninguna colonia");
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
            Clases.Colonias x = new Clases.Colonias();
            x.id = int.Parse(txtId.Text);
            MessageBox.Show(x.Eliminar());
            Limpiar();
        }
    }
}
