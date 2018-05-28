using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace EFEntity.Base
{
    public abstract class BaseEntity<T>
    {
        public BaseEntity()
        {
            CreateTime = DateTime.Now;
            
        }
        [DataMember]
        [Key]
        public T Id { set; get; }

        public DateTime? CreateTime { set; get; }

        public T CreateUserId { set; get; }
    }
}
