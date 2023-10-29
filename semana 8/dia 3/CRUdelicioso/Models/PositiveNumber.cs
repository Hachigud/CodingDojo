namespace CRUdelicioso.Models;
using System.ComponentModel.DataAnnotations;

public class PositiveNumberAttribute : ValidationAttribute
{
   int result;
  
  
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
     
      result = Convert.ToInt32(value);
     
      if(result <= 0){
        return new ValidationResult("Las calorias deben ser mayores a 0");  
      }else{
        return ValidationResult.Success;  
      }
    }
}



public class UnoCincoAttribute : ValidationAttribute
{
   int result;
  
  
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
     
      result = Convert.ToInt32(value);
     
      if(result < 1 || result > 5){
        return new ValidationResult("Debe ser entre 1 y 5");  
      }else{
        return ValidationResult.Success;  
      }
    }
}