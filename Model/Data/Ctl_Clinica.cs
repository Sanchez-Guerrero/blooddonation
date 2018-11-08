using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class Ctl_Clinica
    {
        [Key]
        public int Id_Clinica { get; set; }
        public string NomClinica{ get; set; }
        public string DireccionClinica { get; set; }
    }
}
