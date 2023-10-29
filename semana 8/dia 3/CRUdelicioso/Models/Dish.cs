#pragma warning disable CS8618
namespace CRUdelicioso.Models;
using System.ComponentModel.DataAnnotations;

public class Dish{
    [Key]
    public int DishId {get;set;}

    [Required(ErrorMessage="El campo Nombre es requerido")]
    [MinLength(3, ErrorMessage="El Nombre debe contener 4 o mas caracteres")]
    public string Name  {get;set;}

    [Required(ErrorMessage="El campo Chef es requerido")]
    [MinLength(3, ErrorMessage="El Chef debe contener 4 o mas caracteres")]
    public string Chef  {get;set;}


    [Required(ErrorMessage="El campo Tastiness es requerido")]
    [UnoCinco]
    public int Tastiness  {get;set;}

    [Required(ErrorMessage="El campo Calories es requerido")]
    [PositiveNumber]
    public int Calories  {get;set;}

    [Required(ErrorMessage="El campo Description es requerido")]
    public string Description  {get;set;}


    public DateTime CreatedAt  {get;set;} = DateTime.Now;
    public DateTime UpdatedAt  {get;set;} = DateTime.Now;
    
}