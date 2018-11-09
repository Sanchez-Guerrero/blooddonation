using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model.Data
{
   public class Ctl_Colonia
    {
        [Key]
        public int Id_Colonia { get; set; }
        public string Descripcion { get; set; }
    }
}
