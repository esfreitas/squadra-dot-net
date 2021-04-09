using B3.Entities;
using B3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AtivoController : ControllerBase
    {

        private readonly ILogger<AtivoController> _logger;
        private readonly IAtivoService _ativo;
        public AtivoController(ILogger<AtivoController> logger, IAtivoService ativo)
        {
            _logger = logger;
            _ativo = ativo;
        }

        [HttpGet]
        public IActionResult TodosAtivos()
        {
            return Ok(_ativo.RetonarListaAtivo());
        }

        [HttpGet("{id}")]
        public IActionResult ativo(int id)
        {
            return Ok(_ativo.RetornarAtivoPorId(id));
        }

        [HttpPost]
        public IActionResult ativoAdd([FromBody] Ativo novoAtivo)
        {
            return Ok(_ativo.AdicionarAtivo(novoAtivo));
        }

        [HttpPut]
        public IActionResult produtoUpdate([FromBody] Ativo novoAtivo)
        {
            return Ok(_ativo.AtualizarAtivo(novoAtivo));
        }


        [HttpDelete("{id}")]
        public IActionResult ativooDelete(int id)
        {
            return Ok(_ativo.DeletarAtivo(id));
        }
    }
}
