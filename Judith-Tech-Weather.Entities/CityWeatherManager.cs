using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using Judith_Tech_Weather.Dal;
using Judith_Tech_Weather.Model;

namespace Judith_Tech_Weather.Entities
{
    public class CityWeatherManager
    {
        public bool IsRunning = true;
        private const string lasttemp = @"C:\Users\user\Desktop\ציונט - טק קריירה\Weather app\Judith-Tech-Weather\Judith-Tech-Weather.Dal\DB\lasttemp.txt";
        private const string cityWeatherHistory = @"C:\Users\user\Desktop\ציונט - טק קריירה\Weather app\Judith-Tech-Weather\Judith-Tech-Weather.Dal\DB\cityWeatherData.txt";
        CityWeatherRequest CityWeatherRequest = new CityWeatherRequest();
        public Task StartAutoRequset(string cityname, int milliseconds)
        {
            Task task = Task.Factory.StartNew( async () => {
                while(IsRunning)
                {
                    Thread.Sleep(milliseconds);
                    string cityData = await CityWeatherRequest.GetCityData(cityname);
                    CityWeatherRequest.SaveToDB(lasttemp, cityData);
                }
            });
            return task;
        }

        public void StopAutoRequset()
        {
            IsRunning = false;
        }

        public float[] GetCurrentTempFromFile()
        {
            float[] temperature = new float[2];

            string weatherDataStr = CityWeatherRequest.GetWeatherDataFromDataBase(lasttemp);
            var wearherData = CityWeatherRequest.DesriliationData(weatherDataStr); 

            temperature[0] = wearherData.current.temp_c;
            temperature[1] = wearherData.current.temp_f;

            return temperature;
        }

        public void AddToList(string cityname)
        {
            CityWeatherRequest.SaveToWeatherCityData(cityname, cityWeatherHistory);
        }
    }
}
