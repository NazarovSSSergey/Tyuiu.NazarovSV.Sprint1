using Tyuiu.NazarovSV.Sprint1.Task7.V3.Lib;
namespace Tyuiu.NazarovSV.Sprint1.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(9.5, 9.5);
            Assert.AreEqual(5.775, res);
        }
    }
}
