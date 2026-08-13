using System.ComponentModel.DataAnnotations;
namespace MyWebPage.Models;

    public class Feedback
{
    [Display(Name = "Введите Имя")]
    [Required(ErrorMessage = "Вам нужно ввести имя")]
    
    public string Name { get; set; }

    [Display(Name = "Введите Фамилию")]
    [Required(ErrorMessage = "Вам нужно ввести фамилию")]
     public string Surname { get; set; }

     [Display(Name = "Укажите возраст")]
     [Required(ErrorMessage = "Вам нужно ввести возраст")]
     public int Age { get; set; }

    [Display(Name = "Укажите почту")]
    [Required(ErrorMessage = "Вам нужно ввести почту")]
    public string Email { get; set; }

    [Display(Name = "Укажите коммент")]
    [Required(ErrorMessage = "Вам нужно ввести фидбек")]
    [StringLength(30,ErrorMessage = "Текст не менее 30 символов")]
     public string Message { get; set; }

}
