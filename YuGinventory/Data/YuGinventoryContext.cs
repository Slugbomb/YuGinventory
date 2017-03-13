using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YuGinventory.Models;

namespace YuGinventory.Models
{
    public class YuGinventoryContext : DbContext
    {
        public YuGinventoryContext (DbContextOptions<YuGinventoryContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=YuGinventoryContext-306a00bf-6637-47d0-9e01-a22dbef66606;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<YuGinventory.Models.User> User { get; set; }

        public DbSet<YuGinventory.Models.Deck> Deck { get; set; }

        public DbSet<YuGinventory.Models.Card> Card { get; set; }

        public DbSet<YuGinventory.Models.ReferenceCard> ReferenceCard { get; set; }
    }
}
