using WepApp.Models;

namespace WepApp.ViewModels;

public class CoursesIndexViewModel
{
    public IEnumerable<CourseModel> Courses { get; set; } = []; 
}
