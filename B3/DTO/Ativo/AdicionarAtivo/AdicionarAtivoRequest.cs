using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.DTO.Ativo.AdicionarAtivo
{
    public class AdicionarAtivoRequest
    {
        public string empresa { get; set; }
        public string codigoB3 { get; set; }
        public int valor { get; set; }
    }
}
