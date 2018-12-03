using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewDataModels
{
    public class Administradores_ViewDataModelDonante
    {
        [Key]
        public int Id_Admin { get; set; }
        public string Nombres { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public long Telefono { get; set; }
        public string Estado_Civil { get; set; }
        public string Genero { get; set; }
        public int Id_Direccion { get; set; }
        public string Calle { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Colonia { get; set; }
        public string NumExterior { get; set; }
        public string NumInterior { get; set; }
        public string CodigoPostal { get; set; }
        public int Id_Login { get; set; }
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }
    }
}
