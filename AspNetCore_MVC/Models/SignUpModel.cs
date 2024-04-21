namespace WepApp.Models;
public class SignUpModel
{

    [Required(ErrorMessage = "invalid!")]
    [Display(Name = "First name", Prompt = "Enter your first name")]
    [DataType(DataType.Text)]
    [MinLength(2, ErrorMessage = "Not valid!")]
    public string FirstName { get; set; } = null!;


    [Required(ErrorMessage = "Required")]
    [Display(Name = "Last name", Prompt = "Enter your Last name")]
    [DataType(DataType.Text)]
    [MinLength(2, ErrorMessage = "Not valid!")]
    public string LastName { get; set; } = null!;


    [Required(ErrorMessage = "Invalid email address")]
    [Display(Name = "Email address", Prompt = "Enter your email address")]
    [DataType(DataType.EmailAddress)]
    [RegularExpression("^[^@\\s]+@[^@\\s]+\\.[^@\\s]{2,}$", ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null!;


    [Required(ErrorMessage = "Invalid Password")]
    [Display(Name = "Password", Prompt = "********")]
    [DataType(DataType.Password)]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&]).{8,}$", ErrorMessage = "Password not strong enough")]
    public string Password { get; set; } = null!;



    [Required(ErrorMessage = "Password must be confirmed")]
    [Display(Name = "Confirm Password", Prompt = "********")]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "Password does not match")]
    public string ConfirmPassword { get; set; } = null!;


    [CheckBoxRequired(ErrorMessage = "You must accept the terms and conditions to proceed.")]
    [Display(Name = "Terms & Conditions", Prompt = "I accept the terms and conditions")]
    public bool TermsAndConditions { get; set; }

}


