using Clothes_API.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        ClothingDBEntities3 db = new ClothingDBEntities3();

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
        //新增产品出库
        [HttpPost]
        public string cpchuku(string json)
        {
            JObject json1 = (JObject)JsonConvert.DeserializeObject(json);
            out_repertory or = new out_repertory();
            or.order_id = int.Parse(json1.Root["order_id"].ToString());
            or.person_handling = json1.Root["person_handling"].ToString();
            or.out_time = Convert.ToDateTime(json1.Root["out_time"].ToString());
            db.out_repertory.Add(or);
            db.SaveChanges();
            return "新增成功";
        }
        //修改订单状态
        [HttpGet]
        public string orderzt(int id)
        {
            db.Configuration.ProxyCreationEnabled = false;
            orders o = db.orders.FirstOrDefault(p => p.order_id == id);
            o.order_status = "已提货";
            db.Entry(o).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "";
        }
        
    }
}
