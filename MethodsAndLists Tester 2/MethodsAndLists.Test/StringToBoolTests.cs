using MethodsAndLists.Core;
using MethodsAndLists.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodsAndLists.Test
{
    [TestClass]
    public class StringToBoolTests
    {
        [TestMethod]
        public void IsPalindrome()
        {
            var x = new StringToBool();
            bool result = x.IsPalindrome("hannah");
            Assert.IsTrue(result);


        }

    }
}
