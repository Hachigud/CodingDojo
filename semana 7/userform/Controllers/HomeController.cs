using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using userform.Models;

namespace userform.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet] 
    [Route("/")] 
    public IActionResult Index()
    {
        return View("Index");
    }

    [HttpGet] 
    [Route("privacy")] 
    public IActionResult Privacy()
    {
        return View("Privacy");
    }

    [HttpGet("datos")]
    public IActionResult Datos(Usuario usuario){
        return View("Datos",usuario);
    }


    [HttpPost("userform")]
    public IActionResult UserForm(Usuario usuario){
        if(ModelState.IsValid)    
        {  
             return RedirectToAction("Datos",usuario);
        }else
        {
            return  View("Index");
        }
    } 


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
