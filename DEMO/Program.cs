using System.Text;

namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Formating 

            //string name = "John";
            //int age = 21;
            //Console.WriteLine($"My name is {name} and I am {age} years old.");

            #endregion

            #region Control Statements
            //int number = 10;
            //if (number > 5)
            //{
            //    Console.WriteLine("The number is greater than 5.");
            //}
            //else
            //{
            //    Console.WriteLine("The number is 5 or less.");
            //}

            #endregion

            #region Conditional Statements - If, Switch [Numeric Datatype]

            //int day = 3;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Sunday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown day");
            //        break;
            //}

            #endregion

            #region Conditional Statements - If, Switch [String Datatype]
            //string color = "Red";
            //switch (color)
            //{
            //    case "Red":
            //        Console.WriteLine("The color is Red.");
            //        break;
            //    case "Blue":
            //        Console.WriteLine("The color is Blue.");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown color.");
            //        break;
            //}

            #endregion


            #region Switch [Numeric Datatypes (Comparison Operators)]
            //int number = 10;
            //switch (number)
            //{
            //    case int n when n > 0 && n <= 10:
            //        Console.WriteLine("The number is between 1 and 10.");
            //        break;
            //    case int n when n > 10 && n <= 20:
            //        Console.WriteLine("The number is between 11 and 20.");
            //        break;
            //    default:
            //        Console.WriteLine("The number is out of range.");
            //        break;
            //}

            #endregion

            #region Evolution of Switch in C# 7.0
            //object value = 42;
            //switch (value)
            //{
            //    case int i:
            //        Console.WriteLine($"The value is an integer: {i}");
            //        break;
            //    case string s:
            //        Console.WriteLine($"The value is a string: {s}");
            //        break;
            //    default:
            //        Console.WriteLine("The value is of an unknown type.");
            //        break;
            //}

            #endregion

            #region Evolution of Switch in C# 8.0
            //int month = 7;
            //string season = month switch
            //{
            //    12 or 1 or 2 => "Winter",
            //    3 or 4 or 5 => "Spring",
            //    6 or 7 or 8 => "Summer",
            //    9 or 10 or 11 => "Fall",
            //    _ => "Unknown"
            //};
            //Console.WriteLine($"The season is {season}.");

            #endregion


            #region Loop Statements - For, Foreach
            //// For Loop
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"Current value: {i}");
            //}

            //// Foreach Loop
            //string[] names = { "Alice", "Bob", "Charlie" };
            //foreach (string name in names)
            //{
            //    Console.WriteLine($"Name: {name}");
            //}

            #endregion


            #region Loop Statements - Do While, While

            //// While Loop
            //int count = 1;
            //while (count <= 3)
            //{
            //    Console.WriteLine($"Count: {count}");
            //    count++;
            //}

            //// Do While Loop
            //int num = 1;
            //do
            //{
            //    Console.WriteLine($"Number: {num}");
            //    num++;
            //} while (num <= 3);

            #endregion

            #region  String

            //string message = "Hello, World!";
            //Console.WriteLine($"Message Length: {message.Length}");
            //Console.WriteLine($"Uppercase: {message.ToUpper()}");
            //Console.WriteLine($"Substring: {message.Substring(7, 5)}");

            #endregion

            #region StringBuilder


            //StringBuilder sb = new StringBuilder("Hello");
            //sb.Append(", World!");
            //sb.Insert(0, "Welcome: ");
            //sb.Replace("World", "C# Developer");

            //Console.WriteLine(sb.ToString());

            #endregion

            #region String Methods
            //string phrase = " C# is amazing! ";
            //Console.WriteLine($"Trimmed: '{phrase.Trim()}'");
            //Console.WriteLine($"Contains 'C#': {phrase.Contains("C#")}");
            //Console.WriteLine($"Starts with 'C#': {phrase.StartsWith("C#")}");
            //Console.WriteLine($"Replaced: {phrase.Replace("amazing", "powerful")}");

            #endregion

        }
    }
}
