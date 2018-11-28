namespace blooddonation
{
    partial class RegistrarCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarCitas));
            this.pnEncabezadoPacientes = new System.Windows.Forms.Panel();
            this.lbPacientes = new System.Windows.Forms.Label();
            this.pnContenedorPacientes = new System.Windows.Forms.Panel();
            this.lblIdClinica = new System.Windows.Forms.Label();
            this.lblIdDonante = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dTPFechaCita = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cBDonantes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBPacientes = new System.Windows.Forms.ComboBox();
            this.lbtiquetaNombre = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.pnEncabezadoPacientes.SuspendLayout();
            this.pnContenedorPacientes.SuspendLayout();
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
            this.lbPacientes.Location = new System.Drawing.Point(267, 25);
            this.lbPacientes.Name = "lbPacientes";
            this.lbPacientes.Size = new System.Drawing.Size(177, 25);
            this.lbPacientes.TabIndex = 0;
            this.lbPacientes.Text = "REGISTRAR CITA";
            // 
            // pnContenedorPacientes
            // 
            this.pnContenedorPacientes.AutoScroll = true;
            this.pnContenedorPacientes.BackColor = System.Drawing.Color.Gainsboro;
            this.pnContenedorPacientes.Controls.Add(this.txtHora);
            this.pnContenedorPacientes.Controls.Add(this.lblIdClinica);
            this.pnContenedorPacientes.Controls.Add(this.lblIdDonante);
            this.pnContenedorPacientes.Controls.Add(this.lblPaciente);
            this.pnContenedorPacientes.Controls.Add(this.btnEnviarEmail);
            this.pnContenedorPacientes.Controls.Add(this.richTextBox1);
            this.pnContenedorPacientes.Controls.Add(this.textBox1);
            this.pnContenedorPacientes.Controls.Add(this.label8);
            this.pnContenedorPacientes.Controls.Add(this.txtNombres);
            this.pnContenedorPacientes.Controls.Add(this.label7);
            this.pnContenedorPacientes.Controls.Add(this.label6);
            this.pnContenedorPacientes.Controls.Add(this.comboBox2);
            this.pnContenedorPacientes.Controls.Add(this.label5);
            this.pnContenedorPacientes.Controls.Add(this.comboBox1);
            this.pnContenedorPacientes.Controls.Add(this.label4);
            this.pnContenedorPacientes.Controls.Add(this.btnAgendar);
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
            this.pnContenedorPacientes.Size = new System.Drawing.Size(726, 709);
            this.pnContenedorPacientes.TabIndex = 2;
            // 
            // lblIdClinica
            // 
            this.lblIdClinica.AutoSize = true;
            this.lblIdClinica.Location = new System.Drawing.Point(206, 607);
            this.lblIdClinica.Name = "lblIdClinica";
            this.lblIdClinica.Size = new System.Drawing.Size(47, 13);
            this.lblIdClinica.TabIndex = 43;
            this.lblIdClinica.Text = "IdClinica";
            this.lblIdClinica.Visible = false;
            // 
            // lblIdDonante
            // 
            this.lblIdDonante.AutoSize = true;
            this.lblIdDonante.Location = new System.Drawing.Point(125, 608);
            this.lblIdDonante.Name = "lblIdDonante";
            this.lblIdDonante.Size = new System.Drawing.Size(57, 13);
            this.lblIdDonante.TabIndex = 42;
            this.lblIdDonante.Text = "IdDonante";
            this.lblIdDonante.Visible = false;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(41, 608);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPaciente.Size = new System.Drawing.Size(57, 13);
            this.lblPaciente.TabIndex = 41;
            this.lblPaciente.Text = "idPaciente";
            this.lblPaciente.Visible = false;
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnEnviarEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarEmail.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEnviarEmail.FlatAppearance.BorderSize = 0;
            this.btnEnviarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarEmail.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarEmail.ForeColor = System.Drawing.Color.White;
            this.btnEnviarEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviarEmail.Image")));
            this.btnEnviarEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviarEmail.Location = new System.Drawing.Point(495, 491);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(184, 50);
            this.btnEnviarEmail.TabIndex = 40;
            this.btnEnviarEmail.Text = "Enviar";
            this.btnEnviarEmail.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(81, 351);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(598, 134);
            this.richTextBox1.TabIndex = 39;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(81, 308);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(598, 23);
            this.textBox1.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label8.Location = new System.Drawing.Point(17, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Asunto:";
            // 
            // txtNombres
            // 
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(81, 267);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(598, 23);
            this.txtNombres.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label7.Location = new System.Drawing.Point(28, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 24);
            this.label7.TabIndex = 36;
            this.label7.Text = "Para:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label6.Location = new System.Drawing.Point(37, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "Correo Electrónico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label5.Location = new System.Drawing.Point(387, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Dirección de Hospital";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 178);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(321, 32);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label4.Location = new System.Drawing.Point(37, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Hospital";
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnAgendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgendar.FlatAppearance.BorderSize = 0;
            this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendar.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.ForeColor = System.Drawing.Color.White;
            this.btnAgendar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgendar.Image")));
            this.btnAgendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendar.Location = new System.Drawing.Point(495, 565);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(184, 50);
            this.btnAgendar.TabIndex = 30;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label3.Location = new System.Drawing.Point(383, 87);
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
            this.dTPFechaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPFechaCita.Location = new System.Drawing.Point(41, 114);
            this.dTPFechaCita.Name = "dTPFechaCita";
            this.dTPFechaCita.Size = new System.Drawing.Size(292, 29);
            this.dTPFechaCita.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(37, 87);
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
            this.cBDonantes.Location = new System.Drawing.Point(387, 41);
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
            this.label1.Location = new System.Drawing.Point(383, 14);
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
            this.cBPacientes.Location = new System.Drawing.Point(41, 41);
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
            this.lbtiquetaNombre.Location = new System.Drawing.Point(37, 14);
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
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(726, 709);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderColor = System.Drawing.Color.Silver;
            this.rectangleShape2.Enabled = false;
            this.rectangleShape2.Location = new System.Drawing.Point(13, 239);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(682, 313);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Silver;
            this.rectangleShape1.Enabled = false;
            this.rectangleShape1.Location = new System.Drawing.Point(11, 9);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(682, 210);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.Black;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(387, 178);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox2.Size = new System.Drawing.Size(292, 32);
            this.comboBox2.TabIndex = 34;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtHora
            // 
            this.txtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(391, 114);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(122, 26);
            this.txtHora.TabIndex = 44;
            // 
            // RegistrarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 780);
            this.Controls.Add(this.pnContenedorPacientes);
            this.Controls.Add(this.pnEncabezadoPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarCitas";
            this.Text = "Citas";
            this.pnEncabezadoPacientes.ResumeLayout(false);
            this.pnEncabezadoPacientes.PerformLayout();
            this.pnContenedorPacientes.ResumeLayout(false);
            this.pnContenedorPacientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnEncabezadoPacientes;
        private System.Windows.Forms.Label lbPacientes;
        private System.Windows.Forms.Panel pnContenedorPacientes;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label lbtiquetaNombre;
        private System.Windows.Forms.DateTimePicker dTPFechaCita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBDonantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBPacientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblIdClinica;
        private System.Windows.Forms.Label lblIdDonante;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}