﻿namespace blooddonation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlDonante));
            this.pnEncabezadoPacientes = new System.Windows.Forms.Panel();
            this.lbPacientes = new System.Windows.Forms.Label();
            this.pnContenedorPacientes = new System.Windows.Forms.Panel();
            this.dGVConsultarDonantes = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnNuevoPaciente = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rSTabla = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImpDefinitivos = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Imp12Meses = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ImpMujeres = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Imp72Horas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnEncabezadoPacientes.SuspendLayout();
            this.pnContenedorPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVConsultarDonantes)).BeginInit();
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
            this.pnContenedorPacientes.Controls.Add(this.dGVConsultarDonantes);
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
            // dGVConsultarDonantes
            // 
            this.dGVConsultarDonantes.AllowUserToAddRows = false;
            this.dGVConsultarDonantes.AllowUserToDeleteRows = false;
            this.dGVConsultarDonantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVConsultarDonantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVConsultarDonantes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.dGVConsultarDonantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVConsultarDonantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGVConsultarDonantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVConsultarDonantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVConsultarDonantes.ColumnHeadersHeight = 30;
            this.dGVConsultarDonantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVConsultarDonantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.ImpDefinitivos,
            this.Imp12Meses,
            this.ImpMujeres,
            this.Imp72Horas,
            this.Estatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVConsultarDonantes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVConsultarDonantes.EnableHeadersVisualStyles = false;
            this.dGVConsultarDonantes.GridColor = System.Drawing.Color.White;
            this.dGVConsultarDonantes.Location = new System.Drawing.Point(35, 159);
            this.dGVConsultarDonantes.Name = "dGVConsultarDonantes";
            this.dGVConsultarDonantes.ReadOnly = true;
            this.dGVConsultarDonantes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVConsultarDonantes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGVConsultarDonantes.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dGVConsultarDonantes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dGVConsultarDonantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGVConsultarDonantes.Size = new System.Drawing.Size(662, 235);
            this.dGVConsultarDonantes.TabIndex = 35;
            this.dGVConsultarDonantes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dGVConsultarDonantes_CellFormatting);
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
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
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
            // Column1
            // 
            this.Column1.DataPropertyName = "nombre";
            this.Column1.HeaderText = "Nombre(s)";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 78;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "aPaterno";
            this.Column2.HeaderText = "Apellido Paterno";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 98;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "aMaterno";
            this.Column3.HeaderText = "Apellido Materno";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "edad";
            this.Column4.HeaderText = "Edad";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 55;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "curp";
            this.Column5.HeaderText = "CURP";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "telefono";
            this.Column6.HeaderText = "Teléfono";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 72;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Estado_Civil";
            this.Column7.HeaderText = "Estado Civil";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 78;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Genero";
            this.Column8.HeaderText = "Genero";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 65;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Tipo_Sangre";
            this.Column9.HeaderText = "Tipo de Sangre";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 94;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Calle";
            this.Column10.HeaderText = "Calle";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 53;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Estado";
            this.Column11.HeaderText = "Estado";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 63;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Municipio";
            this.Column12.HeaderText = "Municipio";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 75;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Colonia";
            this.Column13.HeaderText = "Colonia";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 65;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "NumExterior";
            this.Column14.HeaderText = "Numero Exterior";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 96;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "NumInterior";
            this.Column15.HeaderText = "Numero Interior";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 94;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "CodigoPostal";
            this.Column16.HeaderText = "Codigo Postal";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 87;
            // 
            // ImpDefinitivos
            // 
            this.ImpDefinitivos.DataPropertyName = "ImpDefinitivos";
            this.ImpDefinitivos.HeaderText = "Impedimentos Definitivos";
            this.ImpDefinitivos.Name = "ImpDefinitivos";
            this.ImpDefinitivos.ReadOnly = true;
            this.ImpDefinitivos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ImpDefinitivos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ImpDefinitivos.Width = 134;
            // 
            // Imp12Meses
            // 
            this.Imp12Meses.DataPropertyName = "Imp12Meses";
            this.Imp12Meses.HeaderText = "Impedimentos de 12 meses";
            this.Imp12Meses.Name = "Imp12Meses";
            this.Imp12Meses.ReadOnly = true;
            this.Imp12Meses.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Imp12Meses.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Imp12Meses.Width = 103;
            // 
            // ImpMujeres
            // 
            this.ImpMujeres.DataPropertyName = "ImpMujeres";
            this.ImpMujeres.HeaderText = "Impedimentos mujeres";
            this.ImpMujeres.Name = "ImpMujeres";
            this.ImpMujeres.ReadOnly = true;
            this.ImpMujeres.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ImpMujeres.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ImpMujeres.Width = 122;
            // 
            // Imp72Horas
            // 
            this.Imp72Horas.DataPropertyName = "Imp72Horas";
            this.Imp72Horas.HeaderText = "Impedimentos 72 Horas";
            this.Imp72Horas.Name = "Imp72Horas";
            this.Imp72Horas.ReadOnly = true;
            this.Imp72Horas.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Imp72Horas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Imp72Horas.Width = 103;
            // 
            // Estatus
            // 
            this.Estatus.DataPropertyName = "Estatus";
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            this.Estatus.Width = 65;
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
            ((System.ComponentModel.ISupportInitialize)(this.dGVConsultarDonantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnEncabezadoPacientes;
        private System.Windows.Forms.Label lbPacientes;
        private System.Windows.Forms.Panel pnContenedorPacientes;
        private System.Windows.Forms.DataGridView dGVConsultarDonantes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnNuevoPaciente;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rSTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ImpDefinitivos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Imp12Meses;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ImpMujeres;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Imp72Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
    }
}