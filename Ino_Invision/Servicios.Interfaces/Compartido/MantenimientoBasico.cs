using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Compartido
{
    public interface IMantenimientoBasico <TClaseDeCreacion, TClaseDeActualizacion, TClaseRespuestaGeneral>
    {
        TClaseRespuestaGeneral Crear(TClaseDeCreacion peticionDeCreacion);
        List<TClaseRespuestaGeneral> Listar();
        TClaseRespuestaGeneral Actualizar (TClaseDeActualizacion peticionDeActualizacion);
        void Borrar(int Id);

    }
}
