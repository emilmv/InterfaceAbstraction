using InterfaceAbstraction.Constants;
using InterfaceAbstraction.Models;
namespace InterfaceAbstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Beginning:
            //    string input;
            //    int userInput;

            //    Console.WriteLine(ConsoleMessages.MethodChoose);
            //    Console.WriteLine(ConsoleMessages.SquareMethod);
            //    Console.WriteLine(ConsoleMessages.RectangularMethod);
            //    Console.WriteLine(ConsoleMessages.ExitMethod);
            //    bool isCorrectInput = int.TryParse(Console.ReadLine(), out userInput);
            //    if (!isCorrectInput) goto Beginning;
            //    switch (userInput)
            //    {
            //        case 1:
            //        areaOfSquare:
            //            Console.WriteLine(ConsoleMessages.SquareSide);
            //            bool isCorrectSide = double.TryParse(Console.ReadLine(), out double squareSide);
            //            if (!isCorrectSide) goto areaOfSquare;
            //            Square square = new(squareSide);
            //            square.CalcArea();
            //            goto Beginning;
            //        case 2:
            //        areaOfRectangular:
            //            Console.WriteLine(ConsoleMessages.RectangularWidth);
            //            bool isCorrectWidth = double.TryParse(Console.ReadLine(), out double rectangularWitdh);
            //            Console.WriteLine(ConsoleMessages.RectangularLength);
            //            bool isCorrectLength = double.TryParse(Console.ReadLine(), out double rectangularLength);
            //            if (isCorrectWidth && isCorrectLength)
            //            {
            //                Rectangular rectangular = new Rectangular(rectangularWitdh, rectangularLength);
            //                rectangular.CalcArea();
            //                goto Beginning;
            //            }
            //            else goto areaOfRectangular;
            //        case 3:
            //            break;
            //        default: goto Beginning;
            #endregion

            #region Task2

            Console.WriteLine(ConsoleMessages.Introduction);
        idInput:
            Console.WriteLine(ConsoleMessages.Id);
            bool isNumber = int.TryParse(Console.ReadLine(), out int id);
            if (!isNumber)
            {
                Console.WriteLine(ConsoleMessages.ErrorMessage);
                goto idInput;
            }
        fullNameInput:
            Console.WriteLine(ConsoleMessages.FullName);
            string? fullName = Console.ReadLine();
            if (string.IsNullOrEmpty(fullName))
            {
                Console.WriteLine(ConsoleMessages.ErrorMessage);
                goto fullNameInput;
            }
        emailInput:
            Console.WriteLine(ConsoleMessages.Email);
            string? email = Console.ReadLine();
            if (string.IsNullOrEmpty(email))
            {
                Console.WriteLine(ConsoleMessages.ErrorMessage);
                goto emailInput;
            }
        passwordInput:
            Console.WriteLine(ConsoleMessages.Password);
            Console.WriteLine(ConsoleMessages.PasswordCondition1);
            Console.WriteLine(ConsoleMessages.PasswordCondition2);
            Console.WriteLine(ConsoleMessages.PasswordCondition3);
            Console.WriteLine(ConsoleMessages.PasswordCondition4);
            string? password = Console.ReadLine();
            User user = new User(email, password);
            user.Id = id;
            user.FullName = fullName;
            user.Email = email;
            user.ShowInfo();
            #endregion
        }
    }
}


