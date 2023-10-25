#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace Login.Models;

public class LoginUser
{
    // No other fields!
    [Required]    
    public string Email { get; set; }    
    [Required]    
    public string Password { get; set; } 
}
