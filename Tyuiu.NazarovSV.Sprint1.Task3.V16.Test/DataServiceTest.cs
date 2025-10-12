using Tyuiu.NazarovSV.Sprint1.Task3.V16.Lib;
namespace Tyuiu.NazarovSV.Sprint1.Task3.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.CoeffOfQuadraticEquation(3.1, 3.1);
            Assert.AreEqual(-6.2, res);
        }
    }
}
