using LibraryTerminal;

Library gcLibrary = new Library();
Console.WriteLine("Welcome to the Grand Circus Library!");
Console.WriteLine("Would you like to search by {1} Author, {2} Title or {3} view all books?");
gcLibrary.ListAllBooks();

Console.WriteLine("please enter the (index)book you would like to check out");
int response = int.Parse(Console.ReadLine());
gcLibrary.CheckoutBook(response);


Console.WriteLine("please enter the (index)book you would like to check out");
response = int.Parse(Console.ReadLine());
gcLibrary.CheckoutBook(response);

//gcLibrary.TitleSearch("Dune");
//could begin by asking user if they would like to see the entire book catalog or search for by Title or Author?

