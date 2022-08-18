﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTerminal
{
    public class Library
    {
        List<Book> ListOfBooks = new List<Book>
        {
         new Book("Available", "IT", "Stephen King", "Horror", "", "Fair"),
         new Book("Available", "Dune", "Frank Herbert", "Sci-fi", "", "Fair"),
         new Book("Available", "Neverwhere", "Neil Gaiman", "Fantasy", "", "New"),
         new Book("Available", "Black Count", "Tom Reiss", "Non-fiction", "", "Fair"),
         new Book("Available", "The Alchemist", "Paulo Coelho", "Fantasy", "", "Fair"),
         new Book("Available", "Lying For Money", "Dan Davies", "True Crime", "", "Fair"),
         new Book("Available", "Things Fall Apart", "Chinua Achebe", "Fiction", "", "Good"),
         new Book("Available", "Station Eleven", "Emily St. John Mandel", "Sci-fi", "", "New"),
         new Book("Available", "Perdido Street Station", "China Mieville", "Sci-fi", "", "New"),
         new Book("Available", "The Great and Secret Show", "Clive Barker", "Fantasy", "", "Fair"),
         new Book("Available", "Half Of a Yellow Sun", "Chimamanda Adichie", "Fiction", "", "Good"),
         new Book("Available", "Kafka On The Shore", "Haruki Murakami", "Magical Realism", "", "Fair"),
        };

        public void ListAllBooks()
        {
            Console.WriteLine(string.Format($"{"Idx",-2}  {"Title",-26} {"Author",-23} {"Status",-20} {"DueDate",-5}"));
            Console.WriteLine(string.Format($"{"---",-2}  {"-----",-26} {"------",-23} {"------",-20} {"-----",-5}"));
            int i = 1;
            foreach (Book book in ListOfBooks)
            {
                Console.WriteLine("(" + i++ + ") " + book.ToString());
            }
        }

        public void CheckoutBook(int index)
        {
            if (ListOfBooks[--index].OnShelf == "Available")
            {
                Console.WriteLine("The following book will be checked out: " + ListOfBooks[index].Title + " by " + ListOfBooks[index].Author);
                ListOfBooks[index].OnShelf = "Not Available";
                ListOfBooks[index].DueDate = DateTime.Now.AddDays(7).ToString("MM-dd-yy");
                Thread.Sleep(1500);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("This book has already been checked out. Would you like to reserve it?");
                Thread.Sleep(1500);
                Console.Clear();
            }
        }

        public void SearchAll(string titleorauthor)
        {
            List<Book> searchList = new List<Book>();
            searchList = ListOfBooks.Where(x => x.Title.Contains(titleorauthor, StringComparison.OrdinalIgnoreCase) || x.Author.Contains(titleorauthor, StringComparison.OrdinalIgnoreCase)).ToList();
            if (searchList.Count >= 1)
            {
                int i = 1;
                foreach (Book book in searchList)
                {
                    Console.WriteLine("(" + i++ + ") " + book.ToString());
                }
            }
            else
            {
                Console.WriteLine("No books found!");
            }
        }

        public void TitleSearch(string title)
        {
            List<Book> titleSearch = new List<Book>();
            titleSearch = ListOfBooks.Where(x => x.Title.Contains(title)).ToList();
            if (titleSearch.Count() >= 1)
            {
                int i = 1;
                foreach (Book book in titleSearch)
                {
                    Console.WriteLine("(" + i++ + ") " + book.ToString());
                }
            }
            else
            {
                Console.WriteLine("Title not found!");
            }
        }

        public void AuthorSearch(string author)
        {
            List<Book> authorSearch = new List<Book>();
            authorSearch = ListOfBooks.Where(x => x.Author == author).ToList();
            if (authorSearch.Count >= 1)
            {
                int i = 1;
                foreach (Book book in authorSearch)
                {
                    Console.WriteLine("(" + i++ + ") " + book.ToString());
                }
            }
            else
            {
                Console.WriteLine("Author not found!");
            }
        }
        
        public void ListBooksToReturn()
        {
            Console.WriteLine(string.Format($"{"Idx",-2}  {"Title",-26} {"Author",-23} {"Status",-20} {"DueDate",-5}"));
            Console.WriteLine(string.Format($"{"---",-2}  {"-----",-26} {"------",-23} {"------",-20} {"-----",-5}"));
            int i = 1;
            List<Book> booksToReturn = new List<Book>();
            booksToReturn = ListOfBooks.Where(x => x.OnShelf == "Not Available").ToList();
            foreach (Book book in booksToReturn)
            {
                Console.WriteLine("(" + i++ + ") " + book.ToString());
            }
            Console.WriteLine("Please enter the index of the book you wish to return");
            int response = int.Parse(Console.ReadLine());
            response = response - 1;
            Console.WriteLine("The following book will be returned: " + booksToReturn[response].Title + " by " + booksToReturn[response].Author);
            booksToReturn[response].OnShelf = "Available";
            booksToReturn[response].DueDate = "";
        }

        public Library() { }
    }
}