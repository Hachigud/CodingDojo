namespace formulariomvcvalidator.Models;
using System.ComponentModel.DataAnnotations;

public class FutureDateAttribute : ValidationAttribute
{
   
    static string date = DateTime.UtcNow.ToString("yyyy-MM-dd");
    DateTime hoy = DateTime.Parse(date);
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
     
      DateTime fechaSelect = Convert.ToDateTime(value);
      if(fechaSelect >= hoy){
        return new ValidationResult("La fecha no puede ser superior a la de hoy");  
      }else{
        return ValidationResult.Success;  
      }
    }
}

