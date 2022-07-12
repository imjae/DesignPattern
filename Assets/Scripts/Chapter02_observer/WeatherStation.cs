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
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
