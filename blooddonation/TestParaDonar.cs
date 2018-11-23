using Model.Data;
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
    public partial class TestParaDonar : Form
    {
        public TestParaDonar()
        {
            InitializeComponent();
            LlenarComboEstatus();
            btnGuadarTest.Enabled = false;
        }

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

        private void cBIDefinitivosSI_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("No puedes donar sangre, cumples con uno o varios impedimentos definitivos");
            MessageBox.Show("Gracias por intentar apoyar a otros");
            cBIDefinitivosSI.Enabled = false;
            cBIDefinitivosNO.Enabled = false;
            cB12MesesSI.Enabled = false;
            cB12MesesNO.Enabled = false;
            cBMuejeresSI.Enabled = false;
            cBMuejeresNO.Enabled = false;
            cB72HorasSI.Enabled = false;
            cB72HorasNo.Enabled = false;
            btnGuadarTest.Enabled = true;
        }

        private void cB12MesesSI_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Debes esperar 12 meses para poder donar");
            MessageBox.Show("Gracias por intentar apoyar a otros");
            cBIDefinitivosSI.Enabled = false;
            cBIDefinitivosNO.Enabled = false;
            cB12MesesSI.Enabled = false;
            cB12MesesNO.Enabled = false;
            cBMuejeresSI.Enabled = false;
            cBMuejeresNO.Enabled = false;
            cB72HorasSI.Enabled = false;
            cB72HorasNo.Enabled = false;
            btnGuadarTest.Enabled = true;
        }

        private void cBMuejeresSI_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Por el momento no puedes donar");
            MessageBox.Show("Gracias por intentar apoyar a otros");
            cBIDefinitivosSI.Enabled = false;
            cBIDefinitivosNO.Enabled = false;
            cBMuejeresSI.Enabled = false;
            cB12MesesSI.Enabled = false;
            cB12MesesNO.Enabled = false;
            cBMuejeresNO.Enabled = false;
            cB72HorasSI.Enabled = false;
            cB72HorasNo.Enabled = false;
            btnGuadarTest.Enabled = true;
        }

        private void cB72HorasSI_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Deja transcurrir mínimo 72 horas para poder donar sangre");
            MessageBox.Show("Gracias por intentar apoyar a otros");
            cBIDefinitivosSI.Enabled = false;
            cBIDefinitivosNO.Enabled = false;
            cB12MesesSI.Enabled = false;
            cB12MesesNO.Enabled = false;
            cBMuejeresSI.Enabled = false;
            cBMuejeresNO.Enabled = false;
            cB72HorasSI.Enabled = false;
            cB72HorasNo.Enabled = false;
            btnGuadarTest.Enabled = true;
        }

        private void cB72HorasNo_CheckedChanged(object sender, EventArgs e)
        {
            btnGuadarTest.Enabled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LlenarComboEstatus()
        {
            Ctl_Estatus est = new Ctl_Estatus();
            RepoEstatus repo = new RepoEstatus();
            List<Ctl_Estatus> listaEstatus = repo.CargarEstatus().ToList();
            est.Id_Estatus = -1;
            est.Descripcion = "-------Selecciona-------";
            listaEstatus.Insert(0, est);
            this.comboEstatus.ValueMember = "Id_Estatus";
            this.comboEstatus.DisplayMember = "Descripcion";
            this.comboEstatus.DataSource = listaEstatus;
        }

        private void btnGuadarTest_Click(object sender, EventArgs e)
        {
            Tbl_Persona per = new Tbl_Persona();
            RepoDonante repo = new RepoDonante();
            per.nombre = lblNombre.Text;
            per.aPaterno = lblAP.Text;
            per.aMaterno = lblAM.Text;
            per.edad = int.Parse(lblEdad.Text);
            per.curp = lblCurp.Text;
            per.telefono = long.Parse(lblTelefono.Text);
            per.idEstadoCivil = int.Parse(lblEstCivil.Text);
            per.idGenero = int.Parse(lblGenero.Text);
            per.idTipoSangre = int.Parse(lblTipoSangre.Text);
            per.Calle = lblCalle.Text;
            per.NumExterior = lblNExterior.Text;
            per.NumInterior = lblNumInterior.Text;
            per.idTipoPaciente = int.Parse(lblTipoPaciente.Text);
            per.Id_CodigoPostal = int.Parse(lblCP.Text);
            per.ImpDefinitivos = cBIDefinitivosSI.Checked;
            per.Imp12Meses = cB12MesesSI.Checked;
            per.ImpMujeres = cBMuejeresSI.Checked;
            per.Imp72Horas = cB72HorasSI.Checked;
            per.Id_Estatus = comboEstatus.SelectedIndex;
            if(per.Id_Estatus == 0)
            {
                MessageBox.Show("Debe de elegir un status al test!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                repo.RegistrarDonante(per);
            }
        }

        
    }
}
