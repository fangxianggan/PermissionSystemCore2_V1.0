using EFEntity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFEntity.Models
{
    public class User : BaseEntity<int>
    {
        [StringLength(20)]
        public string UserName { set; get; }
        [StringLength(20)]
        public string LoginName { set; get; }

        public string Password { set; get; }

        public int DeptId { set; get; }
        //指定 设置外键 
        [ForeignKey("DeptId")]
        public virtual Department Department { set; get; }

        public virtual ICollection<Role>  GetRoles { set; get; }

    }
}
