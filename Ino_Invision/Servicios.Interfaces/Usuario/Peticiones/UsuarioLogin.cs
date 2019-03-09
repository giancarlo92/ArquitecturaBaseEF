using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servicios.Interfaces.Usuario.Peticiones
{
    [Table("INO_Usuarios")]
    public class UsuarioLogin
    {
        [Key]
        public int idUsuario { get; set; }
        public string usuario { get; set; }
        public string nombres { get; set; }
        public string apepat { get; set; }
        public int? idrol { get; set; }
        public string rol { get; set; }
        public int estado { get; set; }
    }
}
