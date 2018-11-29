using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Data;
using Repo.Repositorio;
using Repo.Encriptacion;

namespace blooddonation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "PASSWORD")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "PASSWORD";
                txtPassword.ForeColor = Color.White;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tbl_Login lo = new Tbl_Login();
            RepoLogin repo = new RepoLogin();
            EncriptacionPassword ecp = new EncriptacionPassword();
            lo.Usuario = txtUsuario.Text;
            lo.Contrasenia = txtPassword.Text;
            if(repo.LogearUsuario(lo.Usuario))
            {
                var password = ecp.DesencriptarPassword(repo.ObtenerEncriptacion(lo.Usuario));
                if (password == lo.Contrasenia)
                {
                    var Id_Perfil = repo.ObtenerPerfil(lo.Usuario);
                    if (Id_Perfil > 0)
                    {
                        if(Id_Perfil == 1)
                        {
                            MessageBox.Show("Bienvenido administrador: " + lo.Usuario, "¡BIENVENIDO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            ControlPrincipal cp = new ControlPrincipal(lo.Usuario);
                            cp.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos!", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
