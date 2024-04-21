using Infrastructure.DTOS;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities;

public class CourseEntity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Title { get; set; } = null!;

    public string? CourseImagePath { get; set; }
    [NotMapped]
    public IFormFile? CourseImage { get; set; }



    public bool IsBestseller { get; set; }
    public int Hours { get; set; }
    public decimal OriginalPrice { get; set; }
    public decimal DiscountPrice { get; set; }
    public decimal LikesInProcent { get; set; }
    public decimal LikesInNumbers { get; set; }
    public string? TitleDescription { get; set; }

    public string? Author { get; set; }
    public string? AuthorImagePath { get; set; }
    [NotMapped]
    public IFormFile? AuthorImage { get; set; }


    public string? AuthorDescription { get; set; }
    public string? CourseDescription { get; set; }

    public string? CourseGoal1 { get; set; }
    public string? CourseGoal2 { get; set; }
    public string? CourseGoal3 { get; set; }
    public string? CourseGoal4 { get; set; }
    public string? CourseGoal5 { get; set; }

    public string? CourseIncludes1 { get; set; }
    public string? CourseIncludes2 { get; set; }
    public string? CourseIncludes3 { get; set; }
    public string? CourseIncludes4 { get; set; }
    public string? CourseIncludes5 { get; set; }

    public string? ProgramDetailTitle1 { get; set; }
    public string? ProgramDetailDescription1 { get; set; }

    public string? ProgramDetailTitle2 { get; set; }
    public string? ProgramDetailDescription2 { get; set; }
    public string? ProgramDetailTitle3 { get; set; }
    public string? ProgramDetailDescription3 { get; set; }
    public string? ProgramDetailTitle4 { get; set; }
    public string? ProgramDetailDescription4 { get; set; }
    public string? ProgramDetailTitle5 { get; set; }
    public string? ProgramDetailDescription5 { get; set; }
    public string? ProgramDetailTitle6 { get; set; }
    public string? ProgramDetailDescription6 { get; set; }

    public static implicit operator CourseEntity(CourseDto dto)
    {
        return new CourseEntity
        {
            Title = dto.Title,
            CourseImagePath = dto.CourseImagePath,
            IsBestseller = dto.IsBestseller,
            Hours = dto.Hours,
            OriginalPrice = dto.OriginalPrice,
            DiscountPrice = dto.DiscountPrice,
            LikesInProcent = dto.LikesInProcent,
            LikesInNumbers = dto.LikesInNumbers,
            TitleDescription = dto.TitleDescription,
            Author = dto.Author,
            AuthorImagePath = dto.AuthorImagePath,
            AuthorDescription = dto.AuthorDescription,
            CourseDescription = dto.CourseDescription,
            CourseGoal1 = dto.CourseGoal1,
            CourseGoal2 = dto.CourseGoal2,
            CourseGoal3 = dto.CourseGoal3,
            CourseGoal4 = dto.CourseGoal4,
            CourseGoal5 = dto.CourseGoal5,
            CourseIncludes1 = dto.CourseIncludes1,
            CourseIncludes2 = dto.CourseIncludes2,
            CourseIncludes3 = dto.CourseIncludes3,
            CourseIncludes4 = dto.CourseIncludes4,
            CourseIncludes5 = dto.CourseIncludes5,
            ProgramDetailTitle1 = dto.ProgramDetailTitle1,
            ProgramDetailDescription1 = dto.ProgramDetailDescription1,
            ProgramDetailTitle2 = dto.ProgramDetailTitle2,
            ProgramDetailDescription2 = dto.ProgramDetailDescription2,
            ProgramDetailTitle3 = dto.ProgramDetailTitle3,
            ProgramDetailDescription3 = dto.ProgramDetailDescription3,
            ProgramDetailTitle4 = dto.ProgramDetailTitle4,
            ProgramDetailDescription4 = dto.ProgramDetailDescription4,
            ProgramDetailTitle5 = dto.ProgramDetailTitle5,
            ProgramDetailDescription5 = dto.ProgramDetailDescription5,
            ProgramDetailTitle6 = dto.ProgramDetailTitle6,
            ProgramDetailDescription6 = dto.ProgramDetailDescription6
        };
    }

}
