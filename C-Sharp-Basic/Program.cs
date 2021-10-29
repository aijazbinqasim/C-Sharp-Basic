using System;
using C_Sharp_Basic.classes;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace C_Sharp_Basic
{
    class Program
    {
        static void Main(string[] args)
        {

            ICalculator calculator = new Calculator();

            calculator.Add(100,200);

            Console.WriteLine(calculator.Multiply(5, 4));

            IList<Person> persons = new List<Person>()
            {
               new Person() { Id = 1, Name = "Aijaz Ali", Age = 31},
               new Person() { Id = 2, Name = "Farooque", Age = 20},
               new Person() { Id = 3, Name = "Ali", Age = 22},
               new Person() { Id = 4, Name = "Khan", Age = 30}
            };

            ////LINQ query syntax same as SQL SELECT clause...
            //var names = (from p in persons
            //            where p.Age < 31
            //            select p).ToList();

            // LINQ method (short) syntax
            //var names = persons.Where(x => x.Name.Contains("Khan") || x.Name.Contains("Farooque"));
            // Console.WriteLine(name);


            //foreach (var p in names)
            //{
            //    Console.WriteLine($"ID: {p.Id} Name: {p.Name} Age: {p.Age}");
            //}

            //IList<string> list = new List<string>();
            //list.Add("Farooque");
            //list.Add("Behan");
            //list.Add("Hyd");
            //list.Add("Bcs");

            //IList<string> person = new List<string>()
            //{
            //    "Farooque",
            //    "Aijaz",
            //    "Umer",
            //    "Khan"
            //};

            //foreach(var p in person)
            //{
            //    Console.WriteLine(p);
            //}

            //ArrayList list = new ArrayList();

            //list.Add(1);
            //list.Add("Farooque");
            //list.Add(true);
            //list.Add(30000.00);

            //ArrayList list = new ArrayList()
            //{
            //     1,
            //     "Farooque",
            //     true,
            //     30000.00,
            //     null,
            //     1500,
            //     "Behan"
            //};


            //for (var count = 0; count < list.Count; count++)
            //{
            //    Console.WriteLine(list[count]);
            //}

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            // Console.WriteLine(list[1]);

            //  double l3 = (double) list[3];

            // Console.WriteLine(l3 + 2000);
            // following is called object initialer syntax
            //var php = new Book()
            //{
            //    Id = 1,
            //    Title = "Php",
            //    Price = 3000,
            //    Languages = new List<string>()
            //    {
            //        "English",
            //        "Urdu"
            //    }
            //};

            //var js = new Book()
            //{
            //    Id = 2,
            //    Title = "JavaScript",
            //    Languages = new List<string>()
            //    {
            //        "English",
            //        "Urdu",
            //        "Sindhi"
            //    }
            //};

            //Console.WriteLine("Book1: " + php.GetBookInfo());

            //Console.WriteLine("Book2: " + js.GetBookInfo());
        }
    }
}
