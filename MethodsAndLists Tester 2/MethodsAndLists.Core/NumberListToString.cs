using System.Collections.Generic;
using System.Linq;
using System;

namespace MethodsAndLists.Core
{
    public class NumberListToString
    {
        // Demo: returnera "fjärde talet är jättestort" om det är större än 10000

        public string ReportNumberOfNegativeValues(List<int> numbers)
            ////int negativeNumbersCounter = 0;
            //foreach (var number in numbers)
            //{
            //    if (number< 0)
            //        negativeNumbersCounter++;
            //}
        {
            var negativeValues = new List<int>();

            foreach (var number in numbers)
            {
                if (number < 0)
                {
                    negativeValues.Add(number);
                }
                else
                {
                    continue;
                }
            }
            if (negativeValues.Count == 0)
            {
               return $"Jippi! Det finns inga negativa tal i listan";
            }
            if (negativeValues.Count == 1)
            {
                return $"Det finns ett negativt tal i listan";
            }
            else
            {
                return $"Det finns {negativeValues.Count} st negativa tal i listan"; // "Det finns " + negativeNumbersCounter + " st negativa tal i listan";
            }
        }

        public string ReportIfAllValuesAreHigherThan100(List<int> numbers)
        {
            var higherThan100 = new List<int>();

            foreach (var item in numbers)
            {
                if (item > 100)
                {
                    higherThan100.Add(item);
                }
                else
                {
                    continue;
                }

            }
            if (higherThan100.Count == numbers.Count)
            {
                return $"Alla nummer är högre än 100";
            }
            else
            {
                return $"Något nummer är lägre än (eller lika med) 100";
            }

        }

        public string ReportFirstAndLastValue(List<int> numbers)
        {
            int first = numbers.First();    //första siffran i listan (alltså EJ högsta och lägsta siffran i listan)
            int last = numbers.Last();      // sista siffran i listan

            return $"Första siffran är {first} och sista siffran är {last}";
            //if (numbers == null || numbers.Count == 0)

            //throw new ArgumentException();

            //int first = numbers[0];
            //int lastIndex = numbers.Count - 1;
            //int last = numbers[lastIndex];

            //return "Första siffran är " + first + " och sista siffran är " + last;

        }

        public string ReportFirstAndLastValue_Linq(List<int> numbers)
        {
            return $"Första siffran är {numbers.First()} och sista siffran är {numbers.Last()}.";
        }
    }
}