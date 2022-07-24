using System.ComponentModel.DataAnnotations;

namespace PersonalWebsite.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {

        [Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen SoyAdınızı Giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Lütfen Resim Url Giriniz")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Giriniz")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz")]
        [Compare("Password",ErrorMessage="Şifreler Aynı Değil")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen Mailinizi Giriniz")]
        public string Mail { get; set; }

    }
}
