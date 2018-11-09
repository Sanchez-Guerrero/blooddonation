using Model.Data;
using Repo.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Repositorio
{
    public class RepoClinica
    {
        public List<Ctl_Clinica> ConsultarClinica()
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    List<Ctl_Clinica> clinica = db.Database.SqlQuery<Ctl_Clinica>("st_ConsultarClinica").ToList();

                    return clinica;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Ctl_Clinica> ConsultarDireccion()
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    List<Ctl_Clinica> direccion = db.Database.SqlQuery<Ctl_Clinica>("st_ConsultarDireccionClinicas").ToList();

                    return direccion;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
