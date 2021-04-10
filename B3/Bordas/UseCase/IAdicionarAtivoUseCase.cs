using B3.DTO.Ativo.AdicionarAtivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.UseCase
{
    public interface IAdicionarAtivoUseCase
    {
        AdicionarAtivoResponse Executar(AdicionarAtivoRequest request);
    }
}
