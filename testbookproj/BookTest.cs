using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace testbookproj
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void CheckReserved_1_ReturnTrue()
        {
            var book = new Book();
            var result = book.CheckReserved(1);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckReserved_2_ReturnFalse()
        {
            var book = new Book();
            var result = book.CheckReserved(2);
            Assert.IsFalse(result);
        }
    }
}
