using NUnit.Framework;
using Tsts;

namespace TstsTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
         //working   
        }

        [Test]
        public void CheckWrkMethodSubstract()
        {
            double need = 0;
            HomeTask hmt = new HomeTask(10);
            hmt.SubtractNumFromWrk(10);
            Assert.AreEqual(need,hmt.GetWrk());
        }
        [Test]
        public void CheckHmtMethodAdd()
        {
            double need = 10;
            HomeTask hmt = new HomeTask(0);
            hmt.AddPrice(10);
            Assert.AreEqual(need,hmt.GetWrk());
        }
        [Test]
        public void CheckCarMethodIncrease()
        {
            double need = 10;
            Car car = new Car(2);
            car.IncreasePrice(5);
            Assert.AreEqual(need,car.GetPrice());
        }
        [Test]
        public void CheckCarMethodShare()
        {
            double need = 10;
            Car car = new Car(20);
            car.SharePrice(2);
            Assert.AreEqual(need,car.GetPrice());
        }
    }
}