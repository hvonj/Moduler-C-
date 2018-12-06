using System;
using System.Collections.Generic;
using MethodsAndLists.Core.Models;



namespace MethodsAndLists.Core
{
    public class StringToObjectList
    {
        public List<City> ParseCities(string input)
        {
            //"Göteborg,401956;Lomma,13016;Mönsterås,5201;Östra Tommarp,293"
            if (input == null) //inte skrivit något alls
            {
                throw new ArgumentException();
            }

            List<City> cities = new List<City>();

            if (string.IsNullOrWhiteSpace(input)) //inte skrivit något eller bara mellanslag
            {
                return cities; //retunera en tom lista
            }
            else
            {
                                //annars så gör vi detta....


                string[] x = input.Split(';');

                foreach (var item in x)
                {
                    var c = new City();
                    string[] y = item.Split(',');
                    c.Name = y[0]; //första elementet namn
                    c.Population = int.Parse(y[1]); //andra elementet populationen
                    cities.Add(c);
                }

                return cities;
            }
        }
    }
}