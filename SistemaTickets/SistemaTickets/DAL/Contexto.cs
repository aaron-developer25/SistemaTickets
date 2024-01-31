using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SistemaTickets.Models;

namespace SistemaTickets.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Prioridades>? Prioridades { get; set; }

        public DbSet<Clientes>? Clientes { get; set; }

        public DbSet<Tickets>? Tickets { get; set; }

        public DbSet<Sistemas>? Sistemas { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    }
}
