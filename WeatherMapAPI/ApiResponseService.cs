using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMapAPI
{
    public class ApiResponseService
    {
        private string ApiUrl = ConfigurationManager.AppSettings["apiurl"];
        private string appid = ConfigurationManager.AppSettings["APPID"];
        public string getResponse(string City, string NoOfDays)
        {
            StringBuilder ApiResponseString = new StringBuilder();
            string Mode = "JSON";
            string Units = "Metric";

            //string UrlParameters = City + "&APPID=" + appid + "&cnt=" + NoOfDays + "&mode=" + Mode + "&units=" + Units;

            string UrlParameters = City + "&appid=" + appid;

            ApiUrl = String.Concat(ApiUrl, UrlParameters);
            Console.WriteLine(ApiUrl);
            string jsonResponse;
            using (WebClient client = new WebClient())
            {
                client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                jsonResponse = client.DownloadString(ApiUrl);
                if (jsonResponse == null)
                {
                    jsonResponse = "error";
                }
            }

            return jsonResponse;
        }
    }
}
