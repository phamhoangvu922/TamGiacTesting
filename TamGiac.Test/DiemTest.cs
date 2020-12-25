using System;
using NUnit.Framework;


namespace TamGiac.Test
{
    [TestFixture]
    public class DiemTest
    {
        [Test]
        public void ConstructerDiemTestMacDinh()
        {
            Diem diem = new Diem();
            Assert.AreEqual(0, diem.X, "X khong chinh xac");
            Assert.AreEqual(0, diem.Y, "Y khong chinh xac");
        }
        [Test]
        public void ConstructerDiemTest()
        {
            Diem diem = new Diem(1.4D,2D);
            Assert.AreEqual(1.4, diem.X, "X khong chinh xac");
            Assert.AreEqual(2, diem.Y, "Y khong chinh xac");
        }
        [Test]
        public void ConstructerDiemTestChuoi()
        {
            Diem diem = new Diem("2,3");
            Assert.AreEqual(2, diem.X, "X khong chinh xac");
            Assert.AreEqual(3, diem.Y, "Y khong chinh xac");
        }
        [Test]
        public void KhoangCachTest()
        {
            Diem diemA = new Diem(0,2D);
            Diem diemB = new Diem(0,4D);
            double x = diemA.KhoangCach(diemB);
            Assert.AreEqual(2, x, "Khoang cach khong chinh xac");
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