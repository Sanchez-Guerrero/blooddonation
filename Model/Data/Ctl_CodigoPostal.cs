
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class Ctl_CodigoPostal
    {
        [Key]
        public int Id_CP { get; set; }
        public string CodigoPostal { get; set; }
    }
}
