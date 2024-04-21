using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace WepApp.Controllers;


[Authorize]
public class AccountController : Controller
{

    private readonly IHostingEnvironment _host;
    private readonly UserManager<ApplicationUser> _userManager;
    public AccountController(UserManager<ApplicationUser> userManager, IHostingEnvironment host)
    {
        _userManager = userManager;
        _host = host;
    }


    public IActionResult Index()
    {
        return RedirectToAction("Details", "Account");
    }




    //go to account Details
    //   [Route("/")]
    public async Task<IActionResult> Details()
    {
        // Retrieve the current user
        ApplicationUser user = await _userManager.GetUserAsync(User);

        // Pass the user model to the view
        return View(user);
    }







    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> UpdateDetailsInfo(ApplicationUser model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var currentUser = await _userManager.GetUserAsync(User);
        currentUser.FirstName = model.FirstName;
        currentUser.LastName = model.LastName;
        currentUser.Email = model.Email;
        currentUser.Phone = model.Phone;
        currentUser.Bio = model.Bio;
        currentUser.AddressLine1 = model.AddressLine1;
        currentUser.AddressLine2 = model.AddressLine2;
        currentUser.City = model.City;
        currentUser.Postalcode = model.Postalcode;

        // Check if a file is uploaded
        if (model.ProfileImage != null)
        {
            string uploadPath = Path.Combine(_host.WebRootPath, "images\\ProfileImage");
            string fileName = Path.GetFileName(model.ProfileImage.FileName);
            string fullPath = Path.Combine(uploadPath, fileName);

            // Save the uploaded file
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                await model.ProfileImage.CopyToAsync(stream);
            }

            // Update the ImagePath property with the path to the image
            currentUser.ImagePath = "/images/ProfileImage/" + fileName; // Adjust this path as needed
        }

        await _userManager.UpdateAsync(currentUser);

        return RedirectToAction("Details");
    }





    //[HttpPost]
    //[ValidateAntiForgeryToken]

    //public async Task<IActionResult> UpdateDetailsInfo(ApplicationUser model)
    //{
    //    if (!ModelState.IsValid)
    //    {
    //        return View(model);
    //    }

    //    var currentUser = await _userManager.GetUserAsync(User);
    //    currentUser.FirstName = model.FirstName;
    //    currentUser.LastName = model.LastName;
    //    currentUser.Email = model.Email;
    //    currentUser.Phone = model.Phone;
    //    currentUser.Bio = model.Bio;
    //    currentUser.AddressLine1 = model.AddressLine1;
    //    currentUser.AddressLine2 = model.AddressLine2;
    //    currentUser.City = model.City;
    //    currentUser.Postalcode = model.Postalcode;

    //    await _userManager.UpdateAsync(currentUser);

    //    return RedirectToAction("Details");

    //}





    //public IActionResult Details()
    //{
    //    // var viewModel = new AccountDetailsViewModel();

    //   var viewModel = new ApplicationUser();


    //    return View(viewModel);
    //}


    //[HttpPost]
    //public IActionResult BasicInfo(AccountDetailsViewModel viewModel)
    //{
    //  //  _accountService.SaveBasicInfo(viewModel.BasicInfo);
    //    return RedirectToAction(nameof(Details));
    //}


    //[HttpPost]
    //public IActionResult AddressInfo(AccountDetailsViewModel viewModel)
    //{
    //    //  _accountService.SaveAddressInfo(viewModel.AddressInfo);
    //    return RedirectToAction(nameof(Details));
    //}

}
