
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;


    public string? ImagePath { get; set; }


    [NotMapped]
    public IFormFile? ProfileImage { get; set; }

    public string? Phone { get; set; } = null!;
    public string? Bio { get; set; } = null!;
    public string? AddressLine1 { get; set; } = null!;
    public string? AddressLine2 { get; set; } = null!;
    public string? City { get; set; } = null!;
    public string? Postalcode { get; set; } = null!;
}
