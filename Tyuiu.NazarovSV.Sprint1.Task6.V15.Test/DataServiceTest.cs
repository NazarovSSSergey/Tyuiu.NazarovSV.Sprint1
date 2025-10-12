using Tyuiu.NazarovSV.Sprint1.Task6.V15.Lib;
namespace Tyuiu.NazarovSV.Sprint1.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.CheckLettersCount("asdwadwadawdaw219321-436886===adwasdwadwadadaw");
            Assert.AreEqual(true, res);
        }
    }
}
