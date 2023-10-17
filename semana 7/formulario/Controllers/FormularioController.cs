
using Microsoft.AspNetCore.Mvc;

namespace formulario.Controllers;   

public class Formulario : Controller{

    [HttpGet] 
    [Route("")] 
      public ViewResult Index()        
    {            
    return View("Index");        
    }


    [HttpGet] 
    [Route("datos")]
    public IActionResult Datos(string nombre,string dojo,string lenguaje,string comentario){
        ViewBag.nombre = nombre;
        ViewBag.dojo = dojo;
        ViewBag.lenguaje = lenguaje;
        ViewBag.comentario = comentario;

        return View("Datos");
    }

    [HttpPost("formulario")]
    public IActionResult formulario (string Nombre,string Dojo,string Lenguaje,string Comentario){

        return RedirectToAction("Datos",new{nombre = Nombre, dojo = Dojo,lenguaje = Lenguaje, comentario=Comentario});
    }



}