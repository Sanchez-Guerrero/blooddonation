using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class Tbl_Donante
    {
        [Key]
        public int Id_Donante { get; set; }
        public int idPersona { get; set; }
        public int Id_Test { get; set; }
        //modificar el tipo de estatus
        public Int32 estatus { get; set; }
        public int idCita { get; set; }

    }
}
