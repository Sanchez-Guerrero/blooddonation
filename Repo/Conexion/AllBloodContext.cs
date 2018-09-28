using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Conexion
{
    public partial class AllBloodContext : DbContext
    {
        //Esto sirve para obtener la conexion a DataBase del ConnectionString
        public AllBloodContext()
            :base("AllBloodContext")
        {

        }
    }
}
