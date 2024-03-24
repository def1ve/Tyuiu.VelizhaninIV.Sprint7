using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VelizhaninIV.Sprint7.Project.V10.Lib;

namespace Tyuiu.VelizhaninIV.Sprint7.Project.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
       
            public void ValidGetMatrix()
            {
                DataService ds = new DataService();

                string path = @"C:\Users\def1v\source\repos\Tyuiu.VelizhaninIV.Sprint7\Orders.csv";
                string[,] res = ds.GetMatrix(path);

                string[,] wait = {
            { "1", "22.03.2024", "Петров corporation", "9223232666", "19302", "Оплачен", "Отправлен", "Безналичный расчет" },
            { "2", "23.03.2024", "Ozon", "9221448228", "22020","Не оплачен", "Не отправлен", "Безналичный расчет" },
            { "3", "24.03.2024", "Yandex", "9990009990", "36740", "Не оплачен", "Не отправлен", "Безналичный расчет" },
            { "4", "25.03.2024", "Tyuiu", "8889992102", "35001", "Оплачен", "Отправлен", "Безналичный расчет" },
            };
                CollectionAssert.AreEqual(wait, res);
            }
        
    }
}
