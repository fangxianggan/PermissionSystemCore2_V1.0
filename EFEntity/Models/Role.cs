using EFEntity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFEntity.Models
{
    public class Role : BaseEntity<int>
    {
        public string RoleName { set; get; }

        public string RoleCode { set; get; }

        public virtual ICollection<User>  GetUsers { set; get; }
    }
}
