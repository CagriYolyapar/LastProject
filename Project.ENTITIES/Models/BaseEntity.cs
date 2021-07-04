using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Models
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public DataStatus Status { get; set; }

        public BaseEntity()
        {
            Status = DataStatus.Inserted;
            CreatedDate = DateTime.Now;
        }
    }
}
