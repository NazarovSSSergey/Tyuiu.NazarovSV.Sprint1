using Tyuiu.NazarovSV.Sprint1.Task0.V20.Lib;

namespace Tyuiu.NazarovSV.Sprint1.Task0.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(2, 2);
            Assert.AreEqual(2, res);
        }
    }
}
