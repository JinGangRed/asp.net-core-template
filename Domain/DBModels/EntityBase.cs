using System;
using System.ComponentModel.DataAnnotations;


namespace Domain.DBModels
{
    public class EntityBase
    {
        public DateTime CreateTime { set; get; }

        [StringLength(20)]
        public string CreateBy { get; set; }

        public DateTime? ModifyTime { get; set; }

        [StringLength(20)]
        public string ModifyBy { get; set; }
    }
}
