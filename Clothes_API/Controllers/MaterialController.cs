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
    public class MaterialController : ApiController
    {
        ClothingDBEntities3 db = new ClothingDBEntities3();
        //材料库存 
        [HttpGet]
        public string select_material()
        {
            var list1 = db.Database.SqlQuery<clkc_Result>("exec clkc ").ToList();
            int s = list1.Count();
            return Newtonsoft.Json.JsonConvert.SerializeObject(list1);
        }

        //材料出库
        [HttpGet]
        public string out_material()
        {
            var list1 = db.Database.SqlQuery<material_Chuku_Result>("exec material_Chuku ").ToList();
            int s = list1.Count();
            return Newtonsoft.Json.JsonConvert.SerializeObject(list1);
        }
        //新增材料
        [HttpPost]
        public string addyl(string json)
        {
            JObject json1 = (JObject)JsonConvert.DeserializeObject(json);
            cl c = new cl();
            c.clName = json1.Root["clName"].ToString();
            c.clnum = int.Parse(json1.Root["clnum"].ToString());
            c.clprice = int.Parse(json1.Root["clprice"].ToString());
            c.clgys = json1.Root["clgys"].ToString();
            db.cl.Add(c);
            db.SaveChanges();

            return "新增成功";
        }
        //删除材料
        [HttpGet]
        public string deleteyl(int id)
        {
            cl c = db.cl.FirstOrDefault(p=>p.clID==id);
            db.cl.Remove(c);
            db.SaveChanges();
            return "删除成功";
        }
        //根据ID查
        [HttpGet]
        public string select_xiangqing(int id)
        {
            var list1 = db.cl.Where(p => p.clID == id).ToList();
            return Newtonsoft.Json.JsonConvert.SerializeObject(list1);
        }
        //修改
        [HttpGet]
        public string update_cl(string json)
        {
            db.Configuration.ProxyCreationEnabled = false;
            JObject json1 = (JObject)JsonConvert.DeserializeObject(json);
            int id = int.Parse(json1.Root["clID"].ToString());
            cl cu = db.cl.FirstOrDefault(p => p.clID == id);
            cu.clID = id;
            cu.clName = json1.Root["clName"].ToString();
            cu.clnum = int.Parse(json1.Root["clnum"].ToString());
            cu.clprice =int.Parse(json1.Root["clprice"].ToString());
            cu.clgys = json1.Root["clgys"].ToString();
            db.Entry(cu).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "";
        }
    }
}
