//DataStructures
//Take in user input and display input in reverse
 
using System.Collections;

Console.WriteLine("Welcome to Data Structre!\n");
//Request user input
Console.Write("Please enter a word or sentence. ");
string input = Console.ReadLine().ToLower().Trim();

input = ReverseInput(input);
Console.WriteLine($"Translated to: {input}");

static String ReverseInput(String str)
{
    char[] charArr = str.ToCharArray();
    int size = charArr.Length;
    Stack stack = new Stack(size);

    int i;
    for (i = 0; i < size; ++i)
    {
        stack.Push(charArr[i]);
    }

    for (i = 0; i < size; ++i)
    {
        charArr[i] = (char)stack.Pop();
    }

    return String.Join("", charArr);
}

while (Repeat());

static bool Repeat()
{
    while (true)
    {
        Console.WriteLine();
        Console.WriteLine("Do you want to go again (y/n)?");
        string input = Console.ReadLine();
        try
        {
            if (input.ToLower().Trim() == "y")
            {
                Console.WriteLine("Okay, keep going!");
                Console.WriteLine();
                return true;
            }
            else if (input.ToLower().Trim() == "n")
            {
                Console.WriteLine("Thank you, goodbye!");
                return false;
            }
            else
            {
                throw new Exception("Not a valid option, please try again.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}