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
        //private const string lasttemp = @"C:\Users\user\Desktop\ציונט - טק קריירה\Weather app\Judith-Tech-Weather\Judith-Tech-Weather.Dal\DB\lasttemp.txt";
        //private const string cityWeatherHistory = @"C:\Users\user\Desktop\ציונט - טק קריירה\Weather app\Judith-Tech-Weather\Judith-Tech-Weather.Dal\DB\cityWeatherData.txt";
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

        public CityWeatherData DesriliationData(string weatherData)
        {
            return JsonSerializer.Deserialize<CityWeatherData>(weatherData);
        }

        public string GetWeatherDataFromDataBase(string filename)
        {
            return File.ReadAllText(filename);
        }

        public void SaveToDB(string filename, string data)
        {
            File.WriteAllText(filename, data);
        }

        public async void SaveToWeatherCityData(string cityname, string filename)
        {
            Dictionary<string, CityWeatherData> weatherList = new Dictionary<string, CityWeatherData>();

            string cityDataFromApi = await GetCityData(cityname);
            string cityDataFromDB = GetWeatherDataFromDataBase(filename);
           
            var cityWeatherData = DesriliationData(cityDataFromApi);
            string name = cityWeatherData.location.name;

            //if DB is empty add city to DB
            if (cityDataFromDB == "")
                weatherList.Add(name, cityWeatherData);
            else
            {
                 
                // convert data from DB
                weatherList = JsonSerializer.Deserialize<Dictionary<string, CityWeatherData>>(cityDataFromDB);
                if(weatherList.ContainsKey(name))
                {
                    weatherList[name].current.temp_c = cityWeatherData.current.temp_c;
                    weatherList[name].current.temp_f = cityWeatherData.current.temp_f;
                }
                else weatherList.Add(name, cityWeatherData);    
            }

            SaveToDB(filename, JsonSerializer.Serialize(weatherList));
        }
    }
}
