using B3.Bordas.Adapter;
using B3.Bordas.Repositorio;
using B3.DTO.Ativo.AdicionarAtivo;
using B3.Entities;
using B3.Teste.Builder;
using B3.UseCase;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace B3.Teste.UseCase
{
    public class AdicionarAtivoUseCaseTest
    {
        private readonly Mock<IRepositorioAtivos> _repositorioAtivos;
        private readonly Mock<IAdicionarAtivoAdapter> _adicionarAtivoAdapter;
        private readonly AdicionarAtivoUseCase _usecase;

        public AdicionarAtivoUseCaseTest()
        {
            _repositorioAtivos = new Mock<IRepositorioAtivos>();
            _adicionarAtivoAdapter = new Mock<IAdicionarAtivoAdapter>();
            _usecase = new AdicionarAtivoUseCase(
                _repositorioAtivos.Object, 
                _adicionarAtivoAdapter.Object
                );
        }

        [Fact]
        public void Ativo_AdicionarAtivo_QuandoRetornarSucesso()
        {
            //Arrange
            var request = new AdicionarAtivoRequestBuilder().Build();
            var response = new AdicionarAtivoResponse();
            var ativo = new Ativo();
            var ativoId = 1;
            _repositorioAtivos.Setup(repositorio => repositorio.Add(ativo)).Returns(ativoId);
            _adicionarAtivoAdapter.Setup(adapter => adapter.converterRequestParaAtivo(request)).Returns(ativo);

            //Act
            var result = _usecase.Executar(request);

            //Assert
            response.Should().BeEquivalentTo(result);

        }

        [Fact]
        public void Ativo_AdicionarAtivo_QuantoEmpresaMenorVinte()
        {
            //Arrange
            var request = new AdicionarAtivoRequestBuilder().withEmpresaLength(10).Build();
            var respose = new AdicionarAtivoResponse();
         
            respose.msg = "Erro ao adicionar o Ativo";

            //Act
            var result = _usecase.Executar(request);

            //Assert
            respose.Should().BeEquivalentTo(result);
        }

        [Fact]
        public void Ativo_AdicionarAtivo_QuantoRepositorioExcecao()
        {
            //Arrange
            var request = new AdicionarAtivoRequestBuilder().Build();
            var respose = new AdicionarAtivoResponse();
            var ativo = new Ativo();
            ativo.id = 1;
            respose.msg = "Erro ao adicionar o produto";
            _adicionarAtivoAdapter.Setup(adapter => adapter.converterRequestParaAtivo(request)).Returns(ativo);
            _repositorioAtivos.Setup(repositorio => repositorio.Add(ativo)).Throws(new Exception());

            //Act
            var result = _usecase.Executar(request);

            //Assert
            respose.Should().BeEquivalentTo(result);
        }

    }
}
