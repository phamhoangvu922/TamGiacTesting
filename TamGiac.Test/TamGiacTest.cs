using NUnit.Framework;
using System;

namespace TamGiac.Test
{
    [TestFixture]
    class TamGiacTest
    {
        
        [Test]
        public void ConstructerTamGiacTestMacDinh()
        {
            TamGiac.TamGiacObj tamGiac = new TamGiac.TamGiacObj();

            Assert.AreEqual(0, tamGiac.A.X, "Gia tri X cua diem A khong chinh xac");
            Assert.AreEqual(0, tamGiac.A.Y, "Gia tri Y cua diem A khong chinh xac");
            Assert.AreEqual(0, tamGiac.B.X, "Gia tri X cua diem B khong chinh xac");
            Assert.AreEqual(0, tamGiac.B.Y, "Gia tri Y cua diem B khong chinh xac");
            Assert.AreEqual(0, tamGiac.C.X, "Gia tri X cua diem C khong chinh xac");
            Assert.AreEqual(0, tamGiac.C.Y, "Gia tri Y cua diem C khong chinh xac");

        }
        [Test]
        public void ConstructerTamGiacTest()
        {
            Diem A = new Diem(0, 2D);
            Diem B = new Diem(1D, 2D);
            Diem C = new Diem(4D, 0);
            TamGiac.TamGiacObj tamGiac = new TamGiac.TamGiacObj(A,B,C);

            Assert.AreEqual(0, tamGiac.A.X, "Gia tri X cua diem A khong chinh xac");
            Assert.AreEqual(2, tamGiac.A.Y, "Gia tri Y cua diem A khong chinh xac");
            Assert.AreEqual(1, tamGiac.B.X, "Gia tri X cua diem B khong chinh xac");
            Assert.AreEqual(2, tamGiac.B.Y, "Gia tri Y cua diem B khong chinh xac");
            Assert.AreEqual(4, tamGiac.C.X, "Gia tri X cua diem C khong chinh xac");
            Assert.AreEqual(0, tamGiac.C.Y, "Gia tri Y cua diem C khong chinh xac");

        }

        [Test]
        public void ChuViTest()
        {
            Diem A = new Diem(0, 0);
            Diem B = new Diem(1D, 0);
            Diem C = new Diem(0, 4D);
            TamGiacObj tamGiac = new TamGiacObj(A, B, C);

            double chuvi = tamGiac.ChuVi();
            double kq = Math.Sqrt(17) + 5;
            Assert.AreEqual(kq, chuvi, "Gia tri chu vi cua Tam Giac khong chinh xac");

        }

        [Test]
        public void LoaiTamGiacTestCan()
        {
            Diem A = new Diem(1D, 2D);
            Diem B = new Diem(0,0);
            Diem C = new Diem(2D, 0);
            TamGiac.TamGiacObj tamGiac = new TamGiac.TamGiacObj(A, B, C);

            int type = tamGiac.LoaiTamGiac();

            Assert.AreEqual(1, type, "Xac dinh loai tam giac can khong chinh xac");


        }
        [Test]
        public void LoaiTamGiacTestKhongPhai()
        {
            Diem A = new Diem(1D, 2D);
            Diem B = new Diem(0, 0);
            Diem C = new Diem(1D, 2D);
            TamGiac.TamGiacObj tamGiac = new TamGiac.TamGiacObj(A, B, C);

            int type = tamGiac.LoaiTamGiac();

            Assert.AreEqual(-1, type, "Xac dinh loai tam giac khong chinh xac");


        }
        [Test]
        public void LoaiTamGiacTestDeu()
        {
            double x = 0.25 * Math.Sqrt(3);
            Diem A = new Diem(0, 0);
            Diem B = new Diem(0.5D, 0);
            Diem C = new Diem(0.25D, x);
            TamGiac.TamGiacObj tamGiac = new TamGiac.TamGiacObj(A, B, C);

            int type = tamGiac.LoaiTamGiac();

            Assert.AreEqual(2, type, "Xac dinh loai tam giac deu khong chinh xac");


        }

        [Test]
        public void LoaiTamGiacTestThuong()
        {
            Diem A = new Diem(0, 0);
            Diem B = new Diem(0.5D, 0);
            Diem C = new Diem(0.25D, 1D);
            TamGiac.TamGiacObj tamGiac = new TamGiac.TamGiacObj(A, B, C);

            int type = tamGiac.LoaiTamGiac();

            Assert.AreEqual(0, type, "Xac dinh loai tam giac thuong khong chinh xac");


        }
    }
}