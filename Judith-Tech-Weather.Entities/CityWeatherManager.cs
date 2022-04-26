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
        CityWeatherRequest CityWeatherRequest = new CityWeatherRequest();
        public Task StartAutoRequset(string cityname, int milliseconds)
        {
            Task task = Task.Factory.StartNew( async () => {
                while(IsRunning)
                {
                    Thread.Sleep(milliseconds);
                    string cityData = await CityWeatherRequest.GetCityData(cityname);
                    CityWeatherRequest.SaveToLasttemp(cityData);
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

            var wearherData = CityWeatherRequest.GetWeatherDataFromLasttemp();
            temperature[0] = wearherData.current.temp_c;
            temperature[1] = wearherData.current.temp_f;

            return temperature;
        }
    }
}
