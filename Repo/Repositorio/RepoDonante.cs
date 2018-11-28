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
    public class RepoDonante
    {
        public void RegistrarDonante(Tbl_Persona pers)
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["AllBloodContext"].ConnectionString;
                AllBloodContext db = new AllBloodContext();
                string sqlComand = @"st_RegistrarDonante";
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand(sqlComand, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", pers.nombre);
                cmd.Parameters.AddWithValue("@APaterno", pers.aPaterno);
                cmd.Parameters.AddWithValue("@AMaterno", pers.aMaterno);
                cmd.Parameters.AddWithValue("@edad", pers.edad);
                cmd.Parameters.AddWithValue("@curp", pers.curp);
                cmd.Parameters.AddWithValue("@telefono", pers.telefono);
                cmd.Parameters.AddWithValue("@idTiposangre ", pers.idTipoSangre);
                cmd.Parameters.AddWithValue("@calle", pers.Calle);
                cmd.Parameters.AddWithValue("@NumExterior", pers.NumExterior);
                cmd.Parameters.AddWithValue("@NumInterior", pers.NumInterior);
                cmd.Parameters.AddWithValue("@idGenero",pers.idGenero);
                cmd.Parameters.AddWithValue("@idEstadoCivil", pers.idEstadoCivil);
                cmd.Parameters.AddWithValue("@idTipoPaciente", pers.idTipoPaciente);
                cmd.Parameters.AddWithValue("@idCita", pers.idCita);
                cmd.Parameters.AddWithValue("@Id_CodigoPostal", pers.Id_CodigoPostal);
                cmd.Parameters.AddWithValue("@ImpDefinitivos", pers.ImpDefinitivos);
                cmd.Parameters.AddWithValue("@Imp12Meses", pers.Imp12Meses);
                cmd.Parameters.AddWithValue("@ImpMujeres", pers.ImpMujeres);
                cmd.Parameters.AddWithValue("@Imp72Horas", pers.Imp72Horas);
                cmd.Parameters.AddWithValue("@Id_Estatus", pers.Id_Estatus);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public void ModificarDonante(Tbl_Persona per)
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["AllBloodContext"].ConnectionString;
                AllBloodContext db = new AllBloodContext();
                string sqlComand = @"st_ModificarDonante";
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand(sqlComand, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", per.id);
                cmd.Parameters.AddWithValue("@nombre", per.nombre);
                cmd.Parameters.AddWithValue("@aPaterno ", per.aPaterno);
                cmd.Parameters.AddWithValue("@aMaterno ", per.aMaterno);
                cmd.Parameters.AddWithValue("@edad", per.edad);
                cmd.Parameters.AddWithValue("@curp", per.curp);
                cmd.Parameters.AddWithValue("@telefono", per.telefono);
                cmd.Parameters.AddWithValue("@idTipoSangre", per.idTipoSangre);
                cmd.Parameters.AddWithValue("@idDireccion", per.idDireccion);
                cmd.Parameters.AddWithValue("@idGenero", per.idGenero);
                cmd.Parameters.AddWithValue("@idEstadoCivil", per.idEstadoCivil);
                cmd.Parameters.AddWithValue("@calle", per.Calle);
                cmd.Parameters.AddWithValue("@NumExterior",per.NumExterior);
                cmd.Parameters.AddWithValue("@NumInterior",per.NumInterior);
                cmd.Parameters.AddWithValue("@Id_CodigoPostal",per.Id_CodigoPostal);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public List<Donante_ViewDataModelDonante> ConsultarPorCurp(Tbl_Persona per)
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    var donantes = db.Database.SqlQuery<Donante_ViewDataModelDonante>("st_ConsultarPorCurp @curp",
                        new SqlParameter("@curp", per.curp)).ToList();
                    return donantes;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Donante_ViewDataModelDonante> ConsultarDonantes()
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    var donantes = db.Database.SqlQuery<Donante_ViewDataModelDonante>("st_ConsultarDonantes").ToList();
                    return donantes;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
