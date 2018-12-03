using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class Tbl_Cita
    {
        [Key]
        public int Id_Cita { get; set; }
        public int Id_Solicitante { get; set; }
        public int Id_Donante { get; set; }
        public DateTime Fecha  { get; set; }
        public string Hora { get; set; }
        public int Id_Direccion { get; set; }
        public int Id_Estatus { get; set; }
    }
}
