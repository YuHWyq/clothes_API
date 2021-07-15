using Clothes_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Clothes_API.Controllers
{
    public class FinanceController : ApiController
    {
        ClothingDBEntities3 db = new ClothingDBEntities3();
        //收入
        [HttpGet]
        public string in_m()
        {
            var list1 = db.Database.SqlQuery<shouru_Result>("exec shouru ").ToList();
            int s = list1.Count();
            return Newtonsoft.Json.JsonConvert.SerializeObject(list1);
        }
    }
}
