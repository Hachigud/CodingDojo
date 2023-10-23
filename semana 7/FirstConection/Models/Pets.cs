#pragma warning disable CS8618
namespace FirstConection.Models;
using System.ComponentModel.DataAnnotations;

public class Pets{
    [Key]
    public int id {get;set;}
    public string Nombre {get;set;}
    public string Tipo {get;set;}
    public bool Pelo {get;set;}
}