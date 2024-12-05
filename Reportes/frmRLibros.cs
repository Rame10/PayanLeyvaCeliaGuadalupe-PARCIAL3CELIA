using Microsoft.Reporting.WinForms;
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

namespace ProyectoFinal_Biblioteca.Reportes
{
    public partial class frmRLibros : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmRLibros()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void Cargarcb()
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

        private void frmRLibros_Load(object sender, EventArgs e)
        {
            Cargarcb();
        }

        void CargarReporte()
        {
            DataTable dt = new DataTable();
            string consulta = "";
            if (chTodo.Checked == true)
            {
                consulta = "select * from vLibros";
            }
            else
            {
                consulta = $"select * from vLibros where idCategoria = {cbCategorias.SelectedValue.ToString()}";
            }
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            this.rvLibros.LocalReport.DataSources.Clear();
            this.rvLibros.LocalReport.ReportEmbeddedResource = "ProyectoFinal_Biblioteca.Reportes.rLibros.rdlc";
            ReportDataSource r = new ReportDataSource("dsRLibros", dt);
            this.rvLibros.LocalReport.DataSources.Add(r);
            this.rvLibros.RefreshReport();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
