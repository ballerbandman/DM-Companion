using Microsoft.EntityFrameworkCore;
using System;

namespace DMCompanion.Data{
    public class ApplicationDBContext : DbContext{
        public DbSet<DMCompanion.Models.Creature> Creatures {get; set;} = null!;
        public DbSet<DMCompanion.Models.NPC> NPCs {get; set;} = null!;
        public DbSet<DMCompanion.Models.Rule> Rules {get; set;} = null!;
        public DbSet<DMCompanion.Models.tag> Tags {get; set;} = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseMySql("server=localhost;user=root;password=Mieguele1;database=DnD", new MySqlServerVersion(new Version(8, 0, 33)));
            


        }
    }
}