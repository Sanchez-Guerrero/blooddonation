using Repo.Repositorio;
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
    public partial class ControlCitas : Form
    {
        public ControlCitas()
        {
            InitializeComponent();
            LlenardGriedViewCitas();
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
            btnNuevaCita.Dispose();
            btnModificarCita.Dispose();
            btnEliminarCita.Dispose();
            dGVConsulta.Dispose();
            rSTabla.Dispose();
        }

        private void btnNuevaCita_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new RegistrarCitas());
        }

        private void btnModificarCita_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new UpdateCitas());
        }

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new DeleteCitas());
        }

        private void LlenardGriedViewCitas()
        {
            RepoCita repo = new RepoCita();
            dGVConsulta.DataSource = repo.ConsultarCitas();
        }
    }
}
