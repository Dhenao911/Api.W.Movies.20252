using System.ComponentModel.DataAnnotations;

namespace Api.W.Movies.Backend.DAL.Entities.Dtos
{
    public class CategoryDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} tiene un maximo de {1} caracteres")]
        public string Name { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}