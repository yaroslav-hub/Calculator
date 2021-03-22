using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first num: ");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second num: ");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operation (it could be 'add', 'sub', 'mul', 'div'): ");
            string Operation = Console.ReadLine();
            if (Operation != "add" && Operation != "sub" && Operation != "mul" && Operation != "div")
            {
                Console.WriteLine("Unknown operation!");
                return;
            }

            double Result = Calculate(X, Y, Operation);
            Console.WriteLine(Result);

            Console.ReadKey();
        }

        static double Calculate(int FirstNum, int SecondNum, string Operation)
        {
            double Result = 0;
            switch (Operation)
            {
                case "add":
                    Result = FirstNum + SecondNum;
                    break;
                case "sub":
                    Result = FirstNum - SecondNum;
                    break;
                case "mul":
                    Result = FirstNum * SecondNum;
                    break;
                case "div":
                    Result = (double)FirstNum / SecondNum;
                    break;
            }
            return Result;
        }
    }
}
