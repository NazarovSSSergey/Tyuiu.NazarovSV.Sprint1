using Tyuiu.NazarovSV.Sprint1.Task1.V15.Lib;
namespace Tyuiu.NazarovSV.Sprint1.Task1.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServiceTest ds = new DataServiceTest();
            double x = 12.0;
            var res = ds.(x);
            Assert.AreEqual(4, res);

        }
    }
}
