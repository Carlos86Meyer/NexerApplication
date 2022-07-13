namespace NexerApplication.Model
{
    public class WeatherData
    {
        public string? DeviceID { get; set; }
        public DateTime MedDate { get; set; }
        public string? SensorType { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double Rainfall { get; set; }

    }
}
