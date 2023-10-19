using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using formulariomvcvalidator.Models;

namespace formulariomvcvalidator.Controllers;

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




    [HttpGet] 
    [Route("datos")]
    public IActionResult Datos(Formulario formulario){
        return View("Datos",formulario);
    }

    [HttpPost("formulario")]
    public IActionResult formulario (Formulario formulario){
        if(ModelState.IsValid)    
        {  
             return RedirectToAction("Datos",formulario);
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
