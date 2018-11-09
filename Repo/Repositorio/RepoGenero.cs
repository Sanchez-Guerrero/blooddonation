using Model.Data;
using Repo.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Repositorio
{
    public class RepoGenero
    {
        public List<Ctl_Genero> CargarGenero()
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    List<Ctl_Genero> genero = db.Database.SqlQuery<Ctl_Genero>("st_ConsultarGenero").ToList();

                    return genero;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
