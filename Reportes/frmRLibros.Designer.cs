﻿namespace ProyectoFinal_Biblioteca.Reportes
{
    partial class frmRLibros
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
            this.rvLibros = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cbDomicilios = new System.Windows.Forms.ComboBox();
            this.chTodo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rvLibros
            // 
            this.rvLibros.LocalReport.ReportEmbeddedResource = "ProyectoFinal_Biblioteca.Reportes.rDomicilios.rdlc";
            this.rvLibros.Location = new System.Drawing.Point(64, 145);
            this.rvLibros.Name = "rvLibros";
            this.rvLibros.ServerReport.BearerToken = null;
            this.rvLibros.Size = new System.Drawing.Size(1056, 369);
            this.rvLibros.TabIndex = 15;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(874, 30);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(82, 40);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // cbDomicilios
            // 
            this.cbDomicilios.FormattingEnabled = true;
            this.cbDomicilios.Location = new System.Drawing.Point(376, 39);
            this.cbDomicilios.Name = "cbDomicilios";
            this.cbDomicilios.Size = new System.Drawing.Size(460, 24);
            this.cbDomicilios.TabIndex = 13;
            // 
            // chTodo
            // 
            this.chTodo.AutoSize = true;
            this.chTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chTodo.Location = new System.Drawing.Point(275, 41);
            this.chTodo.Name = "chTodo";
            this.chTodo.Size = new System.Drawing.Size(66, 20);
            this.chTodo.TabIndex = 12;
            this.chTodo.Text = "Todo";
            this.chTodo.UseVisualStyleBackColor = true;
            // 
            // frmRLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1185, 544);
            this.Controls.Add(this.rvLibros);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbDomicilios);
            this.Controls.Add(this.chTodo);
            this.Name = "frmRLibros";
            this.Text = "frmRLibros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvLibros;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cbDomicilios;
        private System.Windows.Forms.CheckBox chTodo;
    }
}