using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace TamGiacTest
{
    [TestFixture]
    class DiemTest
    {
        [Test]
        public void ConstructerDiemTest()
        {
            TamGiac.Diem diem = new TamGiac.Diem();
            Assert.AreEqual(0, diem.X, "X khong chinh xac");
            Assert.AreEqual(0, diem.Y, "Y khong chinh xac");
        }
        [Test]
        public void ToStringDiemTest()
        {
            TamGiac.Diem diem = new TamGiac.Diem(0, 2f);
            String test = diem.ToString();
            Assert.AreEqual("0,2", test, "toString khong chinh xac");
        }
    }
}
