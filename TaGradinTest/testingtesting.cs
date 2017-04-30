using System;
using GRADES;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaGradinTest
{
    [TestClass]
    public class ReferanceTypeTests
    {

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void BookOfGradesVariablesHoldAReference()
        {
            BookOfGrades g1 = new BookOfGrades();
            BookOfGrades g2 = g1;

            g1.Name = "Brooklyn's book of grades";
            Assert.AreEqual(g1.Name, g2.Name);

            

        }
    }
}
