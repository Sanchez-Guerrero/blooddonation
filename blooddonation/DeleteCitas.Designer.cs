namespace blooddonation
{
    partial class DeleteCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCitas));
            this.pnEncabezadoRegistrar = new System.Windows.Forms.Panel();
            this.etRegistrar = new System.Windows.Forms.Label();
            this.pnContenedorRegistarPaciente = new System.Windows.Forms.Panel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rshDatosPersonales = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.dGVConsulta = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pnEncabezadoRegistrar.SuspendLayout();
            this.pnContenedorRegistarPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnEncabezadoRegistrar
            // 
            this.pnEncabezadoRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.pnEncabezadoRegistrar.Controls.Add(this.etRegistrar);
            this.pnEncabezadoRegistrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnEncabezadoRegistrar.Location = new System.Drawing.Point(0, 0);
            this.pnEncabezadoRegistrar.Name = "pnEncabezadoRegistrar";
            this.pnEncabezadoRegistrar.Size = new System.Drawing.Size(710, 71);
            this.pnEncabezadoRegistrar.TabIndex = 2;
            // 
            // etRegistrar
            // 
            this.etRegistrar.AutoSize = true;
            this.etRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etRegistrar.ForeColor = System.Drawing.Color.White;
            this.etRegistrar.Location = new System.Drawing.Point(251, 25);
            this.etRegistrar.Name = "etRegistrar";
            this.etRegistrar.Size = new System.Drawing.Size(156, 25);
            this.etRegistrar.TabIndex = 0;
            this.etRegistrar.Text = "ELIMINAR CITA";
            // 
            // pnContenedorRegistarPaciente
            // 
            this.pnContenedorRegistarPaciente.BackColor = System.Drawing.Color.Gainsboro;
            this.pnContenedorRegistarPaciente.Controls.Add(this.btnBuscar);
            this.pnContenedorRegistarPaciente.Controls.Add(this.txtBuscar);
            this.pnContenedorRegistarPaciente.Controls.Add(this.dGVConsulta);
            this.pnContenedorRegistarPaciente.Controls.Add(this.shapeContainer1);
            this.pnContenedorRegistarPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedorRegistarPaciente.Location = new System.Drawing.Point(0, 71);
            this.pnContenedorRegistarPaciente.Name = "pnContenedorRegistarPaciente";
            this.pnContenedorRegistarPaciente.Size = new System.Drawing.Size(710, 555);
            this.pnContenedorRegistarPaciente.TabIndex = 3;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rshDatosPersonales});
            this.shapeContainer1.Size = new System.Drawing.Size(710, 555);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // rshDatosPersonales
            // 
            this.rshDatosPersonales.BorderColor = System.Drawing.Color.Silver;
            this.rshDatosPersonales.Enabled = false;
            this.rshDatosPersonales.Location = new System.Drawing.Point(13, 13);
            this.rshDatosPersonales.Name = "rshDatosPersonales";
            this.rshDatosPersonales.Size = new System.Drawing.Size(681, 441);
            // 
            // dGVConsulta
            // 
            this.dGVConsulta.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dGVConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nombre,
            this.APaterno,
            this.AMaterno,
            this.Edad,
            this.ECivil});
            this.dGVConsulta.GridColor = System.Drawing.Color.Silver;
            this.dGVConsulta.Location = new System.Drawing.Point(27, 76);
            this.dGVConsulta.Name = "dGVConsulta";
            this.dGVConsulta.Size = new System.Drawing.Size(655, 363);
            this.dGVConsulta.TabIndex = 38;
            // 
            // ID
            // 
            this.ID.HeaderText = "N\'Cita";
            this.ID.Name = "ID";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Paciente";
            this.nombre.Name = "nombre";
            // 
            // APaterno
            // 
            this.APaterno.HeaderText = "Donante";
            this.APaterno.Name = "APaterno";
            // 
            // AMaterno
            // 
            this.AMaterno.HeaderText = "Fecha";
            this.AMaterno.Name = "AMaterno";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Hora";
            this.Edad.Name = "Edad";
            // 
            // ECivil
            // 
            this.ECivil.HeaderText = "Sitio de la cita";
            this.ECivil.Name = "ECivil";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(526, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(156, 31);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(27, 28);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(477, 31);
            this.txtBuscar.TabIndex = 12;
            // 
            // DeleteCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 626);
            this.Controls.Add(this.pnContenedorRegistarPaciente);
            this.Controls.Add(this.pnEncabezadoRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteCitas";
            this.Text = "DeleteCitas";
            this.pnEncabezadoRegistrar.ResumeLayout(false);
            this.pnEncabezadoRegistrar.PerformLayout();
            this.pnContenedorRegistarPaciente.ResumeLayout(false);
            this.pnContenedorRegistarPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnEncabezadoRegistrar;
        private System.Windows.Forms.Label etRegistrar;
        private System.Windows.Forms.Panel pnContenedorRegistarPaciente;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rshDatosPersonales;
        private System.Windows.Forms.DataGridView dGVConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn APaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECivil;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}