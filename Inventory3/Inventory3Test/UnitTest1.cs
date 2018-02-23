using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inventory3;
using System.Collections.Generic;

namespace Inventory3Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<item> newlist = new List<item>();
            ProductRepository pr = new ProductRepository(newlist);
            int actual = pr.total_ProductNumber(newlist);
            int expected = 10;
            Assert.AreEqual(actual, expected);
            newlist = new List<item>();
            pr = new ProductRepository(newlist);
            pr.add_NewProduct(newlist);
            int actual_1 = pr.total_ProductNumber(newlist);
            int expected_1 = 11;
            Assert.AreEqual(actual_1, expected_1);
            newlist = new List<item>();
            pr = new ProductRepository(newlist);
            var a= pr.deleteProduct(newlist, "zucchini");
            var b= pr.deleteProduct(a, "broccoli");
            int actual_2 = pr.total_ProductNumber(b);
            int expected_2 = 8;
            Assert.AreEqual(actual_2, expected_2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<item> newlist = new List<item>();
            ProductRepository pr = new ProductRepository(newlist);
            pr.add_NewProduct(newlist);
            int Actual=pr.total_ProductNumber(newlist);
            int expected = 11;
            Assert.AreEqual(Actual, expected);

            var a=pr.add_NewProduct(newlist);
              Assert.AreEqual(10,a.FindIndex(p1 => p1.Name.Equals("Potato")));
       
        }

        [TestMethod]
        public void TestMethod3()
        {
            List<item> newlist = new List<item>();
            ProductRepository pr = new ProductRepository(newlist);
           var a=pr.findProductByType(newlist, "Cruciferous");
            Assert.AreEqual(3,a.Count);
            newlist = new List<item>();
            pr = new ProductRepository(newlist);
           var b= pr.findProductByType(newlist, "Marrow");
            foreach (var item in b)
            {
                if (item.Type.Equals("Marrow"))
                    Assert.IsTrue(true);
                else
                    Assert.IsFalse(false);
            }


        }
        [TestMethod]
        public void TestMethod4()
        {
            List<item> newlist = new List<item>();
            ProductRepository pr = new ProductRepository(newlist);
           
            Assert.AreEqual(9, pr.deleteProduct(newlist, "pumpkin").Count);
            pr.deleteProduct(newlist, "Cabbage");
            var a=newlist.FindAll(p1=>p1.Name.Equals("Cabbage"));
            Assert.AreEqual(0,a.Count);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Quantity Per KG
            double total = 0;
            List<item> newlist = new List<item>();
            ProductRepository pr = new ProductRepository(newlist);
           total=pr.totalBoughtProduct(newlist, "lettuce",3)
                         + pr.totalBoughtProduct(newlist, "cabbage", 3)
                         + pr.totalBoughtProduct(newlist, "pumpkin", 1)
                         + pr.totalBoughtProduct(newlist, "zucchini", 2)
                         + pr.totalBoughtProduct(newlist, "spinach", 1)
                          + pr.totalBoughtProduct(newlist, "broccoli", 3)
                          + pr.totalBoughtProduct(newlist, "silverbeet", 3);
            Console.WriteLine(total);
          Assert.AreEqual(263.1,total);

            


        }
    }

}
