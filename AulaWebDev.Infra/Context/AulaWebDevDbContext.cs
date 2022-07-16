using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaWebDev.Infra.Context
{
    public class AulaWebDevDbContext : DbContext
    {
        public AulaWebDevDbContext(DbContextOptions<AulaWebDevDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AulaWebDevDbContext).Assembly);
        }
    }
}
