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
            //Lesson11();
            // What Is Variables in C# ?
            //Lesson12()
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

        // What Is Variables in C# ?
        // Locations in computer memory that are reserved
        // for storing the data used by an application.
        static void Lesson12()
        {
            // Should start with letter.
            string name;
            //string 2name;
            //string @name;

            // Only letters, numbers and underscore can be used.
            float shoesize;
            float shoe_size;
            //float shoe size;
            //float shoe-size;

            // No spaces
            //string school name

            // C# commands cannot be used
            //double int;

            // Case sensitive
            string sensitive;
            string Sensitive;
        }

    }
}
