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
    
    public partial class saysayinfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public saysayinfo()
        {
            this.saysaycommentinfo = new HashSet<saysaycommentinfo>();
        }
    
        public System.Guid Guid_id { get; set; }
        public System.Guid UserId { get; set; }
        public string Content { get; set; }
        public long Subtime { get; set; }
        public byte[] Pic { get; set; }
        public bool DelFlag { get; set; }
        public bool IsAllUserCanSee { get; set; }
        public long PraiseNum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<saysaycommentinfo> saysaycommentinfo { get; set; }
        public virtual userinfo userinfo { get; set; }
    }
}
