﻿using AulaAPI.DataModels;
using Microsoft.EntityFrameworkCore;

namespace AulaAPI
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Email> Emails { get; set; }
        public Contexto()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //ConnectionStringSettings settings =
            //        ConfigurationManager.ConnectionStrings["Aula_Entity"];

            //string retorno = "";

            //if (settings != null)
            //    retorno = settings.ConnectionString;

            ////optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=aulaentity; User ID=aulaentity; password=senha_1234;language=Portuguese");
            //optionsBuilder.UseSqlServer(retorno);

            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=aulaentity;User ID=aulaentity;Password=senha1234");
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>()
                .HasOne(e => e.pessoa)
                .WithMany(p => p.Emails)
                .OnDelete(DeleteBehavior.ClientCascade);


        }
    }
}
