#pragma warning disable CS8618
namespace sessionwork.Models;
using System.ComponentModel.DataAnnotations;


public class Usuario {
    [Required(ErrorMessage="El campo Nombre es requerido")]
    [MinLength(3, ErrorMessage="El Nombre debe contener 4 o mas caracteres")]
    public string Nombre{get; set;}

}