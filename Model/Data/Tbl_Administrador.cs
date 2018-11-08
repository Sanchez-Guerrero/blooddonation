using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class Tbl_Administrador
    {
        [Key]
        public int Id_Admin { get; set; }
        public string Nombre { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public Int32 Telefono { get; set; }
        public int Id_Login { get; set; }
        public int Id_Direccion { get; set; }
        public int id_Genero { get; set; }
        public int id_EstadoCivil { get; set; }
    }
}
