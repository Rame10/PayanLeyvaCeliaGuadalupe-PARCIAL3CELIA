namespace ProyectoFinal_Biblioteca.Reportes
{
    partial class frmRClientes
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
            this.rvClientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.chTodo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rvClientes
            // 
            this.rvClientes.LocalReport.ReportEmbeddedResource = "ProyectoFinal_Biblioteca.Reportes.rDomicilios.rdlc";
            this.rvClientes.Location = new System.Drawing.Point(79, 157);
            this.rvClientes.Name = "rvClientes";
            this.rvClientes.ServerReport.BearerToken = null;
            this.rvClientes.Size = new System.Drawing.Size(1056, 369);
            this.rvClientes.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(889, 42);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(82, 40);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(391, 51);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(460, 24);
            this.cbClientes.TabIndex = 9;
            // 
            // chTodo
            // 
            this.chTodo.AutoSize = true;
            this.chTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chTodo.Location = new System.Drawing.Point(290, 53);
            this.chTodo.Name = "chTodo";
            this.chTodo.Size = new System.Drawing.Size(66, 20);
            this.chTodo.TabIndex = 8;
            this.chTodo.Text = "Todo";
            this.chTodo.UseVisualStyleBackColor = true;
            // 
            // frmRClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1218, 579);
            this.Controls.Add(this.rvClientes);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.chTodo);
            this.Name = "frmRClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmRClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvClientes;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.CheckBox chTodo;
    }
}