using EFEntity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFEntity.Models
{
    public class Role : BaseEntity<int>
    {
        [StringLength(20)]
        public string RoleName { set; get; }
        [StringLength(20)]
        public string RoleCode { set; get; }

        //不存数据库里的字段
        [NotMapped()]
        public virtual ICollection<User> Users { set; get ;  }
    }
}
