using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using PROJECTITI.Context;
using PROJECTITI.Models;

namespace PROJECTITI.Controllers
{
    public class UserController : Controller
    {
        MyContext Db = new MyContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            ModelState.Remove("FirstName");
            ModelState.Remove("LastName");
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "All Fields Requird");
                return View(user);
            }

            var _User =Db.Users.FirstOrDefault(u=>u.Email== user.Email&&u.Password==user.Password);

            if (_User==null)
            {
                ModelState.AddModelError("", "Email Or Passwod Incorrect");

          //      Console.WriteLine(user.Email+" "+user.Password);
                return View(user);
            }

            return RedirectToAction("index", "product");
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag._product = new SelectList(Db.Users, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "All Fields Required");
                return View("Create");
                    
            }
            var _User = Db.Users.FirstOrDefault(u => u.Email == user.Email);

            if (_User == null)
            {
                Db.Users.Add(user);
                Db.SaveChanges();
                return RedirectToAction("Login", "User");

            }

            ModelState.AddModelError("", "This Email Is Already Uesd");
            return View();

        }
    }
}
/*

@model Final_project.Models.User

<h2>Login</h2>

<form asp-action="Login" method="post">
    <div class="form-group">
        <label asp-for="Email"></label>
        <input asp-for="Email" class="form-control" />
        <span asp-validation-for="Email" class="text-danger"></span>
    </div>
    <div class="form-group">
        <label asp-for="Password"></label>
        <input asp-for="Password" type="password" class="form-control" />
        <span asp-validation-for="Password" class="text-danger"></span>
    </div>

    <div class="form-group">
        @* <input type="submit" value="Login" class="btn btn-primary" />*@
        <a asp-controller="Product" asp-action="Index">login</a>
    </div>
   <a asp-controller="User" asp-action="Register">Register</a> 
    
</form>

<script src="~/lib/jquery-validation/dist/jquery.validate.min.js"></script>
<script src="~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"></script*/