//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clothes_API.Models
{
    using System;
    
    public partial class orders_select_Result
    {
        public int order_id { get; set; }
        public string customer_name { get; set; }
        public string person_handling { get; set; }
        public decimal order_paid { get; set; }
        public decimal order_unpaid { get; set; }
        public System.DateTime order_starttime { get; set; }
        public System.DateTime order_endtime { get; set; }
        public string order_status { get; set; }
    }
}