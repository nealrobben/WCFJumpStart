using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Zza.Entities;

namespace Zza.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class ZzaService : IZzaService, IDisposable
    {
        public List<Customer> GetCustomers()
        {
            var users = new List<Customer>();

            users.Add(new Customer() { Id = Guid.NewGuid(), FirstName = "Firstname 1", LastName = "LastName 1" });
            users.Add(new Customer() { Id = Guid.NewGuid(), FirstName = "Firstname 2", LastName = "LastName 2" });
            users.Add(new Customer() { Id = Guid.NewGuid(), FirstName = "Firstname 3", LastName = "LastName 3" });

            return users;
        }

        public List<Product> GetProducts()
        {
            var products = new List<Product>();

            products.Add(new Product() { Id = 1, Name = "Product 1", Description = "Product 1", Type = "Type 1" });
            products.Add(new Product() { Id = 2, Name = "Product 2", Description = "Product 2", Type = "Type 2" });
            products.Add(new Product() { Id = 3, Name = "Product 3", Description = "Product 3", Type = "Type 3" });

            return products;
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void SubmitOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            //Do nothing for now
        }
    }
}
