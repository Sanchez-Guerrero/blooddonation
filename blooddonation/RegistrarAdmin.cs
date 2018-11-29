using Model.Data;
using Repo.Encriptacion;
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
    public partial class RegistrarAdmin : Form
    {
        ValidarLetras vl = new ValidarLetras();
        ValidarNumeros vn = new ValidarNumeros();
        public RegistrarAdmin()
        {
            InitializeComponent();
            LlenarComboEstados();
            LlenarComboGenero();
            LlenarComboEstadoCivil();
            LlenarComboPerfil();
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

        private void LlenarComboPerfil()
        {
            Ctl_Perfil per = new Ctl_Perfil();
            RepoPerfil repo = new RepoPerfil();
            List<Ctl_Perfil> listaTipoPerfil = repo.CargarPerfil().ToList();
            per.Id_Perfil = -1;
            per.Descripcion = "-------Selecciona-------";
            listaTipoPerfil.Insert(0, per);
            this.comboBox1.ValueMember = "Id_Perfil";
            this.comboBox1.DisplayMember = "Descripcion";
            this.comboBox1.DataSource = listaTipoPerfil;
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
            txtTelefono.Clear();
            cBGenero.SelectedIndex = 0;
            cBEstCivil.SelectedIndex = 0;
            txtCalle.Clear();
            cBEstadoDireccion.SelectedIndex = 0;
            txtNumExterior.Clear();
            txtNumInterior.Clear();
            txtNomUsuario.Clear();
            txtPassword.Clear();
            comboBox1.SelectedIndex = 0;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Tbl_Administrador ad = new Tbl_Administrador();
            RepoAdministrador repo = new RepoAdministrador();
            EncriptacionPassword ecp = new EncriptacionPassword(); 
            ad.Nombres = txtNombres.Text;
            ad.APaterno = txtApellidoPaterno.Text;
            ad.AMaterno = txtApellidoMaterno.Text;
            lblTelefono.Text = txtTelefono.Text;
            ad.Id_Genero = cBGenero.SelectedIndex;
            ad.Id_EstadoCivil = cBEstCivil.SelectedIndex;
            ad.Calle = txtCalle.Text;
            var estado = cBEstadoDireccion.SelectedIndex;
            var muni = cBMunicipio.SelectedIndex;
            var col = cBColonia.SelectedIndex;
            ad.NumExterior = txtNumExterior.Text;
            ad.NumInterior = txtNumInterior.Text;
            lblIdCP.Text = cBCP.SelectedValue.ToString();
            ad.Id_CodigoPostal = int.Parse(lblIdCP.Text);
            ad.Usuario = txtNomUsuario.Text;
            ad.Contrasenia = txtPassword.Text;
            ad.Contrasenia = ecp.EncriptarPassword(txtPassword.Text);
            ad.Id_Perfil = comboBox1.SelectedIndex;

            if (ad.Nombres == "")
            {
                MessageBox.Show("El campo nombre debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ad.APaterno == "")
            {
                MessageBox.Show("El campo apellido paterno debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ad.AMaterno == "")
            {
                MessageBox.Show("El campo apellido materno debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lblTelefono.Text == "")
            {
                MessageBox.Show("El campo teléfono debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ad.Id_Genero == 0)
            {
                MessageBox.Show("Debe de elegir un genero!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ad.Id_EstadoCivil == 0)
            {
                MessageBox.Show("Debe de elegir un estado civil!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ad.Calle == "")
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
            else if (ad.NumExterior == "")
            {
                MessageBox.Show("El campo numero exterior debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ad.NumInterior == "")
            {
                MessageBox.Show("El campo numero interior debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lblIdCP.Text == "-1")
            {
                MessageBox.Show("Debe de elegir un codigo postal!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ad.Usuario == "")
            {
                MessageBox.Show("El campo nombre de usuario debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("El campo contraseña debe estar llenado!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ad.Id_Perfil == 0)
            {
                MessageBox.Show("Debe de elegir un perfil!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Desea registrar al administrador: " + ad.Nombres, "¡ADVERTENCIA!"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                
                    ad.Telefono = long.Parse(lblTelefono.Text);
                    repo.RegistrarCuenta(ad);
                    MessageBox.Show("Se ha registrado correctamente", "¡EXITOSO!"
                              , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se registro", "¡Advertencia!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
            }
        }
    }
}
