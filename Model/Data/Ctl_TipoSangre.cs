using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class Ctl_TipoSangre
    {
        [Key]
        public int Id_TipoSangre { get; set; }
        public string Tipo_Sangre { get; set; }
    }
}
