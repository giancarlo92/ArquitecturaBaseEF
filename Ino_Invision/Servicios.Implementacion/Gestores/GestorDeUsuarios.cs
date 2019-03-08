using Servicios.Interfaces.Usuario;
using Servicios.Interfaces.Usuario.Peticiones;
using Servicios.Interfaces.Usuario.Respuestas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dominio.Contexto;
using System.Linq;

namespace Servicios.Implementacion.Gestores
{
    public class GestorDeUsuarios : IGestorDeUsuarios
    {
        public UsuarioGeneral Actualizar(ActualizarUsuario peticionDeActualizacion)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int Id)
        {
            throw new NotImplementedException();
        }

        public UsuarioGeneral Crear(NuevoUsuario peticionDeCreacion)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioGeneral> Listar()
        {
            throw new NotImplementedException();
        }

        public UsuarioLogin Login(string username, string password)
        {
            using (InoBD db = new InoBD())
            {
                var otros = db.Usuarios.ToList();
                var usuarios = db.Database.SqlQuery<UsuarioLogin>("dbo.INO_LogueoWeb @Usuario, @Clave",
                        new SqlParameter("Usuario", username),
                        new SqlParameter("Clave", password)).FirstOrDefault();

                return usuarios;
            }

        }
    }
}
