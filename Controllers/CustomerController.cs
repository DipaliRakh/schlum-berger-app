using Microsoft.AspNetCore.Mvc;
using Schlumberger.Context;
using Schlumberger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Schlumberger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerContext _customerContext;

        public CustomerController(CustomerContext customerContext)
        {
            _customerContext = customerContext;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customerContext.Customers;
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _customerContext.Customers.SingleOrDefault(x=>x.CustomerId==id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            if(ModelState.IsValid)
            {
                _customerContext.Customers.Add(customer);
                _customerContext.SaveChanges();
            }
            

        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer customer)
        {
            if (ModelState.IsValid)
            {
                customer.CustomerId = id;
                _customerContext.Customers.Update(customer);
                _customerContext.SaveChanges();
            }
        }

    }
}
