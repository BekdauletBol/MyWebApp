using MyWebPage.Models;

namespace MyWebPage.Data;

public static class SeedData
{
    public static void Initialize(AppDbContext context)
    {
        if (context.Projects.Any())
            return;

        context.Projects.AddRange(
            new Project
            {
                Title = "Portfolio Website",
                Description = "Персональный сайт-портфолио с тёмным дизайном, адаптивной вёрсткой и формой обратной связи.",
                TechStack = "ASP.NET Core, SQLite, HTML/CSS",
                Icon = "&#127760;"
            },
            new Project
            {
                Title = "Task Manager",
                Description = "Приложение для управления задачами с авторизацией, приоритетами и дедлайнами.",
                TechStack = "ASP.NET Core, Entity Framework, Identity",
                Icon = "&#128203;"
            },
            new Project
            {
                Title = "Weather App",
                Description = "Погодное приложение с геолокацией и прогнозом на 7 дней.",
                TechStack = "C#, OpenWeather API, JSON",
                Icon = "&#9925;"
            },
            new Project
            {
                Title = "Chat Application",
                Description = "Реалтайм чат с комнатами и историей сообщений.",
                TechStack = "ASP.NET Core, SignalR, SQLite",
                Icon = "&#128172;"
            }
        );

        context.BlogPosts.AddRange(
            new BlogPost
            {
                Title = "Как я начинал изучать C#",
                Summary = "Мой путь в мир backend-разработки: от первого Hello World до полноценного приложения.",
                Content = "Начало пути в программировании — это всегда волнительно. Я вспоминаю свой первый проект на C#, когда написал консольное приложение и был в восторге, что оно работает.\n\nПрошли месяцы, и я перешёл от консольных приложений к ASP.NET Core. MVC-паттерн показался сложным, но когда я понял логику — контроллер, модель, вид — всё встало на свои места.\n\nСейчас я работаю над полноценными проектами с базой данных, валидацией и красивым дизайном. Каждый проект учит чему-то новому.",
                Tag = "C#"
            },
            new BlogPost
            {
                Title = "Entity Framework Core для начинающих",
                Summary = "Разбираемся как работает ORM и зачем он нужен в ASP.NET Core приложении.",
                Content = "Entity Framework Core — это ORM (Object-Relational Mapper) от Microsoft. Он позволяет работать с базой данных используя C# объекты вместо SQL-запросов.\n\nОсновные концепции:\n- DbContext — главный класс, связывающий приложение с базой\n- DbSet<T> — коллекция сущностей определённого типа\n- Миграции — способ изменения структуры базы данных\n\nС EF Core вы можете добавлять, обновлять и удалять данные обычными методами C#, а фреймворк сам генерирует SQL.",
                Tag = "ASP.NET"
            },
            new BlogPost
            {
                Title = "CSS-переменные и тёмная тема",
                Summary = "Как создать красивый тёмный дизайн используя CSS Custom Properties.",
                Content = "CSS-переменные (Custom Properties) — мощный инструмент для создания консистентного дизайна. Объявляются через -- и используются через var().\n\nПример:\n--bg: #11110f;\n--accent: #ff6b35;\n\nbody { background: var(--bg); }\n\nПреимущества:\n- Единая точка управления цветами\n- Легко менять тему\n- Поддержка вложенности\n- Работают с media queries для адаптивности",
                Tag = "CSS"
            }
        );

        context.SaveChanges();
    }
}
