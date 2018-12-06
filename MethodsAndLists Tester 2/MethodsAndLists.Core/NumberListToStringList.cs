using System;
using System.Collections.Generic;

namespace MethodsAndLists.Core
{
    public class NumberListToStringList
    {

        public List<string> LongOrShort(List<int> heightList)
        {
            List<string> longOrShort = new List<string>();

            foreach (var number in heightList)
            {
                if (number > 100 && number < 300)
                {
                    if (number > 160)
                    {
                        string high = $"{number}cm är långt";
                        longOrShort.Add(high);
                    }
                    if (number < 160)
                    {
                        string kort = $"{number}cm är kort";
                        longOrShort.Add(kort);
                    }
                }
                else
                {
                    continue;
                }

            } return longOrShort;

        } 

        public List<string> NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(List<int> numbers)
        {
            List<string> zipZap = new List<string>();
            foreach (var number in numbers)
            {
                if (number < 0)
                {
                    string x = "ZIP";
                    zipZap.Add(x);
                }
                if (number > 0)
                {
                    string y = "ZAP";
                    zipZap.Add(y);
                }
                if (number == 0)
                {
                    string i = "BOING";
                    zipZap.Add(i);
                }
            }
            return zipZap;
        } 
        
        public List<string> AddStarsToNumbersHigherThan1000(List<int> numbers)
        {
            List<string> starsHigherThan1000 = new List<string>();

            foreach (var number in numbers)
            {
                if (number > 1000)
                {
                    string x = "***" + number + "***";
                    starsHigherThan1000.Add(x);
                }
                else
                {
                    string y = $"{number}";
                    starsHigherThan1000.Add(y);
                }
            }

            return starsHigherThan1000;
        }

        public List<string> AddStars(List<int> list)
        {
                List<string> starList = new List<string>();
                foreach (var number in list)
                {
                    string x = "***" + number + "***";
                    starList.Add(x);
                }
        return starList;
        } 
    }
}