using System;
using POO_EXERCICIO.ContentContext;

namespace POO_EXERCICIO
{
    class Program
    {
        static void Main (string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre CSHARP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre ASPNET", "orientacao-objetos"));

            foreach (var article in articles )
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }
        }
    }
}