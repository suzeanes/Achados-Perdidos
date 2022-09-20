using ControledeContatos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControledeContatos.BD
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext >options) : base()
        {
        }
        
        public DbSet<ContatoModel> Contatos { get; set; }
    
    }

}
