
using Microsoft.AspNetCore.Mvc;

namespace fechas.Controllers;   

public class Fechas : Controller{


    [HttpGet] 
    [Route("")] 
      public ViewResult Index()        
    {           
        DateTime hoy = DateTime.Now; 
        ViewBag.hoy = hoy;
        string hoyForm = hoy.ToLongDateString();
        ViewBag.hoyFormat = hoyForm;
        DateTime fin = new DateTime(2023,12,31,17,30,00); 
        string finForm = fin.ToLongDateString();
        ViewBag.fin = fin;
        ViewBag.finFormat = finForm;

        TimeSpan difFechas =  fin - hoy ;
        ViewBag.diferencia = difFechas;
        return View("Index");        
    }

}