namespace ProyectoFinal_Biblioteca.Formularios
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsLimpiar = new System.Windows.Forms.ToolStripButton();
            this.tsEliminar = new System.Windows.Forms.ToolStripButton();
            this.txtAMaterno = new System.Windows.Forms.TextBox();
            this.txtAPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDomicilio = new System.Windows.Forms.ComboBox();
            this.txtCURP = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip1.TabIndex = 15;
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
            // txtAMaterno
            // 
            this.txtAMaterno.Location = new System.Drawing.Point(214, 217);
            this.txtAMaterno.Name = "txtAMaterno";
            this.txtAMaterno.Size = new System.Drawing.Size(389, 22);
            this.txtAMaterno.TabIndex = 63;
            // 
            // txtAPaterno
            // 
            this.txtAPaterno.Location = new System.Drawing.Point(214, 171);
            this.txtAPaterno.Name = "txtAPaterno";
            this.txtAPaterno.Size = new System.Drawing.Size(389, 22);
            this.txtAPaterno.TabIndex = 62;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(214, 128);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(389, 22);
            this.txtNombre.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 9F);
            this.label4.Location = new System.Drawing.Point(41, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 60;
            this.label4.Text = "Apellido Materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 9F);
            this.label3.Location = new System.Drawing.Point(41, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 59;
            this.label3.Text = "Apellido Paterno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 9F);
            this.label2.Location = new System.Drawing.Point(41, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 58;
            this.label2.Text = "Nombre";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(214, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 28);
            this.btnBuscar.TabIndex = 57;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(90, 72);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 19);
            this.label1.TabIndex = 55;
            this.label1.Text = "ID";
            // 
            // cbDomicilio
            // 
            this.cbDomicilio.FormattingEnabled = true;
            this.cbDomicilio.Location = new System.Drawing.Point(214, 262);
            this.cbDomicilio.Name = "cbDomicilio";
            this.cbDomicilio.Size = new System.Drawing.Size(389, 24);
            this.cbDomicilio.TabIndex = 71;
            // 
            // txtCURP
            // 
            this.txtCURP.Location = new System.Drawing.Point(214, 337);
            this.txtCURP.Name = "txtCURP";
            this.txtCURP.Size = new System.Drawing.Size(389, 22);
            this.txtCURP.TabIndex = 70;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(214, 426);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(389, 22);
            this.txtEmail.TabIndex = 69;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(214, 381);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(389, 22);
            this.txtTelefono.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 9F);
            this.label9.Location = new System.Drawing.Point(41, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 19);
            this.label9.TabIndex = 67;
            this.label9.Text = "Domicilio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 9F);
            this.label8.Location = new System.Drawing.Point(41, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 19);
            this.label8.TabIndex = 66;
            this.label8.Text = "CURP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 9F);
            this.label7.Location = new System.Drawing.Point(41, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 19);
            this.label7.TabIndex = 65;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 9F);
            this.label6.Location = new System.Drawing.Point(41, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 64;
            this.label6.Text = "Teléfono";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.cbDomicilio);
            this.Controls.Add(this.txtCURP);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAMaterno);
            this.Controls.Add(this.txtAPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsGuardar;
        private System.Windows.Forms.ToolStripButton tsBuscar;
        private System.Windows.Forms.ToolStripButton tsLimpiar;
        private System.Windows.Forms.ToolStripButton tsEliminar;
        private System.Windows.Forms.TextBox txtAMaterno;
        private System.Windows.Forms.TextBox txtAPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDomicilio;
        private System.Windows.Forms.TextBox txtCURP;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}