using System.Configuration;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using NexerApplication.Model.Configurations;

namespace NexerApplication.Model
{
    public class WeatherRepository : IWeatherRepository
    {
        private List<WeatherData> weatherDatas = new List<WeatherData>();
        private readonly IConfiguration Configuration;

        public WeatherRepository()
        {

            //For testing purposes, some data are being set in memory to be able to return something in the queries
            //The idea is to call a method that fetches the csv files in Azure and feeds the object list but that part didn't work. Both the call and the method are commented out here.
            Add(new WeatherData { DeviceID = "test_01", MedDate = Convert.ToDateTime("2022-01-01"), SensorType = "tempersture", Temperature = 31.5, Humidity = 95, Rainfall = 0.5 });
            Add(new WeatherData { DeviceID = "test_01", MedDate = Convert.ToDateTime("2022-01-02"), SensorType = "tempersture", Temperature = 30.4, Humidity = 96, Rainfall = 0.7 });
            Add(new WeatherData { DeviceID = "test_01", MedDate = Convert.ToDateTime("2022-01-03"), SensorType = "tempersture", Temperature = 29.8, Humidity = 80, Rainfall = 0.4 });
            Add(new WeatherData { DeviceID = "test_01", MedDate = Convert.ToDateTime("2022-01-04"), SensorType = "tempersture", Temperature = 30.2, Humidity = 79, Rainfall = 0.3 });
            Add(new WeatherData { DeviceID = "test_01", MedDate = Convert.ToDateTime("2022-01-05"), SensorType = "tempersture", Temperature = 33.5, Humidity = 82, Rainfall = 0.5 });
            Add(new WeatherData { DeviceID = "test_01", MedDate = Convert.ToDateTime("2022-01-06"), SensorType = "tempersture", Temperature = 32.0, Humidity = 93, Rainfall = 0.6 });
            Add(new WeatherData { DeviceID = "test_02", MedDate = Convert.ToDateTime("2022-01-01"), SensorType = "tempersture", Temperature = 30.7, Humidity = 95, Rainfall = 0.7 });
            Add(new WeatherData { DeviceID = "test_02", MedDate = Convert.ToDateTime("2022-01-02"), SensorType = "tempersture", Temperature = 30.2, Humidity = 95, Rainfall = 0.9 });
            Add(new WeatherData { DeviceID = "test_02", MedDate = Convert.ToDateTime("2022-01-03"), SensorType = "tempersture", Temperature = 29.5, Humidity = 82, Rainfall = 0.5 });
            Add(new WeatherData { DeviceID = "test_02", MedDate = Convert.ToDateTime("2022-01-04"), SensorType = "tempersture", Temperature = 29.8, Humidity = 81, Rainfall = 0.4 });

            /*
            ReadFile();
            */
        }

        public WeatherData Add(WeatherData items)
        {
            if (items == null)
            {
                throw new ArgumentNullException("items");
            }
            weatherDatas.Add(items);
            return items;
        }        

        public IEnumerable<WeatherData> GetData(string pDeviceID, DateTime pMedDate, string pSensorType)
        {
            return weatherDatas.FindAll(p => (p.DeviceID == pDeviceID) && (p.MedDate == pMedDate) && (p.SensorType == pSensorType));
        }
        public IEnumerable<WeatherData> GetDataForDevice(string pDeviceID, DateTime pMedDate)
        {
            return weatherDatas.FindAll(p => (p.DeviceID == pDeviceID) && (p.MedDate == pMedDate));
        }

        public IEnumerable<WeatherData> GetAll()
        {
            return weatherDatas;
        }

        public void ReadFile()
        {
            /*
            var connectionStringsOption = new ConnectionStringsOptions();
            Configuration.GetSection(ConnectionStringsOptions.ConnectionStrings).Bind(connectionStringsOption);
            
            string blobEndpoint = connectionStringsOption.BlobEndpoint;
            string queueEndpoint = connectionStringsOption.QueueEndpoint;
            string fileEndpoint = connectionStringsOption.FileEndpoint;
            string tableEndpoint = connectionStringsOption.TableEndpoint;
            string sharedAccessSignature = connectionStringsOption.SharedAccessSignature;

            //In this part, after getting the data in AppConfig, access Azure to get the files and process the data to insert into the object.
            BlobContainerClient blobContainerClient = new BlobContainerClient(blobEndpoint);
            blobContainerClient.CreateIfNotExists();
            Console.WriteLine("Listing blobs...");
            // List all blobs in the container
            var blobs = blobContainerClient.GetBlobs();
            foreach (BlobItem blobItem in blobs)
            {
                WeatherData weatherData = new WeatherData();
                //The idea is to get the file path to identify the ID and Measurement Type data (this is the reason for the split with '/' )
                string[] datas = blobItem.Name.ToString().Split('/');
                for (int i = 0; i < datas.Length; i++)
                {
                    if (i == 0) { weatherData.DeviceID = Convert.ToString(datas[i]); }
                    if (i == 1) { weatherData.SensorType = Convert.ToString(datas[i]); }
                }
                //Here separates the two columns and their data to feed the other items of the object
                string[] contents = blobItem.ToString().Split(';');                    
                for (int i = 0; i < contents.Length; i++)
                {                    
                    if (i == 0) { weatherData.MedDate = Convert.ToDateTime(contents[i]); }
                    if (i == 1) { weatherData.Temperature = Convert.ToDouble(contents[i]); }
                    if (i == 1) { weatherData.Humidity = Convert.ToDouble(contents[i]); }
                    if (i == 1) { weatherData.Rainfall = Convert.ToDouble(contents[i]); }
                }
                //Call the function to add the object to the list
                Add(weatherData);
            }
            */
        }
    }
}
