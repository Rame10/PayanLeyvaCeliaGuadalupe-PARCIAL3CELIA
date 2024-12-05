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
    public partial class frmBusquedaBibliotecarios : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmBusquedaBibliotecarios()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void Cargardg()
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand($"SELECT B.id, B.Nombre, B.APaterno as ApellidoPaterno, B.AMaterno as ApellidoMaterno, B.idDomicilio, D.CP as CódigoPostal, B.FechaDeNacimiento, B.Telefono, B.Email, B.RFC, B.NSS, B.Turno FROM BIBLIOTECARIO B INNER JOIN DOMICILIO D ON D.ID = B.idDomicilio where Nombre like '%{txtFiltro.Text}%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgBibliotecarios.DataSource = dt;
            con.Close();
        }
        private void frmBusquedaBibliotecarios_Load(object sender, EventArgs e)
        {
            try
            {
                dgBibliotecarios.Rows[0].Selected = true;
            }
            catch
            {

            }
        }

        private void dgBibliotecarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgBibliotecarios.CurrentRow.Index;
            dgBibliotecarios.Rows[i].Selected = true;
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
