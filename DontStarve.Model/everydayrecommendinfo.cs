//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DontStarve.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class everydayrecommendinfo
    {
        public System.Guid CookId { get; set; }
        public System.Guid SubAdmin { get; set; }
        public long RecommendTime { get; set; }
        public string OurRatings { get; set; }
        public string Reason { get; set; }
        public long Subtime { get; set; }
    
        public virtual cookinfo cookinfo { get; set; }
        public virtual userinfo userinfo { get; set; }
    }
}
