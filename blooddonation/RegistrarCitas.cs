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
            LlenarComboDireccion();
            LlenarComboPaciente();
            DenegarEscrituraCombos();
            LlenarComboDonante();
        }

        private void LlenarComboClinicas(int Id_Direccion)
        {
            Ctl_Clinica clinica = new Ctl_Clinica();
            RepoClinica repo = new RepoClinica();
            List<Ctl_Clinica> listaClinica = repo.ConsultarClinica(Id_Direccion).ToList();
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

        private void LlenarComboDireccion()
        {
            Ctl_DireccionClinica dir = new Ctl_DireccionClinica();
            RepoClinica repo = new RepoClinica();
            List<Ctl_DireccionClinica> listaDireClini = repo.ConsultarDireccionClinica();
            dir.Id_Direccion = -1;
            dir.DireccionClinica = "----------Seleccionar----------";
            listaDireClini.Insert(0, dir);
            this.comboBox2.ValueMember = "Id_Direccion";
            this.comboBox2.DisplayMember = "DireccionClinica";
            this.comboBox2.DataSource = listaDireClini;
        }

        private void DenegarEscrituraCombos()
        {
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue.ToString() != null)
            {
                int Id_Direccion = int.Parse(comboBox2.SelectedValue.ToString());
                LlenarComboClinicas(Id_Direccion);
            }
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Tbl_Cita ci = new Tbl_Cita();
            RepoCita repo = new RepoCita();
            lblPaciente.Text = cBPacientes.SelectedValue.ToString();
            lblIdDonante.Text = cBDonantes.SelectedValue.ToString();
            lblIdClinica.Text = comboBox1.SelectedValue.ToString();
            ci.Id_Solicitante = int.Parse(lblPaciente.Text);
            ci.Id_Donante = int.Parse(lblIdDonante.Text);
            ci.Id_Clinica = int.Parse(lblIdClinica.Text);
            ci.Fecha = DateTime.Parse(dTPFechaCita.Value.ToLongDateString());
            ci.Hora = txtHora.Text;

            if (MessageBox.Show("Desea registrar la cita", "¡ADVERTENCIA!"
               , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                repo.RegistrarCita(ci);
                MessageBox.Show("Se ha registrado correctamente", "¡EXITOSO!"
                       , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se registro", "¡Advertencia!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
            mmsg.To.Add(txtPara.Text);
            mmsg.Subject = txtAsunto.Text;
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            mmsg.Bcc.Add(txtccc.Text);
            mmsg.Body = txtDescripcion.Text;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = false;
            mmsg.From = new System.Net.Mail.MailAddress("alblood2018@outlook.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("alblood2018@outlook.com", "hola123..");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp-mail.outlook.com";

            try
            {
                cliente.Send(mmsg);
                MessageBox.Show("Se envio correctamente","¡EXITO!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LimpiarCamposCorreo();
            }
            catch(Exception)
            {
                MessageBox.Show("Error al enviar","¡ADVERTENCIA!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void LimpiarCamposCorreo()
        {
            txtPara.Clear();
            txtccc.Clear();
            txtAsunto.Clear();
            txtDescripcion.Clear();
            txtDescripcion.Focus();
        }
    }
}
