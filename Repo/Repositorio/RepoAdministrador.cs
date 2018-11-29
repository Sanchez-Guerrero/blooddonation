using Model.Data;
using Model.ViewDataModels;
using Repo.Conexion;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Repositorio
{
    public class RepoAdministrador
    {
        public void RegistrarCuenta(Tbl_Administrador ad)
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["AllBloodContext"].ConnectionString;
                AllBloodContext db = new AllBloodContext();
                string sqlComand = @"st_RegistrarAdministrador";
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand(sqlComand, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombres", ad.Nombres);
                cmd.Parameters.AddWithValue("@APaterno", ad.APaterno);
                cmd.Parameters.AddWithValue("@AMaterno", ad.AMaterno);
                cmd.Parameters.AddWithValue("@Telefono", ad.Telefono);
                cmd.Parameters.AddWithValue("@Id_Genero", ad.Id_Genero);
                cmd.Parameters.AddWithValue("@Id_EstadoCivil", ad.Id_EstadoCivil);
                cmd.Parameters.AddWithValue("@Usuario", ad.Usuario);
                cmd.Parameters.AddWithValue("@Contrasenia", ad.Contrasenia);
                cmd.Parameters.AddWithValue("@Id_Perfil", ad.Id_Perfil);
                cmd.Parameters.AddWithValue("@Calle", ad.Calle);
                cmd.Parameters.AddWithValue("@NumExterior", ad.NumExterior);
                cmd.Parameters.AddWithValue("@NumInterior", ad.NumInterior);
                cmd.Parameters.AddWithValue("@Id_CodigoPostal", ad.Id_CodigoPostal);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public void ModificarCuenta(Tbl_Administrador ad)
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["AllBloodContext"].ConnectionString;
                AllBloodContext db = new AllBloodContext();
                string sqlComand = @"st_ModificarAdministrador";
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand(sqlComand, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Admin", ad.Id_Admin);
                cmd.Parameters.AddWithValue("@Nombres", ad.Nombres);
                cmd.Parameters.AddWithValue("@APaterno", ad.APaterno);
                cmd.Parameters.AddWithValue("@AMaterno", ad.AMaterno);
                cmd.Parameters.AddWithValue("@Telefono", ad.Telefono);
                cmd.Parameters.AddWithValue("@Id_Login", ad.Id_Login);
                cmd.Parameters.AddWithValue("@Id_Direccion", ad.Id_Direccion);
                cmd.Parameters.AddWithValue("@Id_Genero", ad.Id_Genero);
                cmd.Parameters.AddWithValue("@Id_EstadoCivil", ad.Id_EstadoCivil);
                cmd.Parameters.AddWithValue("@Usuario", ad.Usuario);
                cmd.Parameters.AddWithValue("@Contrasenia", ad.Contrasenia);
                cmd.Parameters.AddWithValue("@Calle", ad.Calle);
                cmd.Parameters.AddWithValue("@NumExterior", ad.NumExterior);
                cmd.Parameters.AddWithValue("@NumInterior", ad.NumInterior);
                cmd.Parameters.AddWithValue("@Id_CodigoPostal", ad.Id_CodigoPostal);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public List<Administradores_ViewDataModelDonante> ConsultarAdministradores()
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    var admin = db.Database.SqlQuery<Administradores_ViewDataModelDonante>("st_ConsultarAdministradores").ToList();
                    return admin;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
