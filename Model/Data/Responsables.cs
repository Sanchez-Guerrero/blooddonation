﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class Responsables
    {
        [Key]
        public int id { get; set; }
        public string idPersona{ get; set; }
    }
}
