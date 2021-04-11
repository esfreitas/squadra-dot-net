using B3.Bordas.Repositorio;
using B3.Context;
using B3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.Repositorios
{
    public class RepositorioAtivos : IRepositorioAtivos
    {
        private readonly LocalDbContext _local;

        public RepositorioAtivos(LocalDbContext local)
        {
            _local = local;
        }

        public int Add(Ativo request)
        {
            _local.ativo.Add(request);
            _local.SaveChanges();
            return request.id;
        }

        public void Remove(int id)
        {
            var obj = _local.ativo.Where(d => d.id == id).FirstOrDefault();
            if (obj == null)
            {
                throw new System.Exception();
            }
            _local.ativo.Remove(obj);
            _local.SaveChanges();
        }
    }
}
