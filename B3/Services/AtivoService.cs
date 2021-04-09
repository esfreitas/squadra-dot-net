using B3.Context;
using B3.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.Services
{
    public class AtivoService : IAtivoService
    {
        private readonly LocalDbContext _local;

        public AtivoService(LocalDbContext local)
        {
            _local = local;
        }
        public bool AdicionarAtivo(Ativo ativo)
        {
            _local.ativo.Add(ativo);
            _local.SaveChanges();
            return true;
        }

        public bool AtualizarAtivo(Ativo novoAtivo)
        {
            _local.ativo.Attach(novoAtivo);
            _local.Entry(novoAtivo).State = EntityState.Modified;
            _local.SaveChanges();
            return true;
        }

        public bool DeletarAtivo(int id)
        {
            var objApagar = _local.ativo.Where(d => d.id == id).FirstOrDefault();
            _local.ativo.Remove(objApagar);
            _local.SaveChanges();
            return true;
        }

        public List<Ativo> RetonarListaAtivo()
        {
            return _local.ativo.ToList();
        }

        public Ativo RetornarAtivoPorId(int id)
        {
            return _local.ativo.Where(d => d.id == id).FirstOrDefault();
        }
    }
}
