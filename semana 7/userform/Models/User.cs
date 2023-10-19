#pragma warning disable CS8618
namespace userform.Models;
using System.ComponentModel.DataAnnotations;

public class Usuario{

   [Required(ErrorMessage="El campo Nombre es requerido")]
   [MinLength(3, ErrorMessage="El Nombre debe contener 4 o mas caracteres")]
    public string Nombre{get;set;}

    [Required(ErrorMessage="El Apellido es requerido")]
    [MinLength(3, ErrorMessage="El Apellido debe contener 3 o mas caracteres")]
    public string Apellido{get;set;}

    [Required(ErrorMessage="El campo Edad es requerido")]
    [PositiveNumber]
    public int Edad {get;set;}

    [Required(ErrorMessage="El campo Email es requerido")]
    [EmailAddress]  
    public string Email {get;set;}


    [Required(ErrorMessage="El campo Passworrd es requerido")]
    [MinLength(8, ErrorMessage="La contraseña debe contener 8 o mas caracteres")]
    public string Password {get;set;}
}