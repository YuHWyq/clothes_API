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
    using System.Collections.Generic;
    
    public partial class customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public customer()
        {
            this.orders = new HashSet<orders>();
        }
    
        public int customer_id { get; set; }
        public string customer_name { get; set; }
        public string customer_phone { get; set; }
        public string customer_linkman { get; set; }
        public string customer_email { get; set; }
        public string customer_address { get; set; }
        public string customer_fax { get; set; }
        public string customer_postcode { get; set; }
        public string bank { get; set; }
        public string bank_account { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orders> orders { get; set; }
    }
}
