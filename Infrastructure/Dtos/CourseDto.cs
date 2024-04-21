
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.DTOS;

public class CourseDto
{
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

}
