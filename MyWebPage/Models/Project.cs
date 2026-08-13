using System.ComponentModel.DataAnnotations;

namespace MyWebPage.Models;

public class Project
{
    public int Id { get; set; }

    [Display(Name = "Название")]
    [Required(ErrorMessage = "Введите название")]
    [StringLength(100)]
    public required string Title { get; set; }

    [Display(Name = "Описание")]
    [Required(ErrorMessage = "Введите описание")]
    [StringLength(1000)]
    public required string Description { get; set; }

    [Display(Name = "Технологии")]
    [StringLength(200)]
    public string? TechStack { get; set; }

    [Display(Name = "Ссылка на проект")]
    [StringLength(300)]
    public string? Url { get; set; }

    [Display(Name = "Иконка")]
    [StringLength(10)]
    public string? Icon { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
