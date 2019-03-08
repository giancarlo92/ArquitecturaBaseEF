using Presentacion.Web.Models;
using Servicios.Implementacion.Gestores;
using Servicios.Interfaces.Usuario;
using Servicios.Interfaces.Usuario.Peticiones;
using System.Web.Http;

namespace Presentacion.Web.Controllers.Api
{
    public class UsuariosController : ApiController
    {
        IGestorDeUsuarios _gestorDeUsuarios = new GestorDeUsuarios();

        [HttpPost]
        public UsuarioLogin Login(UsuarioLoginModel usuarioLogin)
        {
            string usuario = usuarioLogin.usuario;
            string clave = usuarioLogin.clave;
            return _gestorDeUsuarios.Login(usuario, clave);
        }
    }
}
