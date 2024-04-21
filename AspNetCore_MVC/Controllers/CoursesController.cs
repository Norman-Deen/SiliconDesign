namespace WepApp.Controllers;


[Authorize]
public class CoursesController(HttpClient http) : Controller
{
    private readonly HttpClient _http = http;

 public async Task<IActionResult> Index()
{
    try
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var viewModel = new CoursesIndexViewModel();
        var response = await _http.GetAsync("https://localhost:7239/api/courses");
        
        if (!response.IsSuccessStatusCode)
        {
            return View("Error");
        }

        viewModel.Courses = JsonConvert.DeserializeObject<IEnumerable<CourseModel>>(await response.Content.ReadAsStringAsync())!;
        return View(viewModel);
    }
    catch (Exception ex) { return View("Error"); }
}





    //GetOne
    [Route("/details/{id}")]
    public async Task<IActionResult> Details(string id)
    {
        if (!ModelState.IsValid)
        {
            // Handle invalid model state
            return BadRequest(ModelState);
        }

        using var http = new HttpClient();
        var response = await http.GetAsync($"https://localhost:7239/api/Courses/{id}");
        var json = await response.Content.ReadAsStringAsync();
        var data = JsonConvert.DeserializeObject<CourseEntity>(json);

        return View(data);
    }


}
