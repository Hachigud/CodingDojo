namespace userform.Models;
using System.ComponentModel.DataAnnotations;

public class PositiveNumberAttribute : ValidationAttribute
{
   int result;
  
  
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
     
      result = Convert.ToInt32(value);
     
      if(result <= 0){
        return new ValidationResult("La edad debe ser un numero positivo");  
      }else{
        return ValidationResult.Success;  
      }
    }
}

