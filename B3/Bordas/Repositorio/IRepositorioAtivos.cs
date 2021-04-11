using B3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.Bordas.Repositorio
{
    public interface IRepositorioAtivos
    {
        public int Add(Ativo request);
        public void Remove(int id);
    }
}
