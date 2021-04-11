using B3.Entities;
using B3.Services;
using B3.DTO.Ativo.AdicionarAtivo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B3.UseCase;

namespace B3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AtivoController : ControllerBase
    {

        private readonly ILogger<AtivoController> _logger;
        private readonly IAtivoService _ativo;
        private readonly IAdicionarAtivoUseCase _adicionarAtivoUseCase;
        private readonly IRemoverAtivoUseCase _removerAtivoUseCase;


        public AtivoController(
            ILogger<AtivoController> logger, 
            IAtivoService ativo,
            IAdicionarAtivoUseCase adicionarAtivoUseCase,
            IRemoverAtivoUseCase removerAtivoUseCase)
        {
            _logger = logger;
            _ativo = ativo;
            _adicionarAtivoUseCase = adicionarAtivoUseCase;
            _removerAtivoUseCase = removerAtivoUseCase;
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
        public IActionResult ativoAdd([FromBody] AdicionarAtivoRequest novoAtivo)
        {
            return Ok(_adicionarAtivoUseCase.Executar(novoAtivo));
        }

        [HttpPut]
        public IActionResult ativoUpdate([FromBody] Ativo novoAtivo)
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
