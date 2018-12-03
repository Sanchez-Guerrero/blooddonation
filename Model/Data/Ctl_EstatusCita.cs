using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class Ctl_EstatusCita
    {
        [Key]
        public int Id_Estatus { get; set; }
        public string EstatusCita { get; set; }
    }
}
