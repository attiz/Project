using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Szerver.Controllers
{
    public class LoginController : ApiController
    {
        // GET login
        public HttpResponseMessage Get()
        {


            return Request.CreateResponse(HttpStatusCode.OK, "Visszateritett valamittttttt");
        }

        // GET login/5
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.Accepted, "uzenet");
        }

        // POST login
        public HttpResponseMessage Post([FromBody]string value)
        {

            return Request.CreateResponse(HttpStatusCode.NotImplemented, "Johet objektum is");
        }

        // PUT login/5
        public HttpResponseMessage Put(int id, [FromBody]string value)
        {

            return Request.CreateResponse(HttpStatusCode.PartialContent, "Barmi");
        }

        // DELETE login/5
        public HttpResponseMessage Delete(int id)
        {
            return Request.CreateResponse(HttpStatusCode.NotImplemented);
        }
    }
}
