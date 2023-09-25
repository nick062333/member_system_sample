using System.ComponentModel.DataAnnotations;

namespace MemberSystem.Web.Models
{
    public class UserRegisterModel
    {
        [Required(ErrorMessage = "帳號需必填")]
        [DataType(DataType.Text)]
        public string Account { get; set; }

        [Required(ErrorMessage = "密碼需必填")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "姓名需必填")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "信箱需必填")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "生日需必填")]
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }

        [Required(ErrorMessage = "部門需必填")]
        public string OrgId { get; set; }
    }
}
