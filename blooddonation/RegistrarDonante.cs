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
    public partial class RegistrarDonante : Form
    {
        public RegistrarDonante()
        {
            InitializeComponent();
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.pnContenedorRegistarPaciente.Controls.Count > 0)
                this.pnContenedorRegistarPaciente.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnContenedorRegistarPaciente.Controls.Add(fh);
            this.pnContenedorRegistarPaciente.Tag = fh;
            fh.Show();
            txtNombres.Dispose();
            txtApellidoPaterno.Dispose();
            txtApellidoMaterno.Dispose();
            txtEdad.Dispose();
            txtCurp.Dispose();
            txtTelefono.Dispose();
            cBEstCivil.Dispose();
            cBGenero.Dispose();
            cBTipSangre.Dispose();
            txtCalle.Dispose();
            cBEstadoDireccion.Dispose();
            cBMunicipio.Dispose();
            cBColonia.Dispose();
            txtNumExterior.Dispose();
            txtNumInterior.Dispose();
            cBCP.Dispose();
            pnEncabezadoRegistrar.Dispose();
            lbEtiquetaDPersonales.Dispose();
            label1.Dispose();
            label10.Dispose();
            label12.Dispose();
            label13.Dispose();
            label14.Dispose();
            label2.Dispose();
            label3.Dispose();
            label4.Dispose();
            label5.Dispose();
            label6.Dispose();
            label7.Dispose();
            label8.Dispose();
            label9.Dispose();
            lbtiquetaNombre.Dispose();
            lblEtiqutaAPaterno.Dispose();
            lblEtiqueaAMaterno.Dispose();
            lblEtiquetaEdad.Dispose();
            rshDatosPersonales.Dispose();
            rectangleShape1.Dispose();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new TestParaDonar());
        }
    }
}
