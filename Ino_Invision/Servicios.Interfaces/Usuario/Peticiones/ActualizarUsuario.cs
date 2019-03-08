using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Usuario.Peticiones
{
    public class ActualizarUsuario
    {
        public int idUsuario { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public int estado { get; set; }
    }
}
