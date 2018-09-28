using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blooddonation
{
    public partial class ControlAdmin : Form
    {
        public ControlAdmin()
        {
            InitializeComponent();
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.pnContenedorPacientes.Controls.Count > 0)
                this.pnContenedorPacientes.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnContenedorPacientes.Controls.Add(fh);
            this.pnContenedorPacientes.Tag = fh;
            fh.Show();
            lbPacientes.Dispose();
            pnEncabezadoPacientes.Dispose();
            btnNuevoAdmin.Dispose();
            btnModificarAdmin.Dispose();
            
        }

        private void btnNuevoAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new RegistrarAdmin());
        }

        private void btnModificarAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new UpdateAdmin());
        }
    }
}
