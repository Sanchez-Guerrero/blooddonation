namespace blooddonation
{
    partial class ControlCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlCitas));
            this.pnEncabezadoPacientes = new System.Windows.Forms.Panel();
            this.lbPacientes = new System.Windows.Forms.Label();
            this.pnContenedorPacientes = new System.Windows.Forms.Panel();
            this.dGVConsulta = new System.Windows.Forms.DataGridView();
            this.btnEliminarCita = new System.Windows.Forms.Button();
            this.btnNuevaCita = new System.Windows.Forms.Button();
            this.btnModificarCita = new System.Windows.Forms.Button();
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
            this.pnEncabezadoPacientes.Size = new System.Drawing.Size(726, 71);
            this.pnEncabezadoPacientes.TabIndex = 1;
            // 
            // lbPacientes
            // 
            this.lbPacientes.AutoSize = true;
            this.lbPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPacientes.ForeColor = System.Drawing.Color.White;
            this.lbPacientes.Location = new System.Drawing.Point(309, 23);
            this.lbPacientes.Name = "lbPacientes";
            this.lbPacientes.Size = new System.Drawing.Size(73, 25);
            this.lbPacientes.TabIndex = 0;
            this.lbPacientes.Text = "CITAS";
            // 
            // pnContenedorPacientes
            // 
            this.pnContenedorPacientes.BackColor = System.Drawing.Color.Gainsboro;
            this.pnContenedorPacientes.Controls.Add(this.dGVConsulta);
            this.pnContenedorPacientes.Controls.Add(this.btnEliminarCita);
            this.pnContenedorPacientes.Controls.Add(this.btnNuevaCita);
            this.pnContenedorPacientes.Controls.Add(this.btnModificarCita);
            this.pnContenedorPacientes.Controls.Add(this.shapeContainer1);
            this.pnContenedorPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedorPacientes.Location = new System.Drawing.Point(0, 71);
            this.pnContenedorPacientes.Name = "pnContenedorPacientes";
            this.pnContenedorPacientes.Size = new System.Drawing.Size(726, 428);
            this.pnContenedorPacientes.TabIndex = 2;
            // 
            // dGVConsulta
            // 
            this.dGVConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dGVConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVConsulta.GridColor = System.Drawing.Color.Silver;
            this.dGVConsulta.Location = new System.Drawing.Point(32, 150);
            this.dGVConsulta.Name = "dGVConsulta";
            this.dGVConsulta.Size = new System.Drawing.Size(662, 251);
            this.dGVConsulta.TabIndex = 36;
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
            this.btnEliminarCita.Location = new System.Drawing.Point(524, 47);
            this.btnEliminarCita.Name = "btnEliminarCita";
            this.btnEliminarCita.Size = new System.Drawing.Size(185, 50);
            this.btnEliminarCita.TabIndex = 6;
            this.btnEliminarCita.Text = "Eliminar";
            this.btnEliminarCita.UseVisualStyleBackColor = false;
            this.btnEliminarCita.Click += new System.EventHandler(this.btnEliminarCita_Click);
            // 
            // btnNuevaCita
            // 
            this.btnNuevaCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnNuevaCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaCita.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevaCita.FlatAppearance.BorderSize = 0;
            this.btnNuevaCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCita.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCita.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCita.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaCita.Image")));
            this.btnNuevaCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaCita.Location = new System.Drawing.Point(24, 47);
            this.btnNuevaCita.Name = "btnNuevaCita";
            this.btnNuevaCita.Size = new System.Drawing.Size(185, 50);
            this.btnNuevaCita.TabIndex = 5;
            this.btnNuevaCita.Text = "Nueva";
            this.btnNuevaCita.UseVisualStyleBackColor = false;
            this.btnNuevaCita.Click += new System.EventHandler(this.btnNuevaCita_Click);
            // 
            // btnModificarCita
            // 
            this.btnModificarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnModificarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarCita.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModificarCita.FlatAppearance.BorderSize = 0;
            this.btnModificarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCita.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCita.ForeColor = System.Drawing.Color.White;
            this.btnModificarCita.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarCita.Image")));
            this.btnModificarCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarCita.Location = new System.Drawing.Point(269, 47);
            this.btnModificarCita.Name = "btnModificarCita";
            this.btnModificarCita.Size = new System.Drawing.Size(185, 50);
            this.btnModificarCita.TabIndex = 4;
            this.btnModificarCita.Text = "Modificar";
            this.btnModificarCita.UseVisualStyleBackColor = false;
            this.btnModificarCita.Click += new System.EventHandler(this.btnModificarCita_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rSTabla});
            this.shapeContainer1.Size = new System.Drawing.Size(726, 428);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // rSTabla
            // 
            this.rSTabla.BorderColor = System.Drawing.Color.Silver;
            this.rSTabla.Enabled = false;
            this.rSTabla.Location = new System.Drawing.Point(20, 129);
            this.rSTabla.Name = "rSTabla";
            this.rSTabla.Size = new System.Drawing.Size(688, 280);
            // 
            // ControlCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 499);
            this.Controls.Add(this.pnContenedorPacientes);
            this.Controls.Add(this.pnEncabezadoPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlCitas";
            this.Text = "ControlCitas";
            this.pnEncabezadoPacientes.ResumeLayout(false);
            this.pnEncabezadoPacientes.PerformLayout();
            this.pnContenedorPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnEncabezadoPacientes;
        private System.Windows.Forms.Label lbPacientes;
        private System.Windows.Forms.Panel pnContenedorPacientes;
        private System.Windows.Forms.Button btnNuevaCita;
        private System.Windows.Forms.Button btnModificarCita;
        private System.Windows.Forms.Button btnEliminarCita;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rSTabla;
        private System.Windows.Forms.DataGridView dGVConsulta;
    }
}