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
    public partial class frmRClientes : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmRClientes()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }
        void Cargarcb()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from CLIENTE";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbClientes.DisplayMember = "APaterno";
            cbClientes.ValueMember = "id";
            cbClientes.DataSource = dt;
        }
        
        private void frmRClientes_Load(object sender, EventArgs e)
        {
            Cargarcb();
        }
        void CargarReporte()
        {
            DataTable dt = new DataTable();
            string consulta = "";
            if (chTodo.Checked == true)
            {
                consulta = "select * from vClientes";
            }
            else
            {
                consulta = $"select * from vClientes where id = {cbClientes.SelectedValue.ToString()}";
            }
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            this.rvClientes.LocalReport.DataSources.Clear();
            this.rvClientes.LocalReport.ReportEmbeddedResource = "ProyectoFinal_Biblioteca.Reportes.rClientes.rdlc";
            ReportDataSource r = new ReportDataSource("dsRClientes", dt);
            this.rvClientes.LocalReport.DataSources.Add(r);
            this.rvClientes.RefreshReport();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
