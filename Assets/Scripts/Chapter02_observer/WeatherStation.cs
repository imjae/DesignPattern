using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HeadFirst.Assets.Scripts.Chapter02_observer
{
    public class WeatherStation : MonoBehaviour
    {
        public WeatherData weatherData;
        // Start is called before the first frame update
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
