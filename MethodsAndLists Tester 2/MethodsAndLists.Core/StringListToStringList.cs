using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndLists.Core
{
    public class StringListToStringList
    {
        public IEnumerable<string> GetEverySecondElement(string[] strings)
        {

            //if (strings == null)
            //{
            //    throw new ArgumentException();
            //}

            //var result = new List<string>();
            //int everyother = 1;

            //foreach (string s in strings)
            //{
            //    if (everyother % 2 == 0)
            //        result.Add(s);

            //    everyother++;
            //}
            //return result;

            return strings.Where((x, index) => !(index % 2 == 0)).ToList(); // LINQ
        }
    }
}
