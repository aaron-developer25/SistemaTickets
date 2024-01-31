using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SistemaTickets.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    }
}
