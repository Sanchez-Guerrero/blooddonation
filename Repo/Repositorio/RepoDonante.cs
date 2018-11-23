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
    }
}
