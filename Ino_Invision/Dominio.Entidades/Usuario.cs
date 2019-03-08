using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    [Table("INO_Usuarios")]
    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public string nombres { get; set; }
        public string apepat { get; set; }
        public string apemat { get; set; }
        public int estado { get; set; }
    }
}
