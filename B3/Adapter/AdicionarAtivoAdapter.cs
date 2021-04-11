using B3.Bordas.Adapter;
using B3.DTO.Ativo.AdicionarAtivo;
using B3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.Adapter
{
    public class AdicionarAtivoAdapter : IAdicionarAtivoAdapter
    {
        public Ativo converterRequestParaAtivo(AdicionarAtivoRequest request)
        {
            var novoAtivo = new Ativo();
            novoAtivo.empresa = request.empresa;
            novoAtivo.codigoB3 = request.codigoB3;
            novoAtivo.valor = request.valor;
            return novoAtivo;
        }
    }
}
