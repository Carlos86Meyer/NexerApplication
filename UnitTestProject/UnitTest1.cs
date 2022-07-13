using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NexerApplication.Model;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetAll()
        {
            {
                WeatherData weatherData = new WeatherData();

                WeatherController weatherController = new WeatherController();

                // arrange
                const String ExpectedOutput = "";
                int projectId = 1;
                int seasonId = 2;
                int episodeId = 3;

                // act
                var crewController = new CrewController();
                var resultList = crewController.GetProjectCrewsBySpec(1, 2, 3) as DataSourceResult;
                var someInsideData = resultlist.FirstOrDefault().GetType().GetProperty("PropertyName").GetValue(resultList.FirstOrDefault(), null);

                // assert
                Assert.AreEqual(someInsideData, ExpectedOutput);
            }
        }
    }
}
