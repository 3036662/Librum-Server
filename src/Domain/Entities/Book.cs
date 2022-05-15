using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Book
{
    [Key]
    public int BookId { get; set; }

    [Required]
    [MinLength(4, ErrorMessage = "The provided book name is too short")]
    [MaxLength(120, ErrorMessage = "The provided book name is too long")]
    public string Title { get; set; }

    public DateTime ReleaseDate { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int Pages { get; set; }

    [Required]
    [MaxLength(40, ErrorMessage = "The provided book format name is too long")]
    public string Format { get; set; }
    
    [Required]
    public string DataLink { get; set; }
    
    [Required]
    [Range(0, int.MaxValue)]
    public int CurrentPage { get; set; }
    

    public ICollection<Author> Authors { get; set; }
    
    [MaxLength(128), ForeignKey("User")]
    public string UserId { get; set; }
    public User User { get; set; }
}