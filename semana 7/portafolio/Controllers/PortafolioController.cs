
using Microsoft.AspNetCore.Mvc;

namespace portafolio.Controllers;   
public class Portafolio : Controller  
{      
    [HttpGet] 
    [Route("")] 
      public ViewResult Index()        
    {            
    return View("Index");        
    }

    [HttpGet] 
    [Route("projects")]   
    public ViewResult Projects()
    {
        Proyectos proyecto1 = new Proyectos("Proyecto 1","proyecto1","Este fue el proyecto 1");
        Proyectos proyecto2 = new Proyectos("Proyecto 2","proyecto1","Este fue el proyecto 2");
        Proyectos proyecto3 = new Proyectos("Proyecto 3","proyecto1","Este fue el proyecto 3");
        Proyectos proyecto4 = new Proyectos("Proyecto 4","proyecto1","Este fue el proyecto 4");
        Proyectos proyecto5 = new Proyectos("Proyecto 5","proyecto1","Este fue el proyecto 5");
        List<Proyectos> proyectos = new List<Proyectos>();
        proyectos.Add(proyecto1);
        proyectos.Add(proyecto2);
        proyectos.Add(proyecto3);
        proyectos.Add(proyecto4);
        proyectos.Add(proyecto5);
        var contenido = "";
        foreach(Proyectos proye in proyectos){
            contenido += @"<div class='contenidoListaProyectos'> <div class='imgProyectos'> <img class='imagenProyecto' src='/img/"+proye.Imagen+".jpg' alt='"+proye.NombreProyecto+"'></div>";
            contenido += "<div class='detallesProyectos'> <h3 class='tituloproyecti'>"+proye.NombreProyecto+"</h3>";
            contenido +="<p class='descripcionProyecto'>"+proye.Descripcion+"</p>  </div>  </div> " ;
        }
        
        ViewBag.content = contenido;
        
        return View("Projects");
    }  

    [HttpGet("contact")]   
    public ViewResult Contact(){
        return View("Contact");
    }
}




public class Proyectos{
    public string NombreProyecto;
    public string Imagen;
    public string Descripcion;



    public Proyectos(string NombreProyecto, string Imagen, string Descripcion){
        this.NombreProyecto = NombreProyecto;
        this.Imagen=Imagen;
        this.Descripcion = Descripcion;
    }

    public string _NombreProyecto
        {
            get { return NombreProyecto; }
            set { NombreProyecto = value; }
        }

    public string _Imagen
        {
            get { return Imagen; }
            set { Imagen = value; }
        }

      public string _Descripcion
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
}