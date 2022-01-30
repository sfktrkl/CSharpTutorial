using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Functions Used in Console Environment to Write and Read
            //Lesson10();
            // Read & ReadLine
            Lesson11();
        }

        // Functions Used in Console Environment to Write and Read
        static void Lesson10()
        {
            // Cursor stop at the end of the text.
            Console.Write("Hello");
            // Cursor stop at the bottom line of the text.
            Console.WriteLine("Hello");
            // To see the cursor.
            Console.ReadKey();
        }

        // Read & ReadLine
        static void Lesson11()
        {
            Console.WriteLine("What is your name?");
            // Used to retrieve the data (string)
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.WriteLine("What is your name again?");
            // Used to retrieve the data as first char (int, ascii code)
            int ascii = Console.Read();
            Console.WriteLine("First character ASCII " + ascii);
        }

    }
}
