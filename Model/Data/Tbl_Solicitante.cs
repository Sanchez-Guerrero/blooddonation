using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model.Data
{
    public class Tbl_Solicitante
    {
        [Key]
        public int Id_Solicitante { get; set; }
        public int idPersona { get; set; }
        public int benficiario{ get; set; }
        public int idResponsable { get; set; }
        //modificar el tipo de estatus
        public Int32 estatus { get; set; }
     
    }
}
