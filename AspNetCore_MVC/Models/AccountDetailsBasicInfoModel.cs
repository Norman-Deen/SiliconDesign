namespace WepApp.Models;

public class AccountDetailsBasicInfoModel
{

    public IFormFile? ProfileImage { get; set; }


    [Display(Name = "First name", Prompt = "Enter your first name", Order = 0)]
    [Required(ErrorMessage = "Invalid first name.")]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Last name", Prompt = "Enter your last name", Order = 1)]
    [Required(ErrorMessage = "Invalid last name.")]
    public string LastName { get; set; } = null!;



    [Display(Name = "Email address", Prompt = "Enter your email address", Order = 2)]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Invalid email address.")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address.")]
    public string Email { get; set; } = null!;

    [Display(Name = "Phone", Prompt = "Enter your Phone", Order = 3)]
    [DataType(DataType.PhoneNumber)]
    [Required(ErrorMessage = "Invalid Phone number.")]
    public string Phone { get; set; } = null!;



    [Display(Name = "Bio", Prompt = "Add a short bio ...", Order = 4)]
    [DataType(DataType.MultilineText)]
    public string? Biography { get; set; }



}
