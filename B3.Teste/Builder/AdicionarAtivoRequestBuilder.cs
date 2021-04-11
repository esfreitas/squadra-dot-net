using B3.DTO.Ativo.AdicionarAtivo;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3.Teste.Builder
{
    public class AdicionarAtivoRequestBuilder
    {
        private readonly Faker _faker = new Faker("pt_BR");
        private readonly AdicionarAtivoRequest _adicionarAtivo;

        public AdicionarAtivoRequestBuilder()
        {
            _adicionarAtivo = new AdicionarAtivoRequest();
            _adicionarAtivo.empresa = _faker.Random.String(40);
            _adicionarAtivo.codigoB3 = _faker.Random.String(40);
        }

        public AdicionarAtivoRequestBuilder withEmpresaLength(int tamanho)
        {
            _adicionarAtivo.empresa = _faker.Random.String(tamanho);
            return this;
        }


        public AdicionarAtivoRequest Build()
        {
            return _adicionarAtivo;
        }
    }
}
