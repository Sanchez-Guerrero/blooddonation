using Model.Data;
using Repo.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Repositorio
{
    public class RepoPerfil
    {
        public List<Ctl_Perfil> CargarPerfil()
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    List<Ctl_Perfil> perfil = db.Database.SqlQuery<Ctl_Perfil>("st_ConsultarPerfil").ToList();

                    return perfil;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
