#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace FirstConection.Models;


public class MyContext : DbContext 
{   
      public DbSet<Pets> Pet { get; set; }  
    public MyContext(DbContextOptions options) : base(options) { }    


  
}
