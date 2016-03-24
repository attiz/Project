using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Szerver.Controllers
{
    public class LoginController : ApiController
    {
        // GET login
        public HttpResponseMessage Get()
        {


            return Request.CreateResponse(HttpStatusCode.OK, "Visszateritett valamit");
        }

        /// <summary>
        /// Status Kod-ot terit vissza ha a neptun kodot nem talalta meg az adatbazisban
        /// </summary>
        /// <param name="id">Neptun Kod</param>
        /// <returns></returns>
        public HttpResponseMessage Get(string id)
        {
            return Request.CreateResponse(HttpStatusCode.Accepted, "uzenet");
        }

        /// <summary>
        /// Login check a tanaroknak es adminoknak, a Body-bol kell jojjon
        /// </summary>
        /// <param name="value">JSON objektum</param>
        /// <returns>Status Kod-ot terit vissza</returns>
        public HttpResponseMessage Post([FromBody]JObject value)
        {

            return Request.CreateResponse(HttpStatusCode.NotImplemented, value);
        }

        /// <summary>
        /// Uj tanarok hozzaadasa, JSON objektumban at kell kuldeni az admin kodot
        /// </summary>
        /// <param name="value">ADMIN parameterek, JSON objektumban, body-bol</param>
        /// <returns></returns>
        public HttpResponseMessage Put([FromBody]JObject value)
        {
            //a valuebol ki kell szedni, hogy torolni akar, vagy hozzaadni
            return Request.CreateResponse(HttpStatusCode.PartialContent, "Barmi");
        }
        

        public HttpResponseMessage Delete(int id)
        {
            return Request.CreateResponse(HttpStatusCode.Unauthorized);
        }
    }
}
