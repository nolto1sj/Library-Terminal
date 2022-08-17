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
         new Book("Available", "Dune", "Frank Herbert", "Sci-fi", "", "Fair"),
         new Book("Available", "The Alchemist", "Paulo Coelho", "Fantasy", "", "Fair"),
         new Book("Available", "Lying For Money", "Dan Davies", "True Crime", "", "Fair"),
         new Book("Available", "Kafka On The Shore", "Haruki Murakami", "Magical Realism", "", "Fair"),
         new Book("Available", "Black Count", "Tom Reiss", "Non-fiction", "", "Fair"),
         new Book("Available", "Things Fall Apart", "Chinua Achebe", "Fiction", "", "Good"),
         new Book("Available", "Half Of a Yellow Sun", "Chimamanda Adichie", "Fiction", "", "Good"),
         new Book("Available", "Perdido Street Station", "China Mieville" , "Sci-fi", "", "New"),
         new Book("Available", "IT", "Stephen King" , "Horror", "", "Fair"),
         new Book("Available", "Station Eleven", "Emily St. John Mandel" , "Sci-fi", "", "New"),
         new Book("Available", "Neverwhere", "Neil Gaiman" , "Fantasy", "", "New"),
         new Book("Available", "The Great and Secret Show", "Clive Barker" , "Fantasy", "", "Fair"),
        };
        //public static void ShowCarList()
        //{
        //    Console.WriteLine(string.Format($"{"",2}  {"MAKE",-9} {"MODEL",-9} {"YEAR",-5} {"COND.",-5} {"  PRICE",-12} {"MILAGE",8}"));
        //    Console.WriteLine(string.Format($"{"",2}  {"----",-9} {"-----",-9} {"----",-5} {"-----",-5} {"  -----",-12} {"------",8}"));

        //    int count = 0;

        //    UpdatedOrderedInventoryList();

        //    OrderedInventoryList.ForEach(car =>
        //    {
        //        count++;
        //        Console.WriteLine(string.Format($"{count,2}  ") + car.ToString());
        //    });

            public void ListAllBooks()
        {
                Console.WriteLine(string.Format($"{"Idx",2}  {"Title",-9} {"Author",-9} {"Status",-5} {"DueDate",-5}"));
                Console.WriteLine(string.Format($"{"---",2}  {"-----",-9} {"-----",-9} {"----",-5} {"-----",-5}"));
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
        //public void ListAvailableBooks()
        //{
        //    int i = 1;
        //    List<Book> availableBooks = listOfBooks.Where(x => x.OnShelf == "Available).ToList();
        //    foreach (Book book in availableBooks)
        //    {
        //        Console.WriteLine("(" + i++ + ") " + book.ToString());
        //    }
        //    i = 1;
        //}

        public void CheckoutBook(int index)
        {
            if (listOfBooks[--index].OnShelf == "Available")
            {
                Console.WriteLine("The following title will be checked out: " + listOfBooks[index].Title);
                listOfBooks[index].OnShelf = "Not Available";
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

            public void TitleSearch(string title)
        {
            List<Book> titleSearch = new List<Book>();
            titleSearch = listOfBooks.Where(x => x.Title == title).ToList();
            int i = 1;
            foreach (Book book in titleSearch)
            {
                Console.WriteLine("(" + i++ + ") " + book.ToString());
            }
            i = 1;

        }



        public Library()
        {
        }
    }
}
