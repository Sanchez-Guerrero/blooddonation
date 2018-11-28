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
    public class RepoCita
    {
        public void RegistrarCita(Tbl_Cita ci)
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["AllBloodContext"].ConnectionString;
                AllBloodContext db = new AllBloodContext();
                string sqlComand = @"st_RegistrarCita";
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand(sqlComand, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Solicitante", ci.Id_Solicitante);
                cmd.Parameters.AddWithValue("@Id_Donante", ci.Id_Donante);
                cmd.Parameters.AddWithValue("@Fecha", ci.Fecha);
                cmd.Parameters.AddWithValue("@Hora", ci.Hora);
                cmd.Parameters.AddWithValue("@Id_Clinica", ci.Id_Clinica);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public void ModificarCita(Tbl_Cita ci)
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["AllBloodContext"].ConnectionString;
                AllBloodContext db = new AllBloodContext();
                string sqlComand = @"st_ModificarCita";
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand(sqlComand, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Cita", ci.Id_Cita);
                cmd.Parameters.AddWithValue("@Id_Donante", ci.Id_Donante);
                cmd.Parameters.AddWithValue("@Id_Solicitante", ci.Id_Solicitante);
                cmd.Parameters.AddWithValue("@Fecha", ci.Fecha);
                cmd.Parameters.AddWithValue("@Hora", ci.Hora);
                cmd.Parameters.AddWithValue("@Id_Clinica", ci.Id_Clinica);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public void EliminarCita(Tbl_Cita ci)
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["AllBloodContext"].ConnectionString;
                AllBloodContext db = new AllBloodContext();
                string sqlComand = @"st_EliminarCita";
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand(sqlComand, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Cita", ci.Id_Cita);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return;
            }
        }

        public List<Citas_ViewDataModelDonante> ConsultarCitas()
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    var citas = db.Database.SqlQuery<Citas_ViewDataModelDonante>("st_ConsultarCitas").ToList();
                    return citas;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        }
}
