using Tyuiu.KoryakinaAE.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KoryakinaAE.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Алина";
            var res = DataService.GetMassage(name);

            //Вызываем класс Assert и метод AreEual
            Assert.AreEqual("Привет..., Алина", res);
        }
    }
}
