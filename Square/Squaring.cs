using System;
using MathOperations;

namespace Square
{
    public interface ISquare
    {
        public dynamic Power(dynamic a, dynamic b);
    }
    public class Squaring : ISquare
    {
        private static dynamic _result;

        public static dynamic Result
        {
            get => _result;
            set => _result = value;
        }

        public static void Main()
        {
        }
        public dynamic Power(dynamic a, dynamic b)
        {
            Result = MathOperations.Exponentiation.Power(a, b);
            return Result;
        }
    }
}
