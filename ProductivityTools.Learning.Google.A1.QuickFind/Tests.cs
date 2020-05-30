using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.A1.QuickFind
{
    [TestClass]
    public class Tests
    {
       

        public Tests()
        {
            
        }

        private void MakeTests(Base qf)
        {
            Assert.IsFalse(qf.Connected(1, 2));
            qf.Union(1, 2);
            Assert.IsTrue(qf.Connected(1, 2));

            Assert.IsFalse(qf.Connected(0, 1));
            qf.Union(0, 2);
            Assert.IsTrue(qf.Connected(0, 2));
        }
      
        [TestMethod]
        public void QuickFind()
        {
            QuickFindAlghoritm qf = new QuickFindAlghoritm(4);
            MakeTests(qf);
        }

        [TestMethod]
        public void QuickUnionAlghoritm()
        {
            QuickUnionAlghoritm qf = new QuickUnionAlghoritm(4);
            MakeTests(qf);
        }
    }
}
