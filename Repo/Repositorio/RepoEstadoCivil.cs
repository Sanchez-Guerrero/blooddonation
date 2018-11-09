using Model.Data;
using Repo.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Repositorio
{
    public class RepoEstadoCivil
    {
        public List<Ctl_EstadoCivil> CargarEstadoCivil()
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    List<Ctl_EstadoCivil> esCivil = db.Database.SqlQuery<Ctl_EstadoCivil>("st_ConsultarEstadoCivil").ToList();

                    return esCivil;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
