using coreFormsAndValidations.Models;
using Microsoft.AspNetCore.Mvc;

namespace AccountsViewController;

public class AccountController : Controller
{
    public IActionResult StronglyTypedLogin()
    {
        return View();
    }
    [HttpPost]
    public IActionResult LoginSuccess()
    {
        return View();
    }
    public IActionResult UserDetail()
    {
        var user = new LoginViewModel() { Username = "Zack", Password = "pass1234" };
        return View(user);
    }
}