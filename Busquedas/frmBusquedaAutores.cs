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
    public partial class frmBusquedaAutores : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmBusquedaAutores()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void Cargardg()
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand($"select * from AUTOR where Nombre like '%{txtFiltro.Text}%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgAutores.DataSource = dt;
            con.Close();
        }
        private void frmBusquedaAutores_Load(object sender, EventArgs e)
        {
            try
            {
                dgAutores.Rows[0].Selected = true;
            }
            catch
            {

            }
        }

        private void dgAutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgAutores.CurrentRow.Index;
            dgAutores.Rows[i].Selected = true;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Cargardg();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cargardg();        }

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
