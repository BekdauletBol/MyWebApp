using System.ComponentModel.DataAnnotations;

namespace MyWebPage.Models;

public class BlogPost
{
    public int Id { get; set; }

    [Display(Name = "Заголовок")]
    [Required(ErrorMessage = "Введите заголовок")]
    [StringLength(200)]
    public required string Title { get; set; }

    [Display(Name = "Краткое описание")]
    [Required(ErrorMessage = "Введите описание")]
    [StringLength(300)]
    public required string Summary { get; set; }

    [Display(Name = "Текст статьи")]
    [Required(ErrorMessage = "Введите текст")]
    public required string Content { get; set; }

    [Display(Name = "Тег")]
    [StringLength(50)]
    public string? Tag { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}
