using B3.Bordas.Adapter;
using B3.Bordas.Repositorio;
using B3.DTO.Ativo.AdicionarAtivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.UseCase
{
    public class AdicionarAtivoUseCase : IAdicionarAtivoUseCase
    {

        private readonly IRepositorioAtivos _repositorioAtivos;
        private readonly IAdicionarAtivoAdapter _adapter;

        public AdicionarAtivoUseCase(IRepositorioAtivos repositorioAtivos, IAdicionarAtivoAdapter adapter)
        {
            _repositorioAtivos = repositorioAtivos;
            _adapter = adapter;
        }

        public AdicionarAtivoResponse Executar(AdicionarAtivoRequest request)
        {
            var response = new AdicionarAtivoResponse();

            try
            {
                if (request.empresa.Length > 25)
                {
                    response.msg = "Erro ao adicionar o Ativo nome da empresa tem que ser menor que 25 caracteres";
                    return response;
                }

                var ativoAdicionar = _adapter.converterRequestParaAtivo(request);
                var id = _repositorioAtivos.Add(ativoAdicionar);
                response.id = ativoAdicionar.id;
                return response;
            }
            catch
            {
                response.msg = "Erro ao adicionar o Ativo";
                return response;
            }

        }
    }
}
