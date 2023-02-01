using System.ComponentModel.DataAnnotations;

namespace TestTaskForMekashop.DOMAIN.ViewModels.Account
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Enter a name")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "Enter a password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [MinLength(5, ErrorMessage = "Password must be greater than or equal to 5 characters")]
        public string NewPassword { get; set; }
    }
}