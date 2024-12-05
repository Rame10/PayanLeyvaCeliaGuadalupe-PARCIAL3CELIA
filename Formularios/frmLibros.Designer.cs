namespace ProyectoFinal_Biblioteca.Formularios
{
    partial class frmLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibros));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsLimpiar = new System.Windows.Forms.ToolStripButton();
            this.tsEliminar = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.cbAutores = new System.Windows.Forms.ComboBox();
            this.cbGeneros = new System.Windows.Forms.ComboBox();
            this.cbEditoriales = new System.Windows.Forms.ComboBox();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(220, 76);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 28);
            this.btnBuscar.TabIndex = 79;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(96, 79);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 19);
            this.label1.TabIndex = 77;
            this.label1.Text = "ID";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGuardar,
            this.tsBuscar,
            this.tsLimpiar,
            this.tsEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 76;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsGuardar
            // 
            this.tsGuardar.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsGuardar.Image")));
            this.tsGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsGuardar.Name = "tsGuardar";
            this.tsGuardar.Size = new System.Drawing.Size(103, 36);
            this.tsGuardar.Text = "Guardar";
            this.tsGuardar.Click += new System.EventHandler(this.tsGuardar_Click);
            // 
            // tsBuscar
            // 
            this.tsBuscar.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.tsBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsBuscar.Image")));
            this.tsBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBuscar.Name = "tsBuscar";
            this.tsBuscar.Size = new System.Drawing.Size(92, 36);
            this.tsBuscar.Text = "Buscar";
            this.tsBuscar.Click += new System.EventHandler(this.tsBuscar_Click);
            // 
            // tsLimpiar
            // 
            this.tsLimpiar.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.tsLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("tsLimpiar.Image")));
            this.tsLimpiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLimpiar.Name = "tsLimpiar";
            this.tsLimpiar.Size = new System.Drawing.Size(101, 36);
            this.tsLimpiar.Text = "Limpiar";
            this.tsLimpiar.Click += new System.EventHandler(this.tsLimpiar_Click);
            // 
            // tsEliminar
            // 
            this.tsEliminar.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.tsEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsEliminar.Image")));
            this.tsEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEliminar.Name = "tsEliminar";
            this.tsEliminar.Size = new System.Drawing.Size(107, 36);
            this.tsEliminar.Text = "Eliminar";
            this.tsEliminar.Click += new System.EventHandler(this.tsEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 80;
            this.label2.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 81;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 82;
            this.label4.Text = "Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 83;
            this.label5.Text = "Género";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 84;
            this.label6.Text = "Editorial";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 85;
            this.label7.Text = "Categoría";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(148, 133);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(500, 22);
            this.txtTitulo.TabIndex = 86;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(148, 183);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(286, 22);
            this.txtISBN.TabIndex = 87;
            // 
            // cbAutores
            // 
            this.cbAutores.FormattingEnabled = true;
            this.cbAutores.Location = new System.Drawing.Point(148, 233);
            this.cbAutores.Name = "cbAutores";
            this.cbAutores.Size = new System.Drawing.Size(286, 24);
            this.cbAutores.TabIndex = 88;
            // 
            // cbGeneros
            // 
            this.cbGeneros.FormattingEnabled = true;
            this.cbGeneros.Location = new System.Drawing.Point(148, 283);
            this.cbGeneros.Name = "cbGeneros";
            this.cbGeneros.Size = new System.Drawing.Size(286, 24);
            this.cbGeneros.TabIndex = 89;
            // 
            // cbEditoriales
            // 
            this.cbEditoriales.FormattingEnabled = true;
            this.cbEditoriales.Location = new System.Drawing.Point(148, 334);
            this.cbEditoriales.Name = "cbEditoriales";
            this.cbEditoriales.Size = new System.Drawing.Size(286, 24);
            this.cbEditoriales.TabIndex = 90;
            // 
            // cbCategorias
            // 
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(148, 387);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(286, 24);
            this.cbCategorias.TabIndex = 91;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(541, 429);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(107, 34);
            this.btnImprimir.TabIndex = 92;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.cbEditoriales);
            this.Controls.Add(this.cbGeneros);
            this.Controls.Add(this.cbAutores);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmLibros";
            this.Text = "frmLibros";
            this.Load += new System.EventHandler(this.frmLibros_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsGuardar;
        private System.Windows.Forms.ToolStripButton tsBuscar;
        private System.Windows.Forms.ToolStripButton tsLimpiar;
        private System.Windows.Forms.ToolStripButton tsEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.ComboBox cbAutores;
        private System.Windows.Forms.ComboBox cbGeneros;
        private System.Windows.Forms.ComboBox cbEditoriales;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.Button btnImprimir;
    }
}