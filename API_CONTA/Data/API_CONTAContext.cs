using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_CONTA.Models;

namespace API_CONTA.Data
{
    public class API_CONTAContext : DbContext
    {
        public API_CONTAContext (DbContextOptions<API_CONTAContext> options)
            : base(options)
        {
        }

        public DbSet<API_CONTA.Models.Conta> Conta { get; set; }
    }
}
