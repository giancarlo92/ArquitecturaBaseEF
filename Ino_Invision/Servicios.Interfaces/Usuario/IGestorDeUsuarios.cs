using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.Usuario.Peticiones;
using Servicios.Interfaces.Usuario.Respuestas;

namespace Servicios.Interfaces.Usuario
{
    public interface IGestorDeUsuarios : IMantenimientoBasico<NuevoUsuario, ActualizarUsuario, UsuarioGeneral>
    {
        UsuarioLogin Login(string username, string password);
    }
}
