using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectProgram
{
    [TestClass]
    public class TriangleTest
    {
        int texturestyle;
        Brush bb;
        Color c1 = Color.Black;

       
        [TestMethod]


        public void TestMethod1()
        {
            var t = new FinalAssignment.Triangle();
            int xi1 = 100, yi1 = 200, xi2 = 200;
            t.set(texturestyle, bb, c1, xi1, yi1, xi2);
            Assert.AreEqual(100, t.xi1);
        }
    }
}
