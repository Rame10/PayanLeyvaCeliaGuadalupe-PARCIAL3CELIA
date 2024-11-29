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

namespace ProyectoFinal_Biblioteca.Busquedas
{
    public partial class frmBusquedaCategorias : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmBusquedaCategorias()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }
        void Cargardg()
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand($"select * from CATEGORIA where Categoria like '%{txtFiltro.Text}%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgCategorias.DataSource = dt;
            con.Close();
        }

        private void frmBusquedaCategorias_Load(object sender, EventArgs e)
        {
            try
            {
                dgCategorias.Rows[0].Selected = true;
            }
            catch
            {

            }
        }

        private void dgCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgCategorias.CurrentRow.Index;
            dgCategorias.Rows[i].Selected = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cargardg();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Cargardg();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
