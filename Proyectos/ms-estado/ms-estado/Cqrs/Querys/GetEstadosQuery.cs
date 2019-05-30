using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using ms_estado.Modelo;

namespace ms_estado.Cqrs.Querys
{
    public class GetEstadosQuery : IRequest<List<Estado>>
    {
    }
}
