using System;

using System.Linq;



namespace MethodsAndLists.Core

{
    public class NumberToNumber

    {
        public int SumNumbersTo(int input)
        {
            if (input <= 0)
            {
                throw new ArgumentException();
            }

            int sum = 0;
            for (int x = 1; x <= input; x++) //läs på om for-loopar
            {
                sum += x;
            }
            return sum;
        }

        public int SumNumbersTo_WithoutLinq(int input)
        {
            throw new NotImplementedException();
        }

        public int SumNumbers(int from, int to) //count - hur många ggr vi ska göra detta
        {       //3 > 6
            if (from > to)
            {
                throw new ArgumentException(); //om siffran du börjar på (from) är större än siffran du vill sluta på (to) så...
            }

            int stop = to - from +1; //
            // Enumerable.Range(från vilket den ska börja, hur många gånger den ska loopa).Sum();
            int result = Enumerable.Range(from, stop).Sum();
            return result;
        }

        public int SumNumbersDividedByThreeOrFive(int input)
        {
            if (input <= 0)
            {
                throw new ArgumentException(); //om siffran du börjar på (from) är större än siffran du vill sluta på (to) så...
            }

            return Enumerable.Range(1, input).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }
    }

}