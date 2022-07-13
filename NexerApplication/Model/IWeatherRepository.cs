namespace NexerApplication.Model
{
    public interface IWeatherRepository
    {
        IEnumerable<WeatherData> GetAll();
        IEnumerable<WeatherData> GetData(string pDeviceID, DateTime pMedDate, string pSensorType);
        IEnumerable<WeatherData> GetDataForDevice(string pDeviceID, DateTime pMedDate);
    }
}
