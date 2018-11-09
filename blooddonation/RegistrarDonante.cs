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
    public partial class RegistrarDonante : Form
    {
        public RegistrarDonante()
        {
            InitializeComponent();
            LlenarComboEstados();
            LlenarComboMunicipio();
            LlenarComboColonia();
            LlenarComboCP();
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

        private void LlenarComboMunicipio()
        {
            Ctl_Municipio est = new Ctl_Municipio();
            RepoDireccion repo = new RepoDireccion();
            List<Ctl_Municipio> listaMunicipio = repo.CargarMunicipios().ToList();
            est.Id_Municipio = -1;
            est.Descripcion = "-------Selecciona-------";
            listaMunicipio.Insert(0, est);
            this.cBMunicipio.ValueMember = "Id_Municipio";
            this.cBMunicipio.DisplayMember = "Descripcion";
            this.cBMunicipio.DataSource = listaMunicipio;
        }

        private void LlenarComboColonia()
        {
            Ctl_Colonia est = new Ctl_Colonia();
            RepoDireccion repo = new RepoDireccion();
            List<Ctl_Colonia> listaColonia = repo.CargarColonias().ToList();
            est.Id_Colonia = -1;
            est.Descripcion = "-------Selecciona-------";
            listaColonia.Insert(0, est);
            this.cBColonia.ValueMember = "Id_Colonia";
            this.cBColonia.DisplayMember = "Descripcion";
            this.cBColonia.DataSource = listaColonia;
        }

        private void LlenarComboCP()
        {
            Ctl_CodigoPostal est = new Ctl_CodigoPostal();
            RepoDireccion repo = new RepoDireccion();
            List<Ctl_CodigoPostal> listaCP = repo.CargarCP().ToList();
            est.Id_CP = -1;
            est.CodigoPostal = "Selecciona";
            listaCP.Insert(0, est);
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
    }
}
