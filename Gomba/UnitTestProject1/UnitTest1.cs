using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.Sqlite;
using Adattárolás.Táblák;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private OrmLiteConnectionFactory dbFactory;
        /// <summary>
        ///Initialize() is called once during test execution before
        ///test methods in this test class are executed.
        ///</summary>
        [TestInitialize()]
        public void Initialize()
        {
            dbFactory = new OrmLiteConnectionFactory(
                                ":memory:", SqliteOrmLiteDialectProvider.Instance);
        }

        [TestMethod]
        public void GetProductsExecutesQuery()
        {
            using (var db = dbFactory.OpenDbConnection())
            {
                db.CreateTable<Dolgozó>();
                var dolgozó = new Dolgozó
                {
                        Adószám = "122214667",
                        Kód = "1",
                        Név = "Csábi Bettina",
                        SzületésIdeje = DateTime.Parse("1955.02.05")
                };
                db.Insert(dolgozó);
                dolgozó = new Dolgozó
                {
                    Adószám = "55633255",
                    Kód = "2",
                    Név = "Robert Redford",
                    SzületésIdeje = DateTime.Parse("1955.12.05")
                };
                db.Insert(dolgozó);
                var lista = db.Select<Dolgozó>();
                Assert.IsTrue(2 == lista.Count,string.Format("Várt listaszám 2 kapott {0}", lista.Count));
            }
        }
    }
}
