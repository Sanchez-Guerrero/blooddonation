using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    class Tbl_TestDonarSangre
    {
        [Key]
        public int Id_Test { get; set; }
        public Int32 ImpDefinitivos { get; set; }
        public Int32 Imp12Meses { get; set; }
        public Int32 ImpMujeres { get; set; }
        public Int32 Imp72Horas { get; set; }
        public Int32 Id_Estatus{ get; set; }

    }
}
