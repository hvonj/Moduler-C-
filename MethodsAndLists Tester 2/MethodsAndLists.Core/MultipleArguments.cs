using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MethodsAndLists.Core.Enums;



namespace MethodsAndLists.Core
{
    public class MultipleArguments
    {
        private int index;

        public List<string> SomeToUpper(List<string> list, List<bool> toUpper)
        {
            var nylista = new List<string>();
            int i = 0;
            foreach (var word in list)

            {
                if (toUpper[i] == true)
                    nylista.Add(word.ToUpper());

                else
                    nylista.Add(word);
                i++;
            }

            return nylista;
        }


        public List<double> MultiplyAllBy(int factor, List<double> numbers)
        {
            if (numbers == null)
                throw new ArgumentException();


            var result = new List<double>();

            foreach (var number in numbers)
            {
                result.Add(number * factor);
            }

            return result;
        }

        public List<double> MultiplyAllBy_Linq(int factor, List<double> numbers)

        {
            if (numbers == null)
                throw new ArgumentException();

            return numbers.Select(x => x * factor).ToList();

        }


        public List<string> NearbyElements(int position, List<string> list)

        {
            if (position < 0 || position > list.Count - 1)

                throw new ArgumentException();

            List<string> near = new List<string>();

            if (position == 0)
            {
                near.Add(list[position]);
                near.Add(list[position + 1]);
                return near;
            }
            if (position == (list.Count - 1)) //är position sista värdet då lägger vi på nästsista värdet plus sista värdet
            {
                near.Add(list[position - 1]);
                near.Add(list[position]);
                return near;
            }
            else //annars så tar vi bokstaven innan samt bokstaven efter input
            {
                near.Add(list[position - 1]);
                near.Add(list[position]);
                near.Add(list[position + 1]);
                return near;
            }

        }



        public List<List<int>> MultiplicationTable(int rowMax, int colMax)

        {
            if (rowMax == 0 || colMax == 0)
            {
                throw new ArgumentException();
            }

            var result = new List<List<int>>();

            for (int x = 1; x <= rowMax; x++)
            {
                var rows = new List<int>();

                for (int i = 1; i <= colMax; i++)
                {
                    int mult = x * i;
                    rows.Add(mult);
                }
                result.Add(rows);
            }
            return result;
        }



        public List<List<int>> MultiplicationTable_Linq(int rowMax, int colMax)

        {

            if (rowMax <= 0 || colMax <= 0)
                throw new ArgumentException();

            return Enumerable.Range(1, rowMax).Select(r => Enumerable.Range(1, colMax).Select(c => c * r).ToList()).ToList();

        }


        public int ComputeSequenceSumOrProduct(int toNumber, bool sum)

        {

            if (toNumber <= 0) //att input ska vara RÄTT (inte null) input mindre eller likamed
            {
                throw new ArgumentException();
            }

            if (sum)
            {
                int result;

                result = Enumerable.Range(0, toNumber + 1).Sum();

                return result;
            }
            else
            {
                int result2;

                result2 = Enumerable.Range(1, toNumber).Aggregate(1, (a, b) => a * b); //multipl.

                return result2;
            }
        }



        public int ComputeSequence(int toNumber, ComputeMethod sum)

        {
            if (toNumber <= 0) //att input ska vara RÄTT (inte null) input mindre eller likamed
            {
                throw new ArgumentException();
            }

            if (sum == ComputeMethod.Sum)
                return ComputeSequenceSumOrProduct(toNumber, true);
            else // (sum == ComputeMethod.Product)
                return ComputeSequenceSumOrProduct(toNumber, false); //VAD BETYDER DETTA?! NÄR ANVÄNDER MAN DETTA?!
        }



        public int[] CombineLists(int[] list1, int[] list2)

        {

            var result = new List<int>();

            for (int i = 0; i < Math.Max(list1.Length, list2.Length); i++)
            {
                if (i <= list1.Length - 1)
                    result.Add(list1[i]);

                if (i <= list2.Length - 1)
                    result.Add(list2[i]);
            }

            return result.ToArray();
        }



        public void Kalle()
        {
            Console.WriteLine("yyy");
            string x = Console.ReadLine();

            if (x == "ja")
            {
                return;
            }

            Console.WriteLine("xxx");
        }



        public int Lisa()
        {
            Console.WriteLine("yyy");
        }

        public int[] RotateList(int[] list, int rotation)

        {
            if (list == null)
                throw new ArgumentException();

            var newList = list.ToList();

            if (rotation == 0)  //om input är 0 så ska vi retunera listan som den är 
            {
                return list;
            }

            if (rotation > 0)
            {
                int moving;

                for (int i = 0; i < rotation; i++)
                {
                    moving = newList[list.Length - 1];      //om rotationen är större än 0 så ska vi flytta listan (ta bort den sista och sätter längst fram)
                    newList.RemoveAt(newList.Count - 1); // ta bort sista elementet i "newList"
                    newList.Insert(0, moving);          // lägg in heltalet "moving" först i "newList"
                }
                return newList.ToArray();
            }

            else
            {
                int times = rotation * -1;
                int moving2;

                for (int i = 0; i < times; i++)
                {
                    moving2 = newList[0];
                    newList.Insert(newList.Count, moving2); // tar bort första och sätter längst bak (-2 rotera till vänster, +2 rotera till höger)
                    newList.RemoveAt(0);
                }
                return newList.ToArray();

                // Linq (Skip och Take) ....list.Skip, list.Take (plocka ut första och sista delen i listan)               

                //return list.Select((x, i) => list[(i - rotation % list.Length + list.Length) % list.Length]).ToArray();
            }
        }
    }
}

