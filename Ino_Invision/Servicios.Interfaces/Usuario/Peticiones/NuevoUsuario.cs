using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Usuario.Peticiones
{
    public class NuevoUsuario
    {
        public string usuario { get; set; }
        public string clave { get; set; }
        public string nombres { get; set; }
        public string apepat { get; set; }
        public string apemat { get; set; }
        public int idrol { get; set; }
        public int estado { get; set; }
    }
}
