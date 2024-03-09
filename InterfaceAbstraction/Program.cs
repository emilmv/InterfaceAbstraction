using InterfaceAbstraction.Models;
using System.Reflection.Metadata.Ecma335;

namespace InterfaceAbstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Beginning:
            string input;
            int userInput;

            Console.WriteLine("Please choose method you want to operate:");
            Console.WriteLine("1. Area of Square");
            Console.WriteLine("2. Area of Rectangular");
            Console.WriteLine("3. Exit");
            bool isCorrectInput = int.TryParse(Console.ReadLine(), out userInput);
            if (!isCorrectInput) goto Beginning;
            switch (userInput)
            {
                case 1:
                areaOfSquare:
                    Console.WriteLine("Please enter side of Square");
                    bool isCorrectSide = double.TryParse(Console.ReadLine(), out double squareSide);
                    if (!isCorrectSide) goto areaOfSquare;
                    Square square = new(squareSide);
                    square.CalcArea();
                    goto Beginning;
                    break;
                case 2:
                areaOfRectangular:
                    Console.WriteLine("Please enter width of Rectangular");
                    bool isCorrectWidth = double.TryParse(Console.ReadLine(), out double rectangularWitdh);
                    Console.WriteLine("Please enter length of Rectangular");
                    bool isCorrectLength = double.TryParse(Console.ReadLine(), out double rectangularLength);
                    if (isCorrectWidth && isCorrectLength)
                    {
                        Rectangular rectangular = new Rectangular(rectangularWitdh, rectangularLength);
                        rectangular.CalcArea();
                        goto Beginning;
                    }
                    else goto areaOfRectangular;
                case 3:
                    break;
                default: goto Beginning;





            }
        }
    }
}
