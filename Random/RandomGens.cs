using System;

namespace RandomGen
{
    public class Randos
    {
        public static int Generate(int seed)
        {
            var _random = new Random(seed);
            int _randomNum = _random.Next();
            return _randomNum;
        }

        public static int Generate(int seed, int rangeMin, int rangeMax)
        {
            var _random = new Random(seed);
            int _randomNum = _random.Next(rangeMin, rangeMax);
            return _randomNum;
        }

        public static int[] Generate(int seed, int size)
        {
            var _random = new Random(seed);
            int[] result = new int[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = _random.Next();
            }

            return result;
        }

        public static decimal Generate(decimal seed)
        {
            var _random = new Random((int)seed);

            decimal _randomNum = (decimal)_random.NextDouble();
            _randomNum = (decimal)Math.Round(_randomNum, 1);

            return _randomNum;
        }

        public static decimal Generate(decimal seed, double rangeMin, double rangeMax)
        {
            var _random = new Random((int)seed);

            decimal _randomNum = (decimal)(_random.NextDouble() * (rangeMax - rangeMin) + rangeMin);
            _randomNum = (decimal)Math.Round(_randomNum, 2);

            return _randomNum;
        }

        public static decimal[] Generate(decimal seed, int size)
        {
            var _random = new Random((int)seed);
            decimal _randomNum;
            decimal[] result = new decimal[size];

            for (int i = 0; i < size; i++)
            {
                _randomNum = (decimal)_random.NextDouble();
                _randomNum = (decimal)Math.Round(_randomNum, 2);

                result[i] = _randomNum;
            }

            Console.WriteLine(result[4]);

            return result;
        }

    }
}


/*#5
 *
 * If selection of:
 * 0
 * 1
 * 2
 * 3
 *
 * Random function with seed 5 and range of 0-3
 *
 * Then select the value from the list
 */