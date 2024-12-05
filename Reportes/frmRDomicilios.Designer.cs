namespace ProyectoFinal_Biblioteca.Reportes
{
    partial class frmRDomicilios
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cbColonias = new System.Windows.Forms.ComboBox();
            this.chTodo = new System.Windows.Forms.CheckBox();
            this.rvDomicilios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(739, 40);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(82, 40);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbColonias
            // 
            this.cbColonias.FormattingEnabled = true;
            this.cbColonias.Location = new System.Drawing.Point(241, 49);
            this.cbColonias.Name = "cbColonias";
            this.cbColonias.Size = new System.Drawing.Size(460, 24);
            this.cbColonias.TabIndex = 5;
            // 
            // chTodo
            // 
            this.chTodo.AutoSize = true;
            this.chTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chTodo.Location = new System.Drawing.Point(140, 51);
            this.chTodo.Name = "chTodo";
            this.chTodo.Size = new System.Drawing.Size(66, 20);
            this.chTodo.TabIndex = 4;
            this.chTodo.Text = "Todo";
            this.chTodo.UseVisualStyleBackColor = true;
            // 
            // rvDomicilios
            // 
            this.rvDomicilios.LocalReport.ReportEmbeddedResource = "ProyectoFinal_Biblioteca.Reportes.rDomicilios.rdlc";
            this.rvDomicilios.Location = new System.Drawing.Point(47, 120);
            this.rvDomicilios.Name = "rvDomicilios";
            this.rvDomicilios.ServerReport.BearerToken = null;
            this.rvDomicilios.Size = new System.Drawing.Size(839, 369);
            this.rvDomicilios.TabIndex = 7;
            // 
            // frmRDomicilios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(946, 530);
            this.Controls.Add(this.rvDomicilios);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbColonias);
            this.Controls.Add(this.chTodo);
            this.Name = "frmRDomicilios";
            this.Text = "frmRDomicilios";
            this.Load += new System.EventHandler(this.frmRDomicilios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cbColonias;
        private System.Windows.Forms.CheckBox chTodo;
        private Microsoft.Reporting.WinForms.ReportViewer rvDomicilios;
    }
}