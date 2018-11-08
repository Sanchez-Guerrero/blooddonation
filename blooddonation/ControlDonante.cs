﻿using System;
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
    public partial class ControlDonante : Form
    {
        public ControlDonante()
        {
            InitializeComponent();
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
            txtBuscar.Dispose();
            dGVConsulta.Dispose();
            rSTabla.Dispose();
        }
        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new RegistrarDonante());
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new UpdateDonante());
        }
    }
}