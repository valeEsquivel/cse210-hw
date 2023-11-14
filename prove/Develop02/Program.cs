using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int choice = 0;

        do
        {
            Console.WriteLine("Please select on of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Console.WriteLine("You chose to add a new entry.");
                    PromptGenerator promptGenerator = new PromptGenerator();
                    promptGenerator.AddPrompt(); // *** Here is where the prompts are added to the list
                    Entry entry = new Entry();
                    entry._promptText = promptGenerator.GetRandomPrompt();
                    Journal journal = new Journal();

                    Console.WriteLine(entry._promptText);

                    Console.Write("> ");
                    entry._entryText = Console.ReadLine();
                    entry._date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

                    journal.AddEntry(entry);
                    break;
                case 2:
                    Console.WriteLine("You chose to delete an entry.");
                    break;
                case 3:
                    Console.WriteLine("You chose to list all entries.");
                    break;
                case 4:
                    Console.WriteLine("You chose to search for an entry.");
                    break;
                case 5:
                    Console.WriteLine("You chose to quit.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 5);
    }
}