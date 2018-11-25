using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class Ctl_EstadoCivil
    {
        [Key]
        public int Id_EstadoCivil { get; set; }
        public string Estado_Civil { get; set; }
    }
}
