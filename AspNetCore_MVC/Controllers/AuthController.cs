namespace WepApp.Controllers;

public class AuthController(ApplicationContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager) : Controller
{
    private readonly ApplicationContext _context = context;
    private readonly UserManager<ApplicationUser> _userManager = userManager;
    private readonly SignInManager<ApplicationUser> _signInManager = signInManager;


    #region SIGNIN

    [HttpGet]
    [Route("/signin")]
    public IActionResult SignIn()
    {
        var viewModel = new SignInViewModel();
        return View(viewModel);
    }


    [HttpPost]
    [Route("/signin")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> SignIn(SignInViewModel model)
    {
        if (ModelState.IsValid)
        {
            var applicationUser = await _userManager.FindByEmailAsync(model.Form.Email);
            if (applicationUser != null)
            {
                var result = await _signInManager.PasswordSignInAsync(applicationUser, model.Form.Password, model.Form.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Account");
                }
            }
        }

        ViewData["StatusMessage"] = "Incorrect email or password";
        return View(model);
    }
    #endregion



    #region SIGNUP

    [Route("/signup")]
    [HttpGet]
    public IActionResult SignUp()
    {
        var viewModel = new SignUpViewModel();
        return View(viewModel);
    }

    [HttpPost]
    [Route("/signup")]
    public async Task<IActionResult> SignUp(SignUpViewModel model)
    {
        if (ModelState.IsValid)
        {
            if (!await _context.Users.AnyAsync(x => x.Email == model.Form.Email))
            {
                var applicationUser = new ApplicationUser
                {
                    FirstName = model.Form.FirstName,
                    LastName = model.Form.LastName,
                    Email = model.Form.Email,
                    UserName = model.Form.Email
                };

                var result = await _userManager.CreateAsync(applicationUser, model.Form.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn", "Auth");
                }
                else
                {
                    ViewData["StatusMessage"] = "Something went wrong. Try again later";
                }
            }
            else
            {
                ViewData["StatusMessage"] = "User with same email already exists";
            }

        }

        return View(model);
    }


    #endregion


    public new async Task<IActionResult> SignOut()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }

}
