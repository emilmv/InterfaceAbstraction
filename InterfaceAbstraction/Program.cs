using InterfaceAbstraction.Constants;
using InterfaceAbstraction.Models;
using System.Reflection.Metadata.Ecma335;

namespace InterfaceAbstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region Task1
        Beginning:
            string input;
            int userInput;

            Console.WriteLine(ConsoleMessages.MethodChoose);
            Console.WriteLine(ConsoleMessages.SquareMethod);
            Console.WriteLine(ConsoleMessages.RectangularMethod);
            Console.WriteLine(ConsoleMessages.ExitMethod);
            bool isCorrectInput = int.TryParse(Console.ReadLine(), out userInput);
            if (!isCorrectInput) goto Beginning;
            switch (userInput)
            {
                case 1:
                areaOfSquare:
                    Console.WriteLine(ConsoleMessages.SquareSide);
                    bool isCorrectSide = double.TryParse(Console.ReadLine(), out double squareSide);
                    if (!isCorrectSide) goto areaOfSquare;
                    Square square = new(squareSide);
                    square.CalcArea();
                    goto Beginning;
                case 2:
                areaOfRectangular:
                    Console.WriteLine(ConsoleMessages.RectangularWidth);
                    bool isCorrectWidth = double.TryParse(Console.ReadLine(), out double rectangularWitdh);
                    Console.WriteLine(ConsoleMessages.RectangularLength);
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
            #endregion
        }
    }
}

