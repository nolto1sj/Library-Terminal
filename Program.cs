using System.ComponentModel.DataAnnotations;
using LibraryTerminal;

Library gcLibrary = new Library();
Console.WriteLine("Welcome to the Grand Circus Library!\n");
Console.WriteLine("Would you like to search by:\n\n1. Author \n2. Title \n3. View all books\n4. Quit\n");

////gcLibrary.ListAllBooks();

//Loop to validate search
bool runProgram = true;
while (runProgram)
{
    var response = int.Parse(Console.ReadLine());
    try
    {
        switch (response)
        {
            case 1:
                Console.WriteLine("You selected Author");
                break;
            case 2:
                Console.WriteLine("You selected Title");
                break;
            case 3:
                Console.WriteLine("You selected View All Books");
                break;
            case 4:
                Console.WriteLine("Goodbye!");
                runProgram = false;
                break;
            default:
                Console.WriteLine("Please select one of the categories");
                break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Please respopnd right please please");
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
}




