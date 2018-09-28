namespace blooddonation
{
    partial class ControlAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlAdmin));
            this.pnEncabezadoPacientes = new System.Windows.Forms.Panel();
            this.lbPacientes = new System.Windows.Forms.Label();
            this.pnContenedorPacientes = new System.Windows.Forms.Panel();
            this.btnNuevoAdmin = new System.Windows.Forms.Button();
            this.btnModificarAdmin = new System.Windows.Forms.Button();
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
            this.pnEncabezadoPacientes.Size = new System.Drawing.Size(753, 71);
            this.pnEncabezadoPacientes.TabIndex = 2;
            // 
            // lbPacientes
            // 
            this.lbPacientes.AutoSize = true;
            this.lbPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPacientes.ForeColor = System.Drawing.Color.White;
            this.lbPacientes.Location = new System.Drawing.Point(276, 26);
            this.lbPacientes.Name = "lbPacientes";
            this.lbPacientes.Size = new System.Drawing.Size(178, 25);
            this.lbPacientes.TabIndex = 0;
            this.lbPacientes.Text = "ADMINISTRADOR";
            // 
            // pnContenedorPacientes
            // 
            this.pnContenedorPacientes.BackColor = System.Drawing.Color.Gainsboro;
            this.pnContenedorPacientes.Controls.Add(this.btnNuevoAdmin);
            this.pnContenedorPacientes.Controls.Add(this.btnModificarAdmin);
            this.pnContenedorPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedorPacientes.Location = new System.Drawing.Point(0, 71);
            this.pnContenedorPacientes.Name = "pnContenedorPacientes";
            this.pnContenedorPacientes.Size = new System.Drawing.Size(753, 428);
            this.pnContenedorPacientes.TabIndex = 3;
            // 
            // btnNuevoAdmin
            // 
            this.btnNuevoAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnNuevoAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoAdmin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevoAdmin.FlatAppearance.BorderSize = 0;
            this.btnNuevoAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoAdmin.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAdmin.ForeColor = System.Drawing.Color.White;
            this.btnNuevoAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoAdmin.Image")));
            this.btnNuevoAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoAdmin.Location = new System.Drawing.Point(74, 47);
            this.btnNuevoAdmin.Name = "btnNuevoAdmin";
            this.btnNuevoAdmin.Size = new System.Drawing.Size(185, 50);
            this.btnNuevoAdmin.TabIndex = 5;
            this.btnNuevoAdmin.Text = "Nuevo";
            this.btnNuevoAdmin.UseVisualStyleBackColor = false;
            this.btnNuevoAdmin.Click += new System.EventHandler(this.btnNuevoAdmin_Click);
            // 
            // btnModificarAdmin
            // 
            this.btnModificarAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnModificarAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarAdmin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModificarAdmin.FlatAppearance.BorderSize = 0;
            this.btnModificarAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarAdmin.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAdmin.ForeColor = System.Drawing.Color.White;
            this.btnModificarAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarAdmin.Image")));
            this.btnModificarAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarAdmin.Location = new System.Drawing.Point(480, 47);
            this.btnModificarAdmin.Name = "btnModificarAdmin";
            this.btnModificarAdmin.Size = new System.Drawing.Size(185, 50);
            this.btnModificarAdmin.TabIndex = 4;
            this.btnModificarAdmin.Text = "Modificar";
            this.btnModificarAdmin.UseVisualStyleBackColor = false;
            this.btnModificarAdmin.Click += new System.EventHandler(this.btnModificarAdmin_Click);
            // 
            // ControlAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 499);
            this.Controls.Add(this.pnContenedorPacientes);
            this.Controls.Add(this.pnEncabezadoPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlAdmin";
            this.Text = "ControlAdmin";
            this.pnEncabezadoPacientes.ResumeLayout(false);
            this.pnEncabezadoPacientes.PerformLayout();
            this.pnContenedorPacientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnEncabezadoPacientes;
        private System.Windows.Forms.Label lbPacientes;
        private System.Windows.Forms.Panel pnContenedorPacientes;
        private System.Windows.Forms.Button btnNuevoAdmin;
        private System.Windows.Forms.Button btnModificarAdmin;
    }
}