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
    
    public partial class get_materials
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public get_materials()
        {
            this.materialr_details = new HashSet<materialr_details>();
            this.out_materialr = new HashSet<out_materialr>();
        }
    
        public int w_materials_id { get; set; }
        public int product_plan_id { get; set; }
        public string get_department { get; set; }
        public string operator_per { get; set; }
        public string person_handling { get; set; }
        public string status { get; set; }
        public System.DateTime get_time { get; set; }
    
        public virtual get_materials get_materials1 { get; set; }
        public virtual get_materials get_materials2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<materialr_details> materialr_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<out_materialr> out_materialr { get; set; }
    }
}
