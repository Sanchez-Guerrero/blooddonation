using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewDataModels
{
    public class CitasTotales_ViewDataModelDonante
    {
        public int Id_Cita { get; set; }
        public int Id_Solicitante { get; set; }
        public int Id_Donante { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string NomClinica { get; set; }
        public string DireccionClinica { get; set; }
        public string EstatusCita { get; set; }
    }
}
