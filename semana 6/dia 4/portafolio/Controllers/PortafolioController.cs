
using Microsoft.AspNetCore.Mvc;

namespace portafolio.Controllers;   
public class Portafolio : Controller  
{      
    [HttpGet] 
    [Route("")] 
    public string Index()        
    {            
    	return "This is my index";        
    }

    [HttpGet("projects")]   
    public string Projects(){
        return "These are my projects";
    }  

    [HttpGet("contact")]   
    public string Contact(){
        return "This is my contact";
    }

    [HttpGet("variable/{nombre}/{apellido}")]   
    public string Variables(string nombre,string apellido)
    {
        return $"Las variables son {nombre} y {apellido}";
    }

}

