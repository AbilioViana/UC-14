using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chapter.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.WebApi.Contexts
{
    public class ChapterContext : DbContext

    {
        public ChapterContext()

        {
        }
        public ChapterContext(DbContextOptions<ChapterContext>
        options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Essa string de conexão foi depende da SUA máquina.
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-CS5L0LS; initial catalog = Chapter; Integrated Security = true");
                // Exemplo 1 de string de conexão:
                // User ID=sa;Password=admin;Server=localhost;Database=Chapter;-
                // + Trusted_Connection=False;
                // Exemplo 2 de string de conexão:
                //Server = localhost\\SQLEXPRESS; Database = Chapter; Trusted_Connection = True;
            }
        }
        public DbSet<Livro> Livros { get; set; }

    }
}
