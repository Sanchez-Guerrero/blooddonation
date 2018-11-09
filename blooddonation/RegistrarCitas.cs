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
    public partial class RegistrarCitas : Form
    {
        public RegistrarCitas()
        {
            InitializeComponent();
            LlenarComboClinicas();
            LlenarComboDireccion();
            DenegarEscrituraCombos();
        }

        private void LlenarComboClinicas()
        {
            Ctl_Clinica clinica = new Ctl_Clinica();
            RepoClinica repo = new RepoClinica();
            List<Ctl_Clinica> listaClinica = repo.ConsultarClinica().ToList();
            clinica.Id_Clinica = -1;
            clinica.NomClinica = "Seleccionar";
            listaClinica.Insert(0, clinica);
            this.comboBox1.ValueMember = "Id_Clinica";
            this.comboBox1.DisplayMember = "NomClinica";
            this.comboBox1.DataSource = listaClinica;
        }

        private void LlenarComboDireccion()
        {
            Ctl_Clinica clinica = new Ctl_Clinica();
            RepoClinica repo = new RepoClinica();
            List<Ctl_Clinica> listaDireccion = repo.ConsultarDireccion().ToList();
            clinica.Id_Clinica = -1;
            clinica.DireccionClinica = "Seleccionar";
            listaDireccion.Insert(0, clinica);
            this.comboBox2.ValueMember = "Id_Clinica";
            this.comboBox2.DisplayMember = "DireccionClinica";
            this.comboBox2.DataSource = listaDireccion;
        }

        private void DenegarEscrituraCombos()
        {
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
