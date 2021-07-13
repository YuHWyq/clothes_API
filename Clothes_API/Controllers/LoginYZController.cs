using Clothes_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Clothes_API.Controllers
{
    public class LoginYZController : ApiController
    {
        ClothingDBEntities db = new ClothingDBEntities();
        [HttpPost]
        //登录验证接口
        public string LoginUser( dynamic obj)
        {
            string account = obj.account;
            string pwd = obj.pwd;
            var user = db.admin.Where(u => u.account == account && u.pwd == pwd).ToList();
            if (user.Count>0)
            {
                return user[0].name;
            }
            else
            {
                return "";
            }
         }
    }
}
