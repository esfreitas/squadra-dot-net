using B3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.Services
{
    public interface IAtivoService
    {
        bool AdicionarAtivo(Ativo ativo);
        List<Ativo> RetonarListaAtivo();
        Ativo RetornarAtivoPorId(int id);
        bool AtualizarAtivo(Ativo novoAtivo);
        bool DeletarAtivo(int id);
    }
}
