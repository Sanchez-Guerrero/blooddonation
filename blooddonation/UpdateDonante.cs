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
    public partial class UpdateDonante : Form
    {
        ValidarLetras vl = new ValidarLetras();
        ValidarNumeros vn = new ValidarNumeros();
        RepoDonante repo = new RepoDonante();
        public UpdateDonante()
        {
            InitializeComponent();
            LlenarComboEstados();
            LlenarComboTipoSangre();
            LlenarComboGenero();
            LlenarComboEstadoCivil();
            CargardGVDonantes();
            btnModificar.Enabled = false;
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

        private void CargardGVDonantes()
        {
            dGVConsultarDonantes.DataSource = repo.ConsultarDonantes();
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

        private void dGVConsultarDonantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVConsultarDonantes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dGVConsultarDonantes.SelectedRows) 
                {
                    lblId.Text = row.Cells[0].Value.ToString();
                    txtNombres.Text = row.Cells[1].Value.ToString();
                    txtApellidoPaterno.Text = row.Cells[2].Value.ToString();
                    txtApellidoMaterno.Text = row.Cells[3].Value.ToString();
                    txtEdad.Text = row.Cells[4].Value.ToString();
                    txtCurp.Text = row.Cells[5].Value.ToString();
                    txtTelefono.Text = row.Cells[6].Value.ToString();
                    lblIdDireccion.Text = row.Cells[8].Value.ToString();
                    txtCalle.Text = row.Cells[9].Value.ToString();
                    txtNumExterior.Text = row.Cells[10].Value.ToString();
                    txtNumInterior.Text = row.Cells[11].Value.ToString();
                    btnModificar.Enabled = true;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Tbl_Persona per = new Tbl_Persona();
            per.id = int.Parse(lblId.Text);
            per.nombre = txtNombres.Text;
            per.aPaterno = txtApellidoPaterno.Text;
            per.aMaterno = txtApellidoMaterno.Text;
            lblEdad.Text = txtEdad.Text;
            per.edad = int.Parse(lblEdad.Text);
            per.curp = txtCurp.Text;
            lblTelefono.Text = txtTelefono.Text;
            per.telefono = long.Parse(lblTelefono.Text);
            per.idTipoSangre = cBTipSangre.SelectedIndex;
            per.idDireccion = int.Parse(lblIdDireccion.Text);
            per.idGenero = cBGenero.SelectedIndex;
            per.idEstadoCivil = cBEstCivil.SelectedIndex;

            per.Calle = txtCalle.Text;
            per.NumExterior = txtNumExterior.Text;
            per.NumInterior = txtNumInterior.Text;
            lblIdCP.Text = cBCP.SelectedValue.ToString();
            per.Id_CodigoPostal = int.Parse(lblIdCP.Text);

            var estado = cBEstadoDireccion.SelectedIndex;
            var muni = cBMunicipio.SelectedIndex;
            var col = cBColonia.SelectedIndex;

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
            else if (lblTelefono.Text == "")
            {
                MessageBox.Show("El campo teléfono debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (per.idTipoSangre == 0)
            {
                MessageBox.Show("Debe de elegir un tipo de sangre!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (per.idGenero == 0)
            {
                MessageBox.Show("Debe de elegir un genero!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (per.idEstadoCivil == 0)
            {
                MessageBox.Show("Debe de elegir un estado civil!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else if (lblIdCP.Text == "-1")
            {
                MessageBox.Show("Debe de elegir un codigo postal!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Desea modificar al donante: ", "¡ADVERTENCIA!"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    repo.ModificarDonante(per);
                    dGVConsultarDonantes.DataSource = repo.ConsultarDonantes();
                    MessageBox.Show("Se ha modificado correctamente", "¡EXITOSO!"
                               , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se modifico", "¡Advertencia!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            vn.SoloNumeros(e);
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            vn.SoloNumeros(e);
        }
    }
}
