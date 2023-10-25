using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using CRUdelicioso.Models;

namespace CRUdelicioso.Controllers;

public class HomeController : Controller
{
    
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;
    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet] 
    [Route("")] 
    public IActionResult Index()
    {
        List<Dish> ListaDishes = _context.Dishes.ToList();
        return View("Index",ListaDishes);
    }

    [HttpGet] 
    [Route("/AddFish")] 
    public IActionResult AddFish()
    {
        
        return View("AddFish");
    }

    [HttpGet] 
    [Route("/InfoDish/{id}")] 
    public IActionResult InfoDish(int id)
    {
        Dish dishInfo = _context.Dishes.FirstOrDefault(dish => dish.DishId == id);
        return View("InfoDish",dishInfo);
    }

    [HttpGet] 
    [Route("/editDish/{DishId}")] 
    public IActionResult EditDish(int DishId)
    {
         Dish dishInfo = _context.Dishes.FirstOrDefault(dish => dish.DishId == DishId); 
         return View("EditDish",dishInfo);
           
    }

    public IActionResult Privacy()
    {
        return View();
    }


    [HttpPost("deleteDish/{DishId}")]
    public IActionResult DeleteDish(int DishId){
         Dish? dishToDelete = _context.Dishes.SingleOrDefault(i => i.DishId == DishId);
         _context.Dishes.Remove(dishToDelete);
         _context.SaveChanges();
         return RedirectToAction("Index");
    }

        [HttpPost("dishform")]
        public IActionResult DishForm(Dish dishes){
        if(ModelState.IsValid)    
        {  
            _context.Dishes.Add(dishes);
            _context.SaveChanges();
             return RedirectToAction("Index");
        }else
        {
            return  View("AddFish");
        }
    } 
    

    [HttpPost("editform/{DishId}")]
        public IActionResult EditForm(Dish newDish,int DishId){
        Dish? OldDish = _context.Dishes.FirstOrDefault(i => i.DishId == DishId);
        if(ModelState.IsValid)    
        {  
            OldDish.Name = newDish.Name;
            OldDish.Chef = newDish.Chef;
            OldDish.Tastiness = newDish.Tastiness;
            OldDish.Calories = newDish.Calories;
            OldDish.Description = newDish.Description;
            OldDish.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
             return RedirectToAction("Index");
        }else
        {

            return  View("EditDish",OldDish);
        }
    } 

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
