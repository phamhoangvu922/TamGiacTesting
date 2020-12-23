using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace TamGiac.Test
{
    [TestFixture]
    class TamGiacTest
    {
        [Test]
        public void ConstructerTamGiacTest()
        {
            TamGiac tamGiac = new TamGiac();

            Assert.AreEqual(0, tamGiac.A.X, "Gia tri X cua diem A khong chinh xac");
            Assert.AreEqual(0, tamGiac.A.Y, "Gia tri Y cua diem A khong chinh xac");
            Assert.AreEqual(0, tamGiac.B.X, "Gia tri X cua diem B khong chinh xac");
            Assert.AreEqual(0, tamGiac.B.Y, "Gia tri Y cua diem B khong chinh xac");
            Assert.AreEqual(0, tamGiac.C.X, "Gia tri X cua diem C khong chinh xac");
            Assert.AreEqual(0, tamGiac.C.Y, "Gia tri Y cua diem C khong chinh xac");

        }
    }
}
