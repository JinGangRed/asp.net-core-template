using Domain.DBEnums;
using System.ComponentModel.DataAnnotations;

namespace Domain.DBModels
{
    public class User : EntityBase, IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Account { get; set; }
        public string Password { get; set; }
        #region WeChat Info
        public string OpenId { get; set; }
        public int Gender { get; set; }
        public string AvatarUrl { get; set; }
        public string UnionId { get; set; }
        public string NickName { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        #endregion
        [Display(Description = "状态")]
        public EntityStatus Status { set; get; }
    }
}