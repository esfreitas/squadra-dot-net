using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B3.Entities
{
    public class Ativo
    {
        [Key]
        public int id { get; set; }
        public string empresa { get; set; }
        public string codigob3 { get; set; }
        public int preco { get; set; }
        public string tipo { get; set; }

    }
}
