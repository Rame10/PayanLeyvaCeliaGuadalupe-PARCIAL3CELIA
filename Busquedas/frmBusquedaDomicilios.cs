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
    public partial class frmBusquedaDomicilios : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmBusquedaDomicilios()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }
        void Cargardg()
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand($"SELECT D.id, D.Calle, D.CP CódigoPostal, C.Colonia Colonia, D.Referencias FROM DOMICILIO D INNER JOIN COLONIA C ON C.id = D.idColonia where Calle like '%{txtFiltro.Text}%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgDomicilios.DataSource = dt;
            con.Close();
        }

        private void frmBusquedaDomicilios_Load(object sender, EventArgs e)
        {
            try
            {
                dgDomicilios.Rows[0].Selected = true;
            }
            catch
            {

            }
        }

        private void dgDomicilios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgDomicilios.CurrentRow.Index;
            dgDomicilios.Rows[i].Selected = true;
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
