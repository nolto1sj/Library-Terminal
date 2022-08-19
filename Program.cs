using System.ComponentModel.DataAnnotations;
using LibraryTerminal;
using System.Drawing.Printing;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

Library gcLibrary = new Library();
Console.WriteLine("Welcome to the Grand Circus Library!\n");
//Console.WriteLine("Would you like to search by:\n\n1. Author \n2. Title \n3. View all books\n4. Return a book\n5. Quit\n");
////gcLibrary.ListAllBooks();
//Loop to validate search
bool runProgram = true;
Beginning:
while (runProgram)
{
    Console.Clear();
    Console.WriteLine("Would you like to search by (1-5):\n\n1. Author \n2. Title \n3. View All Books\n4. Return Book\n5. Quit\n");

    string response = Console.ReadLine();
    switch (response)
    {
        case "1":
            Console.Clear();
            Console.Write("Please enter the author you are searching for: ");
            string authorInput = Console.ReadLine();
            gcLibrary.SearchAll(authorInput);
            Console.WriteLine("\nType '1' to return to main menu or any other key to quit");
            var input = Console.ReadLine().ToLower().Trim();
            if (input == "1")
            {
                goto Beginning;
            }
            else
            {
                goto Case5;
            }  
        case "2":
            Console.Clear();
            Console.Write("Please enter the title you are searching for: ");
            string titleInput = Console.ReadLine();
            gcLibrary.SearchAll(titleInput);
            Console.WriteLine("\nType '1' to return to main menu or any other key to quit");
            string inputTwo = Console.ReadLine().ToLower().Trim();
            if (inputTwo == "1")
            {
                goto Beginning;
            }
            else
            {
                goto Case5;
            }
        case "3":
            Case3:
            Console.Clear();
            bool caseThreeLoop = true;
            while (caseThreeLoop)
            {
                gcLibrary.ListAllBooks();
                Console.Write("\nPlease select a book to checkout: ");
                int bookSelection = int.Parse(Console.ReadLine());
                while(bookSelection > Library.ListOfBooks.Count)
                {
                    Console.WriteLine($"Invalid index. Please select 1-{Library.ListOfBooks.Count}.");
                    Thread.Sleep(1000);
                    goto Case3;
                }
                gcLibrary.CheckoutBook(bookSelection);
                Console.WriteLine("Would you like to:\n\n1. Return to Menu \n2. Checkout another book\n3. Return a book\n4. Quit\n ");
                //extend book maybe put book on hold
                int inputThree = int.Parse(Console.ReadLine());
                if (inputThree == 1)
                {
                    goto Beginning;
                }
                else if (inputThree == 2)
                {
                    goto Case3;
                }
                else if (inputThree == 3)
                {
                    goto Case4;
                }
                else
                {
                    goto Case5;
                }
            }
            break;
        case "4":
            Case4:
            Console.Clear();
            bool caseFourLoop = true;
            while (caseFourLoop)
            {
                gcLibrary.ListBooksToReturn();
                Console.WriteLine("Would you like to:\n\n1. Return to Menu \n2. Return another book\n3. Checkout a book\n4. Quit\n ");
                int inputFour = int.Parse(Console.ReadLine());
                if (inputFour == 1)
                {
                    goto Beginning;
                }
                else if (inputFour == 2)
                {
                    goto Case4;
                }
                else if (inputFour == 3)
                {
                    goto Case3;
                }
                else
                {
                    goto Case5;
                } 
            }
            break;
        case "5":
            Case5:
            Console.WriteLine("Thank you for stopping by!");
            Thread.Sleep(800);
            Console.WriteLine("Happy reading!");
            Thread.Sleep(800);
            runProgram = false;
            break;
        default:
            Console.WriteLine("Please select one of the categories (1-5) ");
            Thread.Sleep(1000);
            break;
    }
}