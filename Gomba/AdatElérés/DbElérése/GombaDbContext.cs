using AdatElérés.Egyedek;
using Repository.Pattern.Ef6;
using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdatElérés.DbElérése
{
    public class GombaDbContext : DataContext
    {
        //http://erikej.blogspot.hu/2014/11/using-sqlite-with-entity-framework-6.html
        public GombaDbContext()
            : base("AdatElérés")
        {
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Dolgozó> Dolgozók { get; set; }
        public DbSet<Beállítás> Beállítások { get; set; }
        public DbSet<Kezelő> Kezelők { get; set; }
        public DbSet<Láda> Ládák { get; set; }
        public DbSet<Mérés> Mérések { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           /* modelBuilder.Conventions
            .Remove<PluralizingTableNameConvention>();
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<GombaDbContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
            modelBuilder.Entity<Dolgozó>().Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Beállítás>();
            modelBuilder.Entity<Kezelő>();
            modelBuilder.Entity<Láda>();
            modelBuilder.Entity<Mérés>();*/

            var initializer = new GombaDbInitializer(modelBuilder);
            Database.SetInitializer(initializer);
        }
    }

    public class GombaDbInitializer : SqliteDropCreateDatabaseAlways<GombaDbContext>
    {
        public GombaDbInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder)
        { }

        protected override void Seed(GombaDbContext context)
        {
            DolgozókFeltoltése(context);
            LádákFeltöltése(context);
            /*  context.Set<Team>().Add(new Team
              {
                  Name = "YB",
                  Coach = new Coach
                  {
                      City = "Zürich",
                      FirstName = "Masssaman",
                      LastName = "Nachn",
                      Street = "Testingstreet 844"
                  },
                  Players = new List<Player>
                  {
                      new Player
                      {
                          City = "Bern",
                          FirstName = "Marco",
                          LastName = "Bürki",
                          Street = "Wunderstrasse 43",
                          Number = 12
                      },
                      new Player
                      {
                          City = "Berlin",
                          FirstName = "Alain",
                          LastName = "Rochat",
                          Street = "Wonderstreet 13",
                          Number = 14
                      }
                  },
                  Stadion = new Stadion
                  {
                      Name = "Stade de Suisse",
                      City = "Bern",
                      Street = "Papiermühlestrasse 71"
                  }
              });*/
        }

        private void DolgozókFeltoltése(GombaDbContext context)
        {
            context.Set<Dolgozó>()
                .Add(new Dolgozó { Adószám = "12342356", Kód = "1", Név = "Király Viktor", SzületésIdeje = DateTime.Parse("2001.10.04") });
            context.Set<Dolgozó>()
                .Add(new Dolgozó { Adószám = "445553323", Kód = "2", Név = "Blaha Lujza", SzületésIdeje = DateTime.Parse("1987.11.03") });
        }

        private void LádákFeltöltése(GombaDbContext context)
        {
            context.Set<Láda>()
                  .Add(new Láda
                  {
                      Kód = "1",
                      Név = "Pici négyzet",
                      Tára = 12,
                      TáraTólKevesebb = 1,
                      TáraTólTöbb = 14,
                      Brutto = 55,
                      BruttoTólKevesebb = 50,
                      BruttoTólTöbb = 55
                  });
            context.Set<Láda>()
                  .Add(new Láda
                  {
                      Kód = "2",
                      Név = "Nagy láda",
                      Tára = 30,
                      TáraTólKevesebb = 25,
                      TáraTólTöbb = 35,
                      Brutto = 100,
                      BruttoTólKevesebb = 90,
                      BruttoTólTöbb = 110
                  });
        }
    }
}
