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
            if (cBIDefinitivosSI.Checked == true)
            {
                MessageBox.Show("No puede donar sangre. Cumple con uno o varios impedimentos definitivos","¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboEstatus.SelectedIndex = 2;
                BloquearCheckBox();
            }
        }

        private void cBIDefinitivosNO_CheckedChanged(object sender, EventArgs e)
        {
            if (cBIDefinitivosNO.Checked == true)
            {
                cBIDefinitivosSI.Enabled = false;
                cBIDefinitivosNO.Enabled = false;
            }
        }

        private void cB12MesesSI_CheckedChanged(object sender, EventArgs e)
        {
            if (cB12MesesSI.Checked == true)
            {
                MessageBox.Show("Debe esperar 12 meses para poder donar","¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboEstatus.SelectedIndex = 2;
                BloquearCheckBox();
            }
        }

        private void cB12MesesNO_CheckedChanged(object sender, EventArgs e)
        {
            if (cB12MesesNO.Checked == true)
            {
                cB12MesesSI.Enabled = false;
                cB12MesesNO.Enabled = false;
            }
        }

        private void cBMuejeresSI_CheckedChanged(object sender, EventArgs e)
        {
            if (cBMuejeresSI.Checked == true)
            {
                MessageBox.Show("Por el momento no puede donar", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboEstatus.SelectedIndex = 2;
                BloquearCheckBox();
            }
        }

        private void cBMuejeresNO_CheckedChanged(object sender, EventArgs e)
        {
            if (cBMuejeresNO.Checked == true)
            {
                cBMuejeresSI.Enabled = false;
                cBMuejeresNO.Enabled = false;
            }
        }

        private void cB72HorasSI_CheckedChanged(object sender, EventArgs e)
        { 
            if(cB72HorasSI.Checked == true)
            {
                MessageBox.Show("Dejar transcurrir mínimo 72 horas para poder donar sangre", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboEstatus.SelectedIndex = 2;
                BloquearCheckBox();
            }
        }

        private void cB72HorasNo_CheckedChanged(object sender, EventArgs e)
        {
            if(cB72HorasNo.Checked == true)
            {
                comboEstatus.SelectedIndex = 1;
                cB72HorasSI.Enabled = false;
                cB72HorasNo.Enabled = false;
                btnGuadarTest.Enabled = true;
            }
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
            est.Estatus = "-------Selecciona-------";
            listaEstatus.Insert(0, est);
            this.comboEstatus.ValueMember = "Id_Estatus";
            this.comboEstatus.DisplayMember = "Estatus";
            this.comboEstatus.DataSource = listaEstatus;
        }

        private void btnGuadarTest_Click(object sender, EventArgs e)
        {
            Tbl_Persona per = new Tbl_Persona();
            RepoDonante repo = new RepoDonante();
            RepoCurp rep = new RepoCurp();
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
            per.idCita = int.Parse(lblIdCita.Text);
            per.Id_CodigoPostal = int.Parse(lblCP.Text);
            per.ImpDefinitivos = cBIDefinitivosSI.Checked;
            per.Imp12Meses = cB12MesesSI.Checked;
            per.ImpMujeres = cBMuejeresSI.Checked;
            per.Imp72Horas = cB72HorasSI.Checked;
            per.Id_Estatus = comboEstatus.SelectedIndex;
            if (MessageBox.Show("Desea registrar al donante: " + per.nombre, "¡ADVERTENCIA!"
               , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (per.curp == rep.ConsultarsiExistelaPersona(per.curp))
                {
                    MessageBox.Show("No se registro a la persona por que ya existe", "¡Advertencia!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarCampos();
                }
                else
                {
                    repo.RegistrarDonante(per);
                    MessageBox.Show("Se ha registrado correctamente", "¡EXITOSO!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("No se registro", "¡Advertencia!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            cBIDefinitivosSI.Checked = false;
            cBIDefinitivosNO.Checked = false;
            cB12MesesSI.Checked = false;
            cB12MesesNO.Checked = false;
            cBMuejeresSI.Checked = false;
            cBMuejeresNO.Checked = false;
            cB72HorasSI.Checked = false;
            cB72HorasNo.Checked = false;
            comboEstatus.SelectedIndex = 0;
            cBIDefinitivosSI.Enabled = true;
            cB12MesesSI.Enabled = true;
            cBMuejeresSI.Enabled = true;
            cB72HorasSI.Enabled = true;
            cBIDefinitivosNO.Enabled = true;
            cB12MesesNO.Enabled = true;
            cBMuejeresNO.Enabled = true;
            cB72HorasNo.Enabled = true;
            btnGuadarTest.Enabled = false;
        }

        private void BloquearCheckBox()
        {
            cBIDefinitivosSI.Enabled = false;
            cBIDefinitivosNO.Enabled = false;
            cBMuejeresSI.Enabled = false;
            cBMuejeresNO.Enabled = false; 
            cB12MesesSI.Enabled = false;
            cB12MesesNO.Enabled = false;          
            cB72HorasSI.Enabled = false;
            cB72HorasNo.Enabled = false;
            btnGuadarTest.Enabled = true;
        }        
    }
}
