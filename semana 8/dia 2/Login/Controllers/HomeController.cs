using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Identity;
using Login.Models;
namespace Login.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;
    public HomeController(ILogger<HomeController> logger,MyContext context)
    {
        _logger = logger;
        _context = context;
    }
    
    public IActionResult Index()
    {
        return View("Index");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet("logout")]
    public IActionResult Logout(){
         HttpContext.Session.Clear();
         return RedirectToAction("Index");
    }

    [HttpPost("users/create")]
    public IActionResult Method(User newUser)
    {
        if (ModelState.IsValid)
        {
            // Initializing a PasswordHasher object, providing our User class as its type            
            PasswordHasher<User> Hasher = new PasswordHasher<User>();
            // Updating our newUser's password to a hashed version         
            newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
            //Save your user object to the database 
            _context.Add(newUser);
            _context.SaveChanges();
            HttpContext.Session.SetString("Email", newUser.Email);
            return RedirectToAction("Index");
        }
        else
        {
           return RedirectToAction("Index");
        }
    }

    [HttpPost]
    [Route("procesa/login")]
    public IActionResult Login(LoginUser userSubmission)
    {
        if (ModelState.IsValid)
        {
            // If initial ModelState is valid, query for a user with the provided email        
            User? userInDb = _context.User.FirstOrDefault(u => u.Email == userSubmission.Email);
            // If no user exists with the provided email        
            if (userInDb == null)
            {
                // Add an error to ModelState and return to View!            
                ModelState.AddModelError("Email", "Invalid Email/Password");
                return View("Index");
            }
            // Otherwise, we have a user, now we need to check their password                 
            // Initialize hasher object        
            PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
            // Verify provided password against hash stored in db        
            var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);                                    // Result can be compared to 0 for failure        
            if (result == 0)
            {
                ModelState.AddModelError("Email", "Invalid Email/Password");
                return View("Index");
            }
            HttpContext.Session.SetString("Email", userSubmission.Email);
            return View("Index");
        }
        else
        {
            return View("Index");
        }
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

// Name this anything you want with the word "Attribute" at the end


