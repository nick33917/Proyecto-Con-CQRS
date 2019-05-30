﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ms_estado.Modelo;
using ms_estado.Negocio;
namespace ms_estado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        public readonly INegocioEstado _negocioEstado;
        public EstadoController(INegocioEstado negocioEstado)
        {
            _negocioEstado = negocioEstado;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<List<Estado>>> Get()
        {
            // return _negocioEstado.GetEstados();
            return await _negocioEstado.GetEstados();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Estado>> Get(int id)
        {
            return await _negocioEstado.GetEstado(id);
        }

        // POST api/values
        [HttpPost]
        public async Task<bool> Post([FromBody] Estado estado)
        {
            bool x = await _negocioEstado.CrearEstado(estado);
            return x;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
