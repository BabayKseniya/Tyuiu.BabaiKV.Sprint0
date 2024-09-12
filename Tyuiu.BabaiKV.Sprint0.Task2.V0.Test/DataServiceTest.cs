using Tyuiu.BabaiKV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.BabaiKV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Ксения";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Ксения", res);
        }

    }
}