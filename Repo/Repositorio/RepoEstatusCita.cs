using Model.Data;
using Repo.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Repositorio
{
    public class RepoEstatusCita
    {
        public List<Ctl_EstatusCita> CargarEstatusCita()
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    List<Ctl_EstatusCita> estatus = db.Database.SqlQuery<Ctl_EstatusCita>("st_ConsultaEstatusCita").ToList();

                    return estatus;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
