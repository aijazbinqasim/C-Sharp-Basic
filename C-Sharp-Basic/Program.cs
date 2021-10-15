using System;
using C_Sharp_Basic.classes;
using System.Collections.Generic;

namespace C_Sharp_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            // following is called object initialer syntax
            var php = new Book()
            {
                Id = 1,
                Title = "Php",
                Price = 3000,
                Languages = new List<string>()
                {
                    "English",
                    "Urdu"
                }
            };

            var js = new Book()
            {
                Id = 2,
                Title = "JavaScript",
                Languages = new List<string>()
                {
                    "English",
                    "Urdu",
                    "Sindhi"
                }
            };

            Console.WriteLine("Book1: " + php.GetBookInfo());

            Console.WriteLine("Book2: " + js.GetBookInfo());
        }
    }
}
