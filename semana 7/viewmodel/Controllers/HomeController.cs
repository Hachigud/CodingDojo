using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using viewmodel.Models;

namespace viewmodel.Controllers;

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
        string cadena = "Hola esto es desde mi controlador";
        return View("Index",cadena);
    }

    [HttpGet] 
    [Route("/privacy")]
    public IActionResult Privacy()
    {
        return View("Privacy");
    }

    
    [HttpGet] 
    [Route("numbers")]   
    public IActionResult Numbers()
    {
        int[] numeros = {1,2,3,4,5,45};
        return View("Numbers",numeros);
    }


    [HttpGet] 
    [Route("usuarios")]   
    public IActionResult Usuarios()
    {
        List<Usuario> usuarios = new List<Usuario>();
        Usuario usuario1 = new Usuario(){Nombre ="Juan", Apellido = "Aburto"};
        Usuario usuario2 = new Usuario(){Nombre ="Pedro", Apellido = "Pazcal"};
        Usuario usuario3 = new Usuario(){Nombre ="Matias"};
        Usuario usuario4 = new Usuario(){Nombre ="Maria", Apellido = "Juana"};
        usuarios.Add(usuario1);
        usuarios.Add(usuario2);
        usuarios.Add(usuario3);
        usuarios.Add(usuario4);
        return View("Usuarios",usuarios);
    }

    [HttpGet] 
    [Route("usuario")]   
      public IActionResult Usuario()
    {   
        Usuario usuario = new Usuario(){Nombre ="Juan", Apellido = "Aburto"};
        return View("Usuario",usuario);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
