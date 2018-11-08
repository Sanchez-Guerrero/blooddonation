using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewDataModels
{
    public class Donante_ViewDataModelDonante
    {
        public int Id_Donante { get; set; }

        public int idPersona { get; set; }
        public string nombre { get; set; }
        public string aPaterno { get; set; }
        public string aMaterno { get; set; }
        public int edad { get; set; }
        public string curp { get; set; }
        public int idEstadoCivil { get; set; }
        public int idTipoPaciente { get; set; }

        public int Id_Test { get; set; }
        public Int32 estatus { get; set; }
        public int idCita { get; set; }
    }
}
