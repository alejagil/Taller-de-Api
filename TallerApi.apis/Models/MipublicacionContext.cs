using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TallerApi.apis.Models
{
    public class MipublicacionContext: DbContext
    {
       public MipublicacionContext() : base("PublicacionConection")
        {

        }

        public DbSet<Publicacion> Publicacion { get; set; }
    }
}