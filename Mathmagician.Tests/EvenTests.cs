using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class EvenTests
    {
        [TestMethod]
        public void EvenEnsureICanCreateInstance()
        {
            Even my_evens = new Even();
            Assert.IsNotNull(my_evens);
        }
    }
}
