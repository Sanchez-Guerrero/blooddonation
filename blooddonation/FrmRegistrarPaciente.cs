using Model.Data;
using Repo.Repositorio;
using Repo.Validaciones;
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
    public partial class FrmRegistrarPaciente : Form
    {
        ValidarLetras vl = new ValidarLetras();
        ValidarNumeros vn = new ValidarNumeros();
        public FrmRegistrarPaciente()
        {
            InitializeComponent();
            LlenarComboEstados();
            LlenarComboTipoSangre();
            LlenarComboGenero();
            LlenarComboEstadoCivil();
        }

        private void LlenarComboEstados()
        {
            Ctl_Estados est = new Ctl_Estados();
            RepoDireccion repo = new RepoDireccion();
            List<Ctl_Estados> listaEstados = repo.CargarEstados().ToList();
            est.Id_Estado = -1;
            est.Estado = "-------Selecciona-------";
            listaEstados.Insert(0, est);
            this.cBEstadoDireccion.ValueMember = "Id_Estado";
            this.cBEstadoDireccion.DisplayMember = "Estado";
            this.cBEstadoDireccion.DataSource = listaEstados;
        }

        private void LlenarComboMunicipio(int Id_Estado)
        {
            Ctl_Municipio muni = new Ctl_Municipio();
            RepoDireccion repo = new RepoDireccion();
            List<Ctl_Municipio> listaMunicipio = repo.CargarMunicipios(Id_Estado).ToList();
            muni.Id_Municipio = -1;
            muni.Municipio = "-------Selecciona-------";
            listaMunicipio.Insert(0, muni);
            this.cBMunicipio.ValueMember = "Id_Municipio";
            this.cBMunicipio.DisplayMember = "Municipio";
            this.cBMunicipio.DataSource = listaMunicipio;
        }

        private void LlenarComboColonia(int Id_Municipio)
        {
            Ctl_Colonia col = new Ctl_Colonia();
            RepoDireccion repo = new RepoDireccion();
            List<Ctl_Colonia> listaColonia = repo.CargarColonias(Id_Municipio).ToList();
            col.Id_Colonia = -1;
            col.Colonia = "-------Selecciona-------";
            listaColonia.Insert(0, col);
            this.cBColonia.ValueMember = "Id_Colonia";
            this.cBColonia.DisplayMember = "Colonia";
            this.cBColonia.DataSource = listaColonia;
        }

        private void LlenarComboCP(int Id_Colonia)
        {
            Ctl_CodigoPostal cp = new Ctl_CodigoPostal();
            RepoDireccion repo = new RepoDireccion();
            List<Ctl_CodigoPostal> listaCP = repo.CargarCP(Id_Colonia).ToList();
            cp.Id_CP = -1;
            cp.CodigoPostal = "Selecciona";
            listaCP.Insert(0, cp);
            this.cBCP.ValueMember = "Id_CP";
            this.cBCP.DisplayMember = "CodigoPostal";
            this.cBCP.DataSource = listaCP;
        }

        private void LlenarComboTipoSangre()
        {
            Ctl_TipoSangre tip = new Ctl_TipoSangre();
            RepoTipoSangre repo = new RepoTipoSangre();
            List<Ctl_TipoSangre> listaTipoSangre = repo.CargarTipoSangre().ToList();
            tip.Id_TipoSangre = -1;
            tip.Tipo_Sangre = "-------Selecciona-------";
            listaTipoSangre.Insert(0, tip);
            this.cBTipSangre.ValueMember = "Id_TipoSangre";
            this.cBTipSangre.DisplayMember = "Tipo_Sangre";
            this.cBTipSangre.DataSource = listaTipoSangre;
        }

        private void LlenarComboGenero()
        {
            Ctl_Genero gen = new Ctl_Genero();
            RepoGenero repo = new RepoGenero();
            List<Ctl_Genero> listaTipoGenero = repo.CargarGenero().ToList();
            gen.Id_Genero = -1;
            gen.Genero = "-------Selecciona-------";
            listaTipoGenero.Insert(0, gen);
            this.cBGenero.ValueMember = "Id_Genero";
            this.cBGenero.DisplayMember = "Genero";
            this.cBGenero.DataSource = listaTipoGenero;
        }

        private void LlenarComboEstadoCivil()
        {
            Ctl_EstadoCivil est = new Ctl_EstadoCivil();
            RepoEstadoCivil repo = new RepoEstadoCivil();
            List<Ctl_EstadoCivil> listaEstadoCivil = repo.CargarEstadoCivil().ToList();
            est.Id_EstadoCivil = -1;
            est.Estado_Civil = "-------Selecciona-------";
            listaEstadoCivil.Insert(0, est);
            this.cBEstCivil.ValueMember = "Id_EstadoCivil";
            this.cBEstCivil.DisplayMember = "Estado_Civil";
            this.cBEstCivil.DataSource = listaEstadoCivil;
        }

        private void LimpiarCampos()
        {
            txtNombres.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtEdad.Clear();
            txtCurp.Clear();
            txtTelefono.Clear();
            cBEstCivil.SelectedIndex = 0;
            cBGenero.SelectedIndex = 0;
            cBTipSangre.SelectedIndex = 0;
            txtCalle.Clear();
            cBEstadoDireccion.SelectedIndex = 0;
            txtNumExterior.Clear();
            txtNumInterior.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Tbl_Persona per = new Tbl_Persona();
            RepoPacientes repo = new RepoPacientes();
            RepoCurp rep = new RepoCurp();
            per.nombre = txtNombres.Text;
            per.aPaterno = txtApellidoPaterno.Text;
            per.aMaterno = txtApellidoMaterno.Text;
            lblEdad.Text = txtEdad.Text;
            per.curp = txtCurp.Text.ToUpper();
            lblTTelefono.Text = txtTelefono.Text;
            
            per.idEstadoCivil = cBEstCivil.SelectedIndex;
            per.idGenero = cBGenero.SelectedIndex;
            per.idTipoSangre = cBTipSangre.SelectedIndex;
            per.Calle = txtCalle.Text;
            var estado = cBEstadoDireccion.SelectedIndex;
            var muni = cBMunicipio.SelectedIndex;
            var col = cBColonia.SelectedIndex;
            per.NumExterior = txtNumExterior.Text;
            per.NumInterior = txtNumInterior.Text;
            lblCP.Text = cBCP.SelectedValue.ToString();
            per.Id_CodigoPostal = int.Parse(lblCP.Text);
            per.idTipoPaciente = int.Parse("1");
            per.idCita = int.Parse("3");
            
            if (per.nombre == "")
            {
                MessageBox.Show("El campo nombre debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (per.aPaterno == "")
            {
                MessageBox.Show("El campo apellido paterno debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (per.aMaterno == "")
            {
                MessageBox.Show("El campo apellido materno debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lblEdad.Text == "")
            {
                MessageBox.Show("El campo edad debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (per.curp == "")
            {
                MessageBox.Show("El campo curp debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lblTTelefono.Text == "")
            {
                MessageBox.Show("El campo teléfono debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (per.idEstadoCivil == 0)
            {
                MessageBox.Show("Debe de elegir un estado civil!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (per.idGenero == 0)
            {
                MessageBox.Show("Debe de elegir un genero!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (per.idTipoSangre == 0)
            {
                MessageBox.Show("Debe de elegir un tipo de sangre!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (per.Calle == "")
            {
                MessageBox.Show("El campo calle debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (estado == 0)
            {
                MessageBox.Show("Debe de elegir un estado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (muni == 0)
            {
                MessageBox.Show("Debe de elegir un municipio!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (col == 0)
            {
                MessageBox.Show("Debe de elegir una colonia!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (per.NumExterior == "")
            {
                MessageBox.Show("El campo numero exterior debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (per.NumInterior == "")
            {
                MessageBox.Show("El campo numero interior debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lblCP.Text == "-1")
            {
                MessageBox.Show("Debe de elegir un codigo postal!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Desea registrar al paciente: "+per.nombre, "¡ADVERTENCIA!"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (per.curp == rep.ConsultarsiExistelaPersona(per.curp))
                    {
                        MessageBox.Show("No se registro a la persona por que ya existe", "¡Advertencia!"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        per.edad = int.Parse(lblEdad.Text);
                        per.telefono = long.Parse(lblTTelefono.Text);
                        repo.RegistrarPaciente(per);
                        MessageBox.Show("Se ha registrado correctamente", "¡EXITOSO!"
                                  , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                }
                else
                {
                    MessageBox.Show("No se registro", "¡Advertencia!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cBEstCivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBEstadoDireccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBEstadoDireccion.SelectedValue.ToString() != null)
            {
                int Id_Estado = int.Parse(cBEstadoDireccion.SelectedValue.ToString());
                LlenarComboMunicipio(Id_Estado);
            }
        }

        private void cBMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBMunicipio.SelectedValue.ToString() != null)
            {
                int Id_Municipio = int.Parse(cBMunicipio.SelectedValue.ToString());
                LlenarComboColonia(Id_Municipio);
            }
        }

        private void cBColonia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBColonia.SelectedValue.ToString() != null)
            {
                int Id_Colonia = int.Parse(cBColonia.SelectedValue.ToString());
                LlenarComboCP(Id_Colonia);
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            vl.SoloLetras(e);
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            vl.SoloLetras(e);
        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            vl.SoloLetras(e);
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            vn.SoloNumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            vn.SoloNumeros(e);
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            txtNombres.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombres.Text);
            txtNombres.SelectionStart = txtNombres.Text.Length;
        }

        private void txtApellidoPaterno_TextChanged(object sender, EventArgs e)
        {
            txtApellidoPaterno.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtApellidoPaterno.Text);
            txtApellidoPaterno.SelectionStart = txtApellidoPaterno.Text.Length;
        }

        private void txtApellidoMaterno_TextChanged(object sender, EventArgs e)
        {
            txtApellidoMaterno.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtApellidoMaterno.Text);
            txtApellidoMaterno.SelectionStart = txtApellidoMaterno.Text.Length;
        }

        private void txtCalle_TextChanged(object sender, EventArgs e)
        {
            txtCalle.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtCalle.Text);
            txtCalle.SelectionStart = txtCalle.Text.Length;
        }

        private void txtNumExterior_TextChanged(object sender, EventArgs e)
        {
            txtNumExterior.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNumExterior.Text);
            txtNumExterior.SelectionStart = txtNumExterior.Text.Length;
        }

        private void txtNumInterior_TextChanged(object sender, EventArgs e)
        {
            txtNumInterior.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNumInterior.Text);
            txtNumInterior.SelectionStart = txtNumInterior.Text.Length;
        }
    }
}
