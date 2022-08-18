using System.ComponentModel.DataAnnotations;
using LibraryTerminal;

Library gcLibrary = new Library();
Console.WriteLine("Welcome to the Grand Circus Library!\n");
//Console.WriteLine("Would you like to search by:\n\n1. Author \n2. Title \n3. View all books\n4. Return a book\n5. Quit\n");
////gcLibrary.ListAllBooks();
//Loop to validate search
bool runProgram = true;
Waypoint1:
while (runProgram)
{
    Console.WriteLine("Would you like to search by:\n\n1. Author \n2. Title \n3. View All Books\n4. Return Book\n5. Quit\n");

    string response = Console.ReadLine();
    switch (response)
    {
        case "1":
            Console.Write("Please enter the author you are searching for: ");
            string authorInput = Console.ReadLine();
            gcLibrary.SearchAll(authorInput);
            Console.WriteLine("\nType 's' to return to main menu or any other key to quit");
            var input = Console.ReadLine().ToLower().Trim();
            if (input == "s")
            {
                goto Waypoint1;
            }
            else
            {
                Console.WriteLine("Thank you. Goodbye!");
                runProgram = false;
                break;
            }  
        case "2":
            Console.Write("Please enter the title you are searching for: ");
            string titleInput = Console.ReadLine();
            gcLibrary.SearchAll(titleInput);
            Console.WriteLine("\nType 's' to return to main menu or any other key to quit");
            string inputTwo = Console.ReadLine().ToLower().Trim();
            if (inputTwo == "s")
            {
                goto Waypoint1;
            }
            else
            {
                Console.WriteLine("Thank you. Goodbye!");
                runProgram = false;
                break;
            }
        case "3":
            bool caseThreeLoop = true;
            while (caseThreeLoop)
            {
                gcLibrary.ListAllBooks();
                Console.Write("\nPlease select a book to checkout");
                int bookSelection = int.Parse(Console.ReadLine());
                gcLibrary.CheckoutBook(bookSelection);
                Console.WriteLine("\nWould you like to:\n\n1. Return to Menu \n2. Quit\n");
                //extend book maybe put book on hold
                int inputThree = int.Parse(Console.ReadLine());
                if (inputThree == 1)
                {
                    goto Waypoint1;
                }
                else if (inputThree == 2)
                {
                    Console.WriteLine("Thank you. Goodbye!");
                    runProgram = false;
                    break;
                }
            }
            break;
        case "4":
            bool caseFourLoop = true;
            while (caseFourLoop)
            {
                gcLibrary.ListBooksToReturn();
                Console.WriteLine("\nWould you like to:\n\n1. Return to Menu \n2. Quit\n");
                int inputFour = int.Parse(Console.ReadLine());
                if (inputFour == 1)
                {
                    goto Waypoint1;
                }
                else if (inputFour == 2)
                {
                    Console.WriteLine("Thank you. Goodbye!");
                    runProgram = false;
                    break;
                }
            }
            break;
        case "5":
            Console.WriteLine("Thank you. Goodbye!");
            runProgram = false;
            break;
        default:
            Console.WriteLine("Please select one of the categories");
            break;
    }
}
//if (response == gcLibrary.Author + 1) ;
//{
//    string[] Library = Console.ReadLine().ToLower().Split(" ");
//    {
//        string author = response[1];
//        string title = response[2];
//        else if (response == Library.response + 2)
//        {
//            break;
//        }
//        else
//        {
//            Console.Write("\nInvalid entry. Please enter a number between (1-3).\n");
//            continue;
//        }
//    }
//}