using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//using static System.Net.Mime.MediaTypeNames;

namespace LibraryTerminal
{
    public class Book
    {
        public string OnShelf { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string DueDate { get; set; }
        public string Condition { get; set; }

        public Book(string onShelf, string title, string author, string category, string dueDate, string condition)
        {
            this.OnShelf = onShelf;
            this.Title = title;
            this.Author = author;
            this.Category = category;
            this.DueDate = dueDate;
            this.Condition = condition;
        }

        public Book() { }

        public override string ToString()
        {
            return string.Format($"{""} {Title,-26} {Author,-23} {OnShelf,-15} {DueDate,-5}");
        }
    }
}