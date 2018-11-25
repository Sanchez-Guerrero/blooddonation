using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewDataModels
{
    public class Donante_ViewDataModelDonante
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string aPaterno { get; set; }
        public string aMaterno { get; set; }
        public int edad { get; set; }
        public string curp { get; set; }
        public long telefono { get; set; }
        public string Tipo_Sangre { get; set; }
        public string Calle { get; set; }
        public string NumExterior { get; set; }
        public string NumInterior { get; set; }
        public string CodigoPostal { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string Genero { get; set; }
        public string Estado_Civil { get; set; }
        public Boolean ImpDefinitivos { get; set; }
        public Boolean Imp12Meses { get; set; }
        public Boolean ImpMujeres { get; set; }
        public Boolean Imp72Horas { get; set; }
        public string Estatus { get; set; }
    }
}
