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

 
      public bool LogearUsuario(string Usuario)
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

        public string ObtenerEncriptacion(string Usuario)
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    var obPass = db.Database.SqlQuery<string>("st_ObtenerEncriptacion @Usuario",
                        new SqlParameter("@Usuario", Usuario)).FirstOrDefault();
                    return obPass;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}

