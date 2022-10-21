using System;

namespace Area_and_Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("========================================");
            Console.WriteLine("              WELCOME               ");
            for (; ; )
            {
                try
                {

                    Console.WriteLine("========================================");
                    Console.Write(" 1. Circle \n 2. Triangle \n 3. Square\n 4. Exit \n > ");
                    String shape = Console.ReadLine();

                    switch (shape)
                    {

                        case "1":
                            Console.WriteLine("========================================");
                            Console.WriteLine("              CIRCLE\n");
                            Console.Write("Enter radius centimeter: ");
                            int radius = Convert.ToInt32(Console.ReadLine()); // USER INPUT
                            Console.WriteLine("----------------------------------------");
                            const double pi = 3.14; // CONSTANT
                            double areaC = radius * radius * pi; // ARITHMETIC OPERATORS
                            const int cons = 2; // CONSTANT
                            double circum = cons * pi * radius; // ARITHMETIC OPERATORS
                            Console.WriteLine("            YOUR CIRCLE \n");
                            Console.WriteLine(" Radius: " + radius + " cm");
                            Console.WriteLine(" Area: " + areaC + " cm");
                            Console.WriteLine(" Circumperence: " + circum + " cm");
                            break;
                        case "2":
                            Console.WriteLine("========================================");
                            Console.WriteLine("              TRIANGLE\n");
                            Console.Write("Enter height in centimeter: ");
                            double height = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter base in centimeter: ");
                            double baseT = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter side A in centimeter: ");
                            double sideA = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter side C in centimeter: ");
                            double sideB = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("----------------------------------------");
                            int con = 1;
                            int constant = ++con; // INCREMENT
                            double areaT = (baseT * height) / constant; // ARITHMETIC OPERATORS
                            double perimeterT = baseT + sideA + sideB; // ARITHMETIC OPERATORS
                            Console.WriteLine("            YOUR TRIANGLE \n");
                            Console.WriteLine(" Height: " + height + " cm");
                            Console.WriteLine(" Base: " + baseT + " cm");
                            Console.WriteLine(" Side A: " + sideA + " cm");
                            Console.WriteLine(" Side B: " + sideB + " cm");
                            Console.WriteLine(" Area: " + areaT + " cm");
                            Console.WriteLine(" Perimeter: " + perimeterT + " cm");
                            break;
                        case "3":
                            Console.WriteLine("========================================");
                            Console.WriteLine("              SQUARE\n");
                            Console.Write("Enter length of side in centimeter: ");
                            double side = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("            YOUR SQUARE \n");
                            double areaS = side * side;
                            int squareCons = 5;
                            int squareConstant = --squareCons; // DECREMENT
                            double perimeterS = side * squareConstant; // ARITHMETIC OPERATORS
                            double sideS = perimeterS / squareConstant; // ARITHMETIC OPERATORS
                            double squareRoot = 1.41421356237; // CONSTANT
                            double diagonalD = squareRoot * side; // ARITHMETIC OPERATORS
                            Console.WriteLine(" Length: " + side + " cm");
                            Console.WriteLine(" Area: " + areaS + " cm");
                            Console.WriteLine(" Diagonal D: " + diagonalD + " cm");
                            Console.WriteLine(" Perimeter: " + perimeterS + " cm");
                            Console.WriteLine(" Side A: " + sideS + " cm");
                            break;

                        case "4":
                            Console.WriteLine("========================================");
                            System.Environment.Exit(1);
                            break;
                        default:
                            Console.WriteLine("========================================");
                            Console.WriteLine("         INVALID. TRY AGAIN.             ");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("========================================");
                    Console.WriteLine("         INVALID. TRY AGAIN.             ");
                }
            }
        }
    }
}
