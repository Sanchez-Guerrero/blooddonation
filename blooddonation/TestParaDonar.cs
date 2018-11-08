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
    public partial class TestParaDonar : Form
    {
        //modificación Gis 
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.ContenedorTest.Controls.Count > 0)
                this.ContenedorTest.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.ContenedorTest.Controls.Add(fh);
            this.ContenedorTest.Tag = fh;
            fh.Show();
            //DEFINITIVOS
            etImpedimentosDefinitivos.Dispose();
            cBIDefinitivosSI.Dispose();
            cBIDefinitivosNO.Dispose();
            etDescripcionDefinitivos.Dispose();
            //DOCE MESES
            etImpedimentosDoce.Dispose();
            cB12MesesSI.Dispose();
            cB12MesesNO.Dispose();
            etDescripcionDoce.Dispose();
            //MUJERES
            etImpedimentosMujeres.Dispose();
            cBMuejeresSI.Dispose();
            cBMuejeresNO.Dispose();
            etDescripcionMujeres.Dispose();
            //72 HORAS
            etImpedimentosSetentaydos.Dispose();
            cB72HorasSI.Dispose();
            cB72HorasNo.Dispose();
            etDescripcionSetentaydos.Dispose();
            //BOTON GUARDAR
            btnGuadarTest.Dispose();
            //OTRO CONTENEDOR
            rectangleShape2.Dispose();
        }
        //hasta aqui

        public TestParaDonar()
        {
            InitializeComponent();
        }

        private void cBIDefinitivosSI_CheckedChanged(object sender, EventArgs e)
        {
            //modificacion Gis
            MessageBox.Show("No puedes donar sangre, cumples con uno o varios impedimentos definitivos");
            MessageBox.Show("Gracias por intentar apoyar a otros");
            //Application.Exit();
            AbrirFormInPanel(new ControlDonante());



        }

    private void cB12MesesSI_CheckedChanged(object sender, EventArgs e)
        {
            //modificacion Gis
            MessageBox.Show("Debes esperar 12 meses para poder donar");
            MessageBox.Show("Gracias por intentar apoyar a otros");
            AbrirFormInPanel(new ControlDonante());
        }

        private void cBMuejeresSI_CheckedChanged(object sender, EventArgs e)
        {
            //modificacion Gis
            MessageBox.Show("Por el momento no puedes donar");
            MessageBox.Show("Gracias por intentar apoyar a otros");
            AbrirFormInPanel(new ControlDonante());
        }

        private void cB72HorasSI_CheckedChanged(object sender, EventArgs e)
        {
            //modificacion Gis
            MessageBox.Show("Deja transcurrir mínimo 72 horas para poder donar sangre");
            MessageBox.Show("Gracias por intentar apoyar a otros");
            AbrirFormInPanel(new ControlDonante());
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
