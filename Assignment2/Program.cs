namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(num % 3 == 0 && num % 4 == 0 ? "Yes" : "No");
            #endregion


            #region 2
            //Console.Write("Enter an integer: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(num < 0 ? "negative" : "positive");
            #endregion


            #region 3
            //Console.Write("Enter three integers separated by spaces: ");
            //string[] inputs = Console.ReadLine().Split();
            //int num1 = int.Parse(inputs[0]);
            //int num2 = int.Parse(inputs[1]);
            //int num3 = int.Parse(inputs[2]);
            //Console.WriteLine($"Max element = {Math.Max(num1, Math.Max(num2, num3))}");
            //Console.WriteLine($"Min element = {Math.Min(num1, Math.Min(num2, num3))}");
            #endregion

            #region 4
            //Console.Write("Enter an integer: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");
            #endregion

            #region 5
            //Console.Write("Enter a character: ");
            //char ch = char.ToLower(Console.ReadLine()[0]);
            //if ("aeiou".Contains(ch))
            //    Console.WriteLine("vowel");
            //else
            //    Console.WriteLine("consonant");
            #endregion

            #region 6
            //Console.Write("Enter a number: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write(i + (i == n ? "" : ", "));
            //}
            //Console.WriteLine();
            #endregion

            #region 7
            //Console.Write("Enter a number: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(n * i + " ");
            //}
            //Console.WriteLine();
            #endregion


            #region 8
            //Console.Write("Enter a number: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= n; i += 2)
            //{
            //    Console.Write(i + (i + 2 > n ? "" : " "));
            //}
            //Console.WriteLine();
            #endregion

            #region 9
            //Console.Write("Enter the base and exponent separated by a space: ");
            //string[] inputs = Console.ReadLine().Split();
            //int baseNum = int.Parse(inputs[0]);
            //int exponent = int.Parse(inputs[1]);
            //Console.WriteLine($"Output: {Math.Pow(baseNum, exponent)}");
            #endregion

            #region 10
            //Console.WriteLine("Enter marks of five subjects separated by spaces:");
            //string[] inputs = Console.ReadLine().Split();
            //int[] marks = Array.ConvertAll(inputs, int.Parse);
            //int total = marks.Sum();
            //double average = marks.Average();
            //double percentage = (total / 500.0) * 100;
            //Console.WriteLine($"Total marks = {total}");
            //Console.WriteLine($"Average marks = {average:F2}");
            //Console.WriteLine($"Percentage = {percentage:F2}");
            #endregion


            #region 11
            //Console.Write("Enter month number (1-12): ");
            //int month = int.Parse(Console.ReadLine());
            //int days = month == 2 ? 28 : (month <= 7 ? (month % 2 == 0 ? 30 : 31) : (month % 2 == 0 ? 31 : 30));
            //Console.WriteLine($"Days in Month: {days}");
            #endregion


            #region 12
            //Console.WriteLine("Enter two numbers and an operator (+, -, *, /):");
            //double num1 = double.Parse(Console.ReadLine());
            //double num2 = double.Parse(Console.ReadLine());
            //char op = Console.ReadLine()[0];
            //double result = op switch
            //{
            //    '+' => num1 + num2,
            //    '-' => num1 - num2,
            //    '*' => num1 * num2,
            //    '/' => num1 / num2,
            //    _ => throw new InvalidOperationException("Invalid operator")
            //};
            //Console.WriteLine($"Result: {result}");
            #endregion


            #region 13
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();
            //char[] reversed = input.ToCharArray();
            //Array.Reverse(reversed);
            //Console.WriteLine(new string(reversed));
            #endregion


            #region 14
            //Console.Write("Enter an integer: ");
            //int num = int.Parse(Console.ReadLine());
            //string reversed = new string(num.ToString().ToCharArray().Reverse().ToArray());
            //Console.WriteLine($"Reversed: {reversed}");
            #endregion


            #region 15
           


            
            
                Console.Write("Enter start and end of range: ");
                string[] inputs = Console.ReadLine().Split();
                int start = int.Parse(inputs[0]);
                int end = int.Parse(inputs[1]);
                for (int i = start; i <= end; i++)
                {
                    if (IsPrime(i))
                        Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            static bool IsPrime(int num)
            {
                if (num < 2) return false;
                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0) return false;
                }
                return true;
            }


        #endregion

        #region 16
        //    Console.Write("Enter a number to convert: ");
        //    int num = int.Parse(Console.ReadLine());
        //    string binary = "";
        //    while (num > 0)
        //    {
        //        binary = (num % 2) + binary;
        //        num /= 2;
        //    }
        //Console.WriteLine($"Binary: {binary}");
        #endregion

        #region 17

        //Console.Write("x1 y1: ");
        //string[] point1 = Console.ReadLine().Split();
        //double x1 = double.Parse(point1[0]);
        //double y1 = double.Parse(point1[1]);

        //Console.Write("x2 y2: ");
        //string[] point2 = Console.ReadLine().Split();
        //double x2 = double.Parse(point2[0]);
        //double y2 = double.Parse(point2[1]);

        //Console.Write("x3 y3: ");
        //string[] point3 = Console.ReadLine().Split();
        //double x3 = double.Parse(point3[0]);
        //double y3 = double.Parse(point3[1]);


        //double slope1 = (y2 - y1) / (x2 - x1);
        //double slope2 = (y3 - y2) / (x3 - x2);


        //if (slope1 == slope2)
        //    Console.WriteLine("The points lie on a straight line.");
        //else
        //    Console.WriteLine("The points do not lie on a straight line.");
        #endregion


        #region 18
//        Console.Write("Enter the time taken by the worker (in hours): ");
//        double time = double.Parse(Console.ReadLine());

//        if (time >= 2 && time <= 3)
//        {
//            Console.WriteLine("Highly Efficient");
//        }
//        else if (time > 3 && time <= 4)
//        {
//            Console.WriteLine("You need to increase your speed.");
//        }
//        else if (time > 4 && time <= 5)
//{
//    Console.WriteLine("You need training to improve your speed.");
//}
//else if (time > 5)
//{
//    Console.WriteLine("You are required to leave the company.");
//}
//else
//{
//    Console.WriteLine("Invalid input. Time must be greater than or equal to 2 hours.");
//}
        #endregion
    }
}

