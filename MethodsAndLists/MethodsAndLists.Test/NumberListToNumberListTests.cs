// L�s uppgifterna med och utan Linq (g�r allts� tv� olika metoder)
using MethodsAndLists.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MethodsAndLists.Test
{
    [TestClass]
    public class NumberListToNumberListTests
    {
        NumberListToNumberList x = new NumberListToNumberList();

        // Demo: dubblera alla tal i listan
        // Demo: dubblera alla tal i listan. Hoppa �ver negativa tal.

        [TestMethod]
        public void DoubleEachNumberInList()
        {
            List<int> input = new List<int> { 7, 10, 30, 88 };
            List<int> expected = new List<int> { 14, 20, 60, 176};
            List<int> result = x.DoubleEachNumber(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DoubleEachNumberInList_Linq()
        {
            List<int> input = new List<int> { 7, 10, 30, 88 };
            List<int> expected = new List<int> { 14, 20, 60, 176 };
            List<int> result = x.DoubleEachNumber_Linq(input);

            CollectionAssert.AreEqual(expected, result);
        }


        [TestMethod]
        public void Add100ToEachNumber()
        {
            // Addera 100 till varje siffra i listan

            var input = new List<int> { 5, 15, 23, 200 };
            var expected = new List<int> { 105, 115, 123, 300 };
            var result = x.Add100ToEachNumber(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add100ToEachNumber_Linq()
        {
            // Addera 100 till varje siffra i listan

            var input = new List<int> { 5, 15, 23, 200 };
            var expected = new List<int> { 105, 115, 123, 300 };
            var result = x.Add100ToEachNumber_Linq(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetNumbersHigherThan1000_Linq()
        {
            // Filtrera ut de tal som �r h�gre �n 1000

            var input = new List<int> { 1005, 6, 77, 200000, 666 };
            var expected = new List<int> { 1005, 200000 };
            var result = x.GetNumbersHigherThan1000_Linq(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetNumbersHigherThan1000()
        {
            // Filtrera ut de tal som �r h�gre �n 1000

            var input = new List<int> { 1005, 6, 77, 200000, 666 };
            var expected = new List<int> { 1005, 200000 };
            var result = x.GetNumbersHigherThan1000(input);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetNumbersDividableByFive()
        {
            // Filtrera ut de tal som �r delbara med fem

            var input = new List<int> { 20, 5, 6, 7, 10 };
            var expected = new List<int> { 20, 5, 10 };
            var result = x.GetNumbersDividableByFive(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetNumbersDividableByFive_Linq()
        {
            // Filtrera ut de tal som �r delbara med fem

            var input = new List<int> { 20, 5, 6, 7, 10 };
            var expected = new List<int> { 20, 5, 10 };
            var result = x.GetNumbersDividableByFive_linq(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DivideEachNumberBy100()
        {
            // Dela alla tal i listan med 100

            var input = new List<int> { 300, 200, -500, 1000 };
            var expected = new List<int> { 3, 2, -5, 10 };
            var result = x.DivideEachNumberBy100(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DivideEachNumberBy100_Linq()
        {
            // Dela alla tal i listan med 100

            var input = new List<int> { 300, 200, -500, 1000 };
            var expected = new List<int> { 3, 2, -5, 10 };
            var result = x.DivideEachNumberBy100_linq(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NegateEachNumber()
        {
            // Negera alla tal i listan

            var input = new List<int> { 10, 20, -30, 40 };
            var expected = new List<int> { -10, -20, 30, -40 };
            var result = x.NegateEachNumber(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NegateEachNumber_Linq()
        {
            // Negera alla tal i listan

            var input = new List<int> { 10, 20, -30, 40 };
            var expected = new List<int> { -10, -20, 30, -40 };
            var result = x.NegateEachNumber_linq(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add50ToFirstThreeElements()
        {
            // Addera 50 till de tre f�rsta elementen i listan

            var input = new List<int> { 6, 16, 23, 200, 300 };
            var expected = new List<int> { 56, 66, 73, 200, 300 };
            var result = x.Add50ToFirstThreeElements(input);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add50ToFirstThreeElements_linq()
        {
            // Addera 50 till de tre f�rsta elementen i listan

            var input = new List<int> { 6, 16, 23, 200, 300 };
            var expected = new List<int> { 56, 66, 73, 200, 300 };
            var result = x.Add50ToFirstThreeElements_linq(input);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add50ToFirstThreeElements_ShortList()
        {
            // Addera 50 till de tre f�rsta elementen i listan

            var input = new List<int> { 6, 16 };
            var expected = new List<int> { 56, 66 };
            var result = x.Add50ToFirstThreeElements(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add70ToEverySecondElement()
        {
            // Addera 70 till varannat element i listan

            var input = new List<int> { 1000, 2000, 3000, 4000, 5000 };
            var expected = new List<int> { 1000, 2070, 3000, 4070, 5000 };
            var result = x.Add70ToEverySecondElement(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add70ToEverySecondElement_Linq()
        {
            // Addera 70 till varannat element i listan

            var input = new List<int> { 1000, 2000, 3000, 4000, 5000 };
            var expected = new List<int> { 1000, 2070, 3000, 4070, 5000 };
            var result = x.Add70ToEverySecondElement_linq(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CombineTwoMethods()
        {
            // Addera 50 till de tre f�rsta elementen i listan

            var input = new List<int> { 300, 200, -500, 1000 };
            var expected = new List<int> { -3, -2, 5, -10 };
            var result = x.DivideEachNumberBy100(x.NegateEachNumber(input));
            CollectionAssert.AreEqual(expected, result);
        }

    }
}
