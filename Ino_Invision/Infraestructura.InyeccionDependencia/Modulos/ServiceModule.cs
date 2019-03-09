using Autofac;
using Servicios.Implementacion.Gestores;
using Servicios.Interfaces.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.InyeccionDependencia
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<GestorDeUsuarios>().As<IGestorDeUsuarios>().InstancePerLifetimeScope();
        }
    }
}
