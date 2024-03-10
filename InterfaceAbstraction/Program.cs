using InterfaceAbstraction.Constants;
using InterfaceAbstraction.Models;
using System.Security.Cryptography.X509Certificates;
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
            Console.WriteLine(ConsoleMessages.Line);
            Console.WriteLine(ConsoleMessages.MethodChoose);
            Console.WriteLine(ConsoleMessages.SquareButton);
            Console.WriteLine(ConsoleMessages.RectangularButton);
            Console.WriteLine(ConsoleMessages.ExitButton);
            Console.WriteLine(ConsoleMessages.Line);
            if (!isCorrectInput(Console.ReadLine(), out userInput))
                goto Beginning;
            switch (userInput)
            {
                case 1:
                areaOfSquare:
                    double squareSide;
                    Console.WriteLine(ConsoleMessages.SquareSide);
                    Console.WriteLine(ConsoleMessages.Line);
                    if (!isCorrectSide(Console.ReadLine(), out squareSide)) goto areaOfSquare;
                    Square square = new(squareSide);
                    Console.WriteLine(ConsoleMessages.Line);
                    square.CalcArea();
                    goto Beginning;
                case 2:
                areaOfRectangular:
                    double rectangularWidth;
                    double rectangularLength;
                    Console.WriteLine(ConsoleMessages.RectangularWidth);
                    isCorrectWidth(Console.ReadLine(), out rectangularWidth);
                    Console.WriteLine(ConsoleMessages.RectangularLength);
                    isCorrectLength(Console.ReadLine(), out rectangularLength);
                    if (rectangularLength != 0 && rectangularWidth != 0)
                    {
                        Rectangular rectangular = new Rectangular(rectangularWidth, rectangularLength);
                        rectangular.CalcArea();
                        goto Beginning;
                    }
                    else goto areaOfRectangular;
                case 3:
                    break;
                default: goto Beginning;
                    #endregion

                    #region Task2
                    //    Console.WriteLine(ConsoleMessages.Introduction);
                    //fullNameInput:
                    //    Console.WriteLine(ConsoleMessages.Line);
                    //    Console.WriteLine(ConsoleMessages.FullName);
                    //    string? fullName = Console.ReadLine();
                    //    Console.WriteLine(ConsoleMessages.Line);
                    //    if (string.IsNullOrEmpty(fullName))
                    //    {
                    //        Console.WriteLine(ConsoleMessages.ErrorMessage);
                    //        goto fullNameInput;
                    //    }
                    //emailInput:
                    //    Console.WriteLine(ConsoleMessages.Email);
                    //    string? email = Console.ReadLine();
                    //    Console.WriteLine(ConsoleMessages.Line);
                    //    if (string.IsNullOrEmpty(email))
                    //    {
                    //        Console.WriteLine(ConsoleMessages.ErrorMessage);
                    //        goto emailInput;
                    //    }  
                    //    string password = "";
                    //    User user = new User(email, password);
                    //    while(!user.PasswordChecker(password))
                    //    {
                    //        Console.WriteLine(ConsoleMessages.Line);
                    //        Console.WriteLine(ConsoleMessages.Password);
                    //        Console.WriteLine(ConsoleMessages.PasswordCondition1);
                    //        Console.WriteLine(ConsoleMessages.PasswordCondition2);
                    //        Console.WriteLine(ConsoleMessages.PasswordCondition3);
                    //        Console.WriteLine(ConsoleMessages.PasswordCondition4);
                    //        Console.WriteLine(ConsoleMessages.Line);
                    //        password = Console.ReadLine();
                    //    }
                    //    Console.WriteLine(ConsoleMessages.Line);
                    //    Console.WriteLine(ConsoleMessages.PasswordSuccess);
                    //    user.Password=password;
                    //    user.FullName = fullName;
                    //    user.Email = email;
                    //    Console.WriteLine(ConsoleMessages.Line);
                    //    user.ShowInfo();
                    //    Console.WriteLine(ConsoleMessages.Line);
                    #endregion
            }

        }
        public static bool isCorrectInput(string button, out int result)
        {
            if (int.TryParse(button, out result)) return true;
            else return false;
        }
        public static bool isCorrectSide(string side, out double result)
        {
            if (double.TryParse(side, out result)) return true;
            else return false;
        }
        public static bool isCorrectWidth(string width, out double result)
        {
            if (double.TryParse(width, out result)) return true;
            else return false;
        }
        public static bool isCorrectLength(string length, out double result)
        {
            if (double.TryParse(length, out result)) return true;
            else return false;
        }
    }

}


