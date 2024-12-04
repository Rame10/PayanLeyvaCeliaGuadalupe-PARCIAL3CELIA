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
    public partial class frmRDomicilios : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmRDomicilios()
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

        private void frmRDomicilios_Load(object sender, EventArgs e)
        {
            Cargarcb();
        }

        void CargarReporte()
        {
            DataTable dt = new DataTable();
            string consulta = "";
            if (chTodo.Checked == true)
            {
                consulta = "select * from vDomicilios";
            }
            else
            {
                consulta = $"select * from vDomicilios where idColonia = {cbColonias.SelectedValue.ToString()}";
            }
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            this.rvDomicilios.LocalReport.DataSources.Clear();
            this.rvDomicilios.LocalReport.ReportEmbeddedResource = "ProyectoFinal_Biblioteca.Reportes.rDomicilios.rdlc";
            ReportDataSource r = new ReportDataSource("dsRDomicilios", dt);
            this.rvDomicilios.LocalReport.DataSources.Add(r);
            this.rvDomicilios.RefreshReport();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
