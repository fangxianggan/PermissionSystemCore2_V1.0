using EFEntity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFEntity.Models
{
   public class Department:BaseEntity<int>
    {

        [StringLength(20)]
        public string DeptName { set; get; }

        [StringLength(20)]
        public string DeptCode { set; get; }

        public int ParentId { set; get; }

        public virtual Department ParentDepartment { set; get; }



    }
}
