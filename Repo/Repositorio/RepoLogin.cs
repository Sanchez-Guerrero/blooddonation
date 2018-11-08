using Repo.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Model.Data;

namespace Repo.Repositorio
{
    public class RepoLogin
    {
        //Aqui se realiza el stored procedure para el logueo

 
      public bool logear(string Usuario)
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    int IdPerfil = db.Database.SqlQuery<int>("st_logueoPorPerfil @Usuario",
                        new SqlParameter("@Usuario", Usuario)).SingleOrDefault();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public int ObtenerPerfil(string Usuario)
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    int IdPerfil = db.Database.SqlQuery<int>("st_ObtenerPerfil @Usuario",
                        new SqlParameter("@Usuario", Usuario)).SingleOrDefault();
                    return IdPerfil;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public bool ObtenerPassword(string Password)
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    bool IdPerfil = db.Database.SqlQuery<bool>("st_ObtenerPassword @Password",
                        new SqlParameter("@Password", Password)).SingleOrDefault();
                    return IdPerfil;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        } 
       
    }
}

