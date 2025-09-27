using Tyuiu.NazarovSV.Sprint1.Task4.V7.Lib;
namespace Tyuiu.NazarovSV.Sprint1.Task4.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(3.9, 4.9);
            Assert.AreEqual(200, res);
        }
    }
}
