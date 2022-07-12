using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HeadFirst.Assets.Scripts.Chapter02_observer
{
    public class WeatherStation : MonoBehaviour
    {
        public WeatherData weatherData;
        public CurrentConditionsDisplay currentDisplay;
        void Start()
        {
            weatherData = new WeatherData();
            

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(70, 55, 20.4f);
            weatherData.SetMeasurements(60, 45, 10.4f);
        }
    }
}
