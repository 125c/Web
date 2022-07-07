using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _06webAPI.Models;

namespace _06webAPI.Controllers
{
    public class ValuesController : ApiController
    {
       
        NorthwindEntities db=new NorthwindEntities();
        // GET api/values
        public IEnumerable<Customers> Get()
        {
            var customer = db.Customers;
            return customer;
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public Customers Get(string id)
        {
            var customer = db.Customers.Find(id);
            //var customer = db.Customers.Where(c => c.CustomerID == id).FirstOrDefault();
            return customer;
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
