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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void tsAutores_Click(object sender, EventArgs e)
        {
            frmAutores x = new frmAutores();
            x.Show();
        }

        private void dOMICILIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDomicilios x = new frmDomicilios();
            x.Show();
        }

        private void tsGeneros_Click(object sender, EventArgs e)
        {
            frmGeneros x = new frmGeneros();
            x.Show();
        }

        private void tsEditoriales_Click(object sender, EventArgs e)
        {
            frmEditoriales x = new frmEditoriales();
            x.Show();
        }

        private void tsCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias x = new frmCategorias();
            x.Show();
        }

        private void cOLONIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColonias x = new frmColonias();
            x.Show();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes x = new frmClientes();
            x.Show();
        }

        private void tsBibliotecario_Click(object sender, EventArgs e)
        {
            frmBibliotecarios x = new frmBibliotecarios();
            x.Show();
        }

        private void tsLibros_Click(object sender, EventArgs e)
        {
            frmLibros x = new frmLibros();  
            x.Show();
        }
    }
}
