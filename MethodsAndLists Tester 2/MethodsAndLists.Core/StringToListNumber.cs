using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MethodsAndLists.Core

{
    public class StringListToNumber
    {

        public int ElevatorGoUpAndDown(string[] input)
        {
            int hiss = 0; //public = synlig för andra, private = osynlig, 
            // static = kopplad till klassen i sig (den blir gemensam tex. alla fotbollsspelare får samma ålder)
            foreach (var item in input)
            {
                if (item == "UPP")
                {
                    hiss++;
                }
                if (item == "NER")
                    hiss--;

            } return hiss;
        }



        public int ElevatorGoUpAndDown_Linq(string[] input)
        {
            int hiss2 =0;

            input.Sum(x => x == "UPP" ? hiss2++: hiss2--); //? betyder true or false (IF)
            return hiss2;
        }
    }
}
