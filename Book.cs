using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTerminal
{
    public class Book
    {
        public bool OnShelf { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string DueDate { get; set; }
        public string Condition { get; set; }

        public Book(bool onShelf, string title, string author, string category, string dueDate, string condition)
        {
            this.OnShelf = onShelf;
            this.Title = title;
            this.Author = author;
            this.Category = category;
            this.DueDate = dueDate;
            this.Condition = condition;
        }

        public Book() { }


    }
}
