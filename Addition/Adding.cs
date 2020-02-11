using System;
using MathOperations;

namespace Addition
{
    public interface IAdd
    {
        public dynamic Sum(dynamic a, dynamic b);
        public dynamic Sum(dynamic arrayList);
    }
    public class Adding : IAdd
    {
        private static dynamic _result;

        public static dynamic Result
        {
            get => _result;
            set => _result = value;
        }
        public dynamic Sum(dynamic a, dynamic b)
        {
            Result = MathOperations.Addition.Sum(a, b);
            return Result;
        }
        public dynamic Sum(dynamic arrayList)
        {
            Result = MathOperations.Addition.Sum(arrayList);
            return Result;

        }
    }
}
