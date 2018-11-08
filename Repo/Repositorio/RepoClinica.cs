using Model.Data;
using Repo.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Repositorio
{
    public class RepoClinica
    {
        public List<Ctl_Clinica> ObtenerClinica()
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
    }
}
