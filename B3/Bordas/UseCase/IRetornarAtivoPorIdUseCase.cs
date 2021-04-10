using B3.DTO.Ativo.RetornarAtivoPorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.UseCase
{
    public interface IRetornarAtivoPorIdUseCase
    {
        RetornarAtivoPorIdResponse Executar(RetornarAtivoPorIdRequest request);
    }
}
