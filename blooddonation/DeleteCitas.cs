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
    public partial class DeleteCitas : Form
    {
        public DeleteCitas()
        {
            InitializeComponent();
            LlenardGriedViewCitas();
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
                    lblidCita.Text = row.Cells[0].Value.ToString();
                    
                }
            }
        }

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {
            Tbl_Cita ci = new Tbl_Cita();
            RepoCita repo = new RepoCita();
            ci.Id_Cita = int.Parse(lblidCita.Text);
            if (MessageBox.Show("Desea eliminar la cita", "¡ADVERTENCIA!"
               , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                repo.EliminarCita(ci);
                dGVConsulta.DataSource = repo.ConsultarCitas();
                MessageBox.Show("Se ha eliminado correctamente", "¡EXITOSO!"
                       , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se elimino", "¡Advertencia!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
    }
}
