using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using Base_de_Datos.DB;
using ms_estado.Modelo;
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace ms_estado.Cqrs.Commands
{
    public class PostEstadoHandler : IRequestHandler<PostEstadoQuery, bool>
    {
        private readonly RRHHContext _db;
        private readonly IMapper _mapper;
        public PostEstadoHandler(RRHHContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<bool> Handle(PostEstadoQuery request, CancellationToken cancellationToken)
        {
            try
            {
                TblEstados tblEstado = new TblEstados
                {
                    CodEstado = request.UnEstado.CodEstado,
                    CodTipoGalar = request.UnEstado.CodTipoGalar,
                    DescripcionEstado = request.UnEstado.DescripcionEstado
                };
                await _db.TblEstados.AddAsync(tblEstado);
                await _db.SaveChangesAsync();
                return true;

            }
            catch
            {
                return false;
            }
           
        }
    }
}
          
          


