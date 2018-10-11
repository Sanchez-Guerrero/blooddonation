namespace blooddonation
{
    partial class UpdateCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCitas));
            this.pnEncabezadoPacientes = new System.Windows.Forms.Panel();
            this.lbPacientes = new System.Windows.Forms.Label();
            this.pnContenedorPacientes = new System.Windows.Forms.Panel();
            this.btnModificarCita = new System.Windows.Forms.Button();
            this.dGVConsulta = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTPHoraCita = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dTPFechaCita = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cBDonantes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBPacientes = new System.Windows.Forms.ComboBox();
            this.lbtiquetaNombre = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.pnEncabezadoPacientes.Size = new System.Drawing.Size(710, 71);
            this.pnEncabezadoPacientes.TabIndex = 2;
            // 
            // lbPacientes
            // 
            this.lbPacientes.AutoSize = true;
            this.lbPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPacientes.ForeColor = System.Drawing.Color.White;
            this.lbPacientes.Location = new System.Drawing.Point(253, 23);
            this.lbPacientes.Name = "lbPacientes";
            this.lbPacientes.Size = new System.Drawing.Size(175, 25);
            this.lbPacientes.TabIndex = 0;
            this.lbPacientes.Text = "MODIFICAR CITA";
            // 
            // pnContenedorPacientes
            // 
            this.pnContenedorPacientes.BackColor = System.Drawing.Color.Gainsboro;
            this.pnContenedorPacientes.Controls.Add(this.comboBox2);
            this.pnContenedorPacientes.Controls.Add(this.comboBox1);
            this.pnContenedorPacientes.Controls.Add(this.label5);
            this.pnContenedorPacientes.Controls.Add(this.label4);
            this.pnContenedorPacientes.Controls.Add(this.btnModificarCita);
            this.pnContenedorPacientes.Controls.Add(this.dGVConsulta);
            this.pnContenedorPacientes.Controls.Add(this.dTPHoraCita);
            this.pnContenedorPacientes.Controls.Add(this.label3);
            this.pnContenedorPacientes.Controls.Add(this.dTPFechaCita);
            this.pnContenedorPacientes.Controls.Add(this.label2);
            this.pnContenedorPacientes.Controls.Add(this.cBDonantes);
            this.pnContenedorPacientes.Controls.Add(this.label1);
            this.pnContenedorPacientes.Controls.Add(this.cBPacientes);
            this.pnContenedorPacientes.Controls.Add(this.lbtiquetaNombre);
            this.pnContenedorPacientes.Controls.Add(this.shapeContainer1);
            this.pnContenedorPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedorPacientes.Location = new System.Drawing.Point(0, 71);
            this.pnContenedorPacientes.Name = "pnContenedorPacientes";
            this.pnContenedorPacientes.Size = new System.Drawing.Size(710, 555);
            this.pnContenedorPacientes.TabIndex = 3;
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
            this.btnModificarCita.Location = new System.Drawing.Point(494, 398);
            this.btnModificarCita.Name = "btnModificarCita";
            this.btnModificarCita.Size = new System.Drawing.Size(185, 50);
            this.btnModificarCita.TabIndex = 5;
            this.btnModificarCita.Text = "Modificar";
            this.btnModificarCita.UseVisualStyleBackColor = false;
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
            this.dGVConsulta.Location = new System.Drawing.Point(28, 252);
            this.dGVConsulta.Name = "dGVConsulta";
            this.dGVConsulta.Size = new System.Drawing.Size(651, 140);
            this.dGVConsulta.TabIndex = 37;
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
            // dTPHoraCita
            // 
            this.dTPHoraCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dTPHoraCita.Font = new System.Drawing.Font("FontAwesome", 14F);
            this.dTPHoraCita.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPHoraCita.Location = new System.Drawing.Point(387, 112);
            this.dTPHoraCita.Name = "dTPHoraCita";
            this.dTPHoraCita.ShowUpDown = true;
            this.dTPHoraCita.Size = new System.Drawing.Size(292, 27);
            this.dTPHoraCita.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label3.Location = new System.Drawing.Point(383, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Hora de la cita";
            // 
            // dTPFechaCita
            // 
            this.dTPFechaCita.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPFechaCita.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dTPFechaCita.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.dTPFechaCita.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.dTPFechaCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dTPFechaCita.Font = new System.Drawing.Font("FontAwesome", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPFechaCita.Location = new System.Drawing.Point(41, 111);
            this.dTPFechaCita.Name = "dTPFechaCita";
            this.dTPFechaCita.Size = new System.Drawing.Size(292, 27);
            this.dTPFechaCita.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(37, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fecha de la cita";
            // 
            // cBDonantes
            // 
            this.cBDonantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBDonantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBDonantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBDonantes.ForeColor = System.Drawing.Color.Black;
            this.cBDonantes.FormattingEnabled = true;
            this.cBDonantes.Location = new System.Drawing.Point(387, 43);
            this.cBDonantes.Name = "cBDonantes";
            this.cBDonantes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cBDonantes.Size = new System.Drawing.Size(292, 32);
            this.cBDonantes.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(383, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Donante";
            // 
            // cBPacientes
            // 
            this.cBPacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBPacientes.ForeColor = System.Drawing.Color.Black;
            this.cBPacientes.FormattingEnabled = true;
            this.cBPacientes.Location = new System.Drawing.Point(41, 43);
            this.cBPacientes.Name = "cBPacientes";
            this.cBPacientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cBPacientes.Size = new System.Drawing.Size(292, 32);
            this.cBPacientes.TabIndex = 14;
            // 
            // lbtiquetaNombre
            // 
            this.lbtiquetaNombre.AutoSize = true;
            this.lbtiquetaNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbtiquetaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtiquetaNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.lbtiquetaNombre.Location = new System.Drawing.Point(37, 16);
            this.lbtiquetaNombre.Name = "lbtiquetaNombre";
            this.lbtiquetaNombre.Size = new System.Drawing.Size(83, 24);
            this.lbtiquetaNombre.TabIndex = 4;
            this.lbtiquetaNombre.Text = "Paciente";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(710, 555);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Silver;
            this.rectangleShape1.Enabled = false;
            this.rectangleShape1.Location = new System.Drawing.Point(11, 11);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(682, 445);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.Black;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(387, 181);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox2.Size = new System.Drawing.Size(292, 32);
            this.comboBox2.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label5.Location = new System.Drawing.Point(387, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 24);
            this.label5.TabIndex = 37;
            this.label5.Text = "Dirección de Hospital";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(292, 32);
            this.comboBox1.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label4.Location = new System.Drawing.Point(37, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Hospital";
            // 
            // UpdateCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 626);
            this.Controls.Add(this.pnContenedorPacientes);
            this.Controls.Add(this.pnEncabezadoPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateCitas";
            this.Text = "UpdateCitas";
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
        private System.Windows.Forms.DateTimePicker dTPHoraCita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dTPFechaCita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBDonantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBPacientes;
        private System.Windows.Forms.Label lbtiquetaNombre;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.DataGridView dGVConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn APaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECivil;
        private System.Windows.Forms.Button btnModificarCita;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}