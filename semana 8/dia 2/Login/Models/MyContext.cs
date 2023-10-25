#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace Login.Models;


public class MyContext : DbContext 
{   
    public DbSet<User> User { get; set; }  
    public MyContext(DbContextOptions options) : base(options) { }    


  
}
