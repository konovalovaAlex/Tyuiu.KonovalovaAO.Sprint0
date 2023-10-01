using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KonovalovaAO.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KonovalovaAO.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // область создания тестирования, методов из библиотеки
            var name = "Александра";
            var res = DataService.GetMessage(name);

            // вызов класса Assert и метода AreEqual
            Assert.AreEqual("Привет..., Александра", res);
        }
    }
}
