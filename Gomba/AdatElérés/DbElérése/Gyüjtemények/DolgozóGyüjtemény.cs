using AdatElérés.Egyedek;
using AdatElérés.Osztályok;
using Repository.Pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdatElérés.DbElérése.Gyüjtemények
{
    // Exmaple: How to add custom methods to a repository.
    
    public static class DolgozóGyüjtemény
    {
        public static IEnumerable<DolgozóSzedései> DolgozókSzedései(this IRepository<Dolgozó> repository, DateTime kezd, DateTime vége)
        {
            var dolgozók = repository.GetRepository<Dolgozó>().Queryable().OrderBy(d => d.Név);
            IQueryable<Mérés> mérések = repository.GetRepository<Mérés>()
                .Queryable().Where(k => (k.Idő >= kezd) && (k.Idő <= vége));
            var groups = mérések.GroupBy(
                // The key of each group.
                m =>  new
                {
                    m.DolgozóId,
                    m.Helye
                },

                // Count() aggregates items of each group into one single value.
                (key, products) => new
                {
                    Key = key,
                    Count = products.Count(),
                    valami = products.Max(),
                });

            /* var query = from m in mérések;
                       group m by new
                        {
                            m.DolgozóId,
                            m.Helye
                        } into gcs
                        select new DolgozóSzedései
                                    {
                                        DolgozóId = gcs.Key,
                                        DolgozóNév = d.Név,
                                        OrderId = o.OrderID,
                                        OrderDate = o.OrderDate
                                    };*/

            return null;
        }
    }

    
}
