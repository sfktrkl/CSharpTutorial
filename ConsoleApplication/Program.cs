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
            // Type Conversions in Variables
            //Lesson13();
            // Operators
            //Lesson27();
            // If-Else Statement
            //Lesson33();
            // Switch Case Statement
            //Lesson34();
            // While, DoWhile
            //Lesson35();
            // For loop
            Lesson36();
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

        // Type Conversions in Variables
        // Implicit casting
        // When assign a value of a smaller data type to a bigger one.
        // byte, short, int, long, float, double
        // Explicit casting
        // Where automatic conversion cannot be done or
        // while assign a value of a bigger data type to a smaller one or
        // to get the desired type to convert the specified value.
        static void Lesson13()
        {
            // Explicit casting

            // Cast operator
            double x = 24;
            int y;
            y = (int)x;
            Console.WriteLine(y);

            // Convert class
            double k = 24;
            int l;
            l = Convert.ToInt32(k);
            Console.WriteLine(l);

            double m = 24;
            int n = 12;
            float o = 6;
            char c = '+';
            string s = x.ToString() + n.ToString() + o.ToString() + c.ToString();
            Console.WriteLine(s);
        }

        // Operators
        // To perform specific mathematical or logical manipulations.
        static void Lesson27()
        {
            // Arithmetic Operators
            // +, -, *, /, %, %, ++, --
            Console.WriteLine((5 + 10).ToString());
            Console.WriteLine(("a" + "5").ToString());

            // Relational Operators
            // ==, !=, <, >, <=, >=
            Console.WriteLine((5 == 10).ToString());
            Console.WriteLine((5 > 10).ToString());

            // Logical Operators
            // &&, ||
            Console.WriteLine((true && false).ToString());
            Console.WriteLine((true || false).ToString());

            // Assignment Operators
            // +=, -=, *=, /=, %=
            int a = 5;
            a *= a;
            Console.WriteLine(a.ToString());
        }

        #region Region
        // Region directive partitions the code
        // To organize the code blocks.
        #endregion

        // Naming Conventions
        // Important to identify the usage and the 
        // purpose of a class or of a method to
        // identify the type of variable and arguments.
        // Pascal Casing, class and method names
        // SomeClass, DoIt
        // Camel Casing, arguments and local variables
        // inputValue, phoneNumber
        // For form elements,
        // Form - Frm
        // Label - lbl
        // Button - btn
        // TextBox - txt
        // ComboBox - cmb
        // CheckBox - ch
        // RadioButton - rb
        // DateTimePicker - dp
        // GroupBox - gb

        // If-Else Statement
        static void Lesson33()
        {
            int a = 20, b = 30;
            bool condition = true;
            if (a == 20)
                Console.WriteLine("A is 20");
            if (!condition)
                Console.WriteLine("Condition is false");
            if (a <= b)
                Console.WriteLine("A is smaller than B");

            if (a == 30)
                Console.WriteLine("A is 30");
            else if (condition)
                Console.WriteLine("Condition is true");
            else if (a >= b)
                Console.WriteLine("A is bigger than B");
            else
                Console.WriteLine("None");

            Console.WriteLine(a < b ? a.ToString() : b.ToString());

        }

        // Switch Case Statement
        static void Lesson34()
        {
            int x = 5;
            bool y = true;
            string message = "";
            switch (x)
            {
                case 2:
                    message = "low";
                    break;
                case 5:
                    message = "high";
                    switch (y)
                    {
                        case true:
                            message += " true";
                            break;
                        default:
                            message += " false";
                            break;
                    }
                    break;
                case 10:
                    message = "very high";
                    break;
                default:
                    message = "none";
                    break;
            }
            Console.WriteLine(message);
        }

        // While, DoWhile
        static void Lesson35()
        {
            int loop = 0;
            while (loop < 10)
            {
                Console.WriteLine(loop);
                loop++;
            }
            loop = 0;
            do
            {
                Console.WriteLine(loop);
                loop++;
            } while (loop < 10);
        }

        // For loop
        static void Lesson36()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine(i);

            int[] arr = { 0, 1, 2, 3 };
            foreach (var item in arr)
                Console.WriteLine(item);
        }
    }
}
