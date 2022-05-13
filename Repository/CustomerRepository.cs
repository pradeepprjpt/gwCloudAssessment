using gwCloudAssessment.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gwCloudAssessment.Repository
{
    public class CustomerRepository: ICustomerRepository
    {
        protected CustomerDbContext CustomerDbContext { get; set; }

        public CustomerRepository(CustomerDbContext customerDbContext)
        {
            CustomerDbContext = customerDbContext;
        }

        public void Create(Customer customer)
        {
            try
            {
                CustomerDbContext.Customers.Add(customer);
                CustomerDbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        public void Update(Customer customer)
        {
            CustomerDbContext.Customers.Update(customer);
            CustomerDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var customer = Get(id);
            CustomerDbContext.Customers.Remove(customer);
        }

        public Customer Get(int id)
        {
            return CustomerDbContext.Customers.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return CustomerDbContext.Customers;
        }
    }
}
