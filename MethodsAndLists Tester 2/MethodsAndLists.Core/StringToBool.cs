using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodsAndLists.Core
{

    public class StringToBool
    {
        public bool IsPalindrome(string word)
        {
            string x = word; //ordet man vill kolla 
            string y = new string(x.Reverse().ToArray()); //bearbetar strängen till en lista / array
            y.ToLower(); //små bokstäver

            if (word != y) //om det bearbetade ordet INTE är samma som inputen så retunera falskt
            {
                return false;
            }
            else
            {
                return true; //annars retunera sant
            }

        } 
    } 
}
