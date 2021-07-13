using Clothes_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Clothes_API.Controllers
{
    public class DefaultController : ApiController
    {
        ClothingDBEntities db = new ClothingDBEntities();
        [HttpGet]
        public string ss()
        {
            var dd = db.admin.ToList();
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(dd);
            return json;
        }
    }
}
