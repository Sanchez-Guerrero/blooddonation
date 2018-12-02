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

        public int ConsultarIdEstadoCivil(string lblEstadoCivil)
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    int estadoCivil = db.Database.SqlQuery<int>("st_ConsultarIdEstadoCivil @Estado_Civil",
                        new SqlParameter("@Estado_Civil", lblEstadoCivil)).FirstOrDefault();
                    return estadoCivil;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
