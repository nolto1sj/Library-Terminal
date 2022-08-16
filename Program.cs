using System.ComponentModel.DataAnnotations;
using LibraryTerminal;

Library gcLibrary = new Library();
Console.WriteLine("Welcome to the Grand Circus Library!\n");
Console.WriteLine("Would you like to search by:\n\n1. Author \n2. Title \n3. View all books\n");

int response = int.Parse(Console.ReadLine());

//Loop to validate search
bool runProgram = true;
while (runProgram)

if (response == gcLibrary.Author + 1);
{
    string[] Library = Console.ReadLine().ToLower().Split(" ");
    {
        string author = response[1];
        string title = response[2];

        else if (response == Library.response + 2)
        {

            break;
        }
        else
        {
            Console.Write("\nInvalid entry. Please enter a number between (1-3).\n");
            continue;
        }

    }

}

internal class Library
{
}

//gcLibrary.ListAllBooks();
//Console.WriteLine("please enter the (index)book you would like to check out");
int response = int.Parse(Console.ReadLine());
gcLibrary.CheckoutBook(response);

gcLibrary.ListAvailableBooks();

Console.WriteLine("please enter the (index)book you would like to check out");
response = int.Parse(Console.ReadLine());
gcLibrary.CheckoutBook(response);

