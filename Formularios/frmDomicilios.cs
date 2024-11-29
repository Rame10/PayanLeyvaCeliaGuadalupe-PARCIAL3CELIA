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
    public partial class frmDomicilios : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmDomicilios()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }
        void Cargarcb()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from COLONIA";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbColonias.DisplayMember = "Colonia";
            cbColonias.ValueMember = "id";
            cbColonias.DataSource = dt;
        }
        void Limpiar()
        {
            txtCalle.Clear();
            txtCP.Clear();
            txtReferencias.Clear();
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "DOMICILIO").ToString();
            txtCalle.Focus();
            Cargarcb();
        }
        bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtId.Text);
            string cadena = $"select * from DOMICILIO where id = {id}";
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

        private void frmDomicilios_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "DOMICILIO").ToString();
            Cargarcb();
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            Clases.Domicilios x = new Clases.Domicilios();
            x.id = int.Parse(txtId.Text);
            x.Calle = txtCalle.Text;
            x.CP = txtCP.Text;
            x.Referencias = txtReferencias.Text;
            x.idColonia = int.Parse(cbColonias.SelectedValue.ToString());
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

        //PREGUNTAR A LA MAESTRA COMO HACER QUE SOLO MUESTRE EL TEXTO EL LUGAR DEL IDCOLONIA
        private void tsBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.frmBusquedaDomicilios x = new Busquedas.frmBusquedaDomicilios();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtId.Text = x.dgDomicilios.SelectedRows[0].Cells["id"].Value.ToString();
                txtCalle.Text = x.dgDomicilios.SelectedRows[0].Cells["Calle"].Value.ToString();
                txtCP.Text = x.dgDomicilios.SelectedRows[0].Cells["CódigoPostal"].Value.ToString();
                txtReferencias.Text = x.dgDomicilios.SelectedRows[0].Cells["Referencias"].Value.ToString();
                cbColonias.SelectedText =" ";
                cbColonias.SelectedText = x.dgDomicilios.SelectedRows[0].Cells["Colonia"].Value.ToString();
            }
        }
        void Obtener()
        {
            string consulta = $"select * from DOMICILIO where id = {txtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtCalle.Text = reader["Calle"].ToString();
                txtCP.Text = reader["CP"].ToString();
                txtReferencias.Text = reader["Referencias"].ToString();
                cbColonias.SelectedValue = int.Parse(reader["idColonia"].ToString());
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
            Clases.Domicilios x = new Clases.Domicilios();
            x.id = int.Parse(txtId.Text);
            MessageBox.Show(x.Eliminar());
            Limpiar();
        }
    }
}
