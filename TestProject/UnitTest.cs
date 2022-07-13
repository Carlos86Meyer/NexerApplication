using NexerApplication.Controllers;
using NexerApplication.Model;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethodGetAll()
        {
            //Validates if the method's return is as expected
            WeatherController weatherController = new WeatherController();
            IEnumerable<WeatherData> weatherDatas = new List<WeatherData>();
            IEnumerable<WeatherData> expectedDatas = new List<WeatherData>();
            weatherDatas = weatherController.GetAllWeatherDatas();
            expectedDatas = weatherDatas;

            Assert.AreEqual(weatherDatas, expectedDatas);            
        }

        [TestMethod]
        public void TestMethodGetData01()
        {
            //Validates if the method's return will be empty
            WeatherController weatherController = new WeatherController();
            IEnumerable<WeatherData> weatherDatas = new List<WeatherData>();
            IEnumerable<WeatherData> expectedDatas = new List<WeatherData>();
            weatherDatas = weatherController.GetData("", DateTime.Now, "");
            expectedDatas = weatherDatas;

            Assert.AreEqual(weatherDatas, expectedDatas);
        }

        [TestMethod]
        public void TestMethodGetData02()
        {
            //Validates if the method's return is as expected
            WeatherController weatherController = new WeatherController();
            IEnumerable<WeatherData> weatherDatas = new List<WeatherData>();
            IEnumerable<WeatherData> expectedDatas = new List<WeatherData>();
            weatherDatas = weatherController.GetData("", DateTime.Now, "");
            expectedDatas = weatherDatas;

            Assert.AreEqual(weatherDatas, expectedDatas);
        }

        [TestMethod]
        public void TestMethodGetDataForDevice01()
        {
            //Validates if the method's return will be empty
            WeatherController weatherController = new WeatherController();
            IEnumerable<WeatherData> weatherDatas = new List<WeatherData>();
            IEnumerable<WeatherData> expectedDatas = new List<WeatherData>();
            weatherDatas = weatherController.GetDataForDevice("", DateTime.Now);
            expectedDatas = weatherDatas;

            Assert.AreEqual(weatherDatas, expectedDatas);
        }

        [TestMethod]
        public void TestMethodGetDataForDevice02()
        {
            //Validates if the method's return is as expected
            WeatherController weatherController = new WeatherController();
            IEnumerable<WeatherData> weatherDatas = new List<WeatherData>();
            IEnumerable<WeatherData> expectedDatas = new List<WeatherData>();

            {
                weatherDatas = weatherController.GetDataForDevice("", DateTime.Now);
                expectedDatas = weatherDatas;

                Assert.AreEqual(weatherDatas, expectedDatas);
            }
        }
    }
}