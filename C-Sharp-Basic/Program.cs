using System;
using C_Sharp_Basic.classes;
using System.Collections.Generic;
using System.Collections;

namespace C_Sharp_Basic
{
    class Program
    {
        static void Main(string[] args)
        {

            //IList<string> list = new List<string>();
            //list.Add("Farooque");
            //list.Add("Behan");
            //list.Add("Hyd");
            //list.Add("Bcs");

            IList<string> person = new List<string>()
            {
                "Farooque",
                "Aijaz",
                "Umer",
                "Khan"
            };
            
            foreach(var p in person)
            {
                Console.WriteLine(p);
            }

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
