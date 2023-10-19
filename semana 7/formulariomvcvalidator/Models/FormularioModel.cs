#pragma warning disable CS8618
namespace formulariomvcvalidator.Models;
using System.ComponentModel.DataAnnotations;
public class Formulario
{
    [Required(ErrorMessage="El campo Nombre es requerido")]
    [MinLength(3, ErrorMessage="El nombre debe contener 3 o mas caracteres")]
    public string Nombre {get;set;}

    [Required(ErrorMessage="El campo Dojo es requerido")]
    public string Dojo {get;set;}

    [Required(ErrorMessage="El campo Lenguaje favorito es requerido")]
    public string Lenguaje {get;set;}

    [MinLength(20, ErrorMessage="El comentario debe contener 20 o mas caracteres")]
    public string? Comentario {get;set;}

    [FutureDate]
    public string Fecha {get;set;}
}