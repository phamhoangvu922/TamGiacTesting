using System;
using NUnit.Framework;


namespace TamGiac.Test
{
    [TestFixture]
    public class DiemTest
    {
        [Test]
        public void ConstructerDiemTest()
        {
            Diem diem = new Diem();
            Assert.AreEqual(0, diem.X, "X khong chinh xac");
            Assert.AreEqual(0, diem.Y, "Y khong chinh xac");
        }
        [Test]
        public void ToStringDiemTest()
        {
            Diem diem = new Diem(0, 2f);
            String test = diem.ToString();
            Assert.AreEqual("0,2", test, "toString khong chinh xac");
        }
    }
}