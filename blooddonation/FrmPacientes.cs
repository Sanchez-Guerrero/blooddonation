﻿using Model.Data;
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
    public partial class FrmPacientes : Form
    {
        public FrmPacientes()
        {
            InitializeComponent();
            dGVConsulta.AutoGenerateColumns = false;
            LlenardGriedViewPacientes();
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.pnContenedorPacientes.Controls.Count > 0)
                this.pnContenedorPacientes.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnContenedorPacientes.Controls.Add(fh);
            this.pnContenedorPacientes.Tag = fh;
            fh.Show();
            lbPacientes.Dispose();
            pnEncabezadoPacientes.Dispose();
            btnNuevoPaciente.Dispose();
            btnModificarUsuario.Dispose();
            btnBuscar.Dispose();
            dGVConsulta.Dispose();
            txtBuscar.Dispose();
            rSTabla.Dispose();
        }

        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmRegistrarPaciente());
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new TestParaDonar());
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new UpdatePaciente());
        }

        private void LlenardGriedViewPacientes()
        {
            RepoPacientes repo = new RepoPacientes();
            dGVConsulta.DataSource = repo.ConsultarPacientesTotales();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Tbl_Persona per = new Tbl_Persona();
            per.curp = txtBuscar.Text;
            RepoPacientes repo = new RepoPacientes();
            dGVConsulta.DataSource = repo.ConsultarPorCurp(per);
        }
    }
}
