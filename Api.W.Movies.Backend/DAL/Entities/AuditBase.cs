using System.ComponentModel.DataAnnotations;

namespace Api.W.Movies.Backend.DAL.Entities;

public class AuditBase
{
    [Key]
    public int Id { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime ModifiedDate { get; set; } 
}