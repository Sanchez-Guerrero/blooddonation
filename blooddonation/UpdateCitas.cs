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
    public partial class UpdateCitas : Form
    {
        public UpdateCitas()
        {
            InitializeComponent();
            LlenarComboClinicas();
            LlenarComboPaciente();
            LlenarComboDonante();
            LlenardGriedViewCitas();
            txtHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void LlenarComboClinicas()
        {
            Ctl_Clinica clinica = new Ctl_Clinica();
            RepoClinica repo = new RepoClinica();
            List<Ctl_Clinica> listaClinica = repo.ConsultarClinica().ToList();
            clinica.Id_Clinica = -1;
            clinica.NomClinica = "----------Seleccionar----------";
            listaClinica.Insert(0, clinica);
            this.comboBox1.ValueMember = "Id_Clinica";
            this.comboBox1.DisplayMember = "NomClinica";
            this.comboBox1.DataSource = listaClinica;
        }

        private void LlenarComboPaciente()
        {
            Tbl_Persona per = new Tbl_Persona();
            RepoClinica repo = new RepoClinica();
            List<Tbl_Persona> listaPacientes = repo.ConsultarPaciente().ToList();
            per.id = -1;
            per.curp = "----------Seleccionar----------";
            listaPacientes.Insert(0, per);
            this.cBPacientes.ValueMember = "id";
            this.cBPacientes.DisplayMember = "curp";
            this.cBPacientes.DataSource = listaPacientes;

        }

        private void LlenarComboDonante()
        {
            Tbl_Persona per = new Tbl_Persona();
            RepoClinica repo = new RepoClinica();
            List<Tbl_Persona> listaPacientes = repo.ConsultarDonante().ToList();
            per.id = -1;
            per.curp = "----------Seleccionar----------";
            listaPacientes.Insert(0, per);
            this.cBDonantes.ValueMember = "id";
            this.cBDonantes.DisplayMember = "curp";
            this.cBDonantes.DataSource = listaPacientes;

        }

        private void LlenarComboDireccion(int Id_Clinica)
        {
            Ctl_DireccionClinica dir = new Ctl_DireccionClinica();
            RepoClinica repo = new RepoClinica();
            List<Ctl_DireccionClinica> listaDireClini = repo.ConsultarDireccionClinica(Id_Clinica);
            dir.Id_Direccion = -1;
            dir.DireccionClinica = "----------Seleccionar----------";
            listaDireClini.Insert(0, dir);
            this.comboBox2.ValueMember = "Id_Direccion";
            this.comboBox2.DisplayMember = "DireccionClinica";
            this.comboBox2.DataSource = listaDireClini;
        }

        private void LlenardGriedViewCitas()
        {
            RepoCita repo = new RepoCita();
            dGVConsulta.DataSource = repo.ConsultarCitas();
        }

        private void dGVConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVConsulta.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dGVConsulta.SelectedRows)
                {
                    lblId.Text = row.Cells[0].Value.ToString();
                    dTPFechaCita.Text = row.Cells[3].Value.ToString();
                    txtHora.Text = row.Cells[4].Value.ToString();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnModificarCita_Click(object sender, EventArgs e)
        {
            Tbl_Cita ci = new Tbl_Cita();
            RepoCita repo = new RepoCita();
            ci.Id_Cita = int.Parse(lblId.Text);
            ci.Id_Donante = cBDonantes.SelectedIndex;
            ci.Id_Solicitante = cBPacientes.SelectedIndex;
            ci.Fecha = DateTime.Parse(dTPFechaCita.Value.ToLongDateString());
            ci.Hora = txtHora.Text;
            lblIdClinica.Text = comboBox1.SelectedValue.ToString();
            ci.Id_Clinica = int.Parse(lblIdClinica.Text);
            if (MessageBox.Show("Desea Modificar la cita", "¡ADVERTENCIA!"
               , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                repo.ModificarCita(ci);
                dGVConsulta.DataSource = repo.ConsultarCitas();
                MessageBox.Show("Se ha modificado correctamente", "¡EXITOSO!"
                       , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se modifico", "¡Advertencia!"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dTPFechaCita_Validating(object sender, CancelEventArgs e)
        {
            if (dTPFechaCita.Value.Date <= DateTime.Now.Date)
            {
                e.Cancel = true;
                MessageBox.Show("No puede seleccionar una fecha despues de la de hoy", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != null)
            {
                int Id_Clinica = int.Parse(comboBox1.SelectedValue.ToString());
                LlenarComboDireccion(Id_Clinica);
            }
        }
    }
}
