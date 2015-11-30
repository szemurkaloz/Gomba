using System.Collections.Generic;
using Service.Pattern;
using AdatElérés.Egyedek;
using Repository.Pattern.Repositories;

namespace AdatElérés.Szolgáltatások
{
    /// <summary>
    ///     Üzleti eljárások elgondolások
    /// </summary>
    public interface IDolgozókKiszolgáló : IService<Dolgozó>
    {
        //decimal CustomerOrderTotalByYear(string customerId, int year);
        //IEnumerable<Customer> CustomersByCompany(string companyName);
        //IEnumerable<CustomerOrder> GetCustomerOrder(string country);
    }

    /// <summary>
    ///     All methods that are exposed from Repository in Service are overridable to add business logic,
    ///     business logic should be in the Service layer and not in repository for separation of concerns.
    /// </summary>
    public class DolgozókKiszolgáló : Service<Dolgozó>, IDolgozókKiszolgáló
    {
        private readonly IRepositoryAsync<Dolgozó> _repository;

        public DolgozókKiszolgáló(IRepositoryAsync<Dolgozó> repository) : base(repository)
        {
            _repository = repository;
        }
        /*
        public decimal CustomerOrderTotalByYear(string customerId, int year)
        {
            // add business logic here
            return _repository.GetCustomerOrderTotalByYear(customerId, year);
        }

        public IEnumerable<Customer> CustomersByCompany(string companyName)
        {
            // add business logic here
            return _repository.CustomersByCompany(companyName);
        }

        public IEnumerable<CustomerOrder> GetCustomerOrder(string country)
        {
            // add business logic here
            return _repository.GetCustomerOrder(country);
        }*/

        public override void Insert(Dolgozó entity)
        {
            // e.g. add business logic here before inserting
            base.Insert(entity);
        }

        public override void Update(Dolgozó entity)
        {
            // e.g. add business logic here before inserting
            base.Update(entity);
        }

        public override void Delete(object id)
        {
            // e.g. add business logic here before deleting
            base.Delete(id);
        }
    }
}
