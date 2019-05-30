using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using ms_estado.Modelo;
using Base_de_Datos.DB;
using Microsoft.EntityFrameworkCore;

namespace ms_estado.Cqrs.Querys
{
    public class GetEstadosHandler : IRequestHandler<GetEstadosQuery, List<Estado>>
    {
        public readonly RRHHContext _db;
        public readonly IMapper _mapper;
        public GetEstadosHandler(RRHHContext db , IMapper mapper)
        {
            _db = db;
            _mapper = mapper;

        }
        public async Task<List<Estado>> Handle(GetEstadosQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<Estado>>(await _db.TblEstados.ToListAsync());
        }

       
    }
}
