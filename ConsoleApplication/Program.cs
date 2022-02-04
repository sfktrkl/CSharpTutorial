using System.Collections.Generic;
using System.Timers;
using System.IO;
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
            //Lesson36();
            // Jump statements
            //Lesson37();
            // Arrays
            //Lesson39();
            // List
            //Lesson42();
            // Random
            //Lesson43();
            // Timer
            //Lesson44();
            // Math
            //Lesson45();
            // Enum
            // Lesson56();
            // Delegates
            //Lesson57();
            // Exception handling
            //Lesson58();
            // Directory and Directory Classes (Folder Operations)
            //Lesson60();
            // File and File Info Classes (File Operations)
            Lesson61();
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

        // Jump statements
        static void Lesson37()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue;
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    goto Final;
                Console.WriteLine(i);
            }

            Final:
            int x = 3;
            switch (x)
            {
                case 2:
                    goto case 3;
                case 3:
                    Console.WriteLine(x);
                    break;
                default:
                    break;
            }
        }

        // Arrays
        static void Lesson39()
        {
            int[] numbers = new int[4];
            int[] numbers2 = new int[4] { 3, 4, 5, 6 };
            int[] numbers3 = new int[] { 3, 4, 5, 6 };
            int[] numbers4 = { 3, 4, 5, 6 };
        }

        // List
        static void Lesson42()
        {
            List<int> numbers = new List<int>();

            void show()
            {
                foreach (var number in numbers)
                    Console.WriteLine(number);
                Console.WriteLine();
            }

            numbers.Add(1);
            show();

            numbers.AddRange(new List<int>{ 2, 3 });
            show();

            numbers.Clear();
            numbers.Add(4);
            show();

            numbers.Add(numbers.Count);
            show();
        }

        // Random
        static void Lesson43()
        {
            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(100));
            Console.WriteLine(random.Next(100, 200));
            Console.WriteLine(random.NextDouble());

            byte[] array = new byte[3];
            random.NextBytes(array);
            foreach (var b in array)
                Console.WriteLine(b);

            string valid = "asdfgh12345";
            string result = "";
            for (int i = 0; i < 6; i++)
                result += valid[random.Next(0, valid.Length)];
            Console.WriteLine(result);
        }

        // Timer
        static void Lesson44()
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Enabled = true;

            int value = 0;
            timer.Start();
            timer.Elapsed += (sender, e) =>
            {
                value++;
            };
            while (value < 5) // 5 seconds
                Console.WriteLine(value);
            timer.Stop();
        }

        // Math
        static void Lesson45()
        {
            double firstValue = -40, secondValue = 3;
            Console.WriteLine(Math.Min(firstValue, secondValue));
            Console.WriteLine(Math.Max(firstValue, secondValue));
            Console.WriteLine(Math.Abs(firstValue));
            Console.WriteLine(Math.Sign(firstValue));
            Console.WriteLine(Math.Sin(secondValue));
            Console.WriteLine(Math.Cos(secondValue));
            Console.WriteLine(Math.Pow(firstValue, secondValue));
            Console.WriteLine(Math.Sqrt(secondValue));
            Console.WriteLine(Math.Log(secondValue));
            Console.WriteLine(Math.Log10(secondValue));
            Console.WriteLine(Math.Exp(secondValue));
        }

        // Enum
        // Enum is a value data type in C#. They are basically a set of named constants.
        // It is mainly used to assign the names or string values to integer constants that make a program easy to read and maintain.
        // The enum can include named constants of numeric data types, which are like byte sbyte, short, ushort, int, long, ulong.
        // Mainly used to make code more readable by giving related constants a meaningful name, improves maintainability.
        // It has methods, GetName
        enum Colors
        {
            red,        // 0
            blue,       // 1
            white = 5,  // 5
            black = 5, // 5
            yellow,     // 6
            purple,     // 7
        }
        static void Lesson56()
        {
            Console.WriteLine((int)Colors.red + " " + Enum.GetName(typeof(Colors), Colors.red));
            Console.WriteLine((int)Colors.blue + " " + Enum.GetName(typeof(Colors), Colors.blue));
            Console.WriteLine((int)Colors.white + " " + Enum.GetName(typeof(Colors), Colors.white));
            Console.WriteLine((int)Colors.black + " " + Enum.GetName(typeof(Colors), Colors.black));
            Console.WriteLine((int)Colors.yellow + " " + Enum.GetName(typeof(Colors), Colors.yellow));
            Console.WriteLine((int)Colors.purple + " " + Enum.GetName(typeof(Colors), Colors.purple));
        }

        // Delegates
        // A delegate is like a pointer to a function.
        // It is a reference type data type. It holds the reference of a method.
        // You can only use delegate for when you have the same return type and parameters.
        // The delegate can point to multiple methods as well. Delegate that points to multiple methods is called a multicast delegate.
        static class Delegates
        {
            private static string text;

            public delegate void Fill();

            private static void FillText()
            {
                text += "Filled";
            }

            private static void FillTextAgain()
            {
                text += "Again";
            }

            public static void Run()
            {
                Fill fill = FillText;
                fill();
                fill.Invoke();

                fill += FillTextAgain;
                fill();
                fill.Invoke();

                Console.WriteLine(text);
            }
        }
        static void Lesson57()
        {
            Delegates.Run();
        }

        // Exception handling
        // So exception handling is C# is a process to handle runtime errors.
        // We perform exception handling so that the normal flow of the application can be maintained even after runtime errors.
        // An exception is an event or an object which is thrown at runtime. So it's a runtime error which can be handled.
        // Now, if we don't handle the exception, it prints the exception message and then terminates the program.
        // So it maintains the normal flow of the application. So in that case, the rest of the code is executed after an event exception.
        // So exceptions allow an application to transfer control from one part of the code to another.
        // So when an exception is thrown, the current flow, the code is interrupted and then handed back to a parent.
        static void Lesson58()
        {
            int x = 0, y = 5;
            float result;
            try
            {
                result = y / x;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("finally");
                throw new Exception("exception");
            }
        }

        // Directory and Directory Classes(Folder Operations)
        static void Lesson60()
        {
            // Create a new folder
            if (!Directory.Exists(@"firstfolder"))
                Directory.CreateDirectory(@"firstfolder");

            if (!Directory.Exists(@"secondfolder"))
            {
                DirectoryInfo directory = new DirectoryInfo(@"secondfolder");
                directory.Create();

                // Directory info
                Console.WriteLine(directory.LastAccessTime);
                Console.WriteLine(directory.CreationTime);
            }

            // Move the folder
            if (Directory.Exists(@"firstfolder") && !Directory.Exists(@"F:\firstfolder"))
                Directory.Move(@"firstfolder", @"F:\firstfolder");

            // Delete the folder
            if (Directory.Exists(@"firstfolder"))
                Directory.Delete(@"firstfolder");

            if (Directory.Exists(@"secondfolder"))
                Directory.Delete(@"secondfolder");

            if (Directory.Exists(@"F:\firstfolder"))
                Directory.Delete(@"F:\firstfolder");
        }

        // File and File Info Classes(File Operations)
        static void Lesson61()
        {
            // Stream
            // FileStream       : reads writes bytes from or to a physical file
            // MemoryStream     : reads writes bytes that are stored in the memory
            // BufferedStream   : reads writes bytes from others streams to improve the performance of certain IO operations
            // NetworkStream    : reads writes bytes from a network socket
            // PipeStream       : reads writes bytes from different processes
            // CryptoStream     : linking data streams to cryptographic transformations

            // Readers and Writers
            // StreamReader : helper class for reading characters from a stream
            // StreamWriter : writing a string to a stream by converting characters into bytes
            // BinaryReader : reading primitive data times from bytes
            // BinaryWriter : binary writer writes primitive types in binary

            if (!File.Exists("firstfile"))
                File.Create("firstfile");

            if (!File.Exists("secondfile"))
            {
                FileInfo file = new FileInfo("secondfile");
                file.Create();

                Console.WriteLine(file.LastAccessTime);
                Console.WriteLine(file.CreationTime);
            }

            FileStream fs = new FileStream("firstfile", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("firstline");
            sw.WriteLine("secondline");
            sw.Flush();
            sw.Close();
            fs.Close();

            FileStream fs2 = new FileStream("firstfile", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs2);
            string text = "";
            while (!sr.EndOfStream)
                text += sr.ReadLine() + Environment.NewLine;
            sr.Close();
            fs2.Close();

            File.Copy("firstfile", "thirdfile");

            if (File.Exists("firstfile"))
                File.Delete("firstfile");

            if (File.Exists("secondfile"))
                File.Delete("secondfile");

            if (File.Exists("thirdfile"))
                File.Delete("thirdfile");
        }
    }
}
