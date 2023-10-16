using Microsoft.AspNetCore.Mvc;
namespace divertido.Controllers;   

public class Divertido : Controller
{

    [HttpGet] 
    [Route("")] 
      public ViewResult Index()        
    {            
    	return View("Index");        
    }
}