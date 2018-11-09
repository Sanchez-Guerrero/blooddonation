using Model.Data;
using Repo.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Repositorio
{
    public class RepoTipoSangre
    {
        public List<Ctl_TipoSangre> CargarTipoSangre()
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    List<Ctl_TipoSangre> tipSangre = db.Database.SqlQuery<Ctl_TipoSangre>("st_ConsultarTipoSangre").ToList();

                    return tipSangre;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
