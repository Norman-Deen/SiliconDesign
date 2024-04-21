namespace Infrastructure.Dtos;

// i changed WebApi to Infrastructure

public class SubscribDto
{
   
   
    //[Required(ErrorMessage = "Invalid email address")]
   //[Display(Name = "Email address", Prompt = "Enter your email address")]
    [DataType(DataType.EmailAddress)]
    [RegularExpression("^[^@\\s]+@[^@\\s]+\\.[^@\\s]{2,}$", ErrorMessage = "Invalid email address")]
    public string Email { get; set; }  = null!;



    public bool DailyNewsletter { get; set; }
    public bool AdvertisingUpdates { get; set; }
    public bool WeekinReview { get; set; }
    public bool EventUpdates { get; set; }
    public bool StartupsWeekly { get; set; }
    public bool Podcasts { get; set; }

}
