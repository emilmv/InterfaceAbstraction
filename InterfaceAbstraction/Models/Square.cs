using System.Reflection.Metadata.Ecma335;

namespace InterfaceAbstraction.Models
{
    internal class Square : Figure
    {
        public override void CalcArea()
        {
            Console.WriteLine($"Area of the Square: {Side*Side}");
        }
        private double _side;
        public double Side
        {
            get => _side;
            set
            {
                if (value < 0) return;
                _side = value;
            }
        }
        public Square(double side)
        {
            Side = side;
        }
    }

    
}
