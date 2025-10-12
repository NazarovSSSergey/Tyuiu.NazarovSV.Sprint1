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
            var res = ds.Calculate(3.5, 3.5);
            Assert.AreEqual(0.091, res);
        }
    }
}
