using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

using Judith_Tech_Weather.Model;

namespace Judith_Tech_Weather.Dal
{
    public class CityWeatherRequest
    {
        private const string lasttemp = @"C:\Users\user\Desktop\ציונט - טק קריירה\Weather app\Judith-Tech-Weather\Judith-Tech-Weather.Dal\DB\lasttemp.txt";
        public async Task<string> GetCityData(string cityname)
        {
            string weather_data = "";
            const string apikey = "a88b63aef83744ea8c870248221404";
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://api.weatherapi.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method
                HttpResponseMessage response = await client.GetAsync(@"/v1/current.json?key=" + apikey + "&q=" + cityname + "&aqi=no%22");
                if (response.IsSuccessStatusCode)
                {
                    weather_data = await response.Content.ReadAsStringAsync();
                }
            }

            return weather_data;
        }

        public CityWeatherData GetWeatherDataFromLasttemp()
        {
            string data = File.ReadAllText(lasttemp);
            CityWeatherData weatherData = JsonSerializer.Deserialize<CityWeatherData>(data);
            
            return weatherData;
        }

        public void SaveToLasttemp(string cityData)
        {
            File.WriteAllText(lasttemp, cityData);
        }
    }
}
