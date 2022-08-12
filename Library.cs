using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTerminal
{
    public class Library
    {
        public List<Book> LibraryContents { get; set; }

        public Library()//(List<Book> libraryContents)
        {
            //LibraryContents = libraryContents;

            LibraryContents = new List<Book>()
            {
                new Book(true, "Dune", "Frank Herbert", "Sci-fi", DateTime.Now.AddDays(7).ToString("MM-dd-yy"), "Fair"),
                new Book(true, "The Alchemist", "Paulo Coelho", "Fantasy", DateTime.Now.AddDays(7).ToString("MM-dd-yy"), "Fair"),
                new Book(true, "Lying For Money", "Dan Davies", "True Crime", DateTime.Now.AddDays(7).ToString("MM-dd-yy"), "Fair"),
                new Book(true, "Kafka On The Shore", "Haruki Murakami", "Magical Realism", DateTime.Now.AddDays(7).ToString("MM-dd-yy"), "Fair"),
                new Book(true, "Black Count", "Tom Reiss", "Non-fiction", DateTime.Now.AddDays(7).ToString("MM-dd-yy"), "Fair")
            };
        }

        //***methods***
        //return a book - this could also ask for the condition of the returned book and if it is a certain value the user is "fined"
        //borrow a book
        //change list order by category
        //reserve a book
        //remove a book (should be different from return?) I think this would allow for us to keep the duedate time as is since we would be displaying all of the books currently not checked out)
    }
}
