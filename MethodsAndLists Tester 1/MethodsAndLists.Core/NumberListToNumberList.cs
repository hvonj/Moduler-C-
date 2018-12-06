using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsAndLists.Core
{
    public class NumberListToNumberList
    {

        public List<int> Add70ToEverySecondElement(List<int> numbers)
        {
            {
                List<int> add70First = new List<int>();

                int x = 1; //håller koll på antal loopar vi gör
                foreach (var item in numbers)
                {
                    int addedNumber = item;

                    if (x % 2 ==0) //de tre första nr i listan.
                    {
                        addedNumber = item + 70; // vi vill lägga på 50 på de 3 första nr i listan.
                    }
                    add70First.Add(addedNumber);
                    x++; //för varje loop lägger vi på 1 på x, t.ex. loop2 är x = 2.
                }
                return add70First;
            }
        }

        public List<int> Add50ToFirstThreeElements(List<int> numbers)
        {
            {
                List<int> add50First = new List<int>();

                int x = 1; //håller koll på antal loopar vi gör
                foreach (var item in numbers)
                {
                    int addedNumber = item;

                    if (x <= 3) //de tre första nr i listan.
                    {
                        addedNumber = item + 50; // vi vill lägga på 50 på de 3 första nr i listan.
                    }
                    add50First.Add(addedNumber);
                    x++; //för varje loop lägger vi på 1 på x, t.ex. loop2 är x = 2.
                }
                return add50First;
            }
        }

        public List<int> NegateEachNumber(List<int> numbers)
        {
            var negativeNumbers = new List<int>();
            foreach (var number in numbers)
            {
                int x = number * -1;
                negativeNumbers.Add(x);
            }
            return negativeNumbers;

        }

        public List<int> DivideEachNumberBy100(List<int> numbers)
        {
            var numbersBy100 = new List<int>();
            foreach (int number in numbers)
            {
                int x = number / 100;
                numbersBy100.Add(x);
            }
            return numbersBy100;
        }

        public List<int> GetNumbersDividableByFive(List<int> numbers)
        {
            var divadableFive = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 5 == 0)        //för att dela respektive nr i listan med 5
                    divadableFive.Add(number);
            }
            return divadableFive;

        }

        public List<int> DoubleEachNumber(List<int> numbers)
        {
            var doubledNumbers = new List<int>();

            foreach (int number in numbers)
            {
                int d = number * 2;
                doubledNumbers.Add(d);
            }
            return doubledNumbers;
        }

        public List<int> DoubleEachNumber_Linq(List<int> numbers)
        {
            return numbers.Select(number => number * 2).ToList();
        }

        public List<int> GetNumbersHigherThan1000(List<int> numbers)
        {
            var higherThan1000 = new List<int>();
            foreach (var number in numbers)
            {
                if (number >= 1000)
                {
                    higherThan1000.Add(number);
                }
            } return higherThan1000;
        }

        public List<int> Add100ToEachNumber(List<int> numbers)
        {
            var add100ToEachNumber = new List<int>();  //en ny lista som lägger in alla nummer + 100
            foreach (int item in numbers)
            {
                int a = item + 100;
                add100ToEachNumber.Add(a);
            }
            return add100ToEachNumber;
             
        }

        public List<int> Add100ToEachNumber_Linq(List<int> numbers)
        {
            return numbers.Select(number => number + 100).ToList();
        }

        public List<int> GetNumbersHigherThan1000_Linq(List<int> input)
        {
            return input.Where(number => number > 1000).ToList();
        }

        public List<int> GetNumbersDividableByFive_linq(List<int> input)
        {
            return input.Where(number => (number % 5 == 0)).ToList(); //kolla OM det går att dela med ==0
        }

        public List<int> DivideEachNumberBy100_linq(List<int> input)
        {
            return input.Select(number => number / 100).ToList(); //nu VILL vi dela med 100
        }

        public List<int> NegateEachNumber_linq(List<int> input)
        {
            return input.Select(number => number * -1).ToList();
        }

        public List<int> Add50ToFirstThreeElements_linq(List<int> input)
        {
            return input.Take(3).Select(number => number + 50).Concat(input.Skip(3)).ToList(); //concat lägger ihop två sekvenser. Concat = +
        }

        public List<int> Add70ToEverySecondElement_linq(List<int> input)
        {
            return input.Select((x, index) => x + ((index % 2 == 0) ? 0 : 70)).ToList();

                // ? vi vill göra olika saker berodende på om det är sant eller falskt.. : menar sant : falskt
                //   ? 0 : 70
        }
    }
}