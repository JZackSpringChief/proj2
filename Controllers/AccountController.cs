using Microsoft.AspNetCore.Mvc;

namespace AccountsViewController;

public class AccountController : Controller
{
    public IActionResult StronglyTypedLogin()
    {
        return View();
    }
}