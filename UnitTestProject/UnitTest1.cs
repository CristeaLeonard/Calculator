using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NumarPrim()
        {
            int numar, i, ok = 1;

            numar = 1213;

            for (i = 2; i <= numar / 2; i++)
                if (numar % i == 0) { ok = 0; i = numar; }

            if (numar < 0) ok = -1;

            Assert.AreEqual(ok, 1);

        }

        [TestMethod]
        public void NumarNePrim()
        {
            int numar, i, ok = 1;

            numar = 1212;

            if (numar < 0) ok = -1;

            for (i = 2; i <= numar / 2; i++)
                if (numar % i == 0) { ok = 0; i = numar; }

            

            Assert.AreEqual(ok, 0);
        }

        [TestMethod]
        public void NumarNegativ()
        {
            int numar, i, ok = 1;

            numar = -1;

            if (numar < 0) ok = -1;

            for (i = 2; i <= numar / 2; i++)
                if (numar % i == 0) { ok = 0; i = numar; }
            
            Assert.AreEqual(ok, -1);
        }


    }
    
}
