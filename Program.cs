﻿using LibraryTerminal;


//Book One = new Book(true, "Dune", "Frank Herbert", "Sci-fi", DateTime.Now.AddDays(7).ToString("MM-dd-yy"), "Fair");
//Book Two = new Book(true, "The Alchemist", "Paulo Coelho", "Fantasy", DateTime.Now.AddDays(7).ToString("MM-dd-yy"), "Fair");
//Book Three = new Book(true, "Lying For Money", "Dan Davies", "True Crime", DateTime.Now.AddDays(7).ToString("MM-dd-yy"), "Fair");
//Book Four = new Book(true, "Kafka On The Shore", "Haruki Murakami", "Magical Realism", DateTime.Now.AddDays(7).ToString("MM-dd-yy"), "Fair");
//Book Five = new Book(true, "Black Count", "Tom Reiss", "Non-fiction", DateTime.Now.AddDays(7).ToString("MM-dd-yy"), "Fair");

Library gcLibrary = new Library();

//foreach (Book book in gcLibrary.LibraryContents)
//{
//    Console.WriteLine("{0,10},{1,15},{2,20},{3,25},{4,30},{5,35}",
//    book.OnShelf,
//    book.Title,
//    book.Author,
//    book.Category,
//    book.DueDate,
//    book.Condition);
//}//formatting is off on this, eventually would be a method within Library?


gcLibrary.ListAllBooks();

Console.WriteLine("please enter the (index)book you would like to check out");
int response = int.Parse(Console.ReadLine());
gcLibrary.CheckoutBook(response);

gcLibrary.ListAllBooks();

Console.WriteLine("please enter the (index)book you would like to check out");
response = int.Parse(Console.ReadLine());
gcLibrary.CheckoutBook(response);

//could begin by asking user if they would like to see the entire book catalog or search for by Title or Author?

