using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blooddonation
{
    public partial class ControlPrincipal : Form
    {
        public ControlPrincipal()
        {
            InitializeComponent();
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
            lbFecha.Text = DateTime.Now.ToLongDateString();
        }
        //Este metodo o funcion sirve para acoplar los 
        //formularios en el panelContenedor para usar el mismo formulario
        //se manda a llamar los labels y picture box y ocupamos
        //el componente dispose para ocultarlos
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
            lbFecha.Dispose();
            lbHora.Dispose();
            lbDonarSangre.Dispose();
            lbesDonarVida.Dispose();
            pblogomanossangre.Dispose();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            //Convocamos como parametro el formulario que deceamos abrir
            AbrirFormInPanel(new FrmPacientes());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Home());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Se compara con if para saber que opcion va elegir el usuario
            //MessageBox.show("Se escribe el mensaje que se va mostrar","el nombre del titulo"
            //,MessageBoxButtons.siOno,MessageBoxIcono.Selecionamos el icono a mostrar)
            if (MessageBox.Show("Estas seguro de salir de la aplicación?","¡ADVERTENCIA!"
                ,MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ControlCitas());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ShowRecomendaciones());
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ControlAdmin());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ControlDonante());
        }
    }
}
