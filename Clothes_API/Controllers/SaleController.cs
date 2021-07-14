using Clothes_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Clothes_API.Controllers
{
    public class SaleController : ApiController
    {
        ClothingDBEntities2 db = new ClothingDBEntities2();

        //订单查询
        [HttpGet]
        public string customer_order_detail()
        {
            var list1 = db.Database.SqlQuery<orders_select_Result>("exec orders_select ").ToList();
            int s = list1.Count();
            return Newtonsoft.Json.JsonConvert.SerializeObject(list1);
        }
        //订单详情
        [HttpGet]
        public string customer_detail(string id)
        {
            var list1 = db.Database.SqlQuery<orders_details_select_Result>("exec orders_details_select " + id).ToList();
            int s = list1.Count();
            return Newtonsoft.Json.JsonConvert.SerializeObject(list1);
        }

        //未处理订单的ID
        [HttpGet]
        public string weichuli()
        {
            var list1 = db.Database.SqlQuery<Nullable<int>>("exec Unprocessed_ID ").ToList();
            int s = list1.Count();
            return Newtonsoft.Json.JsonConvert.SerializeObject(list1);
        }

        //
        //订单管理
        [HttpGet]
        public string chukuxinxi(string id)
        {
            var list1 = db.Database.SqlQuery<orders_Delivery_Result>("exec orders_Delivery " + id).ToList();
            int s = list1.Count();
            return Newtonsoft.Json.JsonConvert.SerializeObject(list1);
        }
       //出库详情
        [HttpGet]
        public string out_details(string id)
        {
            var list1 = db.Database.SqlQuery<chukuxiangqings_Result>("exec chukuxiangqings " + id).ToList();
            int s = list1.Count();
            return Newtonsoft.Json.JsonConvert.SerializeObject(list1);
        }
    }
}
