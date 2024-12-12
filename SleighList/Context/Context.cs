using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SleighList.Models;

namespace SleighList.Context
{
    public class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        // OnConfiguring -> Possui a configuracao da conexao com
        //o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // colocar as informacoes do banco
            // As configuracoes existem?
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=NOTE36-S28\\SQLEXPRESS; Initial Catalog = Bibliotec_mvc; User Id=sa; Password=123; TrustServerCertificate = true");
            }
        }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Item> Item { get; set; }
    }
}