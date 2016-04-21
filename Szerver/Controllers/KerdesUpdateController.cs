using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Szerver.Controllers
{
    public class KerdesUpdateController : ApiController
    {
        // GET api/kerdesupdate
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/kerdesupdate/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/kerdesupdate
        public void Post([FromBody]string value)
        {
        }

        // PUT api/kerdesupdate/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/kerdesupdate/5
        public void Delete(int id)
        {
        }
    }
}
