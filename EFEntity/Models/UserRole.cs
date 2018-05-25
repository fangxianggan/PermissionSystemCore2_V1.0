using EFEntity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFEntity.Models
{
    /// <summary>
    /// 用户角色表
    /// </summary>
    public class UserRole : BaseEntity<int>
    {
        public int UserId { set; get; }
        [ForeignKey("UserId")]
        public User User { set; get; }

        public int RoleId { set; get; }
        [ForeignKey("RoleId")]
        public Role Role { set; get; }

    }
}
