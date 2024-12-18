using System;
using System.Net.Http.Headers;
using POO_EXERCICIO.ContentContext;
using POO_EXERCICIO.NotificationContext;

// https://github.com/andrebaltieri/flunt   <----- pacote de código que faz o trabalho de notificação

namespace POO_EXERCICIO
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre CSHARP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre ASPNET", "orientacao-objetos"));

            // foreach (var article in articles )
            // {
            //     Console.WriteLine(article.Id);
            //     Console.WriteLine(article.Title);
            //     Console.WriteLine(article.Url);
            // }

            var Courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "Fundamentos-OOP");
            var courseCSHARP = new Course("Fundamentos CSHARP", "Fundamentos-CSHARP");
            var courseASPNET = new Course("Fundamentos ASPNET", "Fundamentos-ASPNET");
            Courses.Add(courseOOP);
            Courses.Add(courseCSHARP);
            Courses.Add(courseASPNET);

            

            var careers = new List<Career>();
            var careerDOTNET = new Career("especialista em .NET", "especialista DEVOPS-DOTNET");
            var careerItem2 = new CareerItem(2, "Aprenda DOTNET", "", courseASPNET);
            var careerItem = new CareerItem(1, "Comece por Aqui", "", courseCSHARP);
            var careerItem3 = new CareerItem(3, "Aprenda OOP  ", "", null);
            careerDOTNET.Items.Add(careerItem2);
            careerDOTNET.Items.Add(careerItem);
            careerDOTNET.Items.Add(careerItem3);
            careers.Add(careerDOTNET);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderByDescending(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }
        }
    }
}
