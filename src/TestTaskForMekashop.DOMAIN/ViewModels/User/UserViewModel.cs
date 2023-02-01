using System.ComponentModel.DataAnnotations;

namespace TestTaskForMekashop.DOMAIN.ViewModels.User
{
    public class UserViewModel
    {
        [Display(Name = "Id")]
        public long Id { get; set; }
        
        [Required(ErrorMessage = "Enter a Role")]
        [Display(Name = "Role")]
        public string Role { get; set; }
        
        [Required(ErrorMessage = "Enter a login")]
        [Display(Name = "Login")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter a password")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}