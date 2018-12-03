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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnEncabezadoRegistrar = new System.Windows.Forms.Panel();
            this.etRegistrar = new System.Windows.Forms.Label();
            this.pnContenedorRegistarPaciente = new System.Windows.Forms.Panel();
            this.btnEliminarCita = new System.Windows.Forms.Button();
            this.lblidCita = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rshDatosPersonales = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.dGVConsulta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pnContenedorRegistarPaciente.AutoScroll = true;
            this.pnContenedorRegistarPaciente.BackColor = System.Drawing.Color.Gainsboro;
            this.pnContenedorRegistarPaciente.Controls.Add(this.dGVConsulta);
            this.pnContenedorRegistarPaciente.Controls.Add(this.btnEliminarCita);
            this.pnContenedorRegistarPaciente.Controls.Add(this.lblidCita);
            this.pnContenedorRegistarPaciente.Controls.Add(this.shapeContainer1);
            this.pnContenedorRegistarPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedorRegistarPaciente.Location = new System.Drawing.Point(0, 71);
            this.pnContenedorRegistarPaciente.Name = "pnContenedorRegistarPaciente";
            this.pnContenedorRegistarPaciente.Size = new System.Drawing.Size(710, 555);
            this.pnContenedorRegistarPaciente.TabIndex = 3;
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
            // lblidCita
            // 
            this.lblidCita.AutoSize = true;
            this.lblidCita.Location = new System.Drawing.Point(55, 431);
            this.lblidCita.Name = "lblidCita";
            this.lblidCita.Size = new System.Drawing.Size(35, 13);
            this.lblidCita.TabIndex = 39;
            this.lblidCita.Text = "label1";
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
            // dGVConsulta
            // 
            this.dGVConsulta.AllowUserToAddRows = false;
            this.dGVConsulta.AllowUserToDeleteRows = false;
            this.dGVConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVConsulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.dGVConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVConsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGVConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVConsulta.ColumnHeadersHeight = 30;
            this.dGVConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column10});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVConsulta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVConsulta.EnableHeadersVisualStyles = false;
            this.dGVConsulta.GridColor = System.Drawing.Color.White;
            this.dGVConsulta.Location = new System.Drawing.Point(28, 26);
            this.dGVConsulta.Name = "dGVConsulta";
            this.dGVConsulta.ReadOnly = true;
            this.dGVConsulta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVConsulta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGVConsulta.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dGVConsulta.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dGVConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVConsulta.Size = new System.Drawing.Size(651, 402);
            this.dGVConsulta.TabIndex = 38;
            this.dGVConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVConsulta_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id_Cita";
            this.Column1.HeaderText = "Nº Cita";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 58;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Id_Solicitante";
            this.Column2.HeaderText = "Nº Solicitante";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 86;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Id_Donante";
            this.Column3.HeaderText = "Nº Donante";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 79;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Fecha";
            this.Column4.HeaderText = "Fecha";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Hora";
            this.Column5.HeaderText = "Hora";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 53;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NomClinica";
            this.Column7.HeaderText = "Nombre Clinica";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 93;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "DireccionClinica";
            this.Column8.HeaderText = "Dirección Clinica";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "EstatusCita";
            this.Column10.HeaderText = "Estatus de la Cita";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 76;
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
        private System.Windows.Forms.Label lblidCita;
        private System.Windows.Forms.Button btnEliminarCita;
        private System.Windows.Forms.DataGridView dGVConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}