using B3.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.Context
{
    public class LocalDbContext : DbContext
    {
        public LocalDbContext(DbContextOptions<LocalDbContext> opt) : base(opt)
        {

        }

        public DbSet<Ativo> ativo { get; set; }
     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

}
}
