using gwCloudAssessment.Context;
using gwCloudAssessment.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace gwCloudAssessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        readonly ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customerRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _customerRepository.Get(id);
        }
        [HttpPost("create")]
        public IActionResult Post([FromBody] Customer input)
        {
            try
            {
                _customerRepository.Create(input);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.Message);
            }
            
        }


        [HttpPut]
        public IActionResult Put([FromBody] Customer input)
        {
            _customerRepository.Update(input);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _customerRepository.Delete(id);
            return Ok();
        }
    }
}
