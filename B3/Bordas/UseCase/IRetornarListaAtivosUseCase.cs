using B3.DTO.Ativo.RetornarListaAtivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.UseCase
{
    public interface IRetornarListaAtivosUseCase
    {
        RetornarListaAtivosResponse Executar(RetornarListaAtivosRequest request);
    }
}
