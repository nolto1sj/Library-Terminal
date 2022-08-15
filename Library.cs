using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTerminal
{
    public class Library
    {
        List<Book> listOfBooks = new List<Book>
        {
         new Book(true, "Dune", "Frank Herbert", "Sci-fi", "", "Fair"),
         new Book(true, "The Alchemist", "Paulo Coelho", "Fantasy", "", "Fair"),
         new Book(true, "Lying For Money", "Dan Davies", "True Crime", "", "Fair"),
         new Book(true, "Kafka On The Shore", "Haruki Murakami", "Magical Realism", "", "Fair"),
         new Book(true, "Black Count", "Tom Reiss", "Non-fiction", "", "Fair"),
         new Book(true, "Things Fall Apart", "Chinua Achebe", "Fiction", DateTime.Now.AddDays(7).ToString("MM-dd-yy"), "Good"),
         new Book(true, "Half Of a Yellow Sun", "Chimamanda Adichie", "Fiction", DateTime.Now.AddDays(7).ToString("MM-dd-yy"), "Good")

        };

        public void ListAllBooks()
        {
            int i = 1;
            foreach (Book book in listOfBooks)
            {
                Console.WriteLine("(" + i++ + ") " + book.ToString());
            }
            i = 1;
        }

        //OrderedInventoryList.ForEach(car =>
        //    {
        //        count++;
        //        Console.WriteLine(string.Format($"{count,2}  ") + car.ToString());
        public void ListAvailableBooks()
        {
            int i = 1;
            List<Book> availableBooks = listOfBooks.Where(x => x.OnShelf == true).ToList();
            foreach (Book book in availableBooks)
            {
                Console.WriteLine("(" + i++ + ") " + book.ToString());
            }
            i = 1;
        }

        public void CheckoutBook(int index)
        {
            if (listOfBooks[--index].OnShelf == true)
            {
                Console.WriteLine("The following title will be checked out: " + listOfBooks[index].Title);
                listOfBooks[index].OnShelf = false;
                listOfBooks[index].DueDate = DateTime.Now.AddDays(7).ToString("MM-dd-yy");
                Thread.Sleep(1500);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("This book has already been checked out. Would you like to reserve it?");
                Thread.Sleep(1500);
                Console.Clear();
            }
                //listOfBooks.RemoveAt(index);
                //Should this just change a book to showing as checked out on list and then using LINQ provide the user with a list of checked out books to then check in?
                //also due date could be blank and set once a book is checkedout (DateTime.Now.AddDays(7).ToString("MM-dd-yy"))
                //display a list of checkedout books and then have them select one to return (similar to checkingout)
                //if statement to account for already checked out book

            }

            public Book TitleSearch(string title)
        {
            return listOfBooks.Find(x => x.Title == title);
        }



        public Library()
        {
        }
    }
}
