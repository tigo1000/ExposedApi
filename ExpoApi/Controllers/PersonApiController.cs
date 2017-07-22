using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExpoApi.Controllers
{


    [RoutePrefix("api/person")]
    public class PersonApiController : ApiController
    {

        [Route("{abs}/{xpto}")]
        public IHttpActionResult GetPerson(string xpto = null, string abs = null)
        {


            return Ok("Thiago " + xpto + abs);
        }

        [Authorize]
        [Route("full-name")]
        public string GetPersonFullName()
        {


            return "Thiago Locci Bomtempo";
        }

        
        private void Login()
        {

        }
    }
}
