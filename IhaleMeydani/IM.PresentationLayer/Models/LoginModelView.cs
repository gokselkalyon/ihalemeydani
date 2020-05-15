using System; 
using System.ComponentModel.DataAnnotations;
namespace IM.PresentationLayer.Models
{
    public class LoginModelView
    {
        [Required(ErrorMessage = "Bu alan boş Geçilemez!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bu alan boş Geçilemez!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Bu alan boş Geçilemez!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Bu alan boş Geçilemez!")]
        public string Password2 { get; set; }

        public string RoleType = "Kullanıcı";
    }
}