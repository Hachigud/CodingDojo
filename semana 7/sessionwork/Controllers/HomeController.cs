using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using sessionwork.Models;

namespace sessionwork.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("/")]
    public IActionResult Index()
    {
        return View("Index");
    }

    [HttpGet("privacy")]
    public IActionResult Privacy()
    {
        return View("Privacy");
    }

    [HttpGet("datos")]
    public IActionResult Datos()
    {
        if(HttpContext.Session.GetString("UserName") != null){
        ViewBag.numero = 22;
        return View("datos");
        }else
        {
            return RedirectToAction("Index");
        }
        
    }

    [HttpPost("formulario")]
    public IActionResult Formulario(Usuario usuario){
       
        if(ModelState.IsValid)    
        {  
             HttpContext.Session.SetString("UserName", usuario.Nombre);
             return RedirectToAction("Datos");
        }else
        {
            return  View("Index");
        }
    }

    [HttpGet("logout")]
    public IActionResult Logout(){
         HttpContext.Session.Clear();
         return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
