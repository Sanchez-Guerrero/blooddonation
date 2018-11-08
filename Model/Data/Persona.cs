using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class Persona
    {
        [Key]
        public int id { get; set; }
        public string nombre  { get; set; }
        public string aPaterno { get; set; }
        public string aMaterno { get; set; }
        public int edad { get; set; }
        public string curp  { get; set; }
        public Int32 telefono  { get; set; }
        public int idTipoSangre { get; set; }
        public int idDireccion { get; set; }
        public int idGenero { get; set; }
        public int idEstadoCivil { get; set; }


    }
}
