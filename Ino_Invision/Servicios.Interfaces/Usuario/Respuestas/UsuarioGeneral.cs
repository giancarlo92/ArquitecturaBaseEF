using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Servicios.Interfaces.Usuario.Respuestas
{
    public class UsuarioGeneral
    {
        [Key]
        public int idUsuario { get; set; }
        public string usuario { get; set; }
        public string nombres { get; set; }
        public string apepat { get; set; }
        public int idrol { get; set; }
        public string rol { get; set; }
        public int estado { get; set; }
    }
}
