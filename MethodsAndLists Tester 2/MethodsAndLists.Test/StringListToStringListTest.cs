﻿using System;
using System.Linq;
using MethodsAndLists.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MethodsAndLists.Test
{
    [TestClass]
    public class StringListToStringListTests
    {
        readonly StringListToStringList x = new StringListToStringList();

        [TestMethod]
        //[datarow(null, new string[] { }, new[] { "a" })]
        //[datarow(null, new string[] { "b" }, new[] { "a", "b" })]
        //[datarow(null, new string[] { "b" }, new[] { "a", "b", "c" })]
        //[datarow(null, new string[] { "b", "d" }, new[] { "a", "b", "c", "d" })]
        [DataRow(null, new string[] { "b", "d" }, new[] { "a", "b", "c", "d", "e" })]

        public void GetEverySecondElement_MultipleTests(object dummy, string[] expected, string[] input)
        {
            Assert.ThrowsException<ArgumentNullException>(() => x.GetEverySecondElement(null).ToArray());

            var result = x.GetEverySecondElement(input).ToArray();
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetEverySecondElement_Null()
        {
            Assert.ThrowsException<ArgumentNullException>(() => x.GetEverySecondElement(null).ToArray());
        }

    }
}
