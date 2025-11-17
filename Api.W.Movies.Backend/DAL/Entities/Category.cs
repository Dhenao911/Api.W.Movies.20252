using System.ComponentModel.DataAnnotations;

namespace Api.W.Movies.Backend.DAL.Entities;

public class Category:AuditBase
{
    [Required(ErrorMessage = "El campo {0} es obligatorio")]//Este campo es obigatorio
    [Display(Name="Category Name")]//Nombre de la categoria
    [StringLength(100,ErrorMessage ="El campo {0} tiene un maximo de {1} caracteres")]//Maximo de caracteres
    public string Name { get; set; }
}