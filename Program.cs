using System;
using POO_EXERCICIO.ContentContext;

namespace POO_EXERCICIO
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Hello World!");
            var career = new Career();
            career.Items.Add(new CareerItem());
            Console.WriteLine(career.TotalCourses);
        }
    }
}