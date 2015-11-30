using AdatElérés.DbElérése;
using AdatElérés.Egyedek;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup configurations
            using (var context = new GombaDbContext())
            {
                Database.SetInitializer<GombaDbContext>(null);
                foreach (var team in context.Set<Dolgozó>())
                {
                    Debug.WriteLine(team.Név);
                }
                foreach (var team in context.Set<Láda>())
                {
                    Debug.WriteLine(team.Név);
                }
            }
            var gyár = DbProviderFactories.GetFactory("System.Data.SQLite");
            using (var kapcsolat = gyár.CreateConnection())
            {
                kapcsolat.ConnectionString = @"Data Source = C:\Users\szemu_000\Documents\Visual Studio 2015\Projects\Gomba\Gomba\bin\Debug\AdatElérés\Gomba.sqlite";
                kapcsolat.Open();
            }
        }
    }
}
