using B3.DTO.Ativo.AtualizarAtivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.UseCase
{
    public interface IAtualizarAtivoUseCase
    {
        AtualizarAtivoResponse Executar(AtualizarAtivoRequest request);
    }
}
