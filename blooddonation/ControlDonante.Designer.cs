namespace blooddonation
{
    partial class ControlDonante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlDonante));
            this.pnEncabezadoPacientes = new System.Windows.Forms.Panel();
            this.lbPacientes = new System.Windows.Forms.Label();
            this.pnContenedorPacientes = new System.Windows.Forms.Panel();
            this.dGVConsulta = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnNuevoPaciente = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rSTabla = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.pnEncabezadoPacientes.SuspendLayout();
            this.pnContenedorPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnEncabezadoPacientes
            // 
            this.pnEncabezadoPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.pnEncabezadoPacientes.Controls.Add(this.lbPacientes);
            this.pnEncabezadoPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnEncabezadoPacientes.Location = new System.Drawing.Point(0, 0);
            this.pnEncabezadoPacientes.Name = "pnEncabezadoPacientes";
            this.pnEncabezadoPacientes.Size = new System.Drawing.Size(740, 71);
            this.pnEncabezadoPacientes.TabIndex = 1;
            // 
            // lbPacientes
            // 
            this.lbPacientes.AutoSize = true;
            this.lbPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPacientes.ForeColor = System.Drawing.Color.White;
            this.lbPacientes.Location = new System.Drawing.Point(305, 23);
            this.lbPacientes.Name = "lbPacientes";
            this.lbPacientes.Size = new System.Drawing.Size(124, 25);
            this.lbPacientes.TabIndex = 0;
            this.lbPacientes.Text = "DONANTES";
            // 
            // pnContenedorPacientes
            // 
            this.pnContenedorPacientes.BackColor = System.Drawing.Color.Gainsboro;
            this.pnContenedorPacientes.Controls.Add(this.dGVConsulta);
            this.pnContenedorPacientes.Controls.Add(this.btnBuscar);
            this.pnContenedorPacientes.Controls.Add(this.txtBuscar);
            this.pnContenedorPacientes.Controls.Add(this.btnModificarUsuario);
            this.pnContenedorPacientes.Controls.Add(this.btnNuevoPaciente);
            this.pnContenedorPacientes.Controls.Add(this.shapeContainer1);
            this.pnContenedorPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedorPacientes.Location = new System.Drawing.Point(0, 71);
            this.pnContenedorPacientes.Name = "pnContenedorPacientes";
            this.pnContenedorPacientes.Size = new System.Drawing.Size(740, 421);
            this.pnContenedorPacientes.TabIndex = 2;
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
            this.dGVConsulta.Location = new System.Drawing.Point(35, 159);
            this.dGVConsulta.Name = "dGVConsulta";
            this.dGVConsulta.Size = new System.Drawing.Size(662, 235);
            this.dGVConsulta.TabIndex = 35;
            // 
            // ID
            // 
            this.ID.HeaderText = "N\'Paciente";
            this.ID.Name = "ID";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre\'s";
            this.nombre.Name = "nombre";
            // 
            // APaterno
            // 
            this.APaterno.HeaderText = "Apellido Paterno";
            this.APaterno.Name = "APaterno";
            // 
            // AMaterno
            // 
            this.AMaterno.HeaderText = "Apellido Materno";
            this.AMaterno.Name = "AMaterno";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // ECivil
            // 
            this.ECivil.HeaderText = "Estado Civil";
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
            this.btnBuscar.Location = new System.Drawing.Point(518, 108);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(156, 31);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(35, 107);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(477, 31);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnModificarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModificarUsuario.FlatAppearance.BorderSize = 0;
            this.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUsuario.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnModificarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarUsuario.Image")));
            this.btnModificarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarUsuario.Location = new System.Drawing.Point(456, 24);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(185, 50);
            this.btnModificarUsuario.TabIndex = 8;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnNuevoPaciente
            // 
            this.btnNuevoPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnNuevoPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoPaciente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevoPaciente.FlatAppearance.BorderSize = 0;
            this.btnNuevoPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPaciente.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPaciente.ForeColor = System.Drawing.Color.White;
            this.btnNuevoPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoPaciente.Image")));
            this.btnNuevoPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoPaciente.Location = new System.Drawing.Point(68, 24);
            this.btnNuevoPaciente.Name = "btnNuevoPaciente";
            this.btnNuevoPaciente.Size = new System.Drawing.Size(185, 50);
            this.btnNuevoPaciente.TabIndex = 4;
            this.btnNuevoPaciente.Text = "Nuevo";
            this.btnNuevoPaciente.UseVisualStyleBackColor = false;
            this.btnNuevoPaciente.Click += new System.EventHandler(this.btnNuevoPaciente_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rSTabla});
            this.shapeContainer1.Size = new System.Drawing.Size(740, 421);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // rSTabla
            // 
            this.rSTabla.BorderColor = System.Drawing.Color.Silver;
            this.rSTabla.Enabled = false;
            this.rSTabla.Location = new System.Drawing.Point(15, 93);
            this.rSTabla.Name = "rSTabla";
            this.rSTabla.Size = new System.Drawing.Size(689, 317);
            // 
            // ControlDonante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 492);
            this.Controls.Add(this.pnContenedorPacientes);
            this.Controls.Add(this.pnEncabezadoPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlDonante";
            this.Text = "ControlDonante";
            this.pnEncabezadoPacientes.ResumeLayout(false);
            this.pnEncabezadoPacientes.PerformLayout();
            this.pnContenedorPacientes.ResumeLayout(false);
            this.pnContenedorPacientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnEncabezadoPacientes;
        private System.Windows.Forms.Label lbPacientes;
        private System.Windows.Forms.Panel pnContenedorPacientes;
        private System.Windows.Forms.DataGridView dGVConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn APaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECivil;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnNuevoPaciente;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rSTabla;
    }
}