using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MessingWithInterfaces
{
    [TestClass]
    public class SettingPropertyValuesTests
    {
        [TestMethod]
        public void A_Poked_Person_Will_Feel_Poked()
        {
            Person marvin = new Person(false);
            Person shea = new Person(false);

            Assert.IsFalse(shea.WasPoked);

            marvin.Poke(shea);

            Assert.IsTrue(shea.WasPoked);
        }
    }
}
