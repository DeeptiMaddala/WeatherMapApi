using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMapAPI.ApiTests
{
    public class HappyHolidayTest
    {
        [Test]
        public void PlanHoliday()
        {
            ApiResponseService Api = new ApiResponseService();
            string responseCityForcast = Api.getResponse(ConfigurationManager.AppSettings["cityname"], ConfigurationManager.AppSettings["noofdays"]);
            Console.WriteLine(responseCityForcast.ToString());
            Assert.IsTrue(responseCityForcast.Contains(ConfigurationManager.AppSettings["cityname"]));

            
        }
    }
}
