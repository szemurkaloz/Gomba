
using Caliburn.Micro;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using Adattárolás.Táblák;
using ServiceStack;
using System.Diagnostics;

namespace Gomba
{
    public class MefBootstrapper : BootstrapperBase
    {
        private CompositionContainer container;
        private static string adatokUtvonal;
        public static string AdatokUtvonal { get { return adatokUtvonal; } }

        public MefBootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["AdatElérés"].ConnectionString;
            string SqliteMemoryDb = ":memory:";
            string sqliteFileDb = "~/AdatElérés/Gomba.sqlite".MapAbsolutePath();

            container = new CompositionContainer(
                new AggregateCatalog(AssemblySource.Instance.Select(x => new AssemblyCatalog(x)))
                );

            var batch = new CompositionBatch();

            batch.AddExportedValue<IWindowManager>(new WindowManager());
            batch.AddExportedValue<IEventAggregator>(new EventAggregator());
            batch.AddExportedValue<IDbConnectionFactory>(new
                OrmLiteConnectionFactory(sqliteFileDb, SqliteDialect.Provider));
            batch.AddExportedValue(container);

            container.Compose(batch);
        }

        protected override object GetInstance(Type serviceType, string key)
        {
            var contract = string.IsNullOrEmpty(key) ? AttributedModelServices.GetContractName(serviceType) : key;
            var exports = container.GetExportedValues<object>(contract);

            if (exports.Any())
                return exports.First();

            throw new Exception(string.Format("Could not locate any instances of contract {0}.", contract));
        }

        protected override IEnumerable<object> GetAllInstances(Type serviceType)
        {
            return container.GetExportedValues<object>(AttributedModelServices.GetContractName(serviceType));
        }

        protected override void BuildUp(object instance)
        {
            container.SatisfyImportsOnce(instance);
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            string appPath = Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().Location);
            adatokUtvonal = appPath + @"\Adatok";

            if (!System.IO.Directory.Exists(adatokUtvonal))
            {
                System.IO.Directory.CreateDirectory(adatokUtvonal);
            }
            AdatbázisLétrehozás();
            if (e.Args.Length != 0)
            {
                if (e.Args[0] == "T")//Telepítés
                {
                    AdatbázisLétrehozás();
                }
            }
                DisplayRootViewFor<IShell>();
        }

        private void AdatbázisLétrehozás()
        {
            // Setup configurations
            using (var db = IoC.Get<IDbConnectionFactory>().Open())
            {
                db.CreateTables(true);
                if (db.CreateTableIfNotExists<Dolgozó>())//CreateTableIfNotExists
                {
                    db.Insert( new Dolgozó
                    {
                        Adószám = "122214667",
                        Kód = "1",
                        Név = "Csábi Bettina",
                        SzületésIdeje = DateTime.Parse("1955.02.05")
                    });
                    db.Insert( new Dolgozó
                    {
                        Adószám = "55633255",
                        Kód = "2",
                        Név = "Robert Redford",
                        SzületésIdeje = DateTime.Parse("1955.12.05")
                    });
                }
            }
        }
    }
}
