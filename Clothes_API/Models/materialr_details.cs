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
    
    public partial class materialr_details
    {
        public int materials_id { get; set; }
        public int w_materials_id { get; set; }
        public int materialr_details_num { get; set; }
        public int materialr_details_id { get; set; }
    
        public virtual get_materials get_materials { get; set; }
        public virtual materialr materialr { get; set; }
    }
}
