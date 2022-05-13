using gwCloudAssessment.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gwCloudAssessment.Repository
{
    public interface ICustomerRepository
    {
        void Create(Customer customer);
        void Update(Customer customer);
        void Delete(int id);
        Customer Get(int id);
        IEnumerable<Customer> GetAll();
    }
}
