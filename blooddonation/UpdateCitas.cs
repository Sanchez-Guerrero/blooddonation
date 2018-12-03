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
            LlenarComboEstatusCita();
            LlenardGriedViewCitas();
            dGVConsulta.AutoGenerateColumns = false;
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
            per.id = 0;
            listaPacientes.Insert(0, per);
            this.cBPacientes.ValueMember = "id";
            this.cBPacientes.DisplayMember = "id";
            this.cBPacientes.DataSource = listaPacientes;

        }

        private void LlenarComboDonante()
        {
            Tbl_Persona per = new Tbl_Persona();
            RepoClinica repo = new RepoClinica();
            List<Tbl_Persona> listaPacientes = repo.ConsultarDonante().ToList();
            per.id = -1;
            per.id = 0;
            listaPacientes.Insert(0, per);
            this.cBDonantes.ValueMember = "id";
            this.cBDonantes.DisplayMember = "id";
            this.cBDonantes.DataSource = listaPacientes;

        }

        private void LlenarComboEstatusCita()
        {
            Ctl_EstatusCita estatus = new Ctl_EstatusCita();
            RepoEstatusCita repo = new RepoEstatusCita();
            List<Ctl_EstatusCita> listaEstatus = repo.CargarEstatusCita().ToList();
            estatus.Id_Estatus = -1;
            estatus.EstatusCita = "----------Seleccionar----------";
            listaEstatus.Insert(0, estatus);
            this.cbEstatusCita.ValueMember = "Id_Estatus";
            this.cbEstatusCita.DisplayMember = "EstatusCita";
            this.cbEstatusCita.DataSource = listaEstatus;
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
            dGVConsulta.DataSource = repo.ConsultarCitasParaModificar();
        }

        private void limpiarCampos()
        {
            cBPacientes.SelectedIndex = 0;
            cBDonantes.SelectedIndex = 0;
            dTPFechaCita.Value = DateTime.Now;
            txtHora.Clear();
            comboBox1.SelectedIndex = 0;
            cbEstatusCita.SelectedIndex = 0;
        }

        private void dGVConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVConsulta.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dGVConsulta.SelectedRows)
                {
                    lblId.Text = row.Cells[0].Value.ToString();
                    cBPacientes.Text = row.Cells[1].Value.ToString();
                    cBDonantes.Text = row.Cells[2].Value.ToString();
                    dTPFechaCita.Text = row.Cells[3].Value.ToString();
                    txtHora.Text = row.Cells[4].Value.ToString();
                    lblIdDireccion.Text = row.Cells[5].Value.ToString();
                    comboBox1.Text = row.Cells[6].Value.ToString();
                    comboBox2.Text = row.Cells[7].Value.ToString();
                    lblStatus.Text = row.Cells[8].Value.ToString();
                    cbEstatusCita.Text = row.Cells[9].Value.ToString();
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
            lblIdDonante.Text = cBDonantes.SelectedValue.ToString();
            lblIdPaciente.Text = cBPacientes.SelectedValue.ToString();
            lblStatus.Text = cbEstatusCita.SelectedValue.ToString();
            ci.Fecha = DateTime.Parse(dTPFechaCita.Value.ToLongDateString());
            ci.Hora = txtHora.Text;
            lblIdClinica.Text = comboBox2.SelectedValue.ToString();
            ci.Id_Solicitante = int.Parse(lblIdPaciente.Text);
            ci.Id_Donante = int.Parse(lblIdDonante.Text);
            ci.Id_Direccion = int.Parse(lblIdClinica.Text);
            ci.Id_Estatus = int.Parse(lblStatus.Text);
            var clini = comboBox1.SelectedIndex;
            if (lblIdPaciente.Text == "-1")
            {
                MessageBox.Show("Debe de elegir un paciente!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lblIdDonante.Text == "-1")
            {
                MessageBox.Show("Debe de elegir un Donante!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dTPFechaCita.Value.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("No puede seleccionar una fecha antes de la de hoy", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ci.Hora == "")
            {
                MessageBox.Show("El campo hora debe estar lleno!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (clini == 0)
            {
                MessageBox.Show("Debe de elegir una clinica!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lblIdClinica.Text == "-1")
            {
                MessageBox.Show("Debe de elegir una dirección!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lblStatus.Text == "-1")
            {
                MessageBox.Show("Debe de elegir una estatus!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Desea Modificar la cita", "¡ADVERTENCIA!"
               , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    repo.ModificarCita(ci);
                    dGVConsulta.DataSource = repo.ConsultarCitasParaModificar();
                    MessageBox.Show("Se ha modificado correctamente", "¡EXITOSO!"
                           , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se modifico", "¡Advertencia!"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void cBPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            RepoClinica repo = new RepoClinica();
            if (cBPacientes.SelectedText.ToString() != null)
            {
                int id = int.Parse(cBPacientes.SelectedValue.ToString());
                if (cBPacientes.SelectedIndex == 0)
                {
                    lbtiquetaNombre.Text = lbtiquetaNombre.Text;
                }
                else
                {
                    lbtiquetaNombre.Text = repo.ObtenerNombre(id);
                }
            }
        }

        private void cBDonantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            RepoClinica repo = new RepoClinica();
            if (cBDonantes.SelectedText.ToString() != null)
            {
                int id = int.Parse(cBDonantes.SelectedValue.ToString());
                if (cBDonantes.SelectedIndex == 0)
                {
                    label1.Text = label1.Text;
                }
                else
                {
                    label1.Text = repo.ObtenerNombre(id);
                }
            }
        }
    }
}
