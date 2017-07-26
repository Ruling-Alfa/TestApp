using DemoWindowsApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TesetApp.Controllers
{
    public class ValuesController : ApiController
    {
        DBConnect context = new DBConnect();
        // GET: api/Values
        public IEnumerable<Person> Get()
        {
            List<Person> data = context.SelectAll();

            return data;
        }

        // GET: api/Values/5
        public Person Get(int id)
        {
            Person p = context.Select(id);

            return p;
        }

        // POST: api/Values
        public void Post([FromBody]Person p)
        {
            context.Insert(p);
        }

        // PUT: api/Values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Values/5
        public void Delete(int id)
        {
        }
    }
}
