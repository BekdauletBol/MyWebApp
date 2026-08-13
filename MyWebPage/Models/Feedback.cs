using System.ComponentModel.DataAnnotations;

namespace MyWebPage.Models;

public class Feedback
{
    public int Id { get; set; }

    [Display(Name = "Имя")]
    [Required(ErrorMessage = "Введите имя")]
    public required string Name { get; set; }

    [Display(Name = "Фамилия")]
    [Required(ErrorMessage = "Введите фамилию")]
    public required string Surname { get; set; }

    [Display(Name = "Возраст")]
    [Required(ErrorMessage = "Укажите возраст")]
    [Range(1, 120, ErrorMessage = "Некорректный возраст")]
    public int Age { get; set; }

    [Display(Name = "Почта")]
    [Required(ErrorMessage = "Укажите почту")]
    [EmailAddress(ErrorMessage = "Некорректный email")]
    public required string Email { get; set; }

    [Display(Name = "Сообщение")]
    [Required(ErrorMessage = "Напишите сообщение")]
    [StringLength(500, ErrorMessage = "Максимум 500 символов")]
    public required string Message { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
