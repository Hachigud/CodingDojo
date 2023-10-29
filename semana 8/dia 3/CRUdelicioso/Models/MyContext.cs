#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace CRUdelicioso.Models;


public class MyContext : DbContext 
{   
    public DbSet<Dish> Dishes { get; set; }  
    public MyContext(DbContextOptions options) : base(options) { }    


  
}
