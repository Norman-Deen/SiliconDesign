using WepApp.ViewModels;

namespace WepApp.Controllers;

public class HomeController(HttpClient http) : Controller
{
    private readonly HttpClient _http = http;


    public IActionResult Index()
    {
        var viewModel = new SubscribeViewModel();
        return View(viewModel);
    }






    [HttpPost]
    public async Task<IActionResult> Index(SubscribeViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(viewModel), Encoding.UTF8, "application/json");
                var response = await _http.PostAsync("https://localhost:7239/api/Subscribers", content);

                if (response.IsSuccessStatusCode)
                {
                    ViewData["Status"] = "Success";
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
                {
                    ViewData["Status"] = "AlreadyExists";
                }
            }
            catch
            {
                ViewData["Status"] = "ConnectionFailed";
            }
        }
        else
        {
            ViewData["Status"] = "Invalid";
        }

        return View(viewModel);
    }


}
