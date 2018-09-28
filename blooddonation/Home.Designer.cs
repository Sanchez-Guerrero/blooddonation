namespace blooddonation
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.PanelContenedorHome = new System.Windows.Forms.Panel();
            this.lbesDonarVida = new System.Windows.Forms.Label();
            this.lbDonarSangre = new System.Windows.Forms.Label();
            this.pblogomanossangre = new System.Windows.Forms.PictureBox();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.PanelContenedorHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogomanossangre)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContenedorHome
            // 
            this.PanelContenedorHome.BackColor = System.Drawing.Color.Transparent;
            this.PanelContenedorHome.Controls.Add(this.lbesDonarVida);
            this.PanelContenedorHome.Controls.Add(this.lbDonarSangre);
            this.PanelContenedorHome.Controls.Add(this.pblogomanossangre);
            this.PanelContenedorHome.Controls.Add(this.lbFecha);
            this.PanelContenedorHome.Controls.Add(this.lbHora);
            this.PanelContenedorHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorHome.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedorHome.Name = "PanelContenedorHome";
            this.PanelContenedorHome.Size = new System.Drawing.Size(707, 501);
            this.PanelContenedorHome.TabIndex = 8;
            // 
            // lbesDonarVida
            // 
            this.lbesDonarVida.AutoSize = true;
            this.lbesDonarVida.BackColor = System.Drawing.Color.Transparent;
            this.lbesDonarVida.Font = new System.Drawing.Font("Century Schoolbook", 50.25F, System.Drawing.FontStyle.Bold);
            this.lbesDonarVida.ForeColor = System.Drawing.Color.Red;
            this.lbesDonarVida.Location = new System.Drawing.Point(128, 116);
            this.lbesDonarVida.Name = "lbesDonarVida";
            this.lbesDonarVida.Size = new System.Drawing.Size(524, 78);
            this.lbesDonarVida.TabIndex = 4;
            this.lbesDonarVida.Text = "es Donar Vida";
            // 
            // lbDonarSangre
            // 
            this.lbDonarSangre.AutoSize = true;
            this.lbDonarSangre.BackColor = System.Drawing.Color.Transparent;
            this.lbDonarSangre.Font = new System.Drawing.Font("Century Schoolbook", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonarSangre.ForeColor = System.Drawing.Color.Red;
            this.lbDonarSangre.Location = new System.Drawing.Point(128, 22);
            this.lbDonarSangre.Name = "lbDonarSangre";
            this.lbDonarSangre.Size = new System.Drawing.Size(517, 78);
            this.lbDonarSangre.TabIndex = 3;
            this.lbDonarSangre.Text = "Donar Sangre";
            // 
            // pblogomanossangre
            // 
            this.pblogomanossangre.Image = ((System.Drawing.Image)(resources.GetObject("pblogomanossangre.Image")));
            this.pblogomanossangre.Location = new System.Drawing.Point(462, 294);
            this.pblogomanossangre.Name = "pblogomanossangre";
            this.pblogomanossangre.Size = new System.Drawing.Size(256, 256);
            this.pblogomanossangre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pblogomanossangre.TabIndex = 2;
            this.pblogomanossangre.TabStop = false;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.BackColor = System.Drawing.Color.Transparent;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.lbFecha.Location = new System.Drawing.Point(50, 353);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(79, 29);
            this.lbFecha.TabIndex = 1;
            this.lbFecha.Text = "label2";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.BackColor = System.Drawing.Color.Transparent;
            this.lbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.lbHora.Location = new System.Drawing.Point(86, 261);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(209, 76);
            this.lbHora.TabIndex = 0;
            this.lbHora.Text = "label2";
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 501);
            this.Controls.Add(this.PanelContenedorHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.PanelContenedorHome.ResumeLayout(false);
            this.PanelContenedorHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogomanossangre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContenedorHome;
        private System.Windows.Forms.Label lbesDonarVida;
        private System.Windows.Forms.Label lbDonarSangre;
        private System.Windows.Forms.PictureBox pblogomanossangre;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer horafecha;
    }
}