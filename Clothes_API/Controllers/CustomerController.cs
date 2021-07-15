using Clothes_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Clothes_API.Controllers
{
    public class CustomerController : ApiController
    {
        //客户管理接口
        public object Get()
        {
            using (ClothingDBEntities3 db = new ClothingDBEntities3())
            {
                var list = db.customer.ToList();
                return list;
            }
        } 
    }
}
