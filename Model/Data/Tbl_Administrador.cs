﻿using System;
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
        public string Nombres { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public long Telefono { get; set; }
        public int Id_Login { get; set; }
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }
        public int Id_Perfil { get; set; }
        public int Id_Direccion { get; set; }
        public string Calle { get; set; }
        public string NumExterior { get; set; }
        public string NumInterior { get; set; }
        public int Id_CodigoPostal { get; set; }
        public int Id_Genero { get; set; }
        public int Id_EstadoCivil { get; set; }
    }
}
