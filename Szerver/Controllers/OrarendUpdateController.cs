using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Szerver.Controllers
{
    public class OrarendUpdateController : ApiController
    {
        // GET api/orarendupdate
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/orarendupdate/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/orarendupdate
        public void Post([FromBody]string value)
        {
        }

        // PUT api/orarendupdate/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/orarendupdate/5
        public void Delete(int id)
        {
        }
    }
}
