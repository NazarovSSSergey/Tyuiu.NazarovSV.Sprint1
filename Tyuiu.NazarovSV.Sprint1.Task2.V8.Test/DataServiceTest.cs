using Tyuiu.NazarovSV.Sprint1.Task2.V8.Lib;
namespace Tyuiu.NazarovSV.Sprint1.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.CalculatePerimetr(4, 4);
            Assert.AreEqual(16, res);
        }
    }
}
