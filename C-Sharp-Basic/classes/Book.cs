using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic.classes
{
    class Book
    {
        // method overloading => compile time polymorphisim
        // method overriding => runtime polymorphisim
        public int Id { get; set; }
        public string Title { get; set; }
        public IList<string> Languages { get; set; }
        public decimal? Price { get; set; }

        //public Book(int id, string title, IList<string> languages, decimal? price)
        //{
        //    Id = id;
        //    Title = title;
        //    Languages = languages;
        //    Price = price;
        //}

        public string GetBookInfo()
        {
            var lang = string.Empty;

            foreach (var language in Languages)
                lang += $"{language},";
            
            return $"Id: {Id} Title: {Title}\n Languages: {lang.TrimEnd(',')}\n Price: {Price ?? 0}";
        }
    }

    //
}

// class contains data (properties & fields) and behavior (functions/methods) to operate on that data