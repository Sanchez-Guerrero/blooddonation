using Repo.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Repositorio
{
    public class RepoCurp
    {
        public string ConsultarsiExistelaPersona(string curp)
        {
            try
            {
                using (AllBloodContext db = new AllBloodContext())
                {
                    string persona = db.Database.SqlQuery<string>("st_ConsultarsiExistelaPersona @curp",
                        new SqlParameter("@curp", curp)).FirstOrDefault();
                    return persona;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
