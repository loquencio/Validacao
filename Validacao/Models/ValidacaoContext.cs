using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Validacao.Models
{
    public class ValidacaoContext : DbContext
    {
        public DbSet<Jogador> Jogadores { get; set; }
    }
}