using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class Tbl_Persona
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
        public int idTipoPaciente { get; set; }
        public int idTest { get; set; }
        public int idCita { get; set; }
        public string Calle { get; set; }
        public string NumExterior { get; set; }
        public string NumInterior { get; set; }
        public int Id_Estado { get; set; }
    }
}
