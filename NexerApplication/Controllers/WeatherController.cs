using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using NexerApplication.Model;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace NexerApplication.Controllers
{
    /// <summary>
    /// Control responsible for the application's EndPoints
    /// </summary>
    /// <returns></returns>
    [Produces("application/json", "application/xml")]
    [Route("api/vi/application/")]
    [ApiController]
    [ApiVersion("1.0")]
    public class WeatherController : Controller
    {
        static readonly IWeatherRepository repository = new WeatherRepository();

        /// <summary>
        /// Method to return all available data
        /// </summary>
        /// <returns>a list of data</returns>
        [HttpPost]
        [Route("GetAllWeatherDatas")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<WeatherData>), StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public IEnumerable<WeatherData> GetAllWeatherDatas()
        {
            return repository.GetAll();
        }

        /// <summary>
        /// Method to return data based on specific parameters
        /// </summary>
        /// <returns>a list of data</returns>
        [HttpPost]
        [Route("GetData")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<WeatherData>), StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public IEnumerable<WeatherData> GetData(string pDeviceID, DateTime pMedDate, string pSensorType)
        {
            IEnumerable <WeatherData> weatherData = repository.GetData(pDeviceID, pMedDate, pSensorType);
            if (weatherData == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return weatherData;
        }

        /// <summary>
        /// Method to return data based on a specific device
        /// </summary>
        /// <returns>a list of data</returns>
        [HttpPost]
        [Route("GetDataForDevice")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<WeatherData>), StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public IEnumerable<WeatherData> GetDataForDevice(string pDeviceID, DateTime pMedDate)
        {
            IEnumerable<WeatherData> weatherData = repository.GetDataForDevice(pDeviceID, pMedDate);
            if (weatherData == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return weatherData;            
        }

    }
}
