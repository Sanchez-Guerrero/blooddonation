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
    public partial class RegistrarDonante : Form
    {
        ValidarLetras v = new ValidarLetras();
        ValidarNumeros vn = new ValidarNumeros();
        public RegistrarDonante()
        {
            InitializeComponent();
            LlenarComboEstados();
            LlenarComboTipoSangre();
            LlenarComboGenero();
            LlenarComboEstadoCivil();
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
            Tbl_Persona per = new Tbl_Persona();
            RepoDonante repo = new RepoDonante();
            per.nombre = txtNombres.Text;
            per.aPaterno = txtApellidoPaterno.Text;
            per.aMaterno = txtApellidoMaterno.Text;
            per.edad = int.Parse(txtEdad.Text);
            per.curp = txtCurp.Text.ToUpper();
            per.telefono = long.Parse(txtTelefono.Text);
            per.idTipoSangre = cBTipSangre.SelectedIndex;
            per.Calle = txtCalle.Text;
            per.NumExterior = txtNumExterior.Text;
            per.NumInterior = txtNumInterior.Text;
            per.idGenero = cBGenero.SelectedIndex;
            per.idEstadoCivil = cBEstCivil.SelectedIndex;
            per.idTipoPaciente = 2;
            per.Id_CodigoPostal = int.Parse(cBCP.SelectedValue.ToString());
            var estado = cBEstadoDireccion.SelectedIndex;
            var muni = cBMunicipio.SelectedIndex;
            var col = cBColonia.SelectedIndex;

            if (per.nombre == "")
            {
                MessageBox.Show("El Campo Nombre debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (per.aPaterno == "")
            {
                MessageBox.Show("El Campo Apellido Paterno debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (per.aMaterno == "")
            {
                MessageBox.Show("El Campo Apellido Materno debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (per.curp == "")
            {
                MessageBox.Show("El Campo CURP debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (per.idEstadoCivil == 0)
            {
                MessageBox.Show("El combo Estado civil debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (per.idGenero == 0)
            {
                MessageBox.Show("El combo Genero debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (per.idTipoSangre == 0)
            {
                MessageBox.Show("El combo Tipo de sangre debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (per.Calle == "")
            {
                MessageBox.Show("El Campo Calle debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (estado == 0)
            {
                MessageBox.Show("El combo Estado debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (muni == 0)
            {
                MessageBox.Show("El combo Municipio debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (col == 0)
            {
                MessageBox.Show("El combo Colonia debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (per.NumExterior == "")
            {
                MessageBox.Show("El Campo Numero Exterior debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (per.NumInterior == "")
            {
                MessageBox.Show("El Campo Numero interio debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (per.Id_CodigoPostal == -1)
            {
                MessageBox.Show("El combo Codigo postal debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                repo.RegistrarDonante(per);
            }
        }

        private void LlenarComboEstados()
        {
            Ctl_Estados est = new Ctl_Estados();
            RepoDireccion repo = new RepoDireccion();
            List<Ctl_Estados> listaEstados = repo.CargarEstados().ToList();
            est.Id_Estado = -1;
            est.Descripcion = "-------Selecciona-------";
            listaEstados.Insert(0, est);
            this.cBEstadoDireccion.ValueMember = "Id_Estado";
            this.cBEstadoDireccion.DisplayMember = "Descripcion";
            this.cBEstadoDireccion.DataSource = listaEstados;
        }

        private void LlenarComboMunicipio(int Id_Estado)
        {
            Ctl_Municipio muni = new Ctl_Municipio();
            RepoDireccion repo = new RepoDireccion();
            List<Ctl_Municipio> listaMunicipio = repo.CargarMunicipios(Id_Estado).ToList();
            muni.Id_Municipio = -1;
            muni.Descripcion = "-------Selecciona-------";
            listaMunicipio.Insert(0, muni);
            this.cBMunicipio.ValueMember = "Id_Municipio";
            this.cBMunicipio.DisplayMember = "Descripcion";
            this.cBMunicipio.DataSource = listaMunicipio;
        }

        private void LlenarComboColonia(int Id_Municipio)
        {
            Ctl_Colonia col = new Ctl_Colonia();
            RepoDireccion repo = new RepoDireccion();
            List<Ctl_Colonia> listaColonia = repo.CargarColonias(Id_Municipio).ToList();
            col.Id_Colonia = -1;
            col.Descripcion = "-------Selecciona-------";
            listaColonia.Insert(0, col);
            this.cBColonia.ValueMember = "Id_Colonia";
            this.cBColonia.DisplayMember = "Descripcion";
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
            tip.Descripcion = "-------Selecciona-------";
            listaTipoSangre.Insert(0, tip);
            this.cBTipSangre.ValueMember = "Id_TipoSangre";
            this.cBTipSangre.DisplayMember = "Descripcion";
            this.cBTipSangre.DataSource = listaTipoSangre;
        }

        private void LlenarComboGenero()
        {
            Ctl_Genero gen = new Ctl_Genero();
            RepoGenero repo = new RepoGenero();
            List<Ctl_Genero> listaTipoGenero = repo.CargarGenero().ToList();
            gen.Id_Genero = -1;
            gen.Descripcion = "-------Selecciona-------";
            listaTipoGenero.Insert(0, gen);
            this.cBGenero.ValueMember = "Id_Genero";
            this.cBGenero.DisplayMember = "Descripcion";
            this.cBGenero.DataSource = listaTipoGenero;
        }

        private void LlenarComboEstadoCivil()
        {
            Ctl_EstadoCivil est = new Ctl_EstadoCivil();
            RepoEstadoCivil repo = new RepoEstadoCivil();
            List<Ctl_EstadoCivil> listaEstadoCivil = repo.CargarEstadoCivil().ToList();
            est.Id_EstadoCivil = -1;
            est.Descripcion = "-------Selecciona-------";
            listaEstadoCivil.Insert(0, est);
            this.cBEstCivil.ValueMember = "Id_EstadoCivil";
            this.cBEstCivil.DisplayMember = "Descripcion";
            this.cBEstCivil.DataSource = listaEstadoCivil;
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
            v.SoloLetras(e);
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
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
    }
}
