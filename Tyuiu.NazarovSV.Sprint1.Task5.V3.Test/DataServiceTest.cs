using Tyuiu.NazarovSV.Sprint1.Task5.V3.Lib;
namespace Tyuiu.NazarovSV.Sprint1.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(9);
            Assert.AreEqual(0, res);
        }
    }
}
