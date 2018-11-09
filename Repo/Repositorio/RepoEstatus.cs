using Model.Data;
using Repo.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Repositorio
{
    public class RepoEstatus
    {
        public List<Ctl_Estatus> CargarEstatus()
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    List<Ctl_Estatus> estatus = db.Database.SqlQuery<Ctl_Estatus>("st_ConsultarEstatus").ToList();

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
