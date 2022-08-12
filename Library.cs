using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTerminal
{
    public class Library
    {
        List<Book> LibraryContents { get; set; }

        public Library(List<Book> libraryContents)
        {
            LibraryContents = libraryContents;
        }

        //***methods***
        //return a book
        //borrow a book
        //change list order by category
        //reserve a book
        //
    }
}
