using ProyectoFinal_Biblioteca.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Biblioteca.Formularios
{
    public partial class frmBusquedaPrestamos : Form
    {
        ConexionSQL x = new ConexionSQL();
        public frmBusquedaPrestamos()
        {
            InitializeComponent();
            this.vPRESTAMOTableAdapter.Connection.ConnectionString = x.Conexion;
            this.vPRESTAMO_DETALLETableAdapter.Connection.ConnectionString = x.Conexion;
        }
        private void Cargardetalles(int id)
        {
            this.vPRESTAMO_DETALLETableAdapter.Fill(this.dsvPrestamoDetalle.vPRESTAMO_DETALLE, id);
        }


        private void frmBusquedaPrestamos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsvPrestamoDetalle.vPRESTAMO_DETALLE' Puede moverla o quitarla según sea necesario.
            //this.vPRESTAMO_DETALLETableAdapter.Fill(this.dsvPrestamoDetalle.vPRESTAMO_DETALLE);
            // TODO: esta línea de código carga datos en la tabla 'dsvPrestamo.vPRESTAMO' Puede moverla o quitarla según sea necesario.
            this.vPRESTAMOTableAdapter.Fill(this.dsvPrestamo.vPRESTAMO);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Cargardetalles(dsvPrestamo.vPRESTAMO[vPRESTAMOBindingSource.Position].id);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
