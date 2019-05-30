using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ms_estado.Modelo;

namespace ms_estado.Negocio
{
    public interface INegocioEstado
    {
        Task<List<Estado>> GetEstados();
        Task<Estado> GetEstado(int codEstado);
        Task<bool> CrearEstado(Estado estado);
        void BorrarEstado(int codEstado);
        void ModificarEstado(int codEstado, Estado estado);
    }
}
