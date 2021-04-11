using B3.DTO.Ativo.AdicionarAtivo;
using B3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.Bordas.Adapter
{
   public interface IAdicionarAtivoAdapter
    {
        public Ativo converterRequestParaAtivo(AdicionarAtivoRequest request);
    }
}
