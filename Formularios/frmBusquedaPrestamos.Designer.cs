namespace ProyectoFinal_Biblioteca.Formularios
{
    partial class frmBusquedaPrestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgPrestamoDetalle = new System.Windows.Forms.DataGridView();
            this.dsvPrestamo = new ProyectoFinal_Biblioteca.dsvPrestamo();
            this.vPRESTAMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vPRESTAMOTableAdapter = new ProyectoFinal_Biblioteca.dsvPrestamoTableAdapters.vPRESTAMOTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBibliotecarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bibliotecarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vPRESTAMODETALLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsvPrestamoDetalle = new ProyectoFinal_Biblioteca.dsvPrestamoDetalle();
            this.vPRESTAMO_DETALLETableAdapter = new ProyectoFinal_Biblioteca.dsvPrestamoDetalleTableAdapters.vPRESTAMO_DETALLETableAdapter();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrestamoDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsvPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPRESTAMOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPRESTAMODETALLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsvPrestamoDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.idBibliotecarioDataGridViewTextBoxColumn,
            this.bibliotecarioDataGridViewTextBoxColumn,
            this.fechaPrestamoDataGridViewTextBoxColumn,
            this.fechaDevolucionDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vPRESTAMOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 259);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dgPrestamoDetalle
            // 
            this.dgPrestamoDetalle.AllowUserToAddRows = false;
            this.dgPrestamoDetalle.AllowUserToDeleteRows = false;
            this.dgPrestamoDetalle.AutoGenerateColumns = false;
            this.dgPrestamoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrestamoDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.idPrestamoDataGridViewTextBoxColumn,
            this.idLibroDataGridViewTextBoxColumn,
            this.libroDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.dgPrestamoDetalle.DataSource = this.vPRESTAMODETALLEBindingSource;
            this.dgPrestamoDetalle.Location = new System.Drawing.Point(34, 327);
            this.dgPrestamoDetalle.Name = "dgPrestamoDetalle";
            this.dgPrestamoDetalle.ReadOnly = true;
            this.dgPrestamoDetalle.RowHeadersWidth = 51;
            this.dgPrestamoDetalle.RowTemplate.Height = 24;
            this.dgPrestamoDetalle.Size = new System.Drawing.Size(679, 220);
            this.dgPrestamoDetalle.TabIndex = 1;
            // 
            // dsvPrestamo
            // 
            this.dsvPrestamo.DataSetName = "dsvPrestamo";
            this.dsvPrestamo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vPRESTAMOBindingSource
            // 
            this.vPRESTAMOBindingSource.DataMember = "vPRESTAMO";
            this.vPRESTAMOBindingSource.DataSource = this.dsvPrestamo;
            // 
            // vPRESTAMOTableAdapter
            // 
            this.vPRESTAMOTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // idBibliotecarioDataGridViewTextBoxColumn
            // 
            this.idBibliotecarioDataGridViewTextBoxColumn.DataPropertyName = "idBibliotecario";
            this.idBibliotecarioDataGridViewTextBoxColumn.HeaderText = "idBibliotecario";
            this.idBibliotecarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idBibliotecarioDataGridViewTextBoxColumn.Name = "idBibliotecarioDataGridViewTextBoxColumn";
            this.idBibliotecarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idBibliotecarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // bibliotecarioDataGridViewTextBoxColumn
            // 
            this.bibliotecarioDataGridViewTextBoxColumn.DataPropertyName = "Bibliotecario";
            this.bibliotecarioDataGridViewTextBoxColumn.HeaderText = "Bibliotecario";
            this.bibliotecarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bibliotecarioDataGridViewTextBoxColumn.Name = "bibliotecarioDataGridViewTextBoxColumn";
            this.bibliotecarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.bibliotecarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaPrestamoDataGridViewTextBoxColumn
            // 
            this.fechaPrestamoDataGridViewTextBoxColumn.DataPropertyName = "FechaPrestamo";
            this.fechaPrestamoDataGridViewTextBoxColumn.HeaderText = "FechaPrestamo";
            this.fechaPrestamoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaPrestamoDataGridViewTextBoxColumn.Name = "fechaPrestamoDataGridViewTextBoxColumn";
            this.fechaPrestamoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaPrestamoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaDevolucionDataGridViewTextBoxColumn
            // 
            this.fechaDevolucionDataGridViewTextBoxColumn.DataPropertyName = "FechaDevolucion";
            this.fechaDevolucionDataGridViewTextBoxColumn.HeaderText = "FechaDevolucion";
            this.fechaDevolucionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDevolucionDataGridViewTextBoxColumn.Name = "fechaDevolucionDataGridViewTextBoxColumn";
            this.fechaDevolucionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDevolucionDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // idPrestamoDataGridViewTextBoxColumn
            // 
            this.idPrestamoDataGridViewTextBoxColumn.DataPropertyName = "idPrestamo";
            this.idPrestamoDataGridViewTextBoxColumn.HeaderText = "idPrestamo";
            this.idPrestamoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPrestamoDataGridViewTextBoxColumn.Name = "idPrestamoDataGridViewTextBoxColumn";
            this.idPrestamoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPrestamoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idLibroDataGridViewTextBoxColumn
            // 
            this.idLibroDataGridViewTextBoxColumn.DataPropertyName = "idLibro";
            this.idLibroDataGridViewTextBoxColumn.HeaderText = "idLibro";
            this.idLibroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idLibroDataGridViewTextBoxColumn.Name = "idLibroDataGridViewTextBoxColumn";
            this.idLibroDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLibroDataGridViewTextBoxColumn.Width = 125;
            // 
            // libroDataGridViewTextBoxColumn
            // 
            this.libroDataGridViewTextBoxColumn.DataPropertyName = "Libro";
            this.libroDataGridViewTextBoxColumn.HeaderText = "Libro";
            this.libroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.libroDataGridViewTextBoxColumn.Name = "libroDataGridViewTextBoxColumn";
            this.libroDataGridViewTextBoxColumn.ReadOnly = true;
            this.libroDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // vPRESTAMODETALLEBindingSource
            // 
            this.vPRESTAMODETALLEBindingSource.DataMember = "vPRESTAMO_DETALLE";
            this.vPRESTAMODETALLEBindingSource.DataSource = this.dsvPrestamoDetalle;
            // 
            // dsvPrestamoDetalle
            // 
            this.dsvPrestamoDetalle.DataSetName = "dsvPrestamoDetalle";
            this.dsvPrestamoDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vPRESTAMO_DETALLETableAdapter
            // 
            this.vPRESTAMO_DETALLETableAdapter.ClearBeforeFill = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(801, 489);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(92, 35);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(936, 489);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 35);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmBusquedaPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1128, 587);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgPrestamoDetalle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBusquedaPrestamos";
            this.Text = "frmBusquedaPrestamos";
            this.Load += new System.EventHandler(this.frmBusquedaPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrestamoDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsvPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPRESTAMOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPRESTAMODETALLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsvPrestamoDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dgPrestamoDetalle;
        public dsvPrestamo dsvPrestamo;
        public System.Windows.Forms.BindingSource vPRESTAMOBindingSource;
        public dsvPrestamoTableAdapters.vPRESTAMOTableAdapter vPRESTAMOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBibliotecarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bibliotecarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDevolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        public dsvPrestamoDetalle dsvPrestamoDetalle;
        public System.Windows.Forms.BindingSource vPRESTAMODETALLEBindingSource;
        public dsvPrestamoDetalleTableAdapters.vPRESTAMO_DETALLETableAdapter vPRESTAMO_DETALLETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}