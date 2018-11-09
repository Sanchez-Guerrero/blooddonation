using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class Ctl_Municipio
    {
        [Key]
        public int Id_Municipio { get; set; }
        public string Descripcion { get; set; }
    }
}
