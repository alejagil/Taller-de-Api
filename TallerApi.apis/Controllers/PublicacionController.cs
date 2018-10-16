using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TallerApi.apis.Models;

namespace TallerApi.apis.Controllers
{
    public class PublicacionController : ApiController
    {
        [HttpGet]
        public IEnumerable<Publicacion> Get()
        {
            using (var context = new MipublicacionContext())
            {
                return context.Publicacion.ToList();
            }

        }
    }
}
