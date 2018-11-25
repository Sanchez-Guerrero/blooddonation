using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class Ctl_Estados
    {
        [Key]
        public int Id_Estado { get; set; }
        public string Estado { get; set; }

    }
}
