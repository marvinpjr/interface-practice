using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MessingWithInterfaces
{
    [TestClass]
    public class PlayingWithFireTests
    {
        [TestMethod]
        public void All_Items_In_Furnace_Will_Burn()
        {
            Paper bluePaper = new Paper();
            Paper redPaper = new Paper();
            Paper greenPaper = new Paper();
            Paper yellowPaper = new Paper();
            
            TrashBag bag = new TrashBag();
            bag.Add(greenPaper);
            bag.Add(redPaper);

            Car car = new Car();
            car.ThrowInTrunk(bag);

            Furnace furnace = new Furnace();
            furnace.Add(car);
            furnace.Add(bluePaper);

            Assert.IsFalse(greenPaper.IsOnFire);
            Assert.IsFalse(bluePaper.IsOnFire);
            Assert.IsFalse(redPaper.IsOnFire);
            Assert.IsFalse(yellowPaper.IsOnFire);

            furnace.Light();

            Assert.IsTrue(greenPaper.IsOnFire);
            Assert.IsTrue(bluePaper.IsOnFire);
            Assert.IsTrue(redPaper.IsOnFire);
            Assert.IsFalse(yellowPaper.IsOnFire);
        }
    }
}
