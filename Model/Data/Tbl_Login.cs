using System.ComponentModel.DataAnnotations;

namespace Model.Data
{
    public class Tbl_Login
    {
        [Key]
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }
        public int IdPerfil { get; set; }
    }
}
