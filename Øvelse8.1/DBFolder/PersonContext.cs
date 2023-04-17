using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse8._1.DBFolder
{
    public class PersonContext : DbContext
    {



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-C42CI8FE\\SQLEXPRESS; " +
                "Initial Catalog = L08CSharpPerson;  " +
                "Integrated Security = SSPI;  " +
                "TrustServerCertificate = true");
        }
 //       Klasse klasse; 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Klasse>().HasData(new Klasse[] {
            //  klasse =  new Klasse{KlasseId=-1,Aargang = "7", KlasseNavn = "VinderKlassen"  }
            //});

            //modelBuilder.Entity<Person>().HasData(new Person[] {
            //    new Person{Id=-1,Name="Bob", Age= "40", LastName= "jensen", Klasse = klasse }
            //});


        }

        public DbSet<Person> Personer { get; set; }
        public DbSet<Klasse> Klasser { get; set; }
    }
}
