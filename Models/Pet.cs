using System.ComponentModel.DataAnnotations;

namespace l10_assignment.Models;

public class Pet 
{
    public int PetId { get; set; }
    [Required]
    public string? PetName { get; set; }
    [Required]
    public string? Type { get; set; }
    [Required]
    public string? Description { get; set; }
}
