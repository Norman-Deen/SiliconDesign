namespace WepApp.Models
{
    public class SignInModel
    {
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Email address", Prompt = "Enter your email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;


        [Required(ErrorMessage = "Required")]
        [Display(Name = "Password", Prompt = "Enter your password")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;


        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
