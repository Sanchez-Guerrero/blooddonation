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
            this.dGVConsulta = new System.Windows.Forms.DataGridView();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rshDatosPersonales = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lblidCita = new System.Windows.Forms.Label();
            this.btnEliminarCita = new System.Windows.Forms.Button();
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
            this.pnContenedorRegistarPaciente.Controls.Add(this.btnEliminarCita);
            this.pnContenedorRegistarPaciente.Controls.Add(this.lblidCita);
            this.pnContenedorRegistarPaciente.Controls.Add(this.dGVConsulta);
            this.pnContenedorRegistarPaciente.Controls.Add(this.shapeContainer1);
            this.pnContenedorRegistarPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedorRegistarPaciente.Location = new System.Drawing.Point(0, 71);
            this.pnContenedorRegistarPaciente.Name = "pnContenedorRegistarPaciente";
            this.pnContenedorRegistarPaciente.Size = new System.Drawing.Size(710, 555);
            this.pnContenedorRegistarPaciente.TabIndex = 3;
            // 
            // dGVConsulta
            // 
            this.dGVConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dGVConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVConsulta.GridColor = System.Drawing.Color.Silver;
            this.dGVConsulta.Location = new System.Drawing.Point(27, 26);
            this.dGVConsulta.Name = "dGVConsulta";
            this.dGVConsulta.Size = new System.Drawing.Size(655, 398);
            this.dGVConsulta.TabIndex = 38;
            this.dGVConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVConsulta_CellClick);
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
            this.rshDatosPersonales.Size = new System.Drawing.Size(681, 516);
            // 
            // lblidCita
            // 
            this.lblidCita.AutoSize = true;
            this.lblidCita.Location = new System.Drawing.Point(55, 431);
            this.lblidCita.Name = "lblidCita";
            this.lblidCita.Size = new System.Drawing.Size(35, 13);
            this.lblidCita.TabIndex = 39;
            this.lblidCita.Text = "label1";
            this.lblidCita.Visible = false;
            // 
            // btnEliminarCita
            // 
            this.btnEliminarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnEliminarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCita.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarCita.FlatAppearance.BorderSize = 0;
            this.btnEliminarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCita.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCita.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCita.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarCita.Image")));
            this.btnEliminarCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCita.Location = new System.Drawing.Point(473, 448);
            this.btnEliminarCita.Name = "btnEliminarCita";
            this.btnEliminarCita.Size = new System.Drawing.Size(185, 50);
            this.btnEliminarCita.TabIndex = 7;
            this.btnEliminarCita.Text = "Eliminar";
            this.btnEliminarCita.UseVisualStyleBackColor = false;
            this.btnEliminarCita.Click += new System.EventHandler(this.btnEliminarCita_Click);
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
        private System.Windows.Forms.Label lblidCita;
        private System.Windows.Forms.Button btnEliminarCita;
    }
}